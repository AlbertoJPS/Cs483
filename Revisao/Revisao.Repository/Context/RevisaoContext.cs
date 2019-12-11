using Revisao.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Repository.Context
{
    public class RevisaoContext : DbContext
    {
        public DbSet<PessoaFisica> PessoaFisica { get; set; }
        public DbSet<PessoaJuridica> PessoaJuridica { get; set; }

        public RevisaoContext() : base(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=P:\Backup ProWay\C#\Cs483\Revisao\Revisao.Repository\DataBase\DatabaseRevisao.mdf;Integrated Security=True")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

        public System.Data.Entity.DbSet<Revisao.Domain.Entities.Pessoa> Pessoas { get; set; }
    }
}
