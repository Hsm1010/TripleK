using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;

namespace TripleK.TKClient
{
                        public enum Instructions : byte
                        {
                            GetItem = 0,
                            GetItemDetail = 1,
                            GetSales = 2,
                            BuyItems = 3,
                            AddAmount = 4,
                        }
    internal class Client : IDisposable
    {
        private readonly Socket _socket;

        public Client(string host, int port)
        {
            _socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            _socket.Connect(IPAddress.Parse(host), port);     //이후 서버 실행시 확인
        }

        public string SendRequest<T>(Instructions inst, T payload)
        {
            string json = JsonSerializer.Serialize(payload);
            byte[] jsonBytes = Encoding.UTF8.GetBytes(json);

            byte[] sendBuf = new byte[jsonBytes.Length + 1];
            sendBuf[0] = (byte)inst;
            Array.Copy(jsonBytes, 0, sendBuf, 1, jsonBytes.Length);

            _socket.Send(sendBuf);

            var receiveBuf = new byte[4096];
            int received = _socket.Receive(receiveBuf);
            
            return Encoding.UTF8.GetString(receiveBuf, 0, received);
        }

        public MenuItemDto GetItem(string ItemName)
        {
            var payload = new { itemName = ItemName };
            string jsonResponse = SendRequest(Instructions.GetItem, payload);

            try
            {
                return JsonSerializer.Deserialize<MenuItemDto>(jsonResponse)
                    ?? throw new Exception("파싱 결과가 null입니다.");
            }
            catch
            {
                return new MenuItemDto { ErrorMessage = jsonResponse };
            }
        }

        public Dictionary<string, MenuItemDto> GetItemDetail()
        {
            string jsonResponse = SendRequest(Instructions.GetItemDetail, new { });
            return JsonSerializer.Deserialize<Dictionary<string, MenuItemDto>>(jsonResponse)
                ?? new Dictionary<string, MenuItemDto>();
        }

        public SalesDto GetSales()
        {
            string jsonResponse = SendRequest(Instructions.GetSales, new { });
            return JsonSerializer.Deserialize<SalesDto>(jsonResponse) 
                ?? new SalesDto { ErrorMessage = "파싱 실패" };

        }

        public string BuyItems(string itemName, int quantity)
        {
            var payload = new {itemName = itemName, quantity = quantity };
            return SendRequest(Instructions.BuyItems, payload);
        }

        public string AddAmount(string itemName, int quantity)
        {   
            var payload = new { itemName, quantity = quantity };
            return SendRequest(Instructions.AddAmount, payload);
        }

        public void Dispose()
        {
            try {  _socket.Shutdown(SocketShutdown.Both); } 
            catch { }
            _socket.Close();
        }
    }

    public class MenuItemDto
    {
        public int Price { get; set; }
        public int Amount { get; set; }
        public int Sold { get; set; }

        public string ErrorMessage { get; set; }
    }
    public class SalesDto
    {
        public int TotalSold { get; set; }
        public string ErrorMessage { get; set; }
    }
}

