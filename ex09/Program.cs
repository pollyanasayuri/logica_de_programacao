Console.WriteLine(" Digite um número");
// solicitar um múmero ao usuário
int numero = int.Parse(Console.ReadLine());
int contador = 10;

// usar do-while para imprimir de 10 até o número informado ( decrementando de 2 em 2)
do
{
    Console.WriteLine(contador);
    contador -= 2; // decrementa o contador em 2
}

while (contador >= numero);
{
    
}
