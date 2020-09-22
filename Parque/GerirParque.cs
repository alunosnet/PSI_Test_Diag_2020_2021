using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parque
{
    class GerirParque
    {
        List<Veiculo> Lugares = new List<Veiculo>();
        const int LOTACAO_MAX = 300;

        ///Entrar
        public bool Entrar(Veiculo novo)
        {
            if (Lugares.Count == LOTACAO_MAX)
                return false;

            Lugares.Add(novo);
            return true;
        }
        //Sair
        public double Sair(string matricula)
        {
            Veiculo veiculaSair = null;
            //procurar a matricula na lista
            foreach(Veiculo v in Lugares)
            {
                if (v.Matricula == matricula)
                {
                    veiculaSair = v;
                    break;
                }
            }
            //matricula não encontrada
            if (veiculaSair == null)
                return -1;
            TimeSpan duracao = DateTime.Now - veiculaSair.Entrada;
            Lugares.Remove(veiculaSair);
            return duracao.TotalMinutes;
        }
        //Estado
        public string Estado()
        {
            return $@"Tem {GetLotacao()-GetLugaresOcupados()} lugares livres 
                e {GetLugaresOcupados()} lugares ocupados";
        }
        public int GetLotacao()
        {
            return LOTACAO_MAX;
        }
        public int GetLugaresOcupados()
        {
            return Lugares.Count;
        }
        //Procurar ou Listar
        public string Listar(string marca = null)
        {
            string lista = "";
            foreach(Veiculo v in Lugares)
            {
                //TODO: continuar aqui!!!!
            }
            return lista;
        }

    }
}
