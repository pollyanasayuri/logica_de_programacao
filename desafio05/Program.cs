//escreva um programa que solicite a usuário a quantidade em litros abastecidos em um automove.Em seguida o programa deve solicitar que o usuário informe a quantidade de kilometros percorridos até o término do tanque.O programa deve exibir a quantidade de Km por litro.


Console.WriteLine("Quantidade em litros abastecidos");
int litrosAbastecidos = int.Parse(Console.ReadLine());

Console.WriteLine("Quantidade de quilômetros percorridos");
int quilometros = int.Parse(Console.ReadLine());


int totalKmPorLitro = quilometros / litrosAbastecidos;
Console.WriteLine("voce faz " + totalKmPorLitro + " quilometros por litro");

