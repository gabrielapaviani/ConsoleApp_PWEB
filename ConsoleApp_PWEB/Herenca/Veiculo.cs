using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Noite.Heranca
{
    public class Veiculo
    {
        public int numeroAssentos;
        public int numeroPortas;
        public bool temMotor;

        public string ExibirDados()
        {
            return "Tem motor: " + (temMotor ? "Sim" : "Não") +
                "\nNúmero portas: " + numeroPortas +
                "\nNúmero assentos: " + numeroAssentos + "\n";
        }
    }
}