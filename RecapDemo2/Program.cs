﻿CustomerManager customerManager = new CustomerManager();
customerManager.Logger = new SmsLogger();
customerManager.Add();



class CustomerManager
{
    public ILogger Logger { get; set; }
    public void Add()
    {
        Logger.Log();
        Console.WriteLine("Customer added!");
    }
}

class DatabaseLogger : ILogger
{
    public void Log()
    {
        Console.WriteLine("Logged to database!");
    }
}
class FileLogger : ILogger
{
    public void Log()
    {
        Console.WriteLine("Logged to file!");
    }
}
class SmsLogger : ILogger
{
    public void Log()
    {
        Console.WriteLine("Logged to sms!");
    }
}

interface ILogger
{
    void Log();
}