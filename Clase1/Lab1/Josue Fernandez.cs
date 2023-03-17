using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase1.Lab1;

namespace Labs.Lab1;


    public class Personal
    {

            public virtual void  CAMINAR()
            {

                Console.Write("camina en las tardes");
            }
     }



        public class Atletas : Personal
        {
            public override void CAMINAR()
            {
                Console.WriteLine("corre con mucha energia");
            }

        }


        public class Policias : Personal
        {
            public override void CAMINAR()
            {
                Console.WriteLine("PATRULLAR");
            }

        }

        public class Bomberos : Personal
        {
            public override void CAMINAR()
            {
                Console.WriteLine("APAGAR FUEGOS");
            }

        }

        public class Jugadores: Personal
        {
            public override void CAMINAR()
            {
                Console.WriteLine("va a las Olimpiadas");
            }
        }



    internal class JosueFernandez
    {
        public static void Run()
        {
            Personal[] personas = new Personal[4];

            personas[0] = new Atletas();
            personas[1] = new Policias();
            personas[2] = new Bomberos();
            personas[3] = new Jugadores();

            foreach (Personal persona in personas)
            {
                persona.CAMINAR();
            }


        }
    }
 
        

