using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase1.Lab1;

namespace Labs.Lab1;
    public class Persona
    {

            public virtual void CAMINAR()
            {

                Console.Write("camina en las tardes");
            }
     }



        public class Atleta : Persona
        {
            public override void CAMINAR()
            {
                Console.WriteLine("corre con mucha energia");
            }

        }


        public class Policia : Persona
        {
            public override void CAMINAR()
            {
                Console.WriteLine("PATRULLAR");
            }

        }

        public class Bombero : Persona
        {
            public override void CAMINAR()
            {
                Console.WriteLine("APAGAR FUEGOS");
            }

        }

        public class Jugador: Persona
        {
            public override void CAMINAR()
            {
                Console.WriteLine("va a las Olimpiadas");
            }
        }






    internal class Josue_Fernandez
    {
        public static void Run()
        {
            Persona[] personas = new Persona[4];

            personas[0] = new Atleta();
            personas[1] = new Policia();
            personas[2] = new Bombero();
            personas[3] = new Jugador();

            foreach (Persona persona in personas)
            {
                persona.CAMINAR();
            }


        }
    }
 
        

