using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parque
{
    class Mercadoria : Veiculo
    {
        public int PesoMax;
        public string TipoCarga;

        public Mercadoria(DateTime entrada, string matricula, 
            string marca, string modelo,
            int pesoMax,string tipoCarga) 
            : base(entrada, matricula, marca, modelo)
        {
            PesoMax = pesoMax;
            TipoCarga = tipoCarga;
        }

        public override string ToString()
        {
            return base.ToString() + $" - {TipoCarga} - {PesoMax}";
        }
    }
}
