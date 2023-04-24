using System;
public interface IAnimal
{
    void Eat();
    void Sleep();
}

public interface ICarnivore
{
    void Hunt();
}

public class Lion : IAnimal, ICarnivore
{
    public void Eat()
    {
        Console.WriteLine("The lion is eating.");
    }

    public void Sleep()
    {
        Console.WriteLine("The lion is sleeping.");
    }

    public void Hunt()
    {
        Console.WriteLine("The lion is hunting.");
    }
}

internal class AxelRamos
{
    public static void Run()
    {
        Lion simba = new Lion();
        simba.Sleep();
        simba.Eat();
        simba.Hunt();
    }
}
