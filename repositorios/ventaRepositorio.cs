using Ejercicio.dto;
using Ejercicio.interfaces;
using Ejercicio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ejercicio.repositorios
{
    public class ventaRepositorio : Iventa
    {
        public List<ventasDTO> Consultar()
        {
            try
            {
                using (pruebasEntities _con = new pruebasEntities())
                {
                    List<ventasDTO> ventas = _con.ventas.
                        Select(x => new ventasDTO()
                        {
                            ID = x.ID,
                            Cedula = x.cedula,
                            Nombre = x.Nombre_vendedor,
                            Apellido = x.Apellido_vendedor,
                            Matricula = x.Matricula,
                            Marca = x.Marca,
                            Color =x.Color_Auto,
                            Precio =x.Valor_Unitario,
                            Total =x.Valor_Total,
                            Fecha =x.Fecha_venta
                        }).ToList();

                    return ventas;


                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nMessage ---\n{0}", ex.Message);
                return new List<ventasDTO>();
            }
        }

        public void Eliminar(int venta)
        {

            try
            {
                using (pruebasEntities _con = new pruebasEntities())
                {
                    venta vt = _con.venta.FirstOrDefault(a => a.id_venta == venta);
                    _con.venta.Remove(vt);
                    _con.SaveChanges();
                }
            }
            catch (Exception ex) { 
            
            }
        }
        }
}