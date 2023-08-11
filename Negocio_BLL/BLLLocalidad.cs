using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraccion;
using Entidades_BE;
using Mapear_MPP;

namespace Negocio_BLL
{
    public class BLLLocalidad : IGestionable<BELocalidad>
    {
        MPPLocalidad MPPlocalidad;
        public BLLLocalidad()
        {
            MPPlocalidad = new MPPLocalidad();
        }

        public List<BELocalidad> ListarTodo()
        {
            return MPPlocalidad.CargoListaLocalidadesSP();
        }

        public bool Guardar(BELocalidad localidad)
        {
            return MPPlocalidad.GuardarSP(localidad);
        }

        public bool Baja(BELocalidad objeto)
        {
            return MPPlocalidad.BajaLocalidadSP(objeto);
        }
    }
}
