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
            public string Ano { get; set; }
            public int QtdPortas { get; set; }
            public int QtdRodas { get; set; }
            public bool TemTetosolar { get; set; }

            public Veiculo(String modelo, 
                String cor,
                String ano,
                int qtdPortas, 
                int qtdRodas, 
                bool temTetosolar)
            {
                this.Modelo = modelo;
                this.Cor = cor;
                this.Ano = ano;
                this.QtdPortas = qtdPortas;
                this.QtdRodas = qtdRodas;
                this.TemTetosolar = temTetosolar;
            }

            public void MostrarTodosAtributos()
            {
                Console.WriteLine("Modelo: " + this.Modelo);
                Console.WriteLine("Cor: " + this.Cor);
                Console.WriteLine("Ano: " + this.Ano);
                Console.WriteLine("Nº de portas: " + this.QtdPortas);
                Console.WriteLine("Nº de rodas: " + this.QtdRodas);
                Console.WriteLine("Tem teto solar: " + this.TemTetosolar);
                Console.ReadLine();
            }


        }
        static void Main(string[] args)
        {
            Veiculo veiculo = new Veiculo("Sedan",
                "Amarelo", 
                "2015", 
                4, 
                4, 
                true);

            veiculo.MostrarTodosAtributos();



        }
    }
}
