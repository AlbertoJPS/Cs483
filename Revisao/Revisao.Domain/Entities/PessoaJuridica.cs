using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Domain.Entities
{
    public class PessoaJuridica : Pessoa
    {
        public string CNPJ { get; set; }
        public string NomeFantasia { get; set; }
    }
}

