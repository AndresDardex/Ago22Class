namespace Ago22class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            Console.WriteLine("¿que quieres hacer mi perro?, dependiendo de lo que quieras pon el numero que sale en la opcion");
            Console.WriteLine("1) ¿sacar el promedio de 3 numeros?");
            Console.WriteLine("2) ¿quieres sacar el area y perimetro de un rectangulo?");
            Console.WriteLine("3) ¿quieres sacarel volumen de un cilindro?");
            String opcion = Console.ReadLine();
            if (opcion.Equals("1")) {
                Console.WriteLine("Escriba 3 numeros");
                String numero1 = Console.ReadLine();
                String numero2 = Console.ReadLine();
                String numero3 = Console.ReadLine();
                Console.WriteLine("el promedio es:" + Class1.EjecutarEjercicio8(numero1, numero2, numero3));
            }else if (opcion.Equals("2")) {
                Console.WriteLine("Escriba la base y su altura");
                String bases = Console.ReadLine();
                String altura = Console.ReadLine();
                Console.WriteLine("el area del rectangulo es: " + Class1.Area(bases, altura);
                Console.WriteLine("el perimetro del rectangulo es: " + Class1.Perimetro(bases, altura);
            }else if (opcion.Equals("3"))
            {
                Console.WriteLine("Escriba la radio y su altura");
                String radio = Console.ReadLine();
                String altura = Console.ReadLine();
                Console.WriteLine("el volumen del cilindro es: " + Class1.Volumen(radio, altura);
            }
        }
    }
}