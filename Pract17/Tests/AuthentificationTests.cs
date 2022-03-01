using NUnit.Framework;
using RestSharp;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp.Serializers;


namespace Pract17.Tests
{
    [TestFixture]
    public class AuthentificationTests
    {
        [Test]
        public async Task PositiveAuthentificationTest()
        {
            RestClient client = new RestClient("https://gorest.co.in");
            RestRequest request = new RestRequest($"public/v2/users/", Method.Post);
            request.AddHeader("Authorization", "Bearer 2e03951568c9304f5892565524e91ba81d30ce2416447628708f6a67432c6cc7");
            request.AddParameter("name", "StLab StLab");
            request.AddParameter("email", "Stlab@techart.by");
            request.AddParameter("gender", "male");
            request.AddParameter("status", "active");

            RestResponse response = await client.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.Created));
        }
        
        [Test]
        public async Task NegativeAuthentificationTest()
        {
            RestClient client = new RestClient("https://gorest.co.in");
            RestRequest request = new RestRequest($"public/v2/users/", Method.Post);

            RestResponse response = await client.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.Unauthorized));
        }
    }
}
