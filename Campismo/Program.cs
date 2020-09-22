using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campismo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] lotes = new bool[20];

            for (int i = 0; i < lotes.Length; i++)
            {
                lotes[i] = false;
            }

            int espacoLivres = lotes.Length;
            while (true)
            {
                Console.Write("Qual o espaço a ocupar?");
                int novoEspaco = Convert.ToInt32(Console.ReadLine());
                if(novoEspaco<1 || novoEspaco > lotes.Length)
                {
                    Console.WriteLine("Espaço não é válido");
                    continue;
                }
                if (lotes[novoEspaco - 1] == true)
                {
                    Console.WriteLine("Espaço ocupado");
                    continue;
                }
                lotes[novoEspaco - 1] = true;
                espacoLivres--;
                Console.WriteLine("Tem {0} espaços livres" +
                    " e {1} espaços ocupados", espacoLivres,
                    lotes.Length - espacoLivres);
                if (espacoLivres == 0)
                    break;
            }
            Console.WriteLine("O parque está cheio");
            Console.ReadKey();
        }
    }
}
