using System;
using System.Collections.Generic;
using System.Text;

namespace NubiTest.MercadoLibre.Countries
{
    public class CountriesResponse
    {
        public string id { get; set; }
        public string name { get; set; }
        public string locale { get; set; }
        public string currency_id { get; set; }
        public string decimal_separator { get; set; }
        public string thousands_separator { get; set; }
        public string time_zone { get; set; }
        public GeoInformationResponse geo_information { get; set; }
        public List<StatesResponse> states { get; set; }
      
    }
    public class GeoInformationResponse
    {
        public LocationResponse location { get; set; }
       

    }
    public class LocationResponse
    {
        public float latitude { get; set; }
        public float longitude { get; set; }

    }
    public class StatesResponse
    {
        public string id { get; set; }
        public string name { get; set; }
     
    }
}
