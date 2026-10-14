using Classes;
  // Criando um Obejto 
  //Chamando a minha Classe Produto 
  Produto produto = new Produto();

  produto.Nome = "Iphone 17 pro";
  produto.Preço = 10000;
  produto.Descriçao = "Melhor camera do mundo";
  produto.Quantidade = 50;

    // Chamando a funçao que exibe informaçoes, mas com dados 
    // que acabamos de atrelar a esse objeto(produto)
produto.ExibirInformaçoes();

double total = produto.CalcularTotal();
Console.WriteLine($"total em esqoque{total:F2}");

produto.ExibirMensagem("SARAH GALBIER");

personagem personagem = new personagem ();
personagem.Nome = "Miranda";
personagem.energia = 40;

personagem.RecuperarEnergia(20, "Descansou");
Console.WriteLine("$Energia: {personagem.Energia}");

personagem.RecuperarEnergia(30, "Alimento");
Console.WriteLine("$Energia: {personagem.Energia}");
