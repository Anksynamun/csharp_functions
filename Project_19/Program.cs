// See https://aka.ms/new-console-template for more information
string number;
Console.Write("Enter a five-digit number: ");
number = Console.ReadLine()!;
if (number.Reverse().SequenceEqual(number))
{
    Console.WriteLine("Palindrome");
}
else
{
    Console.WriteLine("Not a palindrome");
}