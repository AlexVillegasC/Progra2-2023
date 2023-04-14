namespace Labs.Lab2;

using HolaMundo;
using System;


namespace HolaMundo
{
    class Animal
    {
        virtual public void comer()
        {
            Console.WriteLine("Los animales comen");
        }
        virtual public void correr()
        {
            Console.WriteLine("Los animales corren");

        }
    }
}



namespace HolaMundo
{
    class Humano : Animal
    {
        override public void comer()
        {
            Console.WriteLine("Soy human como en platos");
        }
        override public void correr()
        {
            Console.WriteLine("Soy humano y corro con tenis");
        }
    }
}


namespace HolaMundo
{
    class Pajaro : Animal
    {
        override public void comer()
        {
            Console.WriteLine("Los pajaros comemos frutas del campo");
        }
        public void volar()
        {
            Console.WriteLine("Los pajaros volamos");
        }

    }
}

namespace HolaMundo
{
    class Perro : Animal
    {
        override public void comer()
        {
            Console.WriteLine("Los perros  comemos consentrado en una taza");
        }
        public override void correr()
        {
            Console.WriteLine("los perros corremos en cuatro patas  ");
        }

    }
}
class Conejo : Animal
{
    override public void comer()
    {
        Console.WriteLine("los conejos comemos hierbas");
    }
    public override void correr()
    {
        Console.WriteLine("los conejos corremos dando saltos");
    }
}


namespace HolaMundo
{
    class Program
    {
        static void Main(string[] args)
        {   
           
            Animal a = new Animal();
            a.comer();
            a.correr();

            Conejo c = new Conejo();
            c.correr();
            c.comer();

            Humano h = new Humano();
            h.comer();
            h.correr();

            Perro perro = new Perro();
            perro.comer();
            perro.correr();
            

            Pajaro pa = new Pajaro();
            pa.comer();
            pa.volar();
           
        }
    }
}
