using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empresa
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string CUIT { get; set; }
        public string Contacto { get; set; }
        public DatosContacto DatosContacto { get; set; }

        public Empresa()
        {

        }

        public Empresa(string pNombre, string pCUIT, string pContacto, DatosContacto pDatosContacto)
        {
            this.Nombre = pNombre;
            this.CUIT = pCUIT;
            this.Contacto = pContacto;
            this.DatosContacto = pDatosContacto;
        }

        public Empresa(int pId, string pNombre, string pCUIT, string pContacto, DatosContacto pDatosContacto)
        {
            this.Id = pId;
            this.Nombre = pNombre;
            this.CUIT = pCUIT;
            this.Contacto = pContacto;
            this.DatosContacto = pDatosContacto;
        }

        public Empresa(int pId, string pNombre)
        {
            this.Id = pId;
            this.Nombre = pNombre;

        }

        public Empresa(int pId, string pCUIT)
        {
            this.Id = pId;            
            this.CUIT = pCUIT;
        }
    }
}
