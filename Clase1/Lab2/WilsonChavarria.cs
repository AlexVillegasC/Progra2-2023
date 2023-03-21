using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs.Lab2
{
    using System;


    namespace Labs.Lab2
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



    namespace Labs.Lab2
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


    namespace Labs.Lab2
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

    namespace Labs.Lab2
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
    namespace Labs.Lab2
    {
        class Conejo : Animal
        {
            public override void comer()
            {
                Console.WriteLine("los conejos comemos hierbas");
            }
            public override void correr()
            {
                Console.WriteLine("los conejos corremos dando saltos");
            }
        }


        namespace Labs.Lab2
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
    }
}
