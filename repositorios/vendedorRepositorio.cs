using Ejercicio.dto;
using Ejercicio.interfaces;
using Ejercicio.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Ejercicio.repositorios
{
    public class vendedorRepositorio : Ivendedor
    {
        public vendedorDTO buscar(int id)
        {
            try
            {
                using (pruebasEntities _con = new pruebasEntities())
                {
                    vendedorDTO vendedor = _con.vendedor.Where(x => x.id_vendedor == id)
                        .Select(x=> new vendedorDTO() {
                            ID = x.id_vendedor,
                            Cedula = x.cedula,
                            Nombre = x.nombre,
                            Apellido = x.apellido,
                            Edad = x.edad,
                            Telefono = x.telefono
                        }).FirstOrDefault();
                    
                    return vendedor;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nMessage ---\n{0}", ex.Message);
                return new vendedorDTO();
            }
        }

       public List<vendedorDTO> Consultar()
        {
            try
            {
                using (pruebasEntities _con = new pruebasEntities())
                {
                    List<vendedorDTO> vendedor = _con.vendedor.
                        Select(x => new vendedorDTO()
                    {
                        ID = x.id_vendedor,
                        Cedula = x.cedula,
                        Nombre = x.nombre,
                        Apellido = x.apellido,
                        Edad = x.edad,
                        Telefono = x.telefono
                    }).ToList();

                    return vendedor;


                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nMessage ---\n{0}", ex.Message);
                return new List<vendedorDTO>();
            }
        }

        public string Modificar(vendedorDTO vendedor)
        {
            try
            {
                using (pruebasEntities _con = new pruebasEntities())
                {
                    vendedor vend= _con.vendedor.FirstOrDefault(a => a.id_vendedor == vendedor.ID);
                    vend.cedula = vendedor.Cedula;
                    vend.nombre = vendedor.Nombre;
                    vend.apellido = vendedor.Apellido;
                    vend.edad = vendedor.Edad;
                    vend.telefono = vendedor.Telefono;                                                                                            
                    //_con.Entry(vend).State = EntityState.Modified;
                    _con.SaveChanges();                    

                    
                }
                return "El vendedor se ha actualizado satisfactoriamenete";
            }
            catch (Exception ex)
            {
                return $"Error en tiempo de ejecucion {ex}";
            }
        }
    }
}