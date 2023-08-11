using Abstraccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_BE
{
    public class BELocalidad : Entidad
    {
        public string Direccion { get; set; }

        public override string ToString()
        {
            return Codigo + " " + Direccion;
        }
    }
}
