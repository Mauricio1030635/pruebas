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
    
    public partial class vehículo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public vehículo()
        {
            this.venta = new HashSet<venta>();
        }
    
        public int id_vehículo { get; set; }
        public Nullable<int> id_marca { get; set; }
        public string matricula { get; set; }
        public string color { get; set; }
        public double precioUnitario { get; set; }
    
        public virtual marca marca { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<venta> venta { get; set; }
    }
}
