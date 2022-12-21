// See https://aka.ms/new-console-template for more information
int number, i, n = 0;
double j;
Console.Write("Enter the number: ");
number = int.Parse(Console.ReadLine()!);
for (i = 1; i <= number; i++)
{
    n++;
    j = Math.Pow(n, 3);
    Console.Write(j + ", ");
}
Console.WriteLine();