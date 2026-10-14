// Console.WriteLine("Digite seu nome: ");
// string Cliente = Console.ReadLine();

// decimal Compra = -1;
// while (Compra < 0)
// {
//     Console.WriteLine("Digite o valor Total da compra:");
//     bool converteu = decimal.TryParse(Console.ReadLine(), out Compra);

//     if (!converteu || Compra < 0)
//     {
//         Console.WriteLine("Valor inválido! O valor da compra não pode ser negativo.\n");
//         Compra = -1;
//     }
// }
// int fidelidade = 0;

// while (fidelidade != 1 && fidelidade != 2)
// {
//     Console.WriteLine("Possui fidelidade? Digite 1 para sim e 2 para não:");

//     bool confirmacao = int.TryParse(Console.ReadLine(), out fidelidade);

//     if (!confirmacao || (fidelidade != 1 && fidelidade != 2))
//     {
//         Console.WriteLine("Opção Inválida! Tente novamente.\n");
//     }
// }

// if (fidelidade == 1)
// {

// }
// else if (fidelidade == 2)
// {

// }

// decimal desconto = 0m;

// if (Compra >= 500)
// {
//     desconto = 0.15m;
// }
// else if (Compra >= 200)
// {
//     desconto = 0.10m;
// }
// else
// {
//     desconto = 0.05m;
// }

// if (fidelidade == 1)
// {
//     desconto += 0.05m;
// }

// decimal Desconto = Compra * desconto;
// decimal valorFinal = Compra - Desconto;

// Console.WriteLine($"\nCliente: {Cliente}");
// Console.WriteLine($"Compra: {Compra:C}");
// Console.WriteLine($"Desconto: {Desconto:C}");
// Console.WriteLine($"Valor final: {valorFinal:C}");

// //Exercício 02
// Console.WriteLine("Digite a temperatura: ");

// decimal Temperatura = decimal.Parse(Console.ReadLine());
// if (Temperatura < 0)
// {
//     Console.WriteLine($"\nTemperatura: {Temperatura}");
//     Console.WriteLine($"Classificação: Muito Frio");
//     Console.WriteLine($"Aviso: Risco de congelamento!");
// }
// else if (Temperatura == 0 && Temperatura < 10)
// {
//     Console.WriteLine($"\nTemperatura: {Temperatura}");
//     Console.WriteLine($"Classificação: Muito Frio");
// }
// else if (Temperatura >= 10 && Temperatura <= 17)
// {
//     Console.WriteLine($"\nTemperatura: {Temperatura}");
//     Console.WriteLine($"Classificação: Frio");
// }
// else if (Temperatura >= 18 && Temperatura <= 25)
// {
//     Console.WriteLine($"\nTemperatura: {Temperatura}");
//     Console.WriteLine($"Classificação: Agradável");
// }
// else if (Temperatura >= 26 && Temperatura <= 32)
// {
//     Console.WriteLine($"\nTemperatura: {Temperatura}");
//     Console.WriteLine($"Classificação: Quente");
// }
// else if (Temperatura >= 32 && Temperatura <= 40)
// {
//     Console.WriteLine($"\nTemperatura: {Temperatura}");
//     Console.WriteLine($"Classificação: Muito Quente");
// }
// else
// {
//     Console.WriteLine($"\n Temperatura: {Temperatura}");
//     Console.WriteLine($"\n Classificação: Muito Quente");
//     Console.WriteLine($"Aviso: Calor Extremo!");
// }



// //EXERCÍCIOS 3
// int age = 0;
// Console.WriteLine("Digite seu nome: ");
// string SOLICITANTE = Console.ReadLine();

// bool Converteu = false;

// while (Converteu != true)
// {

//     Console.WriteLine("Digite sua idade: ");
//     Converteu = int.TryParse(Console.ReadLine(), out age);

// }

// decimal salario = 0;
// while (salario == 0)
// {
//     Console.WriteLine("Digite seu salário mensal: ");
//     bool Salario = decimal.TryParse(Console.ReadLine(), out salario);
// }
// Console.WriteLine("Digite o valor da parcela: ");
// decimal parcela = decimal.Parse(Console.ReadLine());

// int restricao = 0;

// while (restricao != 1 && restricao != 2)
// {
//     Console.WriteLine("Possui restrição? Digite 1 para sim e 2 para não:");

//     bool confirmacao = int.TryParse(Console.ReadLine(), out restricao);

//     if (!confirmacao || (restricao != 1 && restricao != 2))
//     {
//         Console.WriteLine("Opção Inválida! Tente novamente.\n");
//     }
// }




