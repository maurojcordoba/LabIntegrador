﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    //Clase Vendedor hereda de Persona prueba
    public class Vendedor : Persona
    {
        public string DNI { get; set; }

        public Vendedor(string pNombre, string pApellido, string pDNI, DatosContacto pDatosContacto)
        {
            this.Nombre = pNombre;
            this.Apellido = pApellido;
            this.DNI = pDNI;
            this.DatosContacto = pDatosContacto;
        }

        
    }
}
