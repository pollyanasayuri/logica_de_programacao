// adapte o programa abaixo para solicitar a idade do usuario. Se o usuario maior de 18 anos exibir a mensagem maior de idade.Do contrário exibir a mensagem menor de idade.



Console.WriteLine(" Escreva seu  primeiro nome");
string nome = Console.ReadLine();

Console.WriteLine("Escreva seu sobrenome");
string sobrenome = Console.ReadLine();


Console.WriteLine("Digite sua idade");
int  idade = int.Parse(Console.ReadLine());

if (idade >= 18)
{
    Console.WriteLine(" Maior de idade");
}
else if (idade >= 16)
{
    Console.WriteLine("Você pode entrar com autorização");
}
else
{
    Console.WriteLine("Você é menor de idade");



    Console.WriteLine($"boas vindas!, {nome} {sobrenome}");
}
