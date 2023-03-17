using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs.Lab2 { }



    public class Persona
    {
        public virtual void CAMINAR()
        {
            Console.WriteLine("HAY QUE CAMINAR POCO A POCO");
        }

        public virtual void CAMINAR(int velocidad = 0)
        {
            Console.WriteLine("CAMINAR A VELOCIDAD: " + velocidad);
        }
    }



    public class Atletas : Persona
    {
        public override void CAMINAR()
        {
            Console.WriteLine("CORRER  HAY !");
        }
        public override void CAMINAR(int velocidad = 0)
        {
            velocidad = velocidad * 5;
            Console.WriteLine("CORRE A UNA VELOCIDA: " + velocidad);
        }
    }



    public class Policia : Persona
    {
        public override void CAMINAR()
        {
            Console.WriteLine("DISPARANDO : ");
        }
        public override void CAMINAR(int velocidad = 0)
        {
            Console.WriteLine("DISPARANDO a velocidad: " + velocidad);
        }
    }



    public class Bombero : Persona
    {
        public override void CAMINAR()
        {
            Console.WriteLine("apaga fuego!");
        }

        public override void CAMINAR(int velocidad = 0)
        {
            velocidad = velocidad * 2;
            Console.WriteLine("APAGANDO FEUGO a velocidad: " + velocidad);
        }
    }



    internal class Josue_Fernandez
    {
            public static void Run()
            {
                Persona[] personas= new Persona[3];

                personas[0] = new Atletas();
                personas[1] = new Policia();
                personas[2] = new Bombero();

                foreach (Persona persona in personas)
                {
                    persona.CAMINAR(1);
                }
            }
        }

