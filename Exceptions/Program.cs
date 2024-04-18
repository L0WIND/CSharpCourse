using Exceptions;

//ExceptionIntro();


try
{
    Find();
}
catch (Exception exception)
{
    Console.WriteLine(exception.Message);
}

//Method
HandleException(() =>
{
    Find();
});

//Genellikle temel classa konulur
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

