using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ejercicio.dto
{
    public class vehiculoDTO
    {
        public int id_vehículo { get; set; }
        public Nullable<int> id_marca { get; set; }
        public string matricula { get; set; }
        public string color { get; set; }
        public double precioUnitario { get; set; }

    }
}