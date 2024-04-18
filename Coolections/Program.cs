using System.Collections;

//ArrayList();

//List();

Dictionary<string, string> dictionary = new Dictionary<string, string>();
dictionary.Add("book", "kitap");
dictionary.Add("table", "masa");
dictionary.Add("computer", "bilgisayar");
Console.WriteLine(dictionary["table"]);

foreach (var item in dictionary)
{
    Console.WriteLine(item);
    Console.WriteLine(item.Key);
    Console.WriteLine(item.Value);
}

Console.WriteLine(dictionary.ContainsKey("table"));

void ArrayList()
{
    ArrayList cities  = new ArrayList();
    cities.Add("Ankara");
    cities.Add("Adana");

    cities.Add("İstanbul");
    cities.Add(1);
    cities.Add('A');

    foreach (var city in cities)
    {
        Console.WriteLine(city);
    }
}

void List()
{
    List<string> cities = new List<string>();
    cities.Add("Ankara");
    cities.Add("İstanbul");

//Console.WriteLine(cities.Contains("Ankara"));

    foreach (var city in cities)
    {
        Console.WriteLine(city);
    }

//List<Customer> customers = new List<Customer>();
//customers.Add(new Customer { Id = 1, FirstName = "Yakup" });
//customers.Add(new Customer { Id = 2, FirstName = "Yusuf" });

    List<Customer> customers =
    [
        new Customer { Id = 1, FirstName = "Yakup" },
        new Customer { Id = 2, FirstName = "Yusuf" }
    ];

    var customer2 = new Customer
    {
        Id = 3,
        FirstName = "Oğuz"
    };
    customers.Add(customer2);

    customers.AddRange(new Customer[2]
    {
        new Customer{Id = 4 , FirstName = "Duygu"},
        new Customer{Id = 5 ,FirstName = "Erol"}
    });

    Console.WriteLine(customers.Contains(customer2));

//customers.Clear();

    var index = customers.IndexOf(customer2);
    Console.WriteLine("Index : {0}", index);

    customers.Add(customer2);

    var index2 = customers.LastIndexOf(customer2);
    Console.WriteLine("Index2 : {0}", index2);

    customers.Insert(0, customer2);

    customers.Remove(customer2);
    customers.RemoveAll(c=>c.FirstName=="");

    foreach (var customer in customers)
    {
        Console.WriteLine(customer.FirstName);
    }

    var count = customers.Count;
    Console.WriteLine("Count : {0}", count);
}


class Customer
{
    public int Id { get; set; }
    public string FirstName { get; set; }
}