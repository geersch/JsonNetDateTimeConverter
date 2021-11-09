using System;
using Newtonsoft.Json;

namespace ConsoleApplication
{
    [JsonObject(MemberSerialization.OptIn)]
    public class ReputationChange
    {
        [JsonProperty(PropertyName = "user_id")]
        public int UserId { get; set; }

        [JsonProperty(PropertyName = "post_id")]
        public int PostId { get; set; }

        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "positive_rep")]
        public int PossitiveReputation { get; set; }

        [JsonProperty(PropertyName = "on_date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime OnDate { get; set; }
    }
}
