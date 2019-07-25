using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NubiTest.Data.Models
{
    public class Update
    {
        public static string Entry(Data.Users model)
        {
            try
            {
                NubiTest.Data.NubiDbContext db = new NubiTest.Data.NubiDbContext();
                var usuario = db.Users.FirstOrDefault(d => d.Id == model.Id);
                usuario.Password = model.Password;
                usuario.Nombre = model.Nombre;
                usuario.Apellido = model.Apellido;
                usuario.Email = model.Email;
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
