using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FixedFinalProject.Models
{
    public class APIControls : IAPIControls
    {
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
