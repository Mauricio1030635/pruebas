//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ejercicio.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class venta
    {
        public int id_venta { get; set; }
        public Nullable<int> id_vehículo { get; set; }
        public Nullable<int> id_vendedor { get; set; }
        public Nullable<System.DateTime> fecha_venta { get; set; }
        public double valorVenta { get; set; }
    
        public virtual vehículo vehículo { get; set; }
        public virtual vendedor vendedor { get; set; }
    }
}
