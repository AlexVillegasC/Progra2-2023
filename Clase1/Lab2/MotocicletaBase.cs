namespace Clase2.Lab1
{
    public class MotocicletaBase
    {
        public override void Avanzar(int velocidad = 0)
        {
            velocidad = velocidad * 5;
            Console.WriteLine("Volando a velocidad: " + velocidad);
        }
    }
}