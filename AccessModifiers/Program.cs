//private < protected < internal < public
//private sadece o block içerisin de kullanabilir
//protected inheritance ile sadece o block içinde kullanılabilir
//internal o proje içerisin de çağırabiliriz
//public hepsin de kullanılabilir
class Customer
{
    protected int Id { get; set; }

    public void Save()
    {

    }

    public void Delete()
    {

    }
}

class Student : Customer
{
    public void Save()
    {
        
    }
}

public class Course
{
    public string Name { get; set; }
}