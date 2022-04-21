using Ejercicio.dto;
using Ejercicio.interfaces;
using Ejercicio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ejercicio.repositorios
{
    public class consultaRepositorio : Iconsulta
    {
        public List<vehiculosVendedor_ResultDTO> Consultar(long cedula)
        {
            try
            {
                List<vehiculosVendedor_ResultDTO> vehiculo = new List<vehiculosVendedor_ResultDTO>();
                using (pruebasEntities _con = new pruebasEntities())
                {
                    List<vehiculosVendedor_ResultDTO> valor = _con.vehiculosVendedor(cedula).Select(x => new vehiculosVendedor_ResultDTO
                   ()
                    {
                        Marca = x.Marca,
                        Color =x.Color_Auto,
                        Matricula = x.Matricula

                    }).ToList();                    

                    return valor;
                }

            }
            catch (Exception ex)
            {
                return  new List<vehiculosVendedor_ResultDTO>();

            }
        }
    }
}