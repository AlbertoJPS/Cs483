using System;
using System.Collections.Generic;
using System.Text;

namespace Revisao.CoreDomain.Entities
{
    public class Produto : Base
    {
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public TipoProduto TipoProduto { get; set; }
    }
}
