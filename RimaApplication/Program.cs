using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace RimaApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine(" - Installing packages...");
                }
                if (i == 1)
                {
                    Console.WriteLine(" / Installing packages...");
                }
                if (i == 2)
                {
                    Console.WriteLine(" \\ Installing packages...");
                    i = -1;
                }
                Thread.Sleep(50);
                Console.Clear();
            }   
        }
    }
}
