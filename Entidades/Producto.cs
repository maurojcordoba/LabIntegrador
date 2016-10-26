using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioCosto { get; set; }
        public double Margen { get; set; }
        private static double IVA = 21.0;
        public decimal PrecioBruto
        {
            get
            {
                return PrecioCosto +  Convert.ToDecimal(Margen);
            }
        }
        public decimal PrecioVenta
        {
            get
            {
                return PrecioBruto + Convert.ToDecimal(IVA);
            }
        }
        public Empresa Proveedor { get; set; }
        public Categoria Categoria { get; set; }
        public Categoria SubCategoria { get; set; }

        public Producto()
        {

        }

        public Producto(string Nombre, string Descripcion, decimal PrecioCosto, double Margen, Empresa Proveedor, Categoria Categoria, Categoria SubCategoria)
        {
            this.Nombre = Nombre;
            this.PrecioCosto = PrecioCosto;
            this.Margen = Margen;
         
            this.Proveedor = Proveedor;
            this.Categoria = Categoria;
            this.SubCategoria = SubCategoria;
        }

    }
}
