using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Item
    {
        public int Cantidad { get; set; }
        public string Descripicion { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Importe { get; }

        public Item(int pCantidad, string pDescripcion, decimal pPrecioUnitario)
        {
            this.Cantidad = pCantidad;
            this.Descripicion = pDescripcion;
            this.PrecioUnitario = pPrecioUnitario;
        
        }
    }
}
