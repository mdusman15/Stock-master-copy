using System;
using Newtonsoft.Json;

namespace Stock.Models
{
    public class StockModel
    {
        [JsonProperty("Meta Data")]
        public MetaData MetaData { get; set; }

        [JsonProperty("Monthly Adjusted Time Series")]
        public Dictionary<string, StockData> StockData { get; set; }
    }

    public class MetaData
    {
        [JsonProperty("1. Information")]
        public string Information { get; set; }

        [JsonProperty("2. Symbol")]
        public string Symbol { get; set; }

        [JsonProperty("3. Last Refreshed")]
        public string LastRefreshed { get; set; }

        [JsonProperty("4. Time Zone")]
        public string TimeZone { get; set; }
    }

    public class StockData
    {
        [JsonProperty("1. open")]
        public string Open { get; set; }

        [JsonProperty("2. high")]
        public string High { get; set; }

        [JsonProperty("3. low")]
        public string Low { get; set; }

        [JsonProperty("4. close")]
        public string Close { get; set; }

        [JsonProperty("5. adjusted close")]
        public string AdjustedClose { get; set; }

        [JsonProperty("6. volume")]
        public string Volume { get; set; }

        [JsonProperty("7. dividend amount")]
        public string DividendAmount { get; set; }

    }
}
