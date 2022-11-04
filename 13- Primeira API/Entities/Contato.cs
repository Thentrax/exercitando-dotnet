using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _13__Primeira_API.Entities

{
    public class Contato //Modelo de entidade que será levado para o banco de dados
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public bool Status { get; set; }
    }
}