using NUnit.Framework;
using RestSharp;
using System.Net;
using System.Threading.Tasks;

namespace Pract17.Tests
{
    [TestFixture]
    public class StatusCodeTests
    {
        [Test]
        [TestCase(4165, HttpStatusCode.OK)]
        [TestCase(0, HttpStatusCode.NotFound)]
        public async Task GETStatusCodeTest(int userId, HttpStatusCode expectedHttpStatusCode)
        {
            RestClient client = new RestClient("https://gorest.co.in");
            RestRequest request = new RestRequest($"public/v2/users/{userId}", Method.Get);

            RestResponse response =  await client.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(expectedHttpStatusCode));
        }
        
        [Test]
        public async Task POSTStatusCodeTest()
        {
            RestClient client = new RestClient("https://gorest.co.in");
            RestRequest request = new RestRequest($"public/v2/users/", Method.Post);
            request.AddHeader("Authorization", "Bearer 2e03951568c9304f5892565524e91ba81d30ce2416447628708f6a67432c6cc7");
            request.AddParameter("id", 4678);
            request.AddParameter("name", "StLab StLab");
            request.AddParameter("email", "Stlab@techart.by");
            request.AddParameter("gender", "male");
            request.AddParameter("status", "active");

            RestResponse response =  await client.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.Created));
        }

        [Test]
        [TestCase(4670)]
        public async Task DELATEStatusCodeTest(int userId)
        {
            RestClient client = new RestClient("https://gorest.co.in");
            RestRequest request = new RestRequest($"public/v2/users/{userId}", Method.Delete);
            request.AddHeader("Authorization", "Bearer 2e03951568c9304f5892565524e91ba81d30ce2416447628708f6a67432c6cc7");
            
            RestResponse response = await client.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.NoContent));
        }

        [Test]
        [TestCase(4716)]
        public async Task PUTStatusCodeTest(int userId)
        {
            RestClient client = new RestClient("https://gorest.co.in");
            RestRequest request = new RestRequest($"public/v2/users/{userId}", Method.Put);
            request.AddHeader("Authorization", "Bearer 2e03951568c9304f5892565524e91ba81d30ce2416447628708f6a67432c6cc7");
            request.AddParameter("id", 4678);
            request.AddParameter("name", "Xxxx Xxxx");
            request.AddParameter("email", "Xxxx@xxx.xxx");
            request.AddParameter("gender", "female");
            request.AddParameter("status", "inactive");

            RestResponse response = await client.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
        
        [Test]
        [TestCase(4716)]
        public async Task PATCHStatusCodeTest(int userId)
        {
            RestClient client = new RestClient("https://gorest.co.in");
            RestRequest request = new RestRequest($"public/v2/users/{userId}", Method.Put);
            request.AddHeader("Authorization", "Bearer 2e03951568c9304f5892565524e91ba81d30ce2416447628708f6a67432c6cc7");
            request.AddParameter("gender", "male");
            request.AddParameter("status", "active");

            RestResponse response = await client.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}