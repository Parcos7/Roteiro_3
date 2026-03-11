using System;

public class Item
{
    public string NomeProduto { get; set; }
    public double Preco { get; set; }

    public Item(string nome, double preco)
    {
        NomeProduto = nome;
        Preco = preco;
    }
}

public class Pedido
{
    public int NumeroPedido { get; set; }
    
    public Item ItemDoPedido { get; set; }

    public void ExibirResumo()
    {
        Console.WriteLine($"Pedido nº: {NumeroPedido}");
        Console.WriteLine($"Item: {ItemDoPedido.NomeProduto} - Valor: R$ {ItemDoPedido.Preco}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Item meuItem = new Item("Teclado Mecânico", 250.00);

        Pedido novoPedido = new Pedido();
        novoPedido.NumeroPedido = 101;
        novoPedido.ItemDoPedido = meuItem;

        novoPedido.ExibirResumo();
    }
}
