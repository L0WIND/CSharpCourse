﻿using Interfaces;
//InterfacesIntro();
//Demo();

ICustomerDal[] customerDals = new ICustomerDal[3]
{
    new SqlServerCustomerDal(),
    new OracleCustomerDal(),
    new MySqlCustomerDal()
};
foreach (var customerDal in customerDals)
{
    customerDal.Add();
}


void InterfacesIntro()
{
    PersonManager personManager = new PersonManager();
    personManager.Add(new Customer{Id = 1, FirstName = "Yakup", LastName = "Yılmaz", Address = "İstanbul"});
    Customer customer = new Customer();
    personManager.Add(customer);
    Student student = new Student
    {
        Id = 2,
        FirstName = "Oğuzhan",
        LastName = "Tulu",
        Departmant = "Computer Sciences"
    };
    personManager.Add(student);

    Worker worker = new Worker
    {
        Id = 1,
        FirstName = "Yusuf",
        LastName = "Yılmaz",
        Departmant = "Computer Science"
    };
    personManager.Add(worker);
}

void Demo()
{
    CustomerManager customerManager = new CustomerManager();
    customerManager.Add(new OracleCustomerDal());
}


interface IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}
class Customer : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
}
class Student : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Departmant { get; set; }
}
class Worker : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Departmant { get; set; }
}
class PersonManager
{
    public void Add(IPerson person)
    {
        Console.WriteLine(person.FirstName);
    }
}