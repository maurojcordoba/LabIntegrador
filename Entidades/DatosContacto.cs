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
            if (pEmail == "")
            {
                throw new Exception("Email es obligatrio");
            }

            if (pEmail.Length < 6 || pEmail.Length > 50)
            {
                throw new Exception("Email puede contener entre 1 y 50 caracteres");
            }

            if (pDireccion == "")
            {
                throw new Exception("Direccion es obligatrio");
            }

            if (pDireccion.Length < 1 || pDireccion.Length > 50)
            {
                throw new Exception("Direccion puede contener entre 1 y 50 caracteres");
            }

            this.Email = pEmail;
            this.Direccion = pDireccion;
            this.Telefono = pTelefono;
        }
    }


}
