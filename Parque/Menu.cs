using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parque
{
    class Menu
    {
        GerirParque Parque = new GerirParque();

        //mostrar o menu
        void Mostrar()
        {
            Console.WriteLine("1.Entrar");
            Console.WriteLine("2.Sair");
            Console.WriteLine("3.Estado");
            Console.WriteLine("4.Procurar");
            Console.WriteLine("5.Listar");
            Console.WriteLine("6.Terminar");
        }
        //ler opcoes
        int LerOpcoes()
        {
            int op = 0;
            while(op<1 || op > 6)
            {
                int.TryParse(Console.ReadLine(), out op);
            }
            return op;
        }
        //executar a tarefa escolhida
        public void MainLoop()
        {
            int op = 0;
            do
            {
                Mostrar();
                op = LerOpcoes();
                switch (op)
                {
                    case 1:
                        Entrar();
                        break;
                    case 2:
                        Sair();
                        break;
                    case 3:
                        Estado();
                        break;
                    case 4: 
                        Procurar();
                        break;
                    case 5:
                        Listar();
                        break;
                }
            } while (op != 6);
        }

        private void Listar()
        {
            string lista = Parque.Listar();
            if (lista.Length > 0)
                Console.WriteLine(lista);
            else
                Console.WriteLine("Não foram encontrados dados");
        }

        private void Procurar()
        {
            Console.Write("Qual a marca a procurar:");
            string marca = Console.ReadLine();
            string lista = Parque.Listar(marca);
            if (lista.Length > 0)
                Console.WriteLine(lista);
            else
                Console.WriteLine("Não foram encontrados dados");
        }

        private void Estado()
        {
            Console.WriteLine(Parque.Estado());
        }

        private void Sair()
        {
            Console.Write("Matricula do veículo:");
            string matricula = Console.ReadLine();
            double minutos=Parque.Sair(matricula);
            if (minutos > 0)
                Console.WriteLine("O veículo esteve {0} minutos no parque", minutos);
            else
                Console.WriteLine("Não existe nenhum veículo com essa matrícula");

        }

        private void Entrar()
        {
            Console.Write("Marca:");
            string marca = Console.ReadLine();
            Console.Write("Modelo:");
            string modelo = Console.ReadLine();
            Console.Write("Matricula:");
            string matricula = Console.ReadLine();
            Console.Write("Tipo de veículo (L/M/P):");
            string tipo = Console.ReadLine();
            Veiculo novo = null;
            if (tipo.ToUpper() == "L")
                novo = new Veiculo(DateTime.Now, matricula, marca, modelo);
            if (tipo.ToUpper() == "M")
            {
                Console.Write("Peso Max:");
                int pesoMax = Convert.ToInt32(Console.ReadLine());
                Console.Write("Tipo de mercadoria:");
                string tipoMercadoria = Console.ReadLine();
                novo = new Mercadoria(DateTime.Now, matricula, marca, modelo
                    , pesoMax, tipoMercadoria);
            }
            if (tipo.ToUpper() == "P")
            {
                Console.Write("Lotação:");
                int lotacao = Convert.ToInt32(Console.ReadLine());
                Console.Write("Nr de ocupantes:");
                int nrOcupas = Convert.ToInt32(Console.ReadLine());
                novo = new Passageiro(DateTime.Now, matricula, marca, modelo
                    , lotacao, nrOcupas);
            }
            Parque.Entrar(novo);
        }
    }
}
