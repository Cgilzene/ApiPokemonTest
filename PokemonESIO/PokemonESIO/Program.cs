using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using RestSharp;
using Newtonsoft.Json.Linq;

namespace PokemonESIO
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public static class AppConfigReader

    {
        public static String BaseUri = ConfigurationManager.AppSettings["base_uri"];
    }
    public class singlePokemon
    {
        public RestClient Client { get; set; }

        public JObject PokemonSingleResponseContent { get; set; }

        public string PokemonSelected { get; set; }

        public singlePokemon() => Client = new RestClient
        {
            BaseUrl = new Uri("https://pokeapi.co//api/v2")//rerfrfefe
        };
            
        public JObject GetSinglePokemon(string pokemon)

        {
            var request = new RestRequest();
            request.AddHeader("Content-Type", "application/json");
            PokemonSelected = pokemon;
            request.Resource = $"pokemon/{pokemon.ToLower()}";
            IRestResponse response = Client.Execute(request);
            PokemonSingleResponseContent = JObject.Parse(response.Content);
            return PokemonSingleResponseContent;
        }
    }
}
