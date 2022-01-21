// See https://aka.ms/new-console-template for more information
int m, i, sum = 0, avg = 0;
Console.WriteLine("Montako lukua ");
m = int.Parse(Console.ReadLine());
int[] a = new int[m];

for (i = 0; i < m; i++)
{
    Console.WriteLine("Anna " + (i + 1) + ". luku");
    a[i] = int.Parse(Console.ReadLine());
}
for (i = 0; i < m; i++)
{
    sum += a[i];
}
avg = sum / m;
Console.WriteLine("Keskiarvo annteuille luvuille on: {0}", avg);

