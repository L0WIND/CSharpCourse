using Classes;

CustomerManager customerManager = new CustomerManager();
customerManager.Add();
customerManager.Update();

ProductManager productManager = new ProductManager();
productManager.Add();
productManager.Update();

Customer customer = new Customer();
customer.Id = 1;
customer.FirstName = "Yakup";
customer.LastName = "Yılmaz"; //prop Set
customer.City = "İstanbul";
Customer customer2 = new Customer
{
    Id = 2, FirstName = "Yusuf", LastName = "Yılmaz", City = "Erzurum"
};

Console.WriteLine(customer.FirstName); //prop Get
