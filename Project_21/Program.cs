// See https://aka.ms/new-console-template for more information
double a1, a2, a3, b1, b2, b3, d;
Console.WriteLine("Enter some coordinates: ");
a1 = Convert.ToDouble(Console.ReadLine()!);
a2 = Convert.ToDouble(Console.ReadLine()!);
a3 = Convert.ToDouble(Console.ReadLine()!);
b1 = Convert.ToDouble(Console.ReadLine()!);
b2 = Convert.ToDouble(Console.ReadLine()!);
b3 = Convert.ToDouble(Console.ReadLine()!);
d = Math.Sqrt(Math.Pow(a1 - b1, 2) + Math.Pow(a2 - b2, 2) + Math.Pow(a3 - b3, 2));
Console.WriteLine("Distance between two dots: " + d);