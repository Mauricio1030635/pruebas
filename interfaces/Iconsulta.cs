using Ejercicio.dto;
using System.Collections.Generic;

namespace Ejercicio.interfaces
{
    public interface Iconsulta
    {
        List<vehiculosVendedor_ResultDTO> Consultar(long cedula);
    }
}