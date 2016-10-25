using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DatosContacto
    {
        public string Email { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }

        public DatosContacto(string pEmail, string pDireccion, string pTelefono)
        {
            this.Email = pEmail;
            this.Direccion = pDireccion;
            this.Telefono = pTelefono;
        }
    }


}
