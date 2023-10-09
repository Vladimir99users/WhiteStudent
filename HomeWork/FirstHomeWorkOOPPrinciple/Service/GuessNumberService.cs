
namespace HomeWork
{
    public class GuessNumberService : IRunable
    {
        private const int MIN_NUMBER = 1;
        private const int MAX_NUMBER = 11;
        
        private const string CORRECT_ANSWER = "да";
        private const string NEGATIVE_ANSWER = "нет";

        private const int DISTANCE_VALUE_COLD = 5;
        private const int DISTANCE_VALUE_WARM = 2;

        private string _answer = "";

        private IFixablePromt _promt;
        public GuessNumberService(IFixablePromt promt)
        {
            _promt = promt;
        }

        public void RunService()
        {
            Console.WriteLine(_promt.HIMessage);

            _answer = Console.ReadLine();


            if (IsNotCorrectAnswers(_answer))
            {
                return;
            }

            WriteEmojiInConsole(new HappyEmoji());
            Random rand = new Random();

            while (true)
            {
                int randomValue = GetRandomNumber(rand);

                Console.WriteLine($"угадай число от {MIN_NUMBER} до {MAX_NUMBER - 1}");

                while (true)
                {
                    int userValue = Convert.ToInt32(Console.ReadLine());

                    if (userValue == randomValue)
                    {
                        WriteEmojiInConsole(new CongratulationsEmoji());

                        Console.WriteLine(_promt.WillYouGuessMessage);

                        _answer = Console.ReadLine();


                        if (IsNotCorrectAnswers(_answer))
                        {
                            return;
                        }
                    }
                    else
                    {
                        if (IsExitToTheRange(userValue))
                        {
                            Console.WriteLine(_promt.YouCantReading);
                        }
                        else
                        {
                            WriteHintsForPlayer(userValue, randomValue);
                        }

                    }
                }
            }
        }
        private bool IsNotCorrectAnswers(string answer)
        {
            if (answer == NEGATIVE_ANSWER)
            {
                WriteEmojiInConsole(new DeathEmoji());
                return true;
            }
            else if (answer != CORRECT_ANSWER)
            {
                WriteEmojiInConsole(new SadEmoji());
                Console.WriteLine(_promt.DontKnowMessage);
                return true;
            }

            return false;
        }

        private void WriteEmojiInConsole(IEmojable emoji)
        {
            Console.WriteLine(emoji.GetEmoji());
        }

        private int GetRandomNumber(Random rand)
        {
            return rand.Next(MIN_NUMBER, MAX_NUMBER);
        }

        private bool IsExitToTheRange(int value)
        {
            return value < MIN_NUMBER || value > MAX_NUMBER;
        }

        private bool WriteHintsForPlayer(int userValue, int randomValue)
        {
            if (Math.Abs(userValue - randomValue) > DISTANCE_VALUE_COLD)
            {
                Console.WriteLine(_promt.ColdMessage);
            }
            else if (Math.Abs(userValue - randomValue) > DISTANCE_VALUE_WARM)
            {
                Console.WriteLine(_promt.WarmMessage);
            }
            else
            {
                Console.WriteLine(_promt.BurningMessage);
            }

            return false;
        }

    }

}
