//Sınıfın ihtiyaç duyduğu parametreler var ise constructor ile set ederiz.
CustomerManager customerManager = new CustomerManager(10);
customerManager.List();

Product product = new Product{Id = 1, Name = "Laptop"};
Product product2 = new Product(2, "Computer");

EmployeeManager employeeManager = new EmployeeManager(new DatabaseLogger());
employeeManager.Add();

PersonManager personManager = new PersonManager("Product");
personManager.Add();

Teacher.Number = 10;

Utilities.Validate();

Manager.DoSomething();
Manager manager = new Manager();
manager.DoSomething2();


class CustomerManager
{
    private int _count = 15;
    public CustomerManager(int count)
    {
        _count = count;
    }

    public CustomerManager()
    {
        
    }
    public void List()
    {
        Console.WriteLine("Listed! {0} items", _count);
    }

    public void Add()
    {
        Console.WriteLine("Added!");
    }
}

class Product
{
    private int _id;
    private string _name;
    public Product(int id, string name)
    {
        _id = id;
        _name = name;
    }

    public Product()
    {
        
    }
    public int Id { get; set; }
    public string Name { get; set; }
}

interface ILogger
{
    void Log();
}

class DatabaseLogger : ILogger
{
    public void Log()
    {
        Console.WriteLine("Logged to database");
    }
}
class FileLogger : ILogger
{
    public void Log()
    {
        Console.WriteLine("Logged to file");
    }
}
class EmployeeManager
{
    private ILogger _logger;
    public EmployeeManager(ILogger logger)
    {
        _logger = logger;
    }
    public void Add()
    {
        _logger.Log();
        Console.WriteLine("Added!");
    }
}

#region Yanlış kullanım Ctor inejction kullanmadan
//class EmployeeManager
//{
//    public ILogger Logger { get; set; }
//    public void Add()
//    {
//        Logger.Log();
//        Console.WriteLine("Added!");
//    }
//}

//EmployeeManager employeeManager = new EmployeeManager();
//employeeManager.Logger = new DatabaseLogger();
#endregion

class BaseClass
{
    private string _entity;

    public BaseClass(string entity)
    {
        _entity = entity;
    }
    public void Message()
    {
        Console.WriteLine("{0} message", _entity);
    }
}

class PersonManager : BaseClass
{
    public PersonManager(string entity) : base(entity)
    {
        
    }

    public void Add()
    {
        Console.WriteLine("Added!");
        Message();
    }
}

//static instance oluşturamazsın yani new leyemezsin ve her kez için aynı görülür yani birin de değişdiğinde diğerlerin de de değişir
//Yani bir iş yap ve bitir şeklindedir siteden kullanıcı girişi yaparken ki gibi
static class Teacher
{
    public static int Number { get; set; }
}

static class Utilities
{
    static Utilities()
    {

    }
    public static void Validate()
    {
        Console.WriteLine("Validation is done");
    }
}

class Manager
{
    public static void DoSomething()
    {
        Console.WriteLine("Done");
    }
    public void DoSomething2()
    {
        Console.WriteLine("Done2");
    }
}