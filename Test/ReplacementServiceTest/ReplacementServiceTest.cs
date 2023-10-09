using Replace;
using System.IO;
using System.Net.Http;
using NUnit;
using NUnit.Framework;
using Xunit;
using System.Text.Json;
using System;

namespace Test
{

    public class ReplacementServiceTest
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public async Task UncorrectConectionToURL()
        {
            string UnCorrectURL = GetUncorrectURL();
            HttpClient client = new HttpClient();

            HttpResponseMessage response = await client.GetAsync(UnCorrectURL);

            NUnit.Framework.Assert.AreEqual(response.IsSuccessStatusCode, false);
        }

        [Test]
        public async Task CorrectConnectionToURL()
        {
            string correctURL = GetCorrectURL();
            HttpClient client = new HttpClient();

            HttpResponseMessage response = await client.GetAsync(correctURL);

            NUnit.Framework.Assert.AreEqual(response.IsSuccessStatusCode, true);
        }

        [Test]
        public async Task CheckIsNotNullData()
        {
            IReadData<List<string>> readDataServer = new ReadDataJsonParserFromServer(GetHttpClient());
            string url = GetCorrectURL();
            List<string> data = await readDataServer.GetData(url);

            NUnit.Framework.Assert.IsNotNull(data);
        }

        [Test]
        public void CheckSingleReplace_Test()
        {
            ReplacementService service = GetService();

            ReplacementData replacement = GetSingleReplcementData("Koko", "Hello NUnitTests");

            string testString = "I am doint a Koko";
            string expectedString = "I am doint a Hello NUnitTests";

            string resultString = service.Replace(replacement, testString);

            NUnit.Framework.Assert.AreEqual(resultString, expectedString);
        }

        [Test]
        public async Task CheckResultFile_Test()
        {
            IReadData<string> readDataLocal = new ReadDataOnFile();
            string expectedData = await readDataLocal.GetData("expectedJson.json");

            string result = await readDataLocal.GetData("result.json");

            NUnit.Framework.Assert.AreEqual(expectedData, result);
        }


        private ReplacementData GetSingleReplcementData (string replace, string source)
        {
            ReplacementData replacement = new ReplacementData
            {
                Replacement = replace,
                Source = source
            };


            return replacement;
        }

        private string GetCorrectURL()
        {
            return "https://raw.githubusercontent.com/thewhitesoft/student-2023-assignment/main/data.json";
        }

        private string GetUncorrectURL()
        {
            return "https://raw.githubusercontent.com/thewhitesoft/student-2023-assignment/main/d.json";
        }

        private ReplacementService GetService()
        {
            return new ReplacementService(GetHttpClient());
        }

        private HttpClient GetHttpClient()
        {
            return new HttpClient();
        }
    }
}