namespace Classes;

public class pessoa
{
	public string Nome = "";
	public int Idade ;

	public pessoa(string nome, int idade)
	{
		Nome = nome;
		Idade = idade;
	}
	public void Apresentar()
	{
		Console.WriteLine($"Olá, sou {Nome} e tenho {Idade} anos");
	}
}
