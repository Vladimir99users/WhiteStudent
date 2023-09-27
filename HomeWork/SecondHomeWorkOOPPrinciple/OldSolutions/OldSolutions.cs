namespace Worker
{

    public class OldSolutions
    {

        public static void NoMain(string[] args)
        {
            var testCaseCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < testCaseCount; i++)
            {
                var countWorker = int.Parse(Console.ReadLine());

                GetTemperatureWorker(countWorker);
            }

        }

        private static void GetTemperatureWorker(int countWorker)
        {
            int currectTemperature = 0;
            int minTemperature = 15;
            int maxTemperature = 30;

            for (int i = 0; i < countWorker; i++)
            {
                var collection = Console.ReadLine()
                                        .Split(' ');

                string symbol = collection[0];
                int temperature = int.Parse(collection[1]);

                if (symbol == ">=")
                {
                    if (temperature > minTemperature)
                        minTemperature = temperature;
                }
                else
                {
                    if (temperature < maxTemperature)
                        maxTemperature = temperature;
                }

                if (minTemperature > maxTemperature)
                {
                    Console.WriteLine("-1");
                }
                else
                {
                    currectTemperature = GetRandomTemperature(minTemperature, maxTemperature);
                    Console.WriteLine(currectTemperature);
                }

            }
        }

        private static int GetRandomTemperature(int start, int end)
        {
            Random rnd = new Random();
            return rnd.Next(start, end + 1);
        }
    }
}