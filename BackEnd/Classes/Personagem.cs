using System;

namespace Classes;

public class personagem
{
    public string Nome = "";
    public int energia;
    public void RecuperarEnergia(int pontos, string motivo)
    {
        energia = energia + pontos;
        Console.WriteLine($"{Nome} recuperou {pontos} pontos: {motivo}");
    }
}

