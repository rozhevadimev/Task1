Console.WriteLine("Please, Enter n1");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Please,Enter n2");
int number2 = int.Parse(Console.ReadLine());
int min, max;

if (number1 > number2)
{
    max = number1;
    min = number2;
}
else
{
    max = number2;
    min = number1;
}
Console.WriteLine($"max = {max} > min = {min}");