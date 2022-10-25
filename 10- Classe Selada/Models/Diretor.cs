using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _10__Classe_Selada.Models
{
    public class Diretor : Professor
    {
        public override void Apresentar() //com o método selado, classes filhas não podem herdar esse método
        {

        }
    }
}