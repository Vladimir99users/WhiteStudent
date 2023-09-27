namespace SecondHomeWork
{
    public class ReadDataFromFile : IReadable
    {
        private readonly string _nameFile = "";
        private StreamReader _streamReader;

        public ReadDataFromFile(string nameFile)
        {
            _nameFile = nameFile;

            _streamReader = new StreamReader(_nameFile);
        }
        public string ReadLine()
        {
            if(_streamReader == null) return "";

            return _streamReader.ReadLine();
        }
    }
}