using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Tarde.Heranca
{
    public class Veiculo
    {
        public string cor;
        public int quantidadeRodas;
        public int quantidadeAssentos;
        public bool temMotor;

        public string ExibirDados()
        {
            if (temMotor)
            {
                return "Tem motor" + cor + " " + quantidadeAssentos + " " + quantidadeRodas;
            }
            else
            {
                return cor + " " + quantidadeAssentos + " " + quantidadeRodas;
            }
        } 
    }
}
