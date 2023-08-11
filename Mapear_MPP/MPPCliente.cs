using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades_BE;
using Acceso_DAL;
using System.Data;
using System.Collections;
using System.Data.SqlClient;

namespace Mapear_MPP
{
    public class MPPCliente
    {
        Acceso datos;
        Hashtable hash;
        public MPPCliente()
        {
            hash = new Hashtable();
        }
        
        #region Store Procedure
        public List<BECliente> CargoClientesSP()
        {
            List<BECliente> listaCliente = new List<BECliente>();

            datos = new Acceso();
            DataTable table = datos.LeerSP("s_Cliente_ListarTodo", null);

            if (table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    if (row["Premium"].ToString() == "True")
                    {
                        BEClientePremium cliente = new BEClientePremium();
                        cliente.Legajo = Convert.ToInt32(row["Legajo"]);
                        cliente.DNI = Convert.ToInt32(row["DNI"]);
                        cliente.Nombre = row["Nombre"].ToString();
                        cliente.Apellido = row["Apellido"].ToString();
                        cliente.Telefono = Convert.ToInt32(row["Telefono"]);

                        BELocalidad localidad = new BELocalidad();
                        localidad.Codigo = Convert.ToInt32(row["CodLoc"]);
                        localidad.Direccion = row["Localidad"].ToString();

                        cliente.Direccion = localidad;

                        if (row["Activo"].ToString() == "True")
                        {
                            cliente.Activo = true;
                        }
                        else
                        {
                            cliente.Activo = false;
                        }
                        Acceso datos2 = new Acceso();
                        Hashtable hash2 = new Hashtable();

                        hash2.Add("@Legajo", cliente.Legajo);
                        DataTable table2 = datos2.LeerSP("s_Cliente_Listar_Vehiculos_Propios",hash2);

                        List<BEVehiculo> listavehiculos = new List<BEVehiculo>();

                        if (table2.Rows.Count > 0)
                        {
                            foreach (DataRow row2 in table2.Rows)
                            {
                                BEVehiculo vehiculo = new BEVehiculo();
                                vehiculo.Codigo = Convert.ToInt32(row2["id_Codigo"]);
                                vehiculo.Patente = row2["Patente"].ToString();
                                vehiculo.Marca = row2["Marca"].ToString();
                                vehiculo.Modelo = row2["Modelo"].ToString();
                                vehiculo.Año = Convert.ToInt32(row2["Año"]);
                                vehiculo.Kilometraje = Convert.ToInt32(row2["KilometrajeVendido"]);
                                vehiculo.Precio = Convert.ToDecimal(row2["PrecioVendido"]);
                                vehiculo.Estado = vehiculo.DeterminarEstadoDeAuto();

                                listavehiculos.Add(vehiculo);
                            }
                            cliente.vehiculosPropios = listavehiculos;
                        }

                        cliente.FechaNacimiento = Convert.ToDateTime(row["FecNac"]);
                        cliente.Edad = cliente.CalcularEdad();
                        cliente.Premium = true;

                        listaCliente.Add(cliente);
                    }
                    else
                    {
                        BEClienteNormal cliente = new BEClienteNormal();
                        cliente.Legajo = Convert.ToInt32(row["Legajo"]);
                        cliente.DNI = Convert.ToInt32(row["DNI"]);
                        cliente.Nombre = row["Nombre"].ToString();
                        cliente.Apellido = row["Apellido"].ToString();
                        cliente.Telefono = Convert.ToInt32(row["Telefono"]);

                        BELocalidad localidad = new BELocalidad();
                        localidad.Codigo = Convert.ToInt32(row["CodLoc"]);
                        localidad.Direccion = row["Localidad"].ToString();

                        cliente.Direccion = localidad;

                        if (row["Activo"].ToString() == "True")
                        {
                            cliente.Activo = true;
                        }
                        else
                        {
                            cliente.Activo = false;
                        }
                        Acceso datos2 = new Acceso();
                        Hashtable hash2 = new Hashtable();

                        hash2.Add("@Legajo", cliente.Legajo);
                        DataTable table2 = datos2.LeerSP("s_Cliente_Listar_Vehiculos_Propios", hash2);

                        List<BEVehiculo> listavehiculos = new List<BEVehiculo>();

                        if (table2.Rows.Count > 0)
                        {
                            foreach (DataRow row2 in table2.Rows)
                            {
                                BEVehiculo vehiculo = new BEVehiculo();
                                vehiculo.Codigo = Convert.ToInt32(row2["id_Codigo"]);
                                vehiculo.Patente = row2["Patente"].ToString();
                                vehiculo.Marca = row2["Marca"].ToString();
                                vehiculo.Modelo = row2["Modelo"].ToString();
                                vehiculo.Año = Convert.ToInt32(row2["Año"]);
                                vehiculo.Kilometraje = Convert.ToInt32(row2["KilometrajeVendido"]);
                                vehiculo.Precio = Convert.ToDecimal(row2["PrecioVendido"]);
                                vehiculo.Estado = vehiculo.DeterminarEstadoDeAuto();

                                listavehiculos.Add(vehiculo);
                            }
                            cliente.vehiculosPropios = listavehiculos;
                        }

                        cliente.FechaNacimiento = Convert.ToDateTime(row["FecNac"]);
                        cliente.Edad = cliente.CalcularEdad();

                        listaCliente.Add(cliente);
                    }
                }
            }
            else
            {
                listaCliente = null;
            }
            return listaCliente;
        }
        public bool Guardar(BECliente cliente)
        {
            string Consulta_SQL = "s_Cliente_Crear";

            if (cliente.Legajo != 0)
            {
                hash.Add("@Legajo", cliente.Legajo);
                Consulta_SQL = "s_Cliente_Modificar";
            }

            hash.Add("@DNI", cliente.DNI);
            hash.Add("@Nombre", cliente.Nombre);
            hash.Add("@Apellido", cliente.Apellido);
            hash.Add("@Telefono", cliente.Telefono);
            hash.Add("@Localidad", cliente.Direccion.Codigo);
            hash.Add("@FecNac", cliente.FechaNacimiento);
            hash.Add("@Edad", cliente.CalcularEdad());
            if (cliente is BEClientePremium)
            {
                hash.Add("@Premium", "True");
            }
            else
            {
                hash.Add("@Premium", "False");
            }
            hash.Add("@Activo", "True");

            if (VerificoQueDNINoExista(cliente) == false)
            {
                return datos.EscribirSP(Consulta_SQL, hash);
            }
            else
            {
                return false;
            }
        }
        bool VerificoQueDNINoExista(BECliente cliente)
        {
            Hashtable hash2 = new Hashtable();

            if (cliente.DNI == 0)
            {
                hash2.Add("@DNI", cliente.DNI);
                return datos.LeerScalarSP("s_Cliente_Existe_DNI", hash2);
            }
            else
            {
                return false;
            }
        }
        public bool BajaCliente(BECliente cliente)
        {
            string consulta = "s_Cliente_Baja";
            hash.Add("@Legajo", cliente.Legajo);
            return datos.EscribirSP(consulta, hash);
        }
        #endregion
    }
}
