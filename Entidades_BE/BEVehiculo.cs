using Abstraccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_BE
{
    public class BEVehiculo : Entidad
    {
        #region Propiedades
        public string Patente { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Año { get; set; }
        public int Kilometraje { get; set; }
        public decimal Precio { get; set; }
        public string Estado { get; set; }
        #endregion

        #region Metodos
        public string DeterminarEstadoDeAuto()
        {
            if (Kilometraje <= 2)
            {
                Estado = "Nuevo 0 km";
            }
            else
            {
                Estado = "Usado";
            }
            return Estado;
        }
        public override string ToString()
        {
            return "Vehiculo\n Patente= " + Patente +
                           "\n Marca= " + Marca +
                           "\n Modelo= " + Modelo +
                           "\n Año= " + Año +
                           "\n Kilometraje= " + Kilometraje +
                           "\n Precio= " + Precio + "\r\n";
        }
        #endregion
    }
}
