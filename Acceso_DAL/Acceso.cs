using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Collections;

namespace Acceso_DAL
{
    public class Acceso
    {
        #region variable conexion a base de datos
        private SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["MyStringConection"].ToString());
        #endregion
        private SqlCommand comand;
        private SqlTransaction transaxion;
        string cadena = @"Data Source=DESKTOP-0M99BC2\MSSQLSERVER1;Initial Catalog = TP1integrador; Integrated Security = True";
      
        #region Store Procedure
        public DataTable LeerSP(string consulta, Hashtable Hdatos)
        {
            DataTable tabla = new DataTable();
            SqlDataAdapter DataAdapter;

            comand = new SqlCommand(consulta, conexion);
            comand.CommandType = CommandType.StoredProcedure;

            try
            {
                DataAdapter = new SqlDataAdapter(comand);

                if (Hdatos != null)
                {
                    foreach (string dato in Hdatos.Keys)
                    {
                        //Cargo parametros
                        comand.Parameters.AddWithValue(dato, Hdatos[dato]);
                    }
                }
            }
            catch (SqlException ex) {throw ex;}
            catch (Exception ex) {throw ex;}
            finally {conexion.Close();}

            DataAdapter.Fill(tabla);

            return tabla;
        }
        public bool LeerScalarSP(string consulta, Hashtable hdatos)
        {
            conexion.Open();

            SqlCommand comand = new SqlCommand(consulta, conexion);
            comand.CommandType = CommandType.StoredProcedure;

            try
            {
                if(hdatos != null)
                {
                    foreach (string dato in hdatos.Keys)
                    {
                        comand.Parameters.AddWithValue(dato, hdatos[dato]);
                    }
                }
                int respuesta = Convert.ToInt32(comand.ExecuteScalar());
                conexion.Close();

                if (respuesta > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (SqlException ex) {throw ex;}
            catch (Exception ex) {throw ex;}
        }
        public bool EscribirSP(string Consulta_SQL, Hashtable hdatos)
        {
            if(conexion.State == ConnectionState.Closed)
            {
                conexion.ConnectionString = cadena;
                conexion.Open();
            }
            try
            {
                transaxion = conexion.BeginTransaction();
                comand = new SqlCommand(Consulta_SQL, conexion, transaxion);
                comand.CommandType = CommandType.StoredProcedure;

                if ((hdatos != null))
                {
                    foreach (string dato in hdatos.Keys)
                    {
                        comand.Parameters.AddWithValue(dato, hdatos[dato]);
                    }
                }           
                int respuesta = comand.ExecuteNonQuery();

                transaxion.Commit();

                return true;
            }
            catch (SqlException ex) {transaxion.Rollback();throw ex;}
            catch (Exception ex) {transaxion.Rollback(); throw ex;}
            finally {conexion.Close();}
        }
        #endregion
    }
}
