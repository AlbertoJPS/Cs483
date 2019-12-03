using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs483.Dados
{
    public class Produto : Base
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Marca { get; set; }
        public string Fabricante { get; set; }
        public int Valor { get; set; }
        
    }
}
