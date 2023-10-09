public class CongratulationsEmoji : IEmojable
{
    private string _congratulationsEmoji = "╰(▔∀▔)╯";
    public string GetEmoji()
    {
        return _congratulationsEmoji;
    }
}