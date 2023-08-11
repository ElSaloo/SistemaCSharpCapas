using Acceso_DAL;
using Entidades_BE;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapear_MPP
{
    public class MPPLogin
    {
        Acceso datos;

        #region Stored Procedure
        public bool GuardarSP(BELogin login)
        {
            string consulta = "s_Login_Crear"; 
            Hashtable hash = new Hashtable();

            hash.Add("@username", login.Username);
            hash.Add("@password", login.Password);

            datos = new Acceso();
            return datos.EscribirSP(consulta,hash);
        }
        public bool Log_inSP(BELogin login)
        {
            if (Existe_UserPasswordSP(login) == false)
            {
                return true;
            }
            else
                return false;
        }
        public bool Existe_UserPasswordSP(BELogin login)
        {
            Hashtable hash2 = new Hashtable();
            hash2.Add("@usuario", login.Username);
            hash2.Add("@contraseña", login.Password);

            datos = new Acceso();
            return datos.LeerScalarSP("s_Login_Verifico_Existencia", hash2);
        }
        #endregion
    }
}
