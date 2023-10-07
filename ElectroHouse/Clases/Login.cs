using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectroHouse.Clases
{
    internal class Login
    {
        public Login() { }
        public string usuario { get; set; }
        public string contrasenia { get; set; }


        public Login(string usuario, string contrasenia)
        {
            this.usuario = usuario;
            this.contrasenia = contrasenia;
        }

    }
}
