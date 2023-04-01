using System;
using F1Races.Races;

Console.WriteLine("Hello, World!");
var raceClient = new RaceClient();

var raceData =  await raceClient.GetRaces();

if (raceData != null)
{
    foreach (var race in raceData.MrData.RaceTable.Races)
        Console.WriteLine($"({race.Season} Season - Round {race.Round}) {race.RaceName} at {race.Circuit.CircuitName}");
}