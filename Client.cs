using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.IO;
using System.Text.Json.Serialization;

namespace TripleK.TKClient
{
    public enum Instructions : byte
    {
        GetItem = 0,
        GetItemDetail = 1,
        GetSales = 2,
        BuyItems = 3,
        AddAmount = 4,
        AddProduct = 5,
        DeleteProduct = 6
    }
    public class Client : IDisposable
    {
        private readonly Socket _socket;
        private readonly TcpClient _tcp;
        private readonly NetworkStream _ns;
        private readonly StreamReader _reader;
        private readonly StreamWriter _writer;

        public Client(string host, int port)
        {
            _tcp = new TcpClient(host, port);
            _ns = _tcp.GetStream();
            var utf8NoBom = new System.Text.UTF8Encoding(encoderShouldEmitUTF8Identifier: false);

            _reader = new StreamReader(_ns, utf8NoBom);
            _writer = new StreamWriter(_ns, utf8NoBom) { AutoFlush = true };
        }

        public string SendRequest<T>(Instructions inst, T payload)
        {
            string json = JsonSerializer.Serialize(payload);
            // 1바이트 명령어, 2) JSON + 개행
            _ns.WriteByte((byte)inst);
            _writer.WriteLine(json);

            // 서버 응답(한 줄) 대기
            return _reader.ReadLine() ?? "";
        }

        public string AddProduct(string serverKey, int initialAmount, decimal price)
        {
            var payload = new
            {
                itemName = serverKey,
                quantity = initialAmount,
                price = price
            };
            return SendRequest(Instructions.AddProduct, payload);
        }

        public string DeleteProduct(string serverKey)
        {
            var payload = new { itemName = serverKey };
            return SendRequest(Instructions.DeleteProduct, payload);
        }

        public Dictionary<string, MenuItemDto> GetItemDetail()
        {
            string jsonResponse = SendRequest(Instructions.GetItemDetail, new { });
            return JsonSerializer.Deserialize<Dictionary<string, MenuItemDto>>(jsonResponse)
                   ?? new Dictionary<string, MenuItemDto>();
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
        [JsonPropertyName("amount")]
        public int Amount { get; set; }
        public int Sold { get; set; }

        public string ErrorMessage { get; set; }
    }
}

