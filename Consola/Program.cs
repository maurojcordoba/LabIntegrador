using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Importo todas las clases del proyecto Entidades
using Entidades;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Fase01");
            Console.WriteLine("Ingrese un Producto2");

            string Nombre = "Producto 01",
                Descripcion = "";

            Empresa Proveedor = new Empresa();

            Categoria pCategoria = new Categoria("Categoria01"); 
            Categoria pSubCategoria = new Categoria("SubCategoria01");

            decimal PrecioCosto = 600;
            double Margen = 12;

            Producto producto = new Producto(Nombre, Descripcion, PrecioCosto, Margen, Proveedor, pCategoria, pSubCategoria);
            

            Console.WriteLine("Nombre: " + producto.Nombre);
 
            Console.WriteLine("Descripcion: " + producto.Descripcion);

            Console.WriteLine("PrecioCosto: " + Convert.ToString(producto.PrecioCosto));

            Console.WriteLine("Margen: " + Convert.ToString(producto.Margen));

            //Console.WriteLine("IVA: " + Convert.ToString(producto.IVA));

            Console.WriteLine("PrecioBruto: " + Convert.ToString(producto.PrecioBruto));
            Console.WriteLine("PrecioVenta: " + Convert.ToString(producto.PrecioVenta));

            Console.WriteLine("Proveedor: " + producto.Proveedor);

            Console.WriteLine("Categoria: " + producto.Categoria);
 
            Console.WriteLine("SubCategoria: "+ producto.SubCategoria);


            try
            {
                Persona persona = new Persona("Mauro", "", new DatosContacto("", "",""));
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error: {0}", ex.Message);
            }



            Console.ReadLine();
        }
    }
}