// decimal limiteEmprestimo = salario * 0.3m;

// if (parcela <= limiteEmprestimo && age >= 18)
// {
//     if (restricao == 2)
//     {
//         Console.WriteLine($"\nEmpréstimo aprovado para {SOLICITANTE}.");
//         Console.WriteLine($"Limite da parcela: {limiteEmprestimo}");
//         Console.WriteLine($"Parcela Solicitada: {parcela}");

//     }
//     else
//     {
//         Console.WriteLine($"\nEmpréstimo recusado: parcela acima do limite permitido.");
//     }
// }
// else
// {
//     Console.WriteLine($"\nEmpréstimo recusado: parcela acima do limite permitido.");
// }



//EXERCÍCIOS 4
// int age = 0;
// Console.WriteLine("Digite seu nome: ");
// string nomes = Console.ReadLine();

// bool Converteu = false;

// while (Converteu != true)
// {

//     Console.WriteLine("Digite sua idade: ");
//     Converteu = int.TryParse(Console.ReadLine(), out age);
// }

// int anosxp = 0;
// while (anosxp <= 0)
// {
//     Console.WriteLine("Quantos anos você tem de experiência: ");
//     bool Anosxp = int.TryParse(Console.ReadLine(), out anosxp);
// }


// decimal Nota = 0;
// while (Nota <= 0)
// {
//     Console.WriteLine("Digite a nota da prova técnica: ");

//     bool nota = decimal.TryParse(Console.ReadLine(), out Nota);
// }



// int possuicurso = 0;

// while (possuicurso != 1 && possuicurso != 2)
// {
//     Console.WriteLine("Possui curso técnico? Digite 1 para sim e 2 para não:");

//     bool confirmacao = int.TryParse(Console.ReadLine(), out possuicurso);

//     if (!confirmacao || (possuicurso != 1 && possuicurso != 2))
//     {
//         Console.WriteLine("Opção Inválida! Tente novamente.\n");
//     }
// }



// int posssuidisp = 0;

// while (posssuidisp != 1 && posssuidisp != 2)
// {
//     Console.WriteLine("Possui disponibilidade de horário? Digite 1 para sim e 2 para não:");

//     bool Confirmacao = int.TryParse(Console.ReadLine(), out posssuidisp);

//     if (!Confirmacao || (posssuidisp != 1 && posssuidisp != 2))
//     {
//         Console.WriteLine("Opção Inválida! Tente novamente.\n");
//     }
// }

// if (age >= 18 && Nota >= 7)
// {
//     if (posssuidisp == 1)
//     {
//         if (possuicurso == 1 || anosxp >= 2)
//         {
//             Console.WriteLine($"\nCandidato: {nomes}.");
//             Console.WriteLine($"Resultado: Aprovado");
//         }
//     }
// }
// else if(Nota >= 5 && Nota <= 6.9m)
// {
//     if(posssuidisp == 1)
//     {
//         if (possuicurso == 1 || anosxp >= 2)
//         {
//             Console.WriteLine($"Resultado: Banco de Talentos. Miquelaçi");
//         }
//     }
// }else
// {
//     Console.WriteLine("Reprovado seu betinha");
// }



//EXERCÍCIOS 5

// int age = 0;

// Console.WriteLine("Digite seu nome: ");
// string passageiro = Console.ReadLine();

// bool converted = false;

// while (converted != true)
// {

//     Console.WriteLine("Digite sua idade: ");
//     converted = int.TryParse(Console.ReadLine(), out age);
// }

// double distancia = 0;
// while (distancia <= 0)
// {
//     Console.WriteLine("Digite a distância que será percorrida: ");

//     bool distance = double.TryParse(Console.ReadLine(), out distancia);
// }

// int horapico = 0;

// while (horapico != 1 && horapico != 2)
// {
//     Console.WriteLine("Viagem acontecerá em horário de pico? Digite 1 para sim e 2 para não:");

//     bool Confirmacao = int.TryParse(Console.ReadLine(), out horapico);

//     if (!Confirmacao || (horapico != 1 && horapico != 2))
//     {
//         Console.WriteLine("Opção Inválida! Tente novamente.\n");
//     }
// }


// int posssuicard = 0;

// while (posssuicard != 1 && posssuicard != 2)
// {
//     Console.WriteLine("Passageiro possui cartão de desconto? Digite 1 para sim e 2 para não:");

//     bool Confirmacao = int.TryParse(Console.ReadLine(), out posssuicard);

//     if (!Confirmacao || (posssuicard != 1 && posssuicard != 2))
//     {
//         Console.WriteLine("Opção Inválida! Tente novamente.\n");
//     }
// }

// double valorcorrida = distancia * 0.8;
// double acrescimo = 0;
// double desconto = 0;

// if (posssuicard == 1)
// {
//     desconto += 0.1;

//     if (horapico == 1)
//     {
//         acrescimo += 0.2;
//     }
//     else
//     {
//         acrescimo += 0;
//     }
//     if (age >= 60)
//     {
//         desconto += 0.4;
//     }
//     else if (age >= 6 && age <= 17)
//     {
//         desconto += 0.5;
//     }
//     else
//     {
//         desconto += 0;
//     }
// }
// else if (posssuicard == 2)
// {
//     desconto += 0;

//     if (horapico == 1)
//     {
//         acrescimo += 0.2;
//     }
//     else
//     {
//         acrescimo += 0;
//     }

//     if (age >= 60)
//     {
//         desconto += 0.4;
//     }
//     else if (age >= 6 && age <= 17)
//     {
//         desconto += 0.5;
//     }
//     else
//     {
//         desconto += 0;
//     }
// }
// else if(age <= 6)
// {
//    desconto += 1.0;
// }
// else
// {
//     Console.WriteLine($"Você não existe.");
// }
// double valorfinal = valorcorrida - (desconto * valorcorrida) + (acrescimo * valorcorrida);
// Console.WriteLine($"Passageiro: {passageiro}");
// Console.WriteLine($"Subtotal: {valorcorrida}");
// Console.WriteLine($"Total final: {valorfinal}");


//Exercícios 06

int IDADE = 0;

Console.WriteLine("Digite o nome do paciente: ");
string PACIENTE = Console.ReadLine();

bool converta = false;

while (converta != true)
{

    Console.WriteLine("Digite a idade do paciente: ");
    converta = int.TryParse(Console.ReadLine(), out IDADE);
}

double temperatura = 0;

while (temperatura <= 0)
{
    Console.WriteLine($"Digite a temperatura do paciente: ");
    bool cotro = double.TryParse(Console.ReadLine(), out temperatura);
}

double Dor = 0;
while (Dor <= 0 || Dor > 10)
{
    Console.WriteLine("Qual o nível de dor: ");

    bool distance = double.TryParse(Console.ReadLine(), out Dor);
}


int Respiracao = 0;

while (Respiracao != 1 && Respiracao != 2)
{
    Console.WriteLine("Paciente está com dificuldade pra respirar? Digite 1 para sim e 2 para não:");

    bool analise = int.TryParse(Console.ReadLine(), out Respiracao);

    if (!analise || (Respiracao != 1 && Respiracao != 2))
    {
        Console.WriteLine("Opção Inválida! Tente novamente.\n");
    }
}



int consciencia = 0;

while (consciencia != 1 && consciencia != 2)
{
    Console.WriteLine("Paciente está consciente? Digite 1 para sim e 2 para não:");

    bool analise = int.TryParse(Console.ReadLine(), out consciencia);

    if (!analise || (consciencia != 1 && consciencia != 2))
    {
        Console.WriteLine("Opção Inválida! Tente novamente.\n");
    }
}

if (consciencia == 1 || Respiracao == 1 || Dor >= 9)
{
    Console.WriteLine($"Paciente: {PACIENTE}");
    Console.WriteLine($"Classificação: Emergência");
    Console.WriteLine($"Motivo: Atende os requisitos necessários.");
}
else if (temperatura >= 39 || Dor >= 7)
{
    if (IDADE >= 60 && temperatura >= 38)
    {
        Console.WriteLine($"Paciente: {PACIENTE}");
        Console.WriteLine($"Classificação: Urgência");
        Console.WriteLine($"Motivo: Atende os requisitos necessários.");
    }

    Console.WriteLine($"Paciente: {PACIENTE}");
    Console.WriteLine($"Classificação: Urgência");
    Console.WriteLine($"Motivo: Atende os requisitos necessários.");
}
else if (IDADE < 12 || IDADE >= 60 || temperatura >= 37.5)
{
    Console.WriteLine($"Paciente: {PACIENTE}");
    Console.WriteLine($"Classificação: Prioridade");
    Console.WriteLine($"Motivo: Atende os requisitos necessários.");
}
else
{
    Console.WriteLine($"Paciente: {PACIENTE}");
    Console.WriteLine($"Classificação: Comum");
    Console.WriteLine($"Motivo: Atende os requisitos necessários."); 
}