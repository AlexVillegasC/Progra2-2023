namespace Labs.Lab4;

public class Person
{
    private string _firstName;
    private string _lastName;


    public Person() { }

    public Person(string firstName, string lastName)
    {
        _firstName = firstName;
        _lastName = lastName;
    }

    public string FirstName
    {
        get { return _firstName; }
        set { _firstName = value; }
    }

    public string LastName
    {
        get { return _lastName; }
        
        set
        {
            if (!value.Equals(""))
            {             
                _lastName = value;
            }
        }
    }
}

public class AlexVillegasProgram
{
    public static void Run()
    {
        // 1st Example:
        Person person1 = new Person();
        person1.FirstName = "John";
        person1.LastName = "Doe";
        Console.WriteLine("First Name: " + person1.FirstName);
        Console.WriteLine("Last Name: " + person1.LastName);

        // 2nd Example:
        Person person2 = new Person("Alex", "Villegas");
        Console.WriteLine("First Name: " + person2.FirstName);
        Console.WriteLine("Last Name: " + person2.LastName);        
    }
}
