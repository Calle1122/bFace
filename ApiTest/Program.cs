using System;
using RestSharp;
using Newtonsoft.Json;

namespace ApiTest
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Please choose a pokemon");
            string playerPokemon = Console.ReadLine();

            RestClient client = new RestClient("https://pokeapi.co/api/v2/");

            RestRequest request = new RestRequest("pokemon/" + playerPokemon);

            IRestResponse response = client.Get(request);

            //Console.WriteLine(response.Content);

            Pokemon poke = JsonConvert.DeserializeObject<Pokemon>(response.Content);

            Console.Clear();

            System.Console.WriteLine("Name: " + poke.name + " (id: " + poke.id + ")");
            System.Console.WriteLine("Height: " + poke.height);
            System.Console.WriteLine("Weight: " + poke.weight);
            System.Console.WriteLine("Base EXP: " + poke.base_experience);
            System.Console.WriteLine("Location Area: " + poke.location_area_encounters);

            Console.ReadLine();
        }
    }
}
