public class SadEmoji : IEmojable
{
    private string _sadEmoji = "(︶︹︺)";
    public string GetEmoji()
    {
        return _sadEmoji;
    }
}
