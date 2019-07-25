using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NubiTest.Data.Models
{
    public class Get
    {
        public static List<Data.Users> All(Data.Users model)
        {
            try
            {
                NubiTest.Data.NubiDbContext db = new NubiTest.Data.NubiDbContext();
                return db.Users.ToList();            
               
            }
            catch (Exception)
            {
                return new List<Data.Users>();
            }

        }
    }
}
