using Acceso_DAL;
using Entidades_BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapear_MPP
{
    public class MPPFormaDePago
    {
        Acceso datos;
        public MPPFormaDePago()
        {
            datos = new Acceso();
        }
        public List<BEFormaDePago> ListarTodosSP()
        {
            List<BEFormaDePago> listaformas = new List<BEFormaDePago>();
            DataTable tabla = datos.LeerSP("s_Formas_ListarTodo", null);

            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow row in tabla.Rows)
                {
                    BEFormaDePago forma = new BEFormaDePago();
                    forma.Codigo = Convert.ToInt32(row["Codigo"]);
                    forma.Forma = row["Forma"].ToString();
                    listaformas.Add(forma);
                }
            }
            else
            {
                listaformas = null;
            }
            return listaformas;
        }
    }
}
