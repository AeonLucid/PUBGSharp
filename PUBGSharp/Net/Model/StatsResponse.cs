using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PUBGSharp.Data;

namespace PUBGSharp.Net.Model
{
    public class StatsResponse
    {
        [JsonProperty("platformId")]
        public int PlatformId { get; set; }

        [JsonProperty("AccountId")]
        public string AccountId { get; set; }

        [JsonProperty("Avatar")]
        public string Avatar { get; set; }
        
        [JsonProperty("selectedRegion")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Region SelectedRegion { get; set; }

        [JsonProperty("defaultSeason")]
        public string DefaultSeason { get; set; }

        [JsonProperty("LastUpdated")]
        public DateTimeOffset LastUpdated { get; set; }

        [JsonProperty("PlayerName")]
        public string PlayerName { get; set; }

        [JsonProperty("PubgTrackerId")]
        public int PubgTrackerId { get; set; }

        [JsonProperty("Stats")]
        public List<StatsRoot> Stats { get; set; }
    }
}