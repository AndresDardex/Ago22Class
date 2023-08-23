namespace Ago22class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            Console.WriteLine("¿que quieres hacer mi perro?, dependiendo de lo que quieras pon el numero que sale en la opcion");
            Console.WriteLine("1) ¿sacar el promedio de 3 numeros?");
            Console.WriteLine("2) ¿sacar el promedio de 3 numeros?");
            Console.WriteLine("3) ¿sacar el promedio de 3 numeros?");
            String opcion = Console.ReadLine();
            if (opcion.Equals("1")) {
                Console.WriteLine("Escriba 3 numeros");
                String numero1 = Console.ReadLine();
                String numero2 = Console.ReadLine();
                String numero3 = Console.ReadLine();
                Console.WriteLine("el promedio es:" + Class1.EjecutarEjercicio8(numero1, numero2, numero3));
            }
        }
    }
}