using CrudNetCore5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrudNetCore5.Dato
{
    public class VehiculoAdmin
    {

        // Consulta todo los vehiculos
        // return datos de los vehiculos
        public IEnumerable<vehiculo> Consultar()
        {
            using (RepasodbEntities contexto= new RepasodbEntities())
            {
                return contexto.vehiculo.AsNoTracking().ToList();
            }
        }

        //Guarda un vehiculo en la base de datos
        public void Guardar(vehiculo modelo)
        {
            using(RepasodbEntities contexto = new RepasodbEntities())
            {
                contexto.vehiculo.Add(modelo);
                contexto.SaveChanges();
            }
        }

        //Consulta
        public vehiculo Consultar(int id)
        {
            using (RepasodbEntities contexto = new RepasodbEntities())
            {
                return contexto.vehiculo.FirstOrDefault(v => v.Id == id);
            }
        }

        //Modifica los datos del vehiculo
        public void Modificar(vehiculo modelo)
        {
            using (RepasodbEntities contexto = new RepasodbEntities())
            {
                contexto.Entry(modelo).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }

        //Eliminar un vehiculo
        public void Eliminar(vehiculo modelo)
        {
            using(RepasodbEntities contexto = new RepasodbEntities())
            {
                contexto.Entry(modelo).State = System.Data.Entity.EntityState.Deleted;
                contexto.SaveChanges();
            }
        }


    }
}