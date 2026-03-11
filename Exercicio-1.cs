using System;

public class Animal
{
    public string Nome { get; set; }

    public virtual void EmitirSom()
    {
        Console.WriteLine("Som genérico do animal");
    }
}

public class Cachorro : Animal
{
    public override void EmitirSom()
    {
        Console.WriteLine("Au au au!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal meuAnimal = new Animal();
        meuAnimal.Nome = "Bicho Estranho";
        Console.WriteLine($"Animal: {meuAnimal.Nome}");
        meuAnimal.EmitirSom(); 

        Cachorro meuCachorro = new Cachorro();
        meuCachorro.Nome = "Rex";
        Console.WriteLine($"Cachorro: {meuCachorro.Nome}");
        meuCachorro.EmitirSom(); 

    }
}
