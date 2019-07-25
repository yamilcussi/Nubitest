using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NubiTest.Data.Models
{
    public class Delete
    {
        public static string Entry(Data.Users model)
        {
            try
            {
                NubiTest.Data.NubiDbContext db = new NubiTest.Data.NubiDbContext();
                var usuario = db.Users.FirstOrDefault();
                db.Users.Remove(usuario);
                db.SaveChanges();
                return string.Empty;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }
    }
}
