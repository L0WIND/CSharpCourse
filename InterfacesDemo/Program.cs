IWork[] works = new IWork[3]
{
    new Manager(),
    new Worker(),
    new Robot()
};
foreach (var work in works)
{
    work.Work();
}

IEat[] eats = new IEat[2]
{
    new Manager(),
    new Worker()
};
foreach (var eat in eats)
{
    eat.Eat();
}


interface IWork
{
    void Work();
}

interface IEat
{
    void Eat();
}

interface ISalary
{
    void GetSalary();
}

class Manager : IWork , IEat , ISalary
{
    public void Work()
    {
        throw new NotImplementedException();
    }

    public void Eat()
    {
        throw new NotImplementedException();
    }

    public void GetSalary()
    {
        throw new NotImplementedException();
    }
}

class Worker : IWork, IEat, ISalary
{
    public void Work()
    {
        throw new NotImplementedException();
    }

    public void Eat()
    {
        throw new NotImplementedException();
    }

    public void GetSalary()
    {
        throw new NotImplementedException();
    }
}

class Robot : IWork
{
    public void Work()
    {
        throw new NotImplementedException();
    }
}