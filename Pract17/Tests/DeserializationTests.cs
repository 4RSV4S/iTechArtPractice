using NUnit.Framework;
using RestSharp;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Pract17.DataEntities;

namespace Pract17.Tests
{
    [TestFixture]
    public class DeserializationTests
    {
        [Test]
        [TestCase(4185)]
        [TestCase(4184)]
        public async Task DeserializationTest(int userId)
        {
            RestClient client = new RestClient("https://gorest.co.in");
            RestRequest request = new RestRequest($"public/v2/users/{userId}", Method.Get);

            RestResponse response = await client.ExecuteAsync(request);
            UserResponse userResponse = JsonConvert.DeserializeObject<UserResponse>(response.Content);

            Assert.That(userResponse.Id, Is.EqualTo(userId));
        }
    }
}
