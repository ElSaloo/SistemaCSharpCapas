using Entidades_BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio_BLL
{
    public class BLLClienteNormal : BLLCliente
    {
        public override decimal PrecioAPagar(BEVehiculo vehiculo)
        {
            decimal total = vehiculo.Precio * 1.05m;
            return total;
        }
    }
}
