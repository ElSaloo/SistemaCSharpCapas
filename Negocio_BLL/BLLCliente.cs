using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mapear_MPP;
using Entidades_BE;
using Abstraccion;


namespace Negocio_BLL
{
    public abstract class BLLCliente
    {
        MPPCliente MPPcliente;

        public BLLCliente()
        {
            MPPcliente = new MPPCliente();
        }

        #region Metodo Polimorfico
        public abstract decimal PrecioAPagar(BEVehiculo vehiculo);
        #endregion
  
        public bool Guardar(BECliente cliente)
        {
            return MPPcliente.Guardar(cliente);
        }

        public bool Baja(BECliente objeto)
        {
            return MPPcliente.BajaCliente(objeto);
        }

        public List<BECliente> ListarTodo()
        {
            return MPPcliente.CargoClientesSP();
        }
    }
}
