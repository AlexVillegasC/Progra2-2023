// PROBLEMAS DE COMPILACION
//namespace Labs.Lab4;

//class Persona
//{
//    private string nombre;
//    private int edad;

//    public string Nombre
//    {
//        get
//        {
//            return nombre;
//        }
//        set
//        {
//            nombre = value;
//        }
//    }

//    public int Edad
//    {
//        get
//        {
//            return edad;
//        }
//        set
//        {
//            if (value >= 0)
//            {
//                edad = value;
//            }
//            else
//            {
//                Console.WriteLine("La edad no puede ser negativa.");
//            }
//        }
//    }

//    public Persona(string nombre, int edad)
//    {
//        this.nombre = nombre;
//        this.edad = edad;
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Persona persona1 = new Persona("Juan", 25);
//        Console.WriteLine("Nombre: " + persona1.Nombre); // Salida: Nombre: Juan
//        Console.WriteLine("Edad: " + persona1.Edad); // Salida: Edad: 25

//        persona1.Nombre = "Pedro";
//        persona1.Edad = -30; // Se mostrará un mensaje de error en la consola

//        Console.WriteLine("Nombre: " + persona1.Nombre); // Salida: Nombre: Pedro
//        Console.WriteLine("Edad: " + persona1.Edad); // Salida: Edad: 25
//    }
//}