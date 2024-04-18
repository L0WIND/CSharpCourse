Database sqlServerDatabase = new SqlServer();
sqlServerDatabase.Add();
sqlServerDatabase.Delete();

Database oracleDatabase = new Oracle();
oracleDatabase.Add();
oracleDatabase.Delete();


abstract class Database
{
    public void Add()
    {
        Console.WriteLine("Added by default");
    }

    public abstract void Delete();
}

class SqlServer : Database
{
    public override void Delete()
    {
        Console.WriteLine("Deleted by Sql");
    }
}
class Oracle : Database
{
    public override void Delete()
    {
        Console.WriteLine("Deleted by Oracle");
    }
}