//* desafio 03:Inclua nesse programa uma solicitação o nome completo de usuário. A cada impressão no console deve ser exibido nome completo do usuário, a mensagem sobre a ser maior ou menor de idade ou possui autorização e digitada pelo usuário. desafio 04: ser o usuário até 10 anos aparecer a mensagem "Você é uma criança", entre 10 a 14 " você é um pré-adolescente", entre 15 e 17 " Você é um adolescente", entre 18 a 60 "Você é um adulto", maiores de 60 " Você está na melhor idade".Você não deve apagar nenhum código


Console.WriteLine("Digite seu nome:");

string nome = Console.ReadLine();

Console.WriteLine("Qual o sua idade?");

double idade = double.Parse(Console.ReadLine());

if (idade >= 18)

{
    Console.WriteLine($" {nome}, você é maior de idade {idade}");

}

else if (idade >= 16)

{
    Console.WriteLine($" {nome}, você pode entrar com autorização {idade}");

}

else

{

    Console.WriteLine($" {nome}, você é menor de idade {idade} ");

}
if (idade <= 10)
{
    Console.WriteLine($" {nome}, você é uma criança. ");

}
else if (idade <= 14)
{    Console.WriteLine($"{nome}, você é um pré-adolescente. ");
}

else if(idade <= 17)
{
    Console.WriteLine($"{nome}, você é um adolescente. ");
}
else if (idade <= 18)
{
    Console.WriteLine($"{nome}, você é um adulto. ");
}
else
{
   Console.WriteLine($"{nome}, você está na melhor idade. ");
}
// Outro modo de como fazer comandos 
/*Console.WriteLine("Digite seu nome:");

string nome = Console.ReadLine();

Console.WriteLine("Qual o sua idade?");

double idade = double.Parse(Console.ReadLine());

if (idade >= 18)
{
    Console.WriteLine($" {nome}, você é maior de idade {idade}");

}

else if (idade >= 16)
{
    Console.WriteLine($" {nome}, você pode entrar com autorização {idade}");

}
else
{
    Console.WriteLine($" {nome}, você é menor de idade {idade} ");
}
if (idade <= 10)
{
    Console.WriteLine($" {nome}, você é uma criança. ");

}
else if (idade > 10 && idade <= 14)
    Console.WriteLine($"{nome}, você é um pré-adolescente. ");
else if (idade >= 15 && idade <= 17)
{
    Console.WriteLine($"{nome}, você é um adolescente");
}
else if (idade >= 18 && idade <= 60)
{
    Console.WriteLine($"{nome}, você é um adulto");
}
else
{
    Console.WriteLine("você está na melhor idade");
} */






