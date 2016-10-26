using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Negocio
{
    public static class AdmClientes
    {
        public static List<ClienteIndividuo> ListarClienteIndividuo()
        {
            List<ClienteIndividuo> lista = new List<ClienteIndividuo>();

            return lista;
        }

        public static ClienteIndividuo ListarClienteIndividuo(string CUIT)
        {
            
            return new ClienteIndividuo() ;
        }

        public static List<Empresa> ListarClienteEmpresa()
        {
            return new List<Empresa>(); 
        }

        public static Empresa ListarClienteEmpresa(string CUIT)
        {
            return new Empresa();
        }

        public static void Agregar(ClienteIndividuo pClienteIndividuo)
        {

        }

        public static void Modificar(ClienteIndividuo pClienteIndividuo)
        {

        }

        public static void Eliminar(ClienteIndividuo pClienteIndividuo)
        {

        }

        public static void Agregar(Empresa pEmpresa)
        {

        }

        public static void Modificar(Empresa pEmpresa)
        {

        }

        public static void Eliminar(Empresa pEmpresa)
        {

        }
    }
}
