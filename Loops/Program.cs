//ForLoop();
//WhileLoop();
//DoWhileLoop();
//ForeachLoop();
if (IsPrimeNumber(6))
{
    Console.WriteLine("This is a prime number");
}
else
{
    Console.WriteLine("This is not a prime number");
}


 static bool IsPrimeNumber(int number)
{
    bool result = true;
    for (int i = 2; i < number-1; i++)
    {
        if (number%i==0)
        {
            result = false;
            i = number;
        }
    }
    return result;
}
static void ForLoop()
{
    for (int i = 1; i <= 100; i = i + 2)
    {
        Console.WriteLine(i);
    }
    for (int j = 100; j >= 0; j = j - 2)
    {
        Console.WriteLine(j);
    }
}

static void WhileLoop()
{
    int number = 100;
    while (number >= 0)
    {
        Console.WriteLine(number);
        number--;
    }
}

static void DoWhileLoop()
{
    int number = 10;
    do
    {
        Console.WriteLine(number);
        number--;
    } while (number >= 11);
}

static void ForeachLoop()
{
    string[] students = { "Yakup", "Yusuf", "Büşra" };
    foreach (string student in students)
    {
        Console.WriteLine(student);
    }
}