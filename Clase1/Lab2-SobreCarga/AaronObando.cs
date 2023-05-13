using System;

class Calculadora
{
    public int Sumar(int a, int b)
    {
        return a + b;
    }

    public double Sumar(double a, double b)
    {
        return a + b;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Calculadora calc = new Calculadora();

        int resultado1 = calc.Sumar(5, 10);
        Console.WriteLine("Resultado de la suma de enteros: " + resultado1);

        double resultado2 = calc.Sumar(3.14159, 2.71828);
        Console.WriteLine("Resultado de la suma de números decimales: " + resultado2);
    }
}