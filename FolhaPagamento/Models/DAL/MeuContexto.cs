using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DAL
{
    public class MeuContexto : DbContext
    {
        public MeuContexto() : base("strConn")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<MeuContexto>());

        }

        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Cargo> Cargos { get; set; }
        public DbSet<Empregado> Empregados { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Salario> Salarios { get; set; }
    }
}
