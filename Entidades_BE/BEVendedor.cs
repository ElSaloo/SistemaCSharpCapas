﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_BE
{
    public class BEVendedor : Entidad
    {
        public int DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public override string ToString()
        {
            return Codigo + " | " + DNI + " " + Nombre + " " + Apellido;
        }
    }
}
