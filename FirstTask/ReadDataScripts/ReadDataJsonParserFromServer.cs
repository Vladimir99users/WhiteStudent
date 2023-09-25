using System.Text.Json;
public class ReadDataJsonParserFromServer : IReadData<List<string>>
{
    private readonly HttpClient _httpClient;

    public ReadDataJsonParserFromServer(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public async Task<List<string>> GetData(string path)
    {   
        if(string.IsNullOrEmpty(path) )
        {
            throw new ArgumentNullException();
        }

        HttpResponseMessage response = await _httpClient.GetAsync(path);
        string json = await response.Content.ReadAsStringAsync();
        return JsonSerializer.Deserialize<List<string>>(json);
    }
}
