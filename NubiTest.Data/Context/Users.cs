﻿using System;
using System.Collections.Generic;

namespace NubiTest.Data
{
    public partial class Users
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
