using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ejercicio.dto
{
    public class vendedorDTO
    {
        public int ID { get; set; }
        public long Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public byte Edad { get; set; }
        public string Telefono { get; set; }

    }
}