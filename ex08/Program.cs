// Crie um programa que solicite ao usuário e imprime todos os números de 1 até o número informado usado um laço ' while'.

Console.WriteLine(" Digite um número");

int numero = int.Parse(Console.ReadLine());
int contador = 1;

while (contador <= numero)
{
    Console.WriteLine(contador);
    contador ++;
}
