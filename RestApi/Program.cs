using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace RestApi
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Server server = new Server(8123);

            server.Start();
        }
    }

    public class Server
    {
        public delegate void WriteToClientEvent(object sender, ReqClientInfo e);

        private TcpListener Listener;
        public event WriteToClientEvent OnWriteToClient;


        public Server(int port)
        {
            Listener = new TcpListener(port);

        }

        public void Start()
        {
            Listener.Start();
            Listen();
        }

        public void Stop()
        {
            if (Listener != null)
                Listener.Stop();
        }
        ~Server()
        {
            Stop();
        }
        /// <summary>
        /// Ждём подключений к нашему серверу и обрабатываем их
        /// </summary>
        public void Listen()
        {
            while (true)
            {
                var i = new Interaction(this,Listener.AcceptTcpClient());
             i.Start();
            }
        }

        /// <summary>
        ///  Отвечаем на запрос клиенту
        /// </summary>
        private void WriteToClient(string request, TcpClient Client)
        {
            var p = GetReqParam(request);
            //  string c = "<HTML><HEAD> </HEAD><BODY>HELLO WORD !</BODY><HTML>";
            var rq = new ReqClientInfo() {Params = p};
            OnWriteToClient?.Invoke(this,rq);
            var bb = Encoding.ASCII.GetBytes(rq.Answer);
            WriteHeaderToClient("text/html", bb.Length, Client);
            Client.GetStream().Write(bb, 0, bb.Length);
        }

        private static void WriteHeaderToClient(string content_type, long length, TcpClient Client)
        {
            string str = "HTTP/1.1 200 OK\nContent-type: " + content_type
                                                           + "\nContent-Encoding: 8bit\nContent-Length:" + length.ToString()
                                                           + "\n\n";
            Client.GetStream().Write(Encoding.ASCII.GetBytes(str), 0, str.Length);
        }


        /// <summary>
        /// По строке запроса вычисляем путь к файлу.
        /// </summary>
        private static ReqParam GetReqParam(string request)
        {
            ReqParam r = new ReqParam();
            int space1 = request.IndexOf(" ");
            int space2 = request.IndexOf(" ", space1 + 1);
            r.Url = request.Substring(space1 + 2, space2 - space1 - 2);
            return r;
        }

        class Interaction
        {
            TcpClient Client;
            private Thread interact;
            private Server _srv;

            public Interaction(Server srv ,TcpClient client)
            {
                Client = client;
                interact = new Thread(Interact);
                _srv = srv;
            }

            public void Start()
            {
                interact.Start();
            }

            public void Interact()
            {
                try
                {
                    byte[] buffer = new byte[1024];
                    string request = "";
                    while (true)
                    {
                        int count = Client.GetStream().Read(buffer, 0, 1024);
                        request += Encoding.ASCII.GetString(buffer, 0, count);
                        if (request.IndexOf("\r\n\r\n") >= 0) // Запрос обрывается \r\n\r\n последовательностью
                        {
                            _srv.WriteToClient(request,Client);
                            request = "";
                        }
                    }
                }
                catch (Exception)
                {
                }
            }

        }

        public class ReqClientInfo
        {
            public string Answer = "<HTML><HEAD> </HEAD><BODY>HELLO WORD !</BODY><HTML>";
            public ReqParam Params;
        }

        public class ReqParam
        {
            private string url;

            public string Url
            {
                get { return url; }
                set
                {
                    url = value;
                    Parametrs.Clear();
                    var ss = url.Split('?');
                    if(ss.Length < 2)
                        return;
                    ss = ss[1].Split('&');
                    foreach (string s in ss)
                    {
                        var tmp = s.Split('=');
                        if(tmp.Length >1)
                            Parametrs.Add(tmp[0],tmp[1]);
                    }

                }
            }
            public Dictionary<string,string> Parametrs = new Dictionary<string, string>();

            public string UrlFile => Url.Split('?')[0];
        }
    }
}
