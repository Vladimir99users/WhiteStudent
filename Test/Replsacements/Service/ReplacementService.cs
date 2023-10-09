using System.Text.Json;

namespace Replace
{
    public class ReplacementService
    {
        private readonly string URL = "https://raw.githubusercontent.com/thewhitesoft/student-2023-assignment/main/data.json";
        private readonly string ReplacementJSONFile = "replacement.json";
        private readonly string ResultFile = "result.json";

        private readonly HttpClient _httpClient = new HttpClient();

        private IReadData<List<string>> _readDataServer;
        private IReadData<string> _readDataLocal;
        public List<string> dataData { get; private set; }
        public string replacementData { get; private set; }

        public List<ReplacementData> Replacements { get; private set; }
        public List<string> ModifiedData { get; private set; }

        public string ResultData { get; set; }

        public ReplacementService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task RunService()
        {
            _readDataServer = new ReadDataJsonParserFromServer(_httpClient);
            dataData = await _readDataServer.GetData(URL);

            _readDataLocal = new ReadDataOnFile();
            replacementData = await _readDataLocal.GetData(ReplacementJSONFile);


            Replacements = JsonSerializer.Deserialize<List<ReplacementData>>(replacementData);

            ModifiedData = ReplaceData(Replacements, dataData);



            await WriteMessagesToFile(ModifiedData);
        }


        public List<string> ReplaceData(List<ReplacementData> replacements, List<string> datas)
        {
            List<string> modifiedData = new List<string>();
            string newMessage = "";

            foreach (string message in datas)
            {
                newMessage = message;

                for (int i = replacements.Count - 1; i >= 0; i--)
                {
                    newMessage = Replace(replacements[i], newMessage);
                }

                if (IsNotNullOrEmpty(newMessage))
                {
                    modifiedData.Add(newMessage);
                }
            }

            return modifiedData;
        }

        public string Replace(ReplacementData replacement, string message)
        {
            string rep = replacement.Replacement;
            string source = replacement.Source;

            if (source == "" && message.Contains(rep))
            {
                message = "";
            }

            if (message != "" && rep != null)
            {
                message = message.Replace(rep, source);
            }
            return message;
        }
        private bool IsNotNullOrEmpty(string message)
        {
            return !string.IsNullOrEmpty(message);
        }

        private async Task WriteMessagesToFile(List<string> modifiedData)
        {
            ResultData = JsonSerializer.Serialize(modifiedData);
            await File.WriteAllTextAsync(ResultFile, ResultData);
        }
    }
}