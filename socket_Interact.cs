using System;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Collections.Generic;



namespace TripleK
{
    public class socket_Interact
    {
        public class socketCon
        {
            private readonly string serverIP = "127.0.0.1"; // 서버 IP
            private readonly int port = 8000;               // 서버 포트 (TKSocket과 일치)
            private Socket client;

            public socketCon()
            {
                client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                client.Connect(serverIP, port);
                Console.WriteLine("서버에 연결됨");
            }

            private void SendCommand(byte instruction, string json)
            {
                List<byte> data = new List<byte> { instruction };
                data.AddRange(Encoding.UTF8.GetBytes(json));

                client.Send(data.ToArray());

                byte[] buffer = new byte[4096];
                int received = client.Receive(buffer);
                string response = Encoding.UTF8.GetString(buffer, 0, received);
                Console.WriteLine("서버 응답: " + response);
            }

            // GetItem 요청
            public void RequestGetItem(string itemName)
            {
                var obj = new Dictionary<string, string> { { "itemName", itemName } };
                SendCommand(0, JsonSerializer.Serialize(obj));
            }

            // GetItemDetail 요청
            public void RequestGetItemDetail(string itemName)
            {
                var obj = new Dictionary<string, string> { { "itemName", itemName } };
                SendCommand(1, JsonSerializer.Serialize(obj));
            }

            // GetSales 요청
            public void RequestGetSales(string itemName)
            {
                var obj = new Dictionary<string, string> { { "itemName", itemName } };
                SendCommand(1, JsonSerializer.Serialize(obj));
            }

            // BuyItems 요청
            public void RequestBuyItem(string itemName, int quantity)
            {
                var obj = new Dictionary<string, object>
                {
                    { "itemName", itemName },
                    { "quantity", quantity }
                };
                SendCommand(3, JsonSerializer.Serialize(obj));
            }

            // AddAmount 요청
            public void RequestAddAmount(string itemName, int quantity)
            {
                var obj = new Dictionary<string, object>
                {
                    { "itemName", itemName },
                    { "quantity", quantity }
                };
                SendCommand(4, JsonSerializer.Serialize(obj));
            }

            public void Close()
            {
                client.Close();
            }
        }

        // 동일 구조의 클래스 (필요 시 사용)
        public class MenuItem
        {
            public int Price { get; set; }
            public int Amount { get; set; }
            public int Sold { get; set; }
        }

        public class MenuData
        {
            public Dictionary<string, MenuItem> Items { get; set; }
            public int Sold { get; set; }
        }
    }
}
