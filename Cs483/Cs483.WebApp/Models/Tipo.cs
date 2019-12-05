using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Cs483.WebApp.Models
{
    public class Tipo
    {
        public int id { get; set; }
        public string Nome { get; set; }
        
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }


    }

}