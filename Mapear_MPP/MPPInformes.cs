using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Acceso_DAL;
using Entidades_BE;

namespace Mapear_MPP
{
    public class MPPInformes
    {
        Acceso datos;

        #region Store Procedure
        public int TotalAdquiridoSP()
        {
            int total = 0;
            datos = new Acceso();
            DataTable table = datos.LeerSP("s_Todos_Los_Autos", null);

            if (table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    total = Convert.ToInt32(row["Total"]);
                }
            }
            return total;
        }
        public int TotalVendidoSP()
        {
            int total = 0;
            datos = new Acceso();
            DataTable table = datos.LeerSP("s_Total_Vehiculos_Vendido", null);

            if (table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    total = Convert.ToInt32(row["Total"]);
                }
            }
            return total;
        }
        public decimal PrecioMasAltoSP()
        {
            decimal precio = 0;
            datos = new Acceso();
            DataTable table = datos.LeerSP("s_Vehiculo_Mas_Caro", null);

            if (table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    precio = Convert.ToDecimal(row["MaximoPrecio"]);
                }
            }
            return precio;
        }
        public decimal ValorEmpresaTotalSP()
        {
            decimal precio = 0;
            datos = new Acceso();
            DataTable table = datos.LeerSP("s_Valor_Empresa_Stock", null);

            if (table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    precio = Convert.ToDecimal(row["ValorDeEmpresa"]);
                }
            }
            return precio;
        }
        public List<BEVehiculo> ListarDisponibleSP()
        {
            List<BEVehiculo> listaDisponible = new List<BEVehiculo>();

            datos = new Acceso();
            DataTable table = datos.LeerSP("s_Vehiculos_Vendidos", null);

            if (table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    BEVehiculo vehiculo = new BEVehiculo();
                    vehiculo.Codigo = Convert.ToInt32(row["Codigo"]);
                    vehiculo.Patente = row["Patente"].ToString();
                    vehiculo.Marca = row["Marca"].ToString();
                    vehiculo.Modelo = row["Modelo"].ToString();
                    vehiculo.Año = Convert.ToInt32(row["Año"]);
                    vehiculo.Kilometraje = Convert.ToInt32(row["Kilometraje"]);
                    vehiculo.Precio = Convert.ToDecimal(row["Precio"]);
                    vehiculo.Estado = vehiculo.DeterminarEstadoDeAuto();

                    listaDisponible.Add(vehiculo);
                }
            }
            return listaDisponible;
        }
        public List<BEVehiculo> ListarTodosVendidoSP()
        {
            List<BEVehiculo> ListaTodosVendido = new List<BEVehiculo>();

            datos = new Acceso();
            DataTable table = datos.LeerSP("s_Chart_Top5_Precio", null);

            if (table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    BEVehiculo vehiculo = new BEVehiculo();
                    vehiculo.Codigo = Convert.ToInt32(row["id_Codigo"]);
                    vehiculo.Patente = row["Patente"].ToString();
                    vehiculo.Marca = row["Marca"].ToString();
                    vehiculo.Modelo = row["Modelo"].ToString();
                    vehiculo.Año = Convert.ToInt32(row["Año"]);
                    vehiculo.Kilometraje = Convert.ToInt32(row["Kilometraje"]);
                    vehiculo.Precio = Convert.ToDecimal(row["Precio"]);
                    vehiculo.Estado = vehiculo.DeterminarEstadoDeAuto();

                    ListaTodosVendido.Add(vehiculo);
                }
            }
            return ListaTodosVendido;
        }
        public List<BEVehiculo> ListarPorMarcaVendidoSP(string marca)
        {
            List<BEVehiculo> listaPorMarcaVendido = new List<BEVehiculo>();

            Hashtable hash = new Hashtable();
            datos = new Acceso();

            DataTable table = datos.LeerSP("s_Vehiculos_Por_Marca", null);

            if (table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    BEVehiculo vehiculo = new BEVehiculo();
                    vehiculo.Codigo = Convert.ToInt32(row["id_Codigo"]);
                    vehiculo.Patente = row["Patente"].ToString();
                    vehiculo.Marca = row["Marca"].ToString();
                    vehiculo.Modelo = row["Modelo"].ToString();
                    vehiculo.Año = Convert.ToInt32(row["Año"]);
                    vehiculo.Kilometraje = Convert.ToInt32(row["Kilometraje"]);
                    vehiculo.Precio = Convert.ToDecimal(row["Precio"]);
                    vehiculo.Estado = vehiculo.DeterminarEstadoDeAuto();

                    listaPorMarcaVendido.Add(vehiculo);
                }
            }
            return listaPorMarcaVendido;
        }
        #endregion
    }
}
