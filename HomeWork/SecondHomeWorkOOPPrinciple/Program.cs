namespace SecondHomeWork
{

    public class Program
    {

        public static void Main(string[] args)
        {
            IReadable outputReaderFile = new ReadDataFromFile("data.txt");
            IReadable outputReaderConsole = new ReadDatafromConsole();


            IRunnable service = new OptimalTemperatureService(outputReaderFile);
            service.Run();
        }
    }
}