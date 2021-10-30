using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Ejemplo_EntityFramework.Models
{
    public class Automovil
    {
        public int Id{ get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public int Año { get; set; }
        public double Precio { get; set; }
    }

    public class AutomovilDBContext : DbContext
    {
        public DbSet<Automovil> Automoviles { get; set; }
    }
}