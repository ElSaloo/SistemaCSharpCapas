using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraccion;
using Entidades_BE;
using Mapear_MPP;

namespace Negocio_BLL
{
    public class BLLVendedor : IGestionable<BEVendedor>
    {
        MPPVendedor mppvendedor;
        public BLLVendedor()
        {
            mppvendedor = new MPPVendedor();
        }

        public bool Baja(BEVendedor objeto)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(BEVendedor objeto)
        {
            throw new NotImplementedException();
        }

        public List<BEVendedor> ListarTodo()
        {
            return mppvendedor.ListarTodoSP();
        }
        public bool CrearPreventa(BEPreventa preventa)
        {
            return mppvendedor.CrearPreventa(preventa);
        }
    }
}
