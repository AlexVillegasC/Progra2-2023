using System;

class Ejercicio
{
    public virtual void Entrenar()
    {
        Console.WriteLine("Entrenando");
    }
}

class Gym : Ejercicio
{
    public override void Entrenar()
    {
        Console.WriteLine("Haciendo pesas en el gym");
    }
}

class Crossfit : Ejercicio
{
    public override void Entrenar()
    {
        Console.WriteLine("Haciendo WODs en crossfit");
    }
}

class Calistenia : Ejercicio
{
    public override void Entrenar()
    {
        Console.WriteLine("Haciendo ejercicios de calistenia");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Ejercicio ej = new Ejercicio();
        ej.Entrenar();

        Gym gym = new Gym();
        gym.Entrenar();

        Crossfit crossfit = new Crossfit();
        crossfit.Entrenar();

        Calistenia calistenia = new Calistenia();
        calistenia.Entrenar();
    }
}
