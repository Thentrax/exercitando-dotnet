using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _14__ProjetoMVC.Models
{
    public class Contato
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Numero { get; set; }
        public bool Status { get; set; }
    }
}