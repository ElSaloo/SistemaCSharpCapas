using Entidades_BE;
using Mapear_MPP;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio_BLL
{
    public class BLLInformes
    {
        MPPInformes MPPinformes;

        public BLLInformes()
        {
            MPPinformes = new MPPInformes();
        }

        public int TotalAdquirido()
        {
            return MPPinformes.TotalAdquiridoSP();
        }
        public int TotalVendido()
        {
            return MPPinformes.TotalVendidoSP();
        }
        public decimal PrecioMasAlto()
        {
            return MPPinformes.PrecioMasAltoSP();
        }
        public List<BEVehiculo> ListarDisponible()
        {
            return MPPinformes.ListarDisponibleSP();
        }
        public List<BEVehiculo> ListarPorMarcaVendido(string marca) 
        {
            return MPPinformes.ListarPorMarcaVendidoSP(marca);
        }
        public List<BEVehiculo> ListarTodosVendido()
        {
            return MPPinformes.ListarTodosVendidoSP();
        }
        public decimal ValorEmpresaTotal()
        {
            return MPPinformes.ValorEmpresaTotalSP();
        }
    }
}
