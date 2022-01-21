// See https://aka.ms/new-console-template for more information

Console.WriteLine("Yhteen- vai vähennyslasku (+/-)");
var laskutoimitus = Console.ReadLine();

Console.WriteLine("Anna ensimmäinen luku");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("Anna toinen luku");
int number1 = int.Parse(Console.ReadLine());

var summa = number + number1;
var erotus = number - number1;

if (laskutoimitus == "+")
{
    Console.WriteLine("Annettujen lukujen summa on: " + summa);
}
else
{
    Console.WriteLine("Annettujen lukujen erotus on:" + erotus);
}