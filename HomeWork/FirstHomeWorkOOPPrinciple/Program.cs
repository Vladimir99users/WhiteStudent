using System;
using System.Text;

namespace HomeWork
{

    public class Program
    {
        public static void  Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.GetEncoding("utf-16");

            IFixablePromt promt = new RussianPromt();
            IRunable service = new GuessNumberService(promt);
            service.RunService();
            
        }
    }
}
