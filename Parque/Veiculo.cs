using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parque
{
    class Veiculo
    {
        public DateTime Entrada;
        public string Matricula;
        public string Marca;
        public string Modelo;

        public Veiculo(DateTime entrada, string matricula, 
            string marca, string modelo)
        {
            Entrada = entrada;
            Matricula = matricula;
            Marca = marca;
            Modelo = modelo;
        }

        public override string ToString()
        {
            return $"{Marca} - {Modelo} - {Matricula} - {Entrada}";
        }
    }
}
