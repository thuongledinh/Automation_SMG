using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.API
{
    [TestFixture]
    public class DataDrivenUsingAttributesTests
    {
        private const string BASE_URL = "https://en.wikipedia.org";

        [TestCase("action=query", "format=json", "list=search", "formatversion=2", "srsearch=Software Testing", "sroffset=10", TestName = "TestCase #1: Search with text - Software Testing")]
        [TestCase("action=query", "format=json", "list=search", "formatversion=2", "srsearch=Software", "sroffset=10", TestName = "TestCase #2: Search with text - Software")]
        [TestCase("action=query", "format=json", "list=search", "formatversion=2", "srsearch=$^%%#%#^", "sroffset=10", TestName = "TestCase #3: Search with text - $^%%#%#^")]
        public async Task SearchForString (string action, string format, string list, string formatverion, string srsearch, string sroffset )
        {
            // create request
            RestClient client = new RestClient(BASE_URL);
            RestRequest request =  new RestRequest("/w/api.php?"+$"{action}&{format}&{list}&{formatverion}&{srsearch}&{sroffset}", Method.Get);

            // send request and get response
            RestResponse response = client.Execute(request);
            Console.WriteLine(response.ResponseUri);

            dynamic jsonResponse = JsonConvert.DeserializeObject(response.Content);
            dynamic jsonObject = jsonResponse.batchcomplete;
            Console.WriteLine(jsonResponse);
            Console.WriteLine(jsonObject);
            string isbatchcomplete = (string)jsonObject;



            // assert
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            Assert.That(response.ContentType, Is.EqualTo("application/json"));
            Assert.That(isbatchcomplete, Is.EqualTo("True"));
        }
    }
}
