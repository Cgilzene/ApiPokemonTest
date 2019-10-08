using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using RestSharp;
using Newtonsoft.Json.Linq;

namespace PostcodeESIO
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

    public class singlePostcode
    {
        public RestClient Client { get; set; }
        public JObject PostcodesSingleResponseContent { get; set; }
        public string PostcodeSelected { get; set; }
        public singlePostcode() => Client = new RestClient
        {
            //BaseUrl = new Uri(AppConfigReader.BaseUri);
            BaseUrl = new Uri("https://api.postcodes.io")
           
        };
        public JObject GetSinglePostcodes(string postcodes)
        {
            var request = new RestRequest();
            request.AddHeader("Content-Type", "application/json");
            PostcodeSelected = postcodes;
            request.Resource = $"postcodes/{postcodes.ToLower().Replace(" ", "")}";
            IRestResponse response = Client.Execute(request);
            PostcodesSingleResponseContent = JObject.Parse(response.Content);
            return PostcodesSingleResponseContent;
        }
    }
}
