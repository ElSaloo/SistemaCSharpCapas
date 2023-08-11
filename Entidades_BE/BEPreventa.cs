using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_BE
{
    public class BEPreventa : Entidad
    {
        public BEVendedor Vendedor { get; set; }
        public BECliente Cliente { get; set; }
        public BEVehiculo Vehiculo { get; set; }
        public DateTime FechaCreacion { get; set; }
        public BEFormaDePago FormaDePago { get; set; }
        public decimal MontoTotal { get; set; }
        public bool Autorizado { get; set; }

        public BEPreventa(BEVendedor vendedor, BECliente cliente, BEVehiculo vehiculo, DateTime fechaCreada, BEFormaDePago forma, decimal montototal, bool autoriza)
        {
            Vendedor = vendedor;
            Cliente = cliente;
            Vehiculo = vehiculo;
            FechaCreacion = fechaCreada;
            FormaDePago = forma;
            MontoTotal = montototal;
            Autorizado = autoriza;
        }
    }
}
