using System;
using System.Text;

namespace HomeWork
{

    public class Program
    {
        public static void  Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.GetEncoding("utf-16");
            
            IRunable service = new GuessNumberService();
            service.RunService();
            
        }
    }
}
