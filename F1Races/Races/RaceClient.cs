using Newtonsoft.Json;

namespace F1Races.Races;

public class RaceClient
{
    private static readonly HttpClient HttpClient = new HttpClient();

    public async Task<RaceData> GetRaces()
    {
        var response = await HttpClient.GetAsync("http://ergast.com/api/f1/current.json");
        
        if(!response.IsSuccessStatusCode)
            Console.WriteLine("Something went wrong");

        var content = response.Content.ReadAsStringAsync().Result;
        var data = JsonConvert.DeserializeObject<RaceData>(content);

        return data;
    }
}