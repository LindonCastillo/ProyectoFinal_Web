using Microsoft.EntityFrameworkCore;
using ProyectoFinal_Web.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinal_Web.Data
{
    public class Contexto : DbContext
    {
        public DbSet<Productos> Productos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server = .\SqlExpress; Database= PFTest_Db; Trusted_Connection = True; ");
        }
    }
}
