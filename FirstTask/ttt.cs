using FirstTask;
using System.IO;
using System.Net.Http;
using NUnit;
using NUnit.Framework;

namespace Test
{
    //[TestFixture]
    public class ttt
    {

        //[Test]
        //public async Task UncorrectConectionToURL()
        //{
        //    string UnCorrectURL = GetUncorrectURL();
        //    HttpClient client = new HttpClient();
        //
        //    HttpResponseMessage response = await client.GetAsync(UnCorrectURL);
        //
        //    Assert.Equals(response.IsSuccessStatusCode, false);
        //}
        //
        //[TestCase]
        //public async Task CorrectConnectionToURL()
        //{
        //    string correctURL = GetCorrectURL();
        //    HttpClient client = new HttpClient();
        //
        //    HttpResponseMessage response = await client.GetAsync(correctURL);
        //
        //    Assert.Equals(response.IsSuccessStatusCode, true);
        //}
        //
        //[TestCase]
        //public async Task CheckIsNotNullData()
        //{
        //    IReadData<List<string>> readDataServer = new ReadDataJsonParserFromServer(GetHttpClient());
        //    string url = GetCorrectURL();
        //    List<string> data = await readDataServer.GetData(url);
        //
        //    Assert.IsNotNull(data);
        //}
        //
        //[TestCase]
        //public void CheckCorrectPathFile()
        //{
        //    Assert.Equals(true, true);
        //}
        //
        //private string GetCorrectURL()
        //{
        //    return "https://raw.githubusercontent.com/thewhitesoft/student-2023-assignment/main/data.json";
        //}
        //
        //private string GetUncorrectURL()
        //{
        //    return "https://raw.githubusercontent.com/thewhitesoft/student-2023-assignment/main/d.json";
        //}
        //
        //private HttpClient GetHttpClient()
        //{
        //    return new HttpClient();
        //}
    }
}