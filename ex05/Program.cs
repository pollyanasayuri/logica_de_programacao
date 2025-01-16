//Calcular que recebe 2 numeros e apresena + - * / 

Console.Write("informe o primeiro número:");
double num1 = double.Parse(Console.ReadLine());

Console.Write("informe o segundo número:");
double num2 = double.Parse(Console.ReadLine());

Console.Clear();
Console.WriteLine("soma: " + (num1+ num2));
Console.WriteLine("Subtração:" + (num1 - num2));
Console.WriteLine("Multiplicação:" + (num1 * num2));

if (num2 != 0)
{
    Console.WriteLine("divisão:" + (num1 / num2));
}
else
{
    Console.WriteLine("divisão por ZERO não permitida");
}


