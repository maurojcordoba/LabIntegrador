﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Categoria
    {
        public string Nombre { get; set; }

        public Categoria(string pNombre)
        {
            this.Nombre = pNombre;
        }        
    }
}
