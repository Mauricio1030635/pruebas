using Ejercicio.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio.interfaces
{
    public interface Ivendedor
    {
        vendedorDTO buscar(int id);
        string Modificar(vendedorDTO marca);        
        List<vendedorDTO> Consultar();
    }
}
