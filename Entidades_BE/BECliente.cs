using Abstraccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_BE
{
    public abstract class BECliente
    {
        #region Propiedades
        public int Legajo { get; set; }
        public int DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Telefono { get; set; }
        public BELocalidad Direccion { get; set; } // 1 a 1
        public List<BEVehiculo> vehiculosPropios { get; set; } // 1 a M
        public DateTime FechaNacimiento { get; set; }
        public int Edad { get; set; }
        public bool Activo { get; set; }
        #endregion

        public override string ToString()
        {
            return Legajo + " | " + DNI + " " + Nombre + " " + Apellido;
        }

        #region metodo dentro de mi clase Cliente
        public int CalcularEdad()
        {
            Edad = DateTime.Now.Year - FechaNacimiento.Year;
            if (DateTime.Now.Month < FechaNacimiento.Month)
                Edad -= 1;
            if (DateTime.Now.Month == FechaNacimiento.Month && DateTime.Now.Day < FechaNacimiento.Day)
                Edad -= 1;

            return Edad;
        }
        #endregion
    }
}
