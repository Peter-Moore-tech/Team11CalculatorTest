// See https://aka.ms/new-console-template for more information

using MyCalculator;

Console.WriteLine("Hello World!");
Calculator mycalc = new Calculator();

int a = 2, b = 3;

// Add test
Console.WriteLine("Adding numbers " + a + " and " + b);
if (mycalc.Add(a, b) == 5)
{
    Console.WriteLine($"Printing correct result: {mycalc.Add(a, b)}");
}
else
{
    Console.WriteLine($"Printing incorrect result: {mycalc.Add(a, b)}");
}

// Subtract test
Console.WriteLine("Subtracting numbers " + a + " and " + b);
if (mycalc.Subtract(a, b) == -1)
{
    Console.WriteLine($"Printing correct result: {mycalc.Subtract(a, b)}");
}
else
{
    Console.WriteLine($"Printing incorrect result: {mycalc.Subtract(a, b)}");
}

// Multiplication test
Console.WriteLine("Multiplying numbers " + a + " and " + b);
if (mycalc.Multiply(a, b) == 6)
{
    Console.WriteLine($"Printing correct result: {mycalc.Multiply(a, b)}");
}
else
{
    Console.WriteLine($"Printing incorrect result: {mycalc.Multiply(a, b)}");
}

// Multiplication test
Console.WriteLine("Raising number " + a + " to the power of " + b);
if (mycalc.Power(a, b) == 8)
{
    Console.WriteLine($"Printing correct result: {mycalc.Power(a, b)}");
}
else
{
    Console.WriteLine($"Printing incorrect result: {mycalc.Power(a, b)}");
}
