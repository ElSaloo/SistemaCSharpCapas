using Entidades_BE;
using Mapear_MPP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio_BLL
{
    public class BLLLogin
    {
        MPPLogin MPPlogin;

        public BLLLogin()
        {
            MPPlogin = new MPPLogin();
        }
        public bool Log_in(BELogin objeto)
        {
            return MPPlogin.Log_inSP(objeto);
        }

        public bool Guardar(BELogin objeto)
        {
            return MPPlogin.GuardarSP(objeto);
        }
    }
}
