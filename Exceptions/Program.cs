using Exceptions;

//ExceptionIntro();


//TryCatch();

//Method
//ActionDemo();

//Genellikle temel classa konulur


Func<int, int, int> add = Topla;
Console.WriteLine(add(3,5));
Console.WriteLine(Topla(2,5));

Func<int> getRandomNumber = delegate()
{
    Random random = new Random();
    return random.Next(1, 100);
};
Console.WriteLine(getRandomNumber());
Thread.Sleep(1000);
Func<int> getRandomNumber2 = () => new Random().Next(1, 100);
Console.WriteLine(getRandomNumber2());



static int Topla(int x, int y)
{
    return x + y;
}

void ExceptionIntro()
{
    try
    {
        string[] students = new string[3] { "Yakup", "Yusuf", "Oğuz" };
        students[3] = "Ahmet";
    }
    catch (IndexOutOfRangeException exception)
    {
        Console.WriteLine(exception.Message);
    }
    catch (DivideByZeroException exception)
    {
        Console.WriteLine(exception.Message);
    }
    catch (Exception exception)
    {
        Console.WriteLine(exception.Message);
    }
}

void TryCatch()
{
    try
    {
        //Find();
    }
    catch (RecordNotFoundException exception)
    {
        Console.WriteLine(exception.Message);
    }
    catch (Exception exception)
    {

    }
}

void ActionDemo()
{
    HandleException(() =>
    {
        Find();
    });

    static void HandleException(Action action)
    {
        try
        {
            action.Invoke();
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception.Message);
        }
    }

    void Find()
    {
        List<string> students = new List<string> { "Yakup", "Yusuf", "Oğuz" };
        if (!students.Contains("Ahmet"))
        {
            throw new RecordNotFoundException("Record Not Found!"); 
        }
        else
        {
            Console.WriteLine("Record Found!");
        }
    }
}

