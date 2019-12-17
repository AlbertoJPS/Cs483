using Microsoft.EntityFrameworkCore;
using System;
using Revisao.CoreDomain.Entities;
using System.Collections.Generic;
using System.Text;

namespace Revisao.CoreData.Context
{
    public class CoreContext : DbContext
    {
        public DbSet<Produto> Produto { get; set; }
        public DbSet<TipoProduto> TipoProduto { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=P:\Backup ProWay\C#\Cs483\Revisao\Revisao.CoreData\Db\CoreDb.mdf;Integrated Security=True");
        }

        //no Framework
        //public DbSet<Produto> Produto { get; set; }
        //public DbSet<TipoProduto> TipoProduto { get; set; }

        //public RevisaoContext() : base(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=P:\Backup ProWay\C#\Cs483\Revisao\Revisao.CoreData\Db\CoreDb.mdf;Integrated Security=True")
        //{

        //}
    }
}
