using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DatosContacto DatosContacto { get; set; }

        public Persona()
        {
                
        }

        public Persona(string pNombre, string pApellido, DatosContacto pDatosContacto)
        {
            this.Nombre = pNombre;
            this.Apellido = pApellido;
            this.DatosContacto = pDatosContacto;
        }
    }
}
