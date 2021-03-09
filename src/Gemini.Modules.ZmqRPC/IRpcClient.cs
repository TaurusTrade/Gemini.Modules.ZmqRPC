using System;
using System.Collections.Generic;
using System.Text;

namespace Gemini.Modules.ZmqRPC
{
    public interface IRpcClient
    {
        void StartRequester(string addr);
        void StartScriber(string addr);
        void StartPuller(string addr);
        void Stop();


    }
}
