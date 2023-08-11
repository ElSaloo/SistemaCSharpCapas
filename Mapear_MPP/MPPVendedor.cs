using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades_BE;
using Acceso_DAL;
using System.Data.SqlClient;
using System.Security.Policy;
using System.Data;
using System.Collections;

namespace Mapear_MPP
{
    public class MPPVendedor
    {
        Acceso datos;
        Hashtable hash;
        public MPPVendedor()
        {
            datos = new Acceso();
            hash = new Hashtable();
        }
        public List<BEVendedor> ListarTodoSP()
        {
            List<BEVendedor> listavendedor = new List<BEVendedor>();
            DataTable tabla = datos.LeerSP("s_Vendedores_ListarTodo", null);

            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow row in tabla.Rows)
                {
                    BEVendedor vendedor = new BEVendedor();
                    vendedor.Codigo = Convert.ToInt32(row["Codigo"]);
                    vendedor.DNI = Convert.ToInt32(row["DNI"]);
                    vendedor.Nombre= row["Nombre"].ToString();
                    vendedor.Apellido = row["Apellido"].ToString();
                    listavendedor.Add(vendedor);
                }
            }
            else
            {
                listavendedor = null;
            }
            return listavendedor;
        }
        public bool CrearPreventa(BEPreventa preventa)
        {
            string consulta = "s_Preventa_Crear";

            hash.Add("@CodigoVendedor", preventa.Vendedor.Codigo);
            hash.Add("@Legajo", preventa.Cliente.Legajo);
            hash.Add("@CodigoVehiculo", preventa.Vehiculo.Codigo);
            hash.Add("@FechaCreacion", preventa.FechaCreacion);
            hash.Add("@Forma", preventa.FormaDePago.Codigo);
            hash.Add("@Monto", preventa.MontoTotal);
            hash.Add("@Autoriza", "False");

            return datos.EscribirSP(consulta, hash);            
        }
    }
}
