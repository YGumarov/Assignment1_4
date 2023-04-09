static ulong  Factorial(ulong n)
{
    if (n <= 1)
    {
        return 1;
    }
    return n * Factorial(n - 1);
    
}

ulong n = ulong.Parse(Console.ReadLine());
Console.WriteLine(Factorial(n));