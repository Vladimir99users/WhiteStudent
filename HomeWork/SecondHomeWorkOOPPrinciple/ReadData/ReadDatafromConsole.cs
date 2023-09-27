namespace SecondHomeWork
{
    public class ReadDatafromConsole : IReadable
    {
        public ReadDatafromConsole()
        {

        }
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}