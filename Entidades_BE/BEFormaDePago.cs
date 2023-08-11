using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_BE
{
    public class BEFormaDePago : Entidad
    {
        public string Forma { get; set; }

        public override string ToString()
        {
            return Codigo + " | " + Forma;
        }
    }
    
}
