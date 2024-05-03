using System.Drawing;

Console.Clear();
int numero;

Console.WriteLine("Digite um numero: ");
numero = Convert.ToInt32(Console.ReadLine());

if( numero >= 0)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("Seu número é positivo");
Console.ResetColor();
}

else

if( numero < 0)
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("Seu número é negativo");
Console.ResetColor();
}