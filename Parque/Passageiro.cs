using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parque
{
    class Passageiro : Veiculo
    {
        public int LotacaoMax;
        public int NrOcupantes;

        public Passageiro(DateTime entrada, string matricula, 
            string marca, string modelo,
            int lotacaoMax,int nrOcupantes) 
            : base(entrada, matricula, marca, modelo)
        {
            LotacaoMax = lotacaoMax;
            NrOcupantes = nrOcupantes;
        }

        public override string ToString()
        {
            return base.ToString() + $" - {NrOcupantes}/{LotacaoMax}"; 
        }
    }
}
