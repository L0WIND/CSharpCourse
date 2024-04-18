
Person[] persons = new Person[3]
{
    new Customer
    {
        FirstName = "Yakup"
    }, new Student
    {
        FirstName = "Yusuf"
    }, new()
    {
        FirstName = "Oğzuhan"
    }
};
foreach (var person in persons)
{
    Console.WriteLine(person.FirstName);
}


class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

class Customer : Person
{
    public string City { get; set; }
}

class Student : Person
{
    public string Departmant { get; set; }
}