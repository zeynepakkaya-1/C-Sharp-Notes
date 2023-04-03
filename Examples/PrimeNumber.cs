static bool IsPrimeNumber(int number)
{
    bool result = true;

    for(int i = 2; i < number-1; i++)
    {
        if(number % i == 0)
        {
            result = false;
        }
    }
    return result;
}

Console.WriteLine(IsPrimeNumber(100));
Console.WriteLine(IsPrimeNumber(17));
Console.WriteLine(IsPrimeNumber(7));