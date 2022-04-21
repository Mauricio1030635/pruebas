using Ejercicio.dto;
using Ejercicio.interfaces;
using Ejercicio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ejercicio.repositorios
{
    public class marcaRepositorio : Imarca
    {

     

        public string Agregar(marcaDTO mar)
        {
            try {
                using (pruebasEntities _con = new pruebasEntities())
                {
                    marca nueva = new marca();
                    nueva.descripcion = mar.Descripcion;
                    _con.marca.Add(nueva);                    
                    _con.SaveChanges();
                }
                return "La marca se ha guardado satisfactoriamenete";
            }
            catch (Exception ex) {
                return $"Error en tiempo de ejecucion {ex}";
            }
        }

        public List<marcaDTO> Consultar()
        {
            try
            {
                using (pruebasEntities _con = new pruebasEntities()) { 
            List<marcaDTO> marcas = _con.marca.Select(x=> new marcaDTO() { 
                Identificador=x.id_marca,
                Descripcion=x.descripcion
            }).ToList();
            
            return marcas;
            
            
            }
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nMessage ---\n{0}", ex.Message);
                return new List<marcaDTO>();    
            }
        }

        public void Eliminar(int marca)
        {
            throw new NotImplementedException();
        }

        public string Modificar(marcaDTO marca)
        {
            throw new NotImplementedException();
        }
    }
}