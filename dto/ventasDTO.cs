using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ejercicio.dto
{
    public class ventasDTO
    {

        public int ID { get; set; }
        public long Cedula { get; set; }
        public string Nombre{ get; set; }
        public string Apellido{ get; set; }
        public string Matricula { get; set; }
        public string Marca { get; set; }
        public string Color { get; set; }
        public double Precio{ get; set; }
        public double Total { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        
    }
}