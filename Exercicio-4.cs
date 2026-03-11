using System;

public interface IVoar
{
    void Voar();
}

public interface INadar
{
    void Nadar();
}

public class Pato : IVoar, INadar
{
    public void Voar()
    {
        Console.WriteLine("O Pato está voando sobre o lago.");
    }

    public void Nadar()
    {
        Console.WriteLine("O Pato está nadando no lago.");
    }
}

public class Aguia : IVoar
{
    public void Voar()
    {
        Console.WriteLine("A Águia está voando alto nas montanhas.");
    }
}

public class Peixe : INadar
{
    public void Nadar()
    {
        Console.WriteLine("O Peixe está nadando no oceano.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Pato meuPato = new Pato();
        Aguia minhaAguia = new Aguia();
        Peixe meuPeixe = new Peixe();

        meuPato.Voar();
        meuPato.Nadar();

        minhaAguia.Voar();

        meuPeixe.Nadar();
    }
}
