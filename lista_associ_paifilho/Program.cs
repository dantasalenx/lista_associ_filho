using System;
using System.Collections.Generic;
using System.Linq;

namespace lista_associ_paifilho
{
    class Program
    {
        static void Main(string[] args)
        {
            Pai pai = new Pai();

            List<Filho> listaFilho = new List<Filho>();

            Console.WriteLine("Digite o nome o pai: ");
            pai.Nome = Console.ReadLine();
            Console.WriteLine("Digite a idade do pai: ");
            pai.Idade = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Digite quantos filho o {0} tem: ", pai.Nome);
            int qtd = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= qtd; i++)
            {
                Console.WriteLine("Digite o nome do filho Num. - {0}: ", i);
                Filho filho = new Filho();
                filho.Nome = Console.ReadLine();
                pai.listaFilho.Add(filho);
            }

            Console.WriteLine(pai.Nome + " - " + pai.Idade);
            foreach (var e in pai.listaFilho)
            {
                Console.WriteLine(e.Nome);
            }
        }
    }
}