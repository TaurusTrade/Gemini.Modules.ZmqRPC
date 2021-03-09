using NetMQ;
using NetMQ.Sockets;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gemini.Modules.ZmqRPC
{
    public class ZmqRpcClient : IRpcClient
    {
        INetMQSocket reqSocket;
        INetMQSocket subSocket;

        public void StartRequester(string addr)
        {
            reqSocket = new RequestSocket(addr);
            //reqSocket.BindRandomPort()
        }

        public void StartScriber(string addr)
        {
            subSocket = new SubscriberSocket(addr);
        }

        public void StartPuller(string addr)
        {
            
        }

        

       

        public void Stop()
        {
           
        }
    }
}
