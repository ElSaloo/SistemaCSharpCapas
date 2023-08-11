using Entidades_BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio_BLL
{
    public class BLLClientePremium : BLLCliente
    {
        public override decimal PrecioAPagar(BEVehiculo vehiculo)
        {
            decimal total = vehiculo.Precio * 0.93m;
            return total;
        }
    }
}
