using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Servidor
{
    public static class BaseDatos
    {
        public static string StringConexion {
            get {
                return ConfigurationManager.AppSettings["StringConexion"];                
            }
    }
}
