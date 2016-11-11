using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Clase Persona
    /// </summary>
    public  class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DatosContacto DatosContacto { get; set; }

        public Persona()
        {
                
        }

        public Persona(string pNombre, string pApellido, DatosContacto pDatosContacto)
        {
            if(pNombre == "")
            {
                throw new Exception("Nombre es obligatrio");
            }

            if(pNombre.Length < 1 || pNombre.Length > 50)
            {
                throw new Exception("Nombre puede contener entre 1 y 50 caracteres"); 
            }

            if (pApellido == "")
            {
                throw new Exception("Apellido es obligatrio");
            }

            if (pApellido.Length < 1 || pApellido.Length > 50)
            {
                throw new Exception("Apellido puede contener entre 1 y 50 caracteres");
            }


            this.Nombre = pNombre;
            this.Apellido = pApellido;
            this.DatosContacto = pDatosContacto;
        }
    }
}
