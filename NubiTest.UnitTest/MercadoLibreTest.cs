using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NubiTest.UnitTest
{
    [TestClass]
    public class MercadoLibreTest
    {
        /// <summary>
        /// prubar llamada al api country de mercado libre 
        /// </summary>
        [TestMethod]
        public void AR_Test()
        {
            NubiTest.MercadoLibre.Countries.CountriesResponse response = NubiTest.MercadoLibre.Countries.CountriesService.Get("AR");
        }
        [TestMethod]
        public void BR_Test()
        {
            NubiTest.MercadoLibre.Countries.CountriesResponse response = NubiTest.MercadoLibre.Countries.CountriesService.Get("BR");
        }
        [TestMethod]
        public void CO_Test()
        {
            NubiTest.MercadoLibre.Countries.CountriesResponse response = NubiTest.MercadoLibre.Countries.CountriesService.Get("CO");
        }
    }
}
