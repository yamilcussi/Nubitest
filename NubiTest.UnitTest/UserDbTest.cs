using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NubiTest.UnitTest
{
    [TestClass]
    public class UsuerDbTest
    {
       

        /// <summary>
        /// Test para insertar un usuario nuevo 
        /// </summary>
        [TestMethod]
        public void InsertTest()
        {
            NubiTest.Data.Models.Insert.Entry(new Data.Users { Nombre = "Juana", Apellido = "De Arco", Email = "juanadearco@gmail.com", Password = "123456" });
        }
        /// <summary>
        /// test para actualizar un usuario
        /// </summary>
        [TestMethod]
        public void UpdateTest()
        {
            NubiTest.Data.Models.Update.Entry(new Data.Users { Nombre = "Juana", Apellido = "De Arco", Email = "juanadearco@gmail.com", Password = "123456" ,Id=new System.Guid("A645BF58-07C0-4C81-8A14-E69FBDCFEE16") });
        }

        /// <summary>
        /// test para  eliminar el primer usuario de la bd
        /// </summary>
        [TestMethod]
        public void DeleteTest()
        {
            NubiTest.Data.Models.Delete.Entry(new Data.Users { Id=new System.Guid("B6ACCDB9-C596-4325-BA05-6A5B72DD214D") });
        }
    }
}
