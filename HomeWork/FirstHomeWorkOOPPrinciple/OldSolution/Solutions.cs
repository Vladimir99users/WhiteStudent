using System;
using System.Text;

namespace HomeWork
{

    public class OldSolutions
    {
        public static void Main()
        {
            Console.InputEncoding = System.Text.Encoding.GetEncoding("utf-16");
            
            Console.WriteLine("Привет!\nБудешь угадывать? (да/нет)");
            string answers = Console.ReadLine().ToString();
            Console.WriteLine(answers);

            if (answers == "нет")
            {
                Console.WriteLine("(×﹏×)");
                return;
            }
            else if (answers != "да")
            {
                Console.WriteLine("(︶︹︺)\n непонятно, давай до свидания");
                return;
            }

            Console.WriteLine("(⌒‿⌒)");
            Random rand = new Random();

            while (true)
            {

                int randomValue = rand.Next(0, 10) + 1;
                Console.WriteLine("угадай число от 1 до 10");

                while (true)
                {
                    int value = Convert.ToInt32(Console.ReadLine());

                    if (value == randomValue)
                    {
                        Console.WriteLine("╰(▔∀▔)╯");
                        Console.WriteLine("Будешь угадывать? (да/нет)");

                        answers = Console.ReadLine();
                        

                        if (answers == "нет")
                        {
                            Console.WriteLine("(×﹏×)");
                            return;
                        }
                        else if (answers != "да")
                        {
                            Console.WriteLine("(︶︹︺)\n непонятно, давай до свидания");
                            return;
                        }
                    }
                    else
                    {
                        if (value < 1 || value > 10)
                        {
                            Console.WriteLine("Читать не умеешь?");
                        }
                        else if (Math.Abs(value - randomValue) > 5)
                        {
                            Console.WriteLine("Холодно");
                        }
                        else if (Math.Abs(value - randomValue) > 2)
                        {
                            Console.WriteLine("Тепло");
                        }
                        else
                        {
                            Console.WriteLine("Жгётся!");
                        }
                    }
                }
            }

        }
    }
}
