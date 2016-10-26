using Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    //Clase de la Fase 03
    class AdmProductos
    {
        public List<Producto> Listar()
        {
            return new List<Producto>();
        }

        //Lista de Productos
        public List<Producto> Listar(Categoria Categoria)
        {
            return new List<Producto>();
        }

        public List<Producto> Listar(Categoria Categoria, Categoria SubCategoria)
        {
            return new List<Producto>();
        }

        public Producto Listar(string Nombre)
        {
            Producto Item = new Producto();
            //...
            return Item;
        }
    }
}
