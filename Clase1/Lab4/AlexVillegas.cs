namespace Labs.Lab4;

public class Person
{
    private string _firstName;
    private string _lastName;

    public string FirstName
    {
        get { return _firstName; }
        set { _firstName = value; }
    }

    public string LastName
    {
        get { return _lastName; }
        set { _lastName = value; }
    }
}

public class AlexVillegasProgram
{
    public static void Run()
    {
        Person person = new Person();
        person.FirstName = "John";
        person.LastName = "Doe";

        Console.WriteLine("First Name: " + person.FirstName);
        Console.WriteLine("Last Name: " + person.LastName);
    }
}
