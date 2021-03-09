using NetMQ;
using NetMQ.Sockets;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gemini.Modules.ZmqRPC
{
    public class ZmqRpcServer :IRpcServer
    {
        INetMQSocket resSocket;

        public void StartReponser(string addr)
        {
            resSocket = new ResponseSocket(addr);
        }
    }
}
