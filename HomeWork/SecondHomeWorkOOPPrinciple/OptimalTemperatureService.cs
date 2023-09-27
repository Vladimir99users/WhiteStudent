namespace SecondHomeWork
{

    public class OptimalTemperatureService : IRunnable
    {
        private const int MIN_TEMPERATURE_WORKER = 15;
        private const int MAX_TEMPERATURE_WORKER = 30;
        private const string SIGN_GREATER_EQUAL = ">=";

        private IReadable _readable;

        public OptimalTemperatureService(IReadable readable)
        {
            _readable = readable;
        }
        public void Run()
        {

            //Сколько раз нужно выполнить задание
            var testCaseCount = int.Parse(_readable.ReadLine());

            for (int i = 0; i < testCaseCount; i++)
            {
                // количество работников для определения комфортной температуры
                var countWorker =  int.Parse(_readable.ReadLine());

                GetTemperatureWorker(countWorker);
            }
        }


        private void GetTemperatureWorker(int countWorker)
        {
            int correctTemperature = 0;
            int minTemperature = MIN_TEMPERATURE_WORKER;
            int maxTemperature = MAX_TEMPERATURE_WORKER;

            for (int i = 0; i < countWorker; i++)
            {
                var collection = _readable.ReadLine().Split(' ').ToArray();

                string symbolInequality = collection[0];
                int temperature = int.Parse(collection[1]);

                if (symbolInequality == SIGN_GREATER_EQUAL)
                {
                    if (temperature > minTemperature)
                        minTemperature = temperature;
                }
                else
                {
                    if (temperature < maxTemperature)
                        maxTemperature = temperature;
                }

                if (IsMinimumTemperatureGreaterMaxTemperature(minTemperature, maxTemperature))
                {
                    Console.WriteLine("Не возможно определить корректую температуру");
                    return;
                }
                else
                {
                    correctTemperature = GetRandomTemperature(minTemperature, maxTemperature);
                }

            }

            Console.WriteLine($"Корректная температура для сотрудников = {correctTemperature}," + 
                        $"Диапозон конфортной температуры [{minTemperature},{maxTemperature}]");
                    
        }
        private bool IsMinimumTemperatureGreaterMaxTemperature(int minTemperature, int maxTemperature)
        {
            return minTemperature > maxTemperature;
        }


        private int GetRandomTemperature(int start, int end)
        {
            Random rnd = new Random();
            return rnd.Next(start, end + 1);
        }


    }
}