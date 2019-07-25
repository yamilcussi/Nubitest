using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace NubiTest.UnitTest
{
    [TestClass]
    public class UsuerDbTest
    {
        NubiTest.Data.NubiDbContext db = new NubiTest.Data.NubiDbContext();
        [TestMethod]
        public void InsertTest()
        {          
            db.Users.Add(new Data.Users {Nombre="Juana",Apellido="De Arco",Email="juanadearco@gmail.com",Password="123456" });
            db.SaveChanges();
        }
        [TestMethod]
        public void UpdateTest()
        {
            var usuario = db.Users.FirstOrDefault();
            usuario.Password = "4562184848754545112121022222";
            db.SaveChanges();
        }
        [TestMethod]
        public void DeleteTest()
        {
            var usuario = db.Users.FirstOrDefault();
            db.Users.Remove(usuario);
            db.SaveChanges();
        }
    }
}
