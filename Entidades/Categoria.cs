using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public Categoria(string pNombre)
        {
            this.Nombre = pNombre;
        }

        public Categoria(int pId,string pNombre)
        {
            this.Id = pId;
            this.Nombre = pNombre;
        }
    }
}
