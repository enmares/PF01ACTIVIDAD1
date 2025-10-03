namespace PF01ACTIVIDAD1
{
    class Producto
    {
        public string Nombre;
        public double Precio;
        public bool EnStock;
        public string Descripcion;

        public Producto(string nombre, double precio, bool enStock, string descripcion)
        {
            Nombre = nombre;
            Precio = precio;
            EnStock = enStock;
            Descripcion = descripcion;
        }

        public void MostrarDatos()
        {
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Precio: " + Precio);
            Console.WriteLine("En Stock: " + EnStock);
            Console.WriteLine("Descripcion: " + Descripcion);
        }
    }
}
