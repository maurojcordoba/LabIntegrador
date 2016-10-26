using Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public static class AdmProductos
    {
        public static List<Producto> Listar()
        {
            return new List<Producto>();
        }

        public static List<Producto> Listar(Categoria Categoria)
        {
            return new List<Producto>();
        }

        public static List<Producto> Listar(Categoria Categoria, Categoria SubCategoria)
        {
            return new List<Producto>();
        }

        public static Producto Listar(string Nombre)
        {
            Producto Item = new Producto();
            //...
            return Item;
        }

        public static void Agregar(Producto pProducto)
        {

        }

        public static void Modificar(Producto pProducto)
        {

        }

        public static void Eliminar(Producto pProducto)
        {

        }
    }
}
