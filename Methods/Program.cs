Add();

Console.WriteLine(Add2(1, 2));

int number1 = 20;
int number2 = 100;
var result = Add3(ref number1 , number2);
Console.WriteLine(result);
Console.WriteLine(number1);



Console.ReadLine();
static void Add()
{
    Console.WriteLine("Added!");
}
static int Add2(int number1, int number2 = 20)
{
    return number1 + number2;
}
static int Add3(ref int number1, int number2) //ref method içindeki sayıyı alıyor senin verdiğin değil out ise ref ile aynı şekilde çalışır tek fark verdiğin veri tipinde sayı olmasına gerek yok
{
    number1 = 30;
    return number1 + number2;
}
#region Overload Method
//public class Overload
//{
//    public static int Multiply(int number1, int number2)
//    {
//        return number1 * number2;
//    }
//    public static int Multiply(int number1, int number2, int number3)
//    {
//        return number1 * number2 * number3;
//    }
//}
#endregion

