public class RussianPromt : IFixablePromt
{
    private string _dontKnowMessage = "непонятно, давай до свидания";
    private string _youCantReading = "Читать не умеешь";
    private string _willYouGuessMessage = "Будешь угадывать? (да/нет)";
    private string _hiMessage = "Привет!\nБудешь угадывать? (да/нет)";
    private string _negativeAnswer = "нет";
    private string _correctAnswer = "да";
    public string _coldMessage = "Холодно";
    public string _warmMessage = "Тепло";
    public string _burningMessage = "Жгётся!";

    public string DontKnowMessage => _dontKnowMessage;

    public string YouCantReading => _youCantReading;

    public string WillYouGuessMessage => _willYouGuessMessage;

    public string HIMessage => _hiMessage;

    public string NegativeAnswer => _negativeAnswer;

    public string CorrectAnswer => _correctAnswer;

    public string ColdMessage => _coldMessage;

    public string WarmMessage => _warmMessage;

    public string BurningMessage => _burningMessage;
}
