using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using ModelLib;

namespace PlainUPDReciever
{
    class UDPWorker
    {
        public void Start()
        {
            UdpClient udpClient = new UdpClient(11001);
            IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);

            while (true)
            {
                Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);
                string returnData = Encoding.UTF8.GetString(receiveBytes);

                Console.WriteLine("This is the message you received " + returnData.ToString());
            }
        }
    }
}
