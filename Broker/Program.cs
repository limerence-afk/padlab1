using System;

namespace Broker
{
    class Program
    {
  
        static void Main(string[] args)
        {
            Console.WriteLine("Broker");
            BrokerSocket socket = new BrokerSocket();
            ushort port = 9000;
            socket.Bind(port); // va asculta la portu 9000
            socket.Listen(); // incepe sa asculte
            socket.Accept(); // accepta conexiuni
            Console.WriteLine($"Broker is listening on port {port}");

            Console.ReadLine();
        }
    }
}
