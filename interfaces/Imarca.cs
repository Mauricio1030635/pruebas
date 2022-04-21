using Ejercicio.dto;
using Ejercicio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio.interfaces
{
     public  interface Imarca
    {
        string Agregar(marcaDTO marca);
        string Modificar(marcaDTO marca);
        void Eliminar(int  marca);
        List<marcaDTO> Consultar();

    }
}
