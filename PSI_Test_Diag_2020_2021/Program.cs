using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Ano bissexto
/// </summary>
namespace PSI_Test_Diag_2020_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            int ano;

            Console.Write("Indique o ano:");
            ano = Convert.ToInt32(Console.ReadLine());
            string mensagem = ano_bissexto(ano) == 1 ?
                   String.Format("O ano {0} é bissexto", ano) :
                   String.Format("O ano {0} não é bissexto", ano);
            Console.WriteLine(mensagem);
            Console.WriteLine("Falta {0} dias para o fim do mês",
                fim_do_mes(DateTime.Now.Day,
                            DateTime.Now.Month,
                            DateTime.Now.Year));

            Console.ReadKey();
        }
        public static int ano_bissexto(int ano)
        {
            if (ano % 400 == 0) return 1;
            if (ano % 100 != 0 && ano % 4 == 0) return 1;
            return 0;
        }
        public static int fim_do_mes(int d,int m,int a)
        {
            if (m == 1 || m == 3 || m == 5 || m == 7 || m == 8 || m == 10 || m == 12)
                return 31 - d;
            if (m == 4 || m == 6 || m == 9 || m == 11)
                return 30 - d;
            if (ano_bissexto(a) == 1)
                return 29 - d;
            
            return 28 - d;
        }
    }
}
