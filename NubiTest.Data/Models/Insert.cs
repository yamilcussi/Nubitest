using System;
using System.Collections.Generic;
using System.Text;

namespace NubiTest.Data.Models
{
    public class Insert
    {
       
       
        public static string Entry(Data.Users  model)
        {
            try {
                NubiTest.Data.NubiDbContext db = new NubiTest.Data.NubiDbContext();
                db.Users.Add(model);
                db.SaveChanges();
                return string.Empty;
            } catch (Exception ex) {
                return ex.Message;
            }
           
        }

    }
}
