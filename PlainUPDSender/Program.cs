using System;

namespace PlainUPDSender
{
    class Program
    {
        static void Main(string[] args)
        {
            UDPSenderWorker worker = new UDPSenderWorker();
            worker.Start();

            Console.ReadLine();
        }
    }
}
