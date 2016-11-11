using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ClienteIndividuo : Persona
    {
        public int Id { get; set; }
        public string CUIT { get; set; }

        public ClienteIndividuo(string Nombre, string Apellido, string CUIT, DatosContacto pDatosContacto)
        {
            this.Nombre = Nombre;
            this.CUIT = CUIT;
            this.Apellido = Apellido;
            this.DatosContacto = pDatosContacto;
        }

        public ClienteIndividuo()
        {

        }

        public ClienteIndividuo(int pId, string Nombre, string Apellido, string CUIT, DatosContacto pDatosContacto)
        {
            this.Id = pId;
            this.Nombre = Nombre;
            this.CUIT = CUIT;
            this.Apellido = Apellido;
            this.DatosContacto = pDatosContacto;
        }

        public ClienteIndividuo(int pId, string Nombre, string Apellido, string CUIT)
        {
            this.Id = pId;
            this.Nombre = Nombre;
            this.CUIT = CUIT;
            this.Apellido = Apellido;            
        }
    }
}
