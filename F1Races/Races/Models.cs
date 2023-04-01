using System.Text.Json.Serialization;

    public class Circuit
    {
        [JsonPropertyName("circuitId")]
        public string CircuitId { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("circuitName")]
        public string CircuitName { get; set; }

        [JsonPropertyName("Location")]
        public Location Location { get; set; }
    }

    public class RaceData
    {
        [JsonPropertyName("MRData")]
        public MRData MrData { get; set; }
    }

    public class FirstPractice
    {
        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("time")]
        public string Time { get; set; }
    }

    public class Location
    {
        [JsonPropertyName("lat")]
        public string Lat { get; set; }

        [JsonPropertyName("long")]
        public string Long { get; set; }

        [JsonPropertyName("locality")]
        public string Locality { get; set; }

        [JsonPropertyName("country")]
        public string Country { get; set; }
    }

    public class MRData
    {
        [JsonPropertyName("xmlns")]
        public string Xmlns { get; set; }

        [JsonPropertyName("series")]
        public string Series { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("limit")]
        public string Limit { get; set; }

        [JsonPropertyName("offset")]
        public string Offset { get; set; }

        [JsonPropertyName("total")]
        public string Total { get; set; }

        [JsonPropertyName("RaceTable")]
        public RaceTable RaceTable { get; set; }
    }

    public class Qualifying
    {
        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("time")]
        public string Time { get; set; }
    }

    public class Race
    {
        [JsonPropertyName("season")]
        public string Season { get; set; }

        [JsonPropertyName("round")]
        public string Round { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("raceName")]
        public string RaceName { get; set; }

        [JsonPropertyName("Circuit")]
        public Circuit Circuit { get; set; }

        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("time")]
        public string Time { get; set; }

        [JsonPropertyName("FirstPractice")]
        public FirstPractice FirstPractice { get; set; }

        [JsonPropertyName("SecondPractice")]
        public SecondPractice SecondPractice { get; set; }

        [JsonPropertyName("ThirdPractice")]
        public ThirdPractice ThirdPractice { get; set; }

        [JsonPropertyName("Qualifying")]
        public Qualifying Qualifying { get; set; }

        [JsonPropertyName("Sprint")]
        public Sprint Sprint { get; set; }
    }

    public class RaceTable
    {
        [JsonPropertyName("season")]
        public string Season { get; set; }

        [JsonPropertyName("Races")]
        public List<Race> Races { get; set; }
    }

    public class Root
    {
        [JsonPropertyName("MRData")]
        public MRData MRData { get; set; }
    }

    public class SecondPractice
    {
        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("time")]
        public string Time { get; set; }
    }

    public class Sprint
    {
        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("time")]
        public string Time { get; set; }
    }

    public class ThirdPractice
    {
        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("time")]
        public string Time { get; set; }
    }

