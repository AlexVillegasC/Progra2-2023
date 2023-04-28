using System;
public class Sujeto
{
    private string _firstName;
    private string _lastName;

    public Sujeto() { }

    public Sujeto(string firstName, string lastName)
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

public class MyProgram
{
    public static void Run()
    {
        // 1st Example:
        Sujeto person1 = new Sujeto();
        person1.FirstName = "Emily";
        person1.LastName = "Johnson";
        Console.WriteLine("First Name: " + person1.FirstName);
        Console.WriteLine("Last Name: " + person1.LastName);

        // 2nd Example:
        Sujeto person2 = new Sujeto("David", "Smith");
        Console.WriteLine("First Name: " + person2.FirstName);
        Console.WriteLine("Last Name: " + person2.LastName);
    }
}
