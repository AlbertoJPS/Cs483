using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs483.Dados
{
    public class Pessoa : Base
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public byte Idade { get; set; }
    }
}
