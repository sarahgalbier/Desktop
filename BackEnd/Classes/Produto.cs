using System;

namespace Classes;

public class Produto
{

    // Atributos
public string Nome = "";

public double Preço ;

public int Quantidade ; 

public string Descriçao = "";


   // Método/Funçao. Executa uma
   //açao
public void ExibirInformaçoes()
    {
        
        Console.Write($"Produto: {Nome}");
        Console.Write($"Preço: {Preço: F2}");
        Console.Write($"Quantidade: {Quantidade}");
        Console.Write($"Descriçao: {Descriçao}");
    }

public double CalcularTotal()
    {
        return Preço * Quantidade; 

    }
    // funçao com Parametro, espero receber o nome do usuario

public void ExibirMensagem(string nome)
    {
        Console.WriteLine($"Olá, {Nome}");
    }
}





