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

            System.Console.WriteLine("Name: " + poke.name);
            System.Console.WriteLine("Weight: " + poke.weight);
            System.Console.WriteLine("Base EXP: " + poke.base_experience);

            Console.ReadLine();
        }
    }
}
