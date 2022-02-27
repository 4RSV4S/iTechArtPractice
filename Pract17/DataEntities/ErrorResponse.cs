using Newtonsoft.Json;

namespace Pract17.DataEntities
{
    public class ErrorResponse
    {
        [JsonProperty("field")]
        public string Field { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
