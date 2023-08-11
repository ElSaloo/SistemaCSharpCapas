using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acceso_DAL;
using Entidades_BE;
using System.Data;
using System.Collections;
using System.Data.SqlClient;
using System.Security.Policy;

namespace Mapear_MPP
{
    public class MPPLocalidad
    {
        Acceso datos;
        Hashtable hdatos;
        public MPPLocalidad()
        {
            datos = new Acceso();
        }

        #region Store Procedure
        public List<BELocalidad> CargoListaLocalidadesSP()
        {
            List<BELocalidad> listalocalidad = new List<BELocalidad>();
            DataTable tabla = datos.LeerSP("s_Localidad_ListarTodo", null);

            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow row in tabla.Rows)
                {
                    BELocalidad localidad = new BELocalidad();
                    localidad.Codigo = Convert.ToInt32(row["id_Codigo"]);
                    localidad.Direccion = row["Nombre"].ToString();
                    listalocalidad.Add(localidad);
                }
            }
            else
            {
                listalocalidad = null;
            }
            return listalocalidad;
        }
        public bool GuardarSP(BELocalidad localidad)
        {
            string Consulta_SQL = "s_Localidad_Crear";

            if (localidad.Codigo != 0)
            {
                hdatos.Add("@Codigo", localidad.Codigo);
                Consulta_SQL = "s_Localidad_Modificar";
            }
            hdatos.Add("@Nombre", localidad.Direccion);
            return datos.EscribirSP(Consulta_SQL, hdatos);
        }
        public bool BajaLocalidadSP(BELocalidad localidad)
        {
            if (Existe_Localidades_AsociadasSP(localidad) == false)
            {              
                return datos.EscribirSP("s_Localidad_Baja", hdatos);
            }
            else
                return false;
        }

        public bool Existe_Localidades_AsociadasSP(BELocalidad localidad)
        {
            hdatos = new Hashtable();
            hdatos.Add("@Codigo", localidad.Codigo);

            return datos.LeerScalarSP("s_Localidad_Asociada", hdatos);
        }
        #endregion

    }
}
