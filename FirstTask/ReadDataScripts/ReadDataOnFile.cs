namespace FirstTask
{

    public class ReadDataOnFile : IReadData<string>
    {
        public ReadDataOnFile()
        {

        }
        public async Task<string> GetData(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                throw new ArgumentNullException();
            }

            string data = await File.ReadAllTextAsync(path);

            return data;
        }
    }
}
