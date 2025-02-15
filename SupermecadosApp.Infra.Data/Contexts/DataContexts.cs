using Microsoft.EntityFrameworkCore;
using SupermecadosApp.Infra.Data.Mappings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermecadosApp.Infra.Data.Contexts
{
    /// <summary>
    /// Classe de contexto para conexão com banco de dados e para configuração do Entity Framework
    /// </summary>
    public class DataContexts : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BDSupermecados;Integrated Security=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProdutoMap());
            modelBuilder.ApplyConfiguration(new CategoriaMap());    
        }
    }
}
