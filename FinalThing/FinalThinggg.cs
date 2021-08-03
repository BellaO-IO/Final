using Newtonsoft.Json;
using RestSharp;
using System;

namespace FinalThing
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new RestClient("https://apple-store-top-charts.p.rapidapi.com/topapps?date=2021-07-15&countryCode=us&device=%3CREQUIRED%3E&purchaseType=%3CREQUIRED%3E&categoryId=0");
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-key", "1bdddc2d1fmsh5cfe9b873f94f80p128b8cjsn47d04248630c");
            request.AddHeader("x-rapidapi-host", "apple-store-top-charts.p.rapidapi.com");
            //Irequest is being weird
            IRestResponse response = client.Execute(request);

            var root = JsonConvert.DeserializeObject<Root>(response.Content);

            Console.WriteLine(root.topChart[0].title);


            foreach (var app in root.topChart)
            {
                Console.WriteLine("...............");
                Console.WriteLine($"This app has {app.rating} rating");
                Console.WriteLine(app.title);
                Console.WriteLine($"{app.price}$");
                Console.WriteLine($"{app.rating_count} have rated this app.");
            }
        }

        public Root GetAllApps()
        {
            var client = new RestClient("https://apple-store-top-charts.p.rapidapi.com/topapps?date=2021-07-15&countryCode=us&device=%3CREQUIRED%3E&purchaseType=%3CREQUIRED%3E&categoryId=0");
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-key", "1bdddc2d1fmsh5cfe9b873f94f80p128b8cjsn47d04248630c");
            request.AddHeader("x-rapidapi-host", "apple-store-top-charts.p.rapidapi.com");
            IRestResponse response = client.Execute(request);
            return JsonConvert.DeserializeObject<Root>(response.Content);
        }
    }
}
