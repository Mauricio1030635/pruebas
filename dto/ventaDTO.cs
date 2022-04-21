using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ejercicio.dto
{
    public class ventaDTO
    {
        public int id_venta { get; set; }
        public Nullable<int> id_vehículo { get; set; }
        public Nullable<int> id_vendedor { get; set; }
        public Nullable<System.DateTime> fecha_venta { get; set; }
        public double valorVenta { get; set; }
    }
}