using Nancy.Json;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text; 

namespace NubiTest.MercadoLibre.Countries
{
    public class CountriesService
    {
        public static CountriesResponse Get(string CodigoPais) {
            CountriesResponse country = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://api.mercadolibre.com/classified_locations/countries/");
                var responseTask = client.GetAsync(CodigoPais);
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsStringAsync();
                    readTask.Wait();
                    country= JsonConvert.DeserializeObject<CountriesResponse>(readTask.Result);               
                }             
            }
            return country;

        }
    }
}



