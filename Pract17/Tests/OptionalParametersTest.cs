using NUnit.Framework;
using RestSharp;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Pract17.DataEntities;

namespace Pract17.Tests
{
    [TestFixture]
    public class OptionalParametersTest
    {
        [Test]
        [TestCase("", "TechArt@stlab.by", "male", "active")]
        [TestCase("Tech Art", "", "male", "active")]
        [TestCase("Tech Art", "TechArt@stlab.by", "", "active")]
        [TestCase("Tech Art", "TechArt@stlab.by", "male", "")]
        public async Task NoRequiredParametersTest(string name, string email, string gender, string status)
        {
            RestClient client = new RestClient("https://gorest.co.in");
            RestRequest request = new RestRequest($"public/v2/users/", Method.Post);
            request.AddHeader("Authorization", "Bearer 2e03951568c9304f5892565524e91ba81d30ce2416447628708f6a67432c6cc7");
            request.AddParameter("name", name);
            request.AddParameter("email", email);
            request.AddParameter("gender", gender);
            request.AddParameter("status", status);

            RestResponse response = await client.ExecuteAsync(request);

            ErrorResponse[] errorResponse = JsonConvert.DeserializeObject<ErrorResponse[]>(response.Content);
            
            Assert.That(errorResponse[0].Message, Is.EqualTo("can't be blank"));
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.UnprocessableEntity));
        }
    }
}
