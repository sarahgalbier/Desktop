// See https://aka.ms/new-console-template for more information
using System.Data;
using System.Security.AccessControl;

Console.WriteLine("Olá, Mundo!");
Console.WriteLine("Minha primeira aplicaçao com C#");

// Variásveis no C#
string nome = "Sarah"; // Usado para todos
int idade = 18; // Valores inteiros
double altura = 1.72; // Números com decimais e mais geral
decimal salario = 800; // Valores financeiros
bool matriculado = false; // Verdadeiro ou falso
char turma = 'A'; // Um caractere

// Exibindo as variáveis com interpolaçao com C#
Console.WriteLine($"Nome: {nome}");
Console.WriteLine($"idade: {idade}");
Console.WriteLine($"Sua altura é de: {altura}");
Console.WriteLine($"Seu nome é: {nome}, voce tem {idade} anos");

// Entrada de todos
Console.WriteLine("Digite seu nome: ");
string Aluno = Console.ReadLine();

// Saída/Exibir
Console.WriteLine($"O aluno se chama:{Aluno}");





// Exemplo 2 - Conversoes
Console.WriteLine("Digite a sua idade: ");
// int age = int.Parse(Console.ReadLine());
bool converteu = int.TryParse(Console.ReadLine(), out int age);

if(converteu)
{
    Console.WriteLine($"O aluno se chma: {Aluno} e tem {age} anos");

}
else
{
Console.WriteLine($"Idade é inválida");
}


// Operadores Aritmétricos
int numero01 = 10;
int numero02 = 2;

Console.WriteLine(numero01 - numero02);  
Console.WriteLine(numero01 + numero02);
Console.WriteLine(numero01 * numero02);
Console.WriteLine(numero01 / numero02);
Console.WriteLine(numero01 % numero02);



// Operacoes Relacionais

Console.WriteLine(numero01 > numero02);
Console.WriteLine(numero01 < numero02);
Console.WriteLine(numero01 >= numero02);
Console.WriteLine(numero01 <= numero02);
Console.WriteLine(numero01 == numero02);
Console.WriteLine(numero01 != numero02);

//Operadores relacionais

Console.WriteLine(numero01 > numero02);
Console.WriteLine(numero01 < numero02);
Console.WriteLine(numero01 >= numero02);
Console.WriteLine(numero01 <= numero02);
Console.WriteLine(numero01 == numero02);
Console.WriteLine(numero01 != numero02);

//Operadores Lógicos: &&, !(Não e diferente) e ||(ou)
int Idade = 20;
bool possuiIngresso = true;
if (Idade > 18 && possuiIngresso)
{
    Console.WriteLine($"Sua entrada na festa foi autorizada!");
    Console.BackgroundColor = ConsoleColor.Yellow;
    Console.ForegroundColor = ConsoleColor.White;
}
else
{
    Console.WriteLine("Entrada recusada!");
    Console.BackgroundColor = ConsoleColor.White;
    Console.ForegroundColor = ConsoleColor.Red;
}

// Exemplo com Operador Lógico OU "||"
// Basta apenas um cenário ser verdade 
bool professor = false;
bool administrador = true;

if(professor || administrador)
{
    Console.WriteLine(" Acesso Permitido");

}

int AGE = 20;
bool temIngresso = true;
if (AGE > 18)
    if (temIngresso)
    {
    Console.WriteLine($"Entrada foi autorizada!");
    Console.BackgroundColor = ConsoleColor.Yellow;
    Console.ForegroundColor = ConsoleColor.White;
    }
else
{
    Console.WriteLine("Entrada recusada!");
}