using Acceso_DAL;
using Entidades_BE;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapear_MPP
{
    public class MPPVehiculo
    {
        Acceso datos;
        Hashtable hash;

        public MPPVehiculo()
        {
            datos = new Acceso();
            hash = new Hashtable();
        }   
        #region Store Procedure
        public List<BEVehiculo> CargoVehiculosSP()
        {
            List<BEVehiculo> listaVehiculo = new List<BEVehiculo>();
            DataTable tabla = datos.LeerSP("s_Vehiculo_ListarTodo", null);

            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow row in tabla.Rows)
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

                    listaVehiculo.Add(vehiculo);
                }
            }
            return listaVehiculo;
        }
        public bool GuardarSP(BEVehiculo vehiculo)
        {
            string Consulta_SQL = "s_Vehiculo_Crear";

            if (vehiculo.Codigo != 0)
            {
                hash.Add("@Codigo", vehiculo.Codigo);
                Consulta_SQL = "s_Vehiculo_Modificar";
            }
            hash.Add("@Patente", vehiculo.Patente);
            hash.Add("@Marca", vehiculo.Marca);
            hash.Add("@Modelo", vehiculo.Modelo);
            hash.Add("@Año", vehiculo.Año);
            hash.Add("@Kilometraje", vehiculo.Kilometraje);
            hash.Add("@Precio", vehiculo.Precio);

            if (VerificoQuePatenteNoExista(vehiculo) == false)
            {
                return datos.EscribirSP(Consulta_SQL, hash);
            }
            else
            {
                return false;
            }
        }
        bool VerificoQuePatenteNoExista(BEVehiculo vehiculo)
        {
            Hashtable hash2 = new Hashtable();

            if (vehiculo.Patente == string.Empty)
            {
                hash2.Add("@Patente", vehiculo.Patente);
                return datos.LeerScalarSP("s_Vehiculo_Existe_Patente", hash2);
            }
            else
            {
                return false;
            }
        }
        public bool BajaVehiculoSP(BEVehiculo vehiculo)
        {
            string Consulta_SQL = "s_Vehiculo_Baja";

            hash.Add("@Codigo", vehiculo.Codigo);
            return datos.EscribirSP(Consulta_SQL, hash);
        }
        public bool TransferirClienteVehiculoSP(BECliente cliente, BEVehiculo vehiculo)
        {
            string consulta = "s_Vehiculo_Transferir";

            hash.Add("@Legajo", cliente.Legajo);
            hash.Add("@Codigo", vehiculo.Codigo);

            if (Existe_Propietario_DelVehiculoSP(vehiculo) == false)
            {             
                return datos.EscribirSP(consulta, hash);
            }
            else
                return false;
        }
        bool Existe_Propietario_DelVehiculoSP(BEVehiculo vehiculo)
        {
            Hashtable hash2 = new Hashtable();
            
            hash2.Add("@Codigo", vehiculo.Codigo);
            return datos.LeerScalarSP("s_Vehiculo_Existe_Propietario", hash2);
        }
        public bool DesasignarClienteVehiculoSP(BECliente cliente, BEVehiculo vehiculo)
        {
            string consulta = "s_Vehiculo_Desasignar";

            hash.Add("@Legajo", cliente.Legajo);
            hash.Add("@Codigo", vehiculo.Codigo);

            return datos.EscribirSP(consulta, hash);
        }
        #endregion
    }
}
