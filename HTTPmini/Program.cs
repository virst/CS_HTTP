using System;
using System.Net.Sockets;
using System.Text;

namespace HTTPmini
{
    class Program
    {
        static void Main(string[] args)
        {

            var Listener = new TcpListener(8123);
            Listener.Start();
            Console.WriteLine("start - " + 8123);

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" while (true)" + DateTime.Now.ToLongTimeString());

                var Client = Listener.AcceptTcpClient();

                #region если нужно несколько парралельных подключений нужно запускать в отдельном потоке

                byte[] buffer = new byte[1024];
                string request = "";
                while (true)
                {
                    int count = Client.GetStream().Read(buffer, 0, 1024);
                    request += Encoding.ASCII.GetString(buffer, 0, count);
                    if (request.IndexOf("\r\n\r\n") >= 0) // Запрос обрывается \r\n\r\n последовательностью
                    {
                        break;
                    }
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(request);

                var content = "<HTML><HEAD> </HEAD><BODY>HELLO WORD !</BODY><HTML>";
                var bb = Encoding.ASCII.GetBytes(content);

                string str = "HTTP/1.1 200 OK\nContent-type: " + "text/html"
                                                               + "\nContent-Encoding: 8bit\nContent-Length:" + bb.Length.ToString()
                                                               + "\n\n";
                Client.GetStream().Write(Encoding.ASCII.GetBytes(str), 0, str.Length);
                Client.GetStream().Write(bb, 0, bb.Length);

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(content);
                Client.Close();
                #endregion
            }
        }
    }
}
