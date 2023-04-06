using System;

// Classe a ser instanciada
public class Veiculo
{
    public string Modelo { get; set; }
    public string Cor { get; set; }
    public string Ano { get; set; }
    public int QtdPortas { get; set; }
    public int QtdRodas { get; set; }
    public bool TemTetosolar { get; set; }

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


// Construtor abstrato do objeto
public abstract class VeiculoBuilder
{
    protected Veiculo veiculo;
    public void CriaVeiculo()
    {
        veiculo = new Veiculo();
    }
    public Veiculo GetVeiculo()
    {
        return veiculo;
    }
    public abstract void SetModelo();
    public abstract void SetCaracteristicas();

}

// Construtor concreto do objeto
class SedanBuilder : VeiculoBuilder
{
    public override void SetModelo()
    {
        this.veiculo.Modelo = "Sedan";
    }
    public override void SetCaracteristicas()
    {
        Console.WriteLine("Cor do veículo: ");
        String input = Console.ReadLine();
        this.veiculo.Cor = input;

        Console.WriteLine("Ano do veículo: ");
        input = Console.ReadLine();
        this.veiculo.Ano = input;

        this.veiculo.QtdPortas = 4;

        this.veiculo.QtdRodas = 4;

        Console.WriteLine("O carro terá teto solar? ");
        input = Console.ReadLine();
        if (input == "Sim")
            this.veiculo.TemTetosolar = true;
        else
            this.veiculo.TemTetosolar = false;

    }

}

// Construtor concreto do objeto
class BicicletaBuilder : VeiculoBuilder
{
    public override void SetModelo()
    {
        this.veiculo.Modelo = "Bicicleta";
    }

    public override void SetCaracteristicas()
    {
        Console.WriteLine("Cor do veículo: ");
        String input = Console.ReadLine();
        this.veiculo.Cor = input;

        this.veiculo.QtdRodas = 2;
    }
}



// Classe diretora
public class VeiculoBuildDirector
{
    private VeiculoBuilder builder;

    public VeiculoBuildDirector(VeiculoBuilder builder)
    {
        this.builder = builder;
    }

    public void ConstructVeiculo()
    {
        builder.CriaVeiculo();
        builder.SetModelo();
        builder.SetCaracteristicas();

    }
    public Veiculo GetVeiculo()
    {
        return builder.GetVeiculo();
    }
}



// Main
class Program
{
    static void Main(string[] args)
    {
        VeiculoBuilder builder = new SedanBuilder();
        VeiculoBuildDirector director = new VeiculoBuildDirector(builder);

        director.ConstructVeiculo();
        
        Veiculo veiculo = director.GetVeiculo();

        veiculo.MostrarTodosAtributos();


    }
}

