using Ejercicio.dto;
using Ejercicio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ejercicio.interfaces
{
    public interface Iventa
    {
        void Eliminar(int venta);
        List<ventasDTO> Consultar();
    }
}