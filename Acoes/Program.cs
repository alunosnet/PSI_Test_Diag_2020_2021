using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acoes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, pv, pc, acumulado=0;

            Console.Write("Quantas ações comprou?");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("Qual o preço de compra: ");
                pc = Convert.ToInt32(Console.ReadLine());
                Console.Write("Qual o preço de venda: ");
                pv = Convert.ToInt32(Console.ReadLine());
                acumulado += (pv - pc);
            }
            Console.WriteLine("Acumulado {0}", acumulado);
            Console.ReadKey();
        }
    }
}
