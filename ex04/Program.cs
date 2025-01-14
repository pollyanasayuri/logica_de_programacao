// tipos de dados 

using System.IO.Pipes;

string nome = "Pollyana"; // tipo texto
Console.WriteLine(" O nome do usuário é:"+ nome);

int idade = 24;  // números inteiros
//Console.Writine("A idade do usuário é: "+ idade + anos");
Console.WriteLine($"A idade do usuário é: {idade} anos");

float carteira = 2.63f; // números com vírgula ( n* menor)

char classificacao = 'A'; // quando vc quer usar apenas um caractere, e usar apenas com uma apas exemplo acima.  
Console.WriteLine($" O cliente é do tipo{classificacao}");

bool dinheiroNaconta = true; // verdadeiro(true) ou falso (false) 
Console.WriteLine(dinheiroNaconta);

double limitecredito = 2000.0; // numeros com vírgulas ( n* maior )
Console.WriteLine("Seu limite de crédito é: " + limitecredito);

string sobrenome = "Brito";

string nomecompleto = nome + sobrenome;
Console.WriteLine(nomecompleto);

double valorConta = 53.73;
Console.WriteLine($"valor na conta é: {valorConta}");

double limiteTotal = valorConta + limitecredito;
Console.WriteLine($"O saldo + limite é {limiteTotal}");
