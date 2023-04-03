static int Add(int number1 = 0, int number2 = 0)
{
    return number1 + number2;
}

Console.WriteLine(Add(10, 13)); // 23

// ref keyword - change variable's value in the method
static int Add2(ref int num1, int num2)
{
    num1 = 100;
    return num1 + num2;
}

int num1 = 10;
int num2 = 20;
Console.WriteLine(Add2(ref num1, num2)); // 120
Console.WriteLine(num1); // 100

// out keyword
static int Add3(out int num3, int num4)
{
    num3 = 100;
    return num3 + num4;
}

int num3; // *
int num4 = 20;
Console.WriteLine(Add3(out num3, num4)); // 120
Console.WriteLine(num3); // 100

// params keyword
static int Add4(params int[] numbers)
{
    return numbers.Sum();
}
Console.WriteLine(Add4(1, 2, 3, 4)); // 10