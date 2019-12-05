using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs483.Dados.Contexto
{
    public class DadosContexto : DbContext
    {
        public DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<ClasseTipo> ClasseTipos { get; set; }
        public DadosContexto() : base(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=P:\Backup ProWay\C#\Cs483\Cs483\Cs483.Dados\Banco\DadosDb.mdf;Integrated Security = True")
        {

        }
       

    }
}
