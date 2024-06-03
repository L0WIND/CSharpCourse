CustomerManager customerManager = new CustomerManager();
Matematik matematik = new Matematik();
//customerManager.SendMessage();
//customerManager.ShowAlert();

MyDelegate myDelegate = customerManager.SendMessage;
myDelegate += customerManager.ShowAlert;

myDelegate -= customerManager.SendMessage;

MyDelegate2 myDelegate2 = customerManager.SendMessage2;
myDelegate2 += customerManager.ShowAlert2;

MyDelegate3 myDelegate3 = matematik.Carp;
Console.WriteLine(myDelegate3(2, 1)); 

myDelegate2("Hello2!");

myDelegate();

public delegate void MyDelegate();
public delegate void MyDelegate2(string text);
public delegate int MyDelegate3(int number1, int number2);


public class CustomerManager
{
    public void SendMessage()
    {
        Console.WriteLine("Hello!");
    }
    public void ShowAlert()
    {
        Console.WriteLine("Be careful!");
    }
    public void SendMessage2(string message)
    {
        Console.WriteLine(message);
    }
    public void ShowAlert2(string alert)
    {
        Console.WriteLine(alert);
    }
}

public class Matematik
{
    public int Topla(int sayi1, int sayi2)
    {
        return sayi1 + sayi2;
    }
    public int Carp(int sayi1, int sayi2)
    {
        return sayi1 * sayi2;
    }
}