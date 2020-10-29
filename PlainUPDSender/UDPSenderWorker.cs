using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using ModelLib;

namespace PlainUPDSender
{
    public class UDPSenderWorker
    {
        public void Start()
        {
            Car car = new Car("Opel", "Lilla", "GG 42 007");

            UdpClient udpClient = new UdpClient(11000);
            udpClient.Connect("localhost", 11001);
            Byte[] sendBytes = Encoding.UTF8.GetBytes(car.ToString());
            udpClient.Send(sendBytes, sendBytes.Length);
        }
    }
}
