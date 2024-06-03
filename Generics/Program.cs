﻿Utilities utilities = new Utilities();
List<string> result = utilities.BuildList<string>("Ankara", "İzmir", "Adana");
foreach (var resultItem in result)
{
    Console.WriteLine(resultItem);
}

List<Customer> result2 = utilities.BuildList<Customer>(new Customer { FirstName = "Yakup"}, new Customer { FirstName = "Yusuf"});

foreach (var customer in result2)
{
    Console.WriteLine(customer.FirstName);
}

class Utilities
{
    public List<T> BuildList<T>(params T[] items)
    {
        return new List<T>(items);
    }
}

class Product : IEntity
{
    
}

interface IProductDal:IRepository<Product>
{

}

class Customer : IEntity
{
    public string FirstName { get; set; }
}

interface ICustomerDal:IRepository<Customer>
{
    void Custom();
}

interface IStudentDal:IRepository<Student>
{
    
}

class Student : IEntity
{
    
}

interface IEntity
{
    
}

interface IRepository<T> where T : class, IEntity, new()
{
    List<T> GetAll();
    T Get(int id);
    void Add(T entity);
    void Delete(T entity);
    void Update(T entity);
}

class ProductDal:IProductDal
{
    public List<Product> GetAll()
    {
        throw new NotImplementedException();
    }

    public Product Get(int id)
    {
        throw new NotImplementedException();
    }

    public void Add(Product entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(Product entity)
    {
        throw new NotImplementedException();
    }

    public void Update(Product entity)
    {
        throw new NotImplementedException();
    }
}

class CustomerDal:ICustomerDal
{
    public List<Customer> GetAll()
    {
        throw new NotImplementedException();
    }

    public Customer Get(int id)
    {
        throw new NotImplementedException();
    }

    public void Add(Customer entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(Customer entity)
    {
        throw new NotImplementedException();
    }

    public void Update(Customer entity)
    {
        throw new NotImplementedException();
    }

    public void Custom()
    {
        throw new NotImplementedException();
    }
}