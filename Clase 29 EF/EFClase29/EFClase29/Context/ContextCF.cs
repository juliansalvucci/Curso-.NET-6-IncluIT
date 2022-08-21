using EFClase29.Modelo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFClase29.Context
{
    public class ContextCF: DbContext
    {
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Deposito> Depositos { get; set; }
        public DbSet<Sucursal> Sucursals { get; set; }

        //DOMICILIO NO SE IMPLEMENTA EN EL CONTEXTO.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Conexión con bd utilizando string de conexión.
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-TKIL3L6\\SQLEXPRESS;Initial Catalog=testClase29; Integrated Security=True");

            base.OnConfiguring(optionsBuilder);
        }
    }
}
