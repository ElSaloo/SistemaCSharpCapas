using Abstraccion;
using Entidades_BE;
using Mapear_MPP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio_BLL
{
    public class BLLFormaDePago : IGestionable<BEFormaDePago>
    {
        MPPFormaDePago mppformadepago;
        public BLLFormaDePago()
        {
            mppformadepago = new MPPFormaDePago();
        }
        public bool Baja(BEFormaDePago objeto)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(BEFormaDePago objeto)
        {
            throw new NotImplementedException();
        }

        public List<BEFormaDePago> ListarTodo()
        {
            return mppformadepago.ListarTodosSP();
        }
    }
}
