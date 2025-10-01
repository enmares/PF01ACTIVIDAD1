namespace PF01ACTIVIDAD1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Persona Tonio = new Persona("Toni", 21, EstadoCivil.SOLTERO);
            Console.WriteLine(Tonio.MostrarDatos());
        }
    }
}
