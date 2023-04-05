using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class ConstrutorPadrao
    {
        public class Veiculo
        {
            public string Modelo { get; set; }
            public string Cor { get; set; }
            public int QtdPortas { get; set; }
            public int QtdRodas { get; set; }
            public bool TemTetosolar { get; set; }

            public Veiculo(String modelo, 
                String cor, 
                int qtdPortas, 
                int qtdRodas, 
                bool temTetosolar)
            {
                this.Modelo = modelo;
                this.Cor = cor;
                this.QtdPortas = qtdPortas;
                this.QtdRodas = qtdRodas;
                this.TemTetosolar = temTetosolar;
            }



        }
        static void Main(string[] args)
        {
            Veiculo veiculo = new Veiculo("Sedan",
                "Amarelo",
                4, 
                4, 
                true);

            Console.WriteLine("Modelo: " + veiculo.Modelo);
            Console.WriteLine("Cor: " + veiculo.Cor);
            Console.WriteLine("Numero de portas: " + veiculo.QtdPortas);
            Console.WriteLine("Numero de rodas: " + veiculo.QtdRodas);
            Console.WriteLine("Tem teto solar: " + veiculo.TemTetosolar);
            Console.ReadLine();


        }
    }
}
