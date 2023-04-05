using System;

// Classe a ser instanciada
class Veiculo
{
    public string Modelo { get; set; }
    public string Cor { get; set; }
    public int QtdPortas { get; set; }
    public int QtdRodas { get; set; }
    public bool TemTetosolar { get; set; }

}

// Interface do construtor
public interface IVeiculoBuilder
{
    void SetModelo(String modelo);
    void SetCor(String cor);
    void SetQtdPortas(int qtdPortas);
    void SetQtdRodas(int qtdRodas);
    void SetTetosolar();

}

// Construtor concreto do objeto
class VeiculoBuilder : IVeiculoBuilder
{
    private Veiculo veiculo = new Veiculo();
    public void SetModelo(String model)
    {
        this.veiculo.Modelo = model;
    }
    public void SetCor(String color)
    {
        this.veiculo.Cor = color;
    }
    public void SetQtdPortas(int qtdPortas)
    {
        this.veiculo.QtdPortas = qtdPortas;
    }
    public void SetQtdRodas(int QtdRodas)
    {
        this.veiculo.QtdRodas = QtdRodas;
    }
    public void SetTetosolar()
    {
        this.veiculo.TemTetosolar = true;
    }
    public Veiculo GetResult()
    {
        return this.veiculo;
    }
}

// Classe diretora
class VeiculoBuildDirector
{
    public void ConstructBicicleta(VeiculoBuilder builder)
    {
        builder.SetModelo("Bicicleta");

        builder.SetQtdRodas(4);

        Console.WriteLine("Cor da bicicleta? ");
        String input = Console.ReadLine();
        builder.SetCor(input);
    }

    public void ConstructSedan(VeiculoBuilder builder)
    {
        builder.SetModelo("Sedan");
        builder.SetQtdPortas(4);
        builder.SetQtdRodas(4);
        Console.WriteLine("Cor do carro? ");
        String input = Console.ReadLine();
        builder.SetCor(input);
        Console.WriteLine("O carro terá teto solar? ");
        input = Console.ReadLine();
        if (input == "Sim")
            builder.SetTetosolar();

    }
}

// Main
class Program
{
    static void Main(string[] args)
    {
        VeiculoBuilder builder = new VeiculoBuilder();
        VeiculoBuildDirector director = new VeiculoBuildDirector();

        director.ConstructBicicleta(builder);

        

        Veiculo veiculo = builder.GetResult();


        Console.WriteLine("Model: " + veiculo.Modelo);
        Console.WriteLine("Color: " + veiculo.Cor);
        Console.WriteLine("Number of doors: " + veiculo.QtdPortas);
        Console.ReadLine();

        builder = new VeiculoBuilder();

        director.ConstructSedan(builder);
        veiculo = builder.GetResult();

        Console.WriteLine("Model: " + veiculo.Modelo);
        Console.WriteLine("Color: " + veiculo.Cor);
        Console.WriteLine("Number of doors: " + veiculo.QtdPortas);
        Console.WriteLine("Has sunroof: " + veiculo.TemTetosolar);
        Console.ReadLine();


    }
}
