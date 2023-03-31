using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace WilsonChavarria
{
    class Animales
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





    class Humano : Animales
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




    class Pajaro : Animales
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

    class Perro : Animales
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

    class Conejo1 : Animales
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




    class WilsonChavarria2
    {
        static void Main(string[] args)
        {

            Animales a = new Animales();
            a.comer();
            a.correr();

            Animales c = new Animales();
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