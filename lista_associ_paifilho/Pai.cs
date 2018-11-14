using System;
using System.Collections.Generic;

namespace lista_associ_paifilho
{
    public class Pai
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public List<Filho> listaFilho = new List<Filho>();


        public Pai()
        {
        }
    }
}
