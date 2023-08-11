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
    public class BLLVehiculo : IGestionable<BEVehiculo>
    {
        MPPVehiculo MPPvehiculo;
        public BLLVehiculo()
        {
            MPPvehiculo = new MPPVehiculo();
        }
        public bool Guardar(BEVehiculo vehiculo)
        {
            return MPPvehiculo.GuardarSP(vehiculo);
        }

        public bool Baja(BEVehiculo objeto)
        {
            return MPPvehiculo.BajaVehiculoSP(objeto);
        }

        public List<BEVehiculo> ListarTodo()
        {
            return MPPvehiculo.CargoVehiculosSP();
        }
        public bool TransferirClienteVehiculo(BECliente cliente, BEVehiculo vehiculo)
        {
            return MPPvehiculo.TransferirClienteVehiculoSP(cliente, vehiculo);
        }
        public bool DesasignarClienteVehiculo(BECliente cliente, BEVehiculo vehiculo)
        {
            return MPPvehiculo.DesasignarClienteVehiculoSP(cliente, vehiculo);
        }
    }
}
