using System;

class Vehiculo
{
    public string Placa;
    public string Marca;
    public string Modelo;
    public int Año;
    public double Precio;
    public Vehiculo Siguiente;
}

class ListaVehiculos
{
    private Vehiculo inicio = null;

    public void Agregar()
    {
        Vehiculo nuevo = new Vehiculo();

        Console.Write("Placa: ");
        nuevo.Placa = Console.ReadLine();

        Console.Write("Marca: ");
        nuevo.Marca = Console.ReadLine();

        Console.Write("Modelo: ");
        nuevo.Modelo = Console.ReadLine();

        Console.Write("Año: ");
        nuevo.Año = int.Parse(Console.ReadLine());

        Console.Write("Precio: ");
        nuevo.Precio = double.Parse(Console.ReadLine());

        nuevo.Siguiente = inicio;
        inicio = nuevo;

        Console.WriteLine("Vehículo agregado correctamente.\n");
    }

    public void Buscar(string placa)
    {
        Vehiculo actual = inicio;

        while (actual != null)
        {
            if (actual.Placa == placa)
            {
                MostrarVehiculo(actual);
                return;
            }
            actual = actual.Siguiente;
        }

        Console.WriteLine("Vehículo no encontrado.\n");
    }

    public void MostrarPorAño(int año)
    {
        Vehiculo actual = inicio;

        while (actual != null)
        {
            if (actual.Año == año)
                MostrarVehiculo(actual);

            actual = actual.Siguiente;
        }
    }

    public void MostrarTodos()
    {
        Vehiculo actual = inicio;

        while (actual != null)
        {
            MostrarVehiculo(actual);
            actual = actual.Siguiente;
        }
    }

    public void Eliminar(string placa)
    {
        Vehiculo actual = inicio;
        Vehiculo anterior = null;

        while (actual != null)
        {
            if (actual.Placa == placa)
            {
                if (anterior == null)
                    inicio = actual.Siguiente;
                else
                    anterior.Siguiente = actual.Siguiente;

                Console.WriteLine("Vehículo eliminado.\n");
                return;
            }

            anterior = actual;
            actual = actual.Siguiente;
        }

        Console.WriteLine("Vehículo no encontrado.\n");
    }

    private void MostrarVehiculo(Vehiculo v)
    {
        Console.WriteLine($"Placa: {v.Placa} | Marca: {v.Marca} | Modelo: {v.Modelo} | Año: {v.Año} | Precio: {v.Precio}");
    }
}

class Program
{
    static void Main()
    {
        ListaVehiculos lista = new ListaVehiculos();
        int opcion;

        do
        {
            Console.WriteLine("\n--- MENÚ VEHÍCULOS ---");
            Console.WriteLine("1. Agregar vehículo");
            Console.WriteLine("2. Buscar por placa");
            Console.WriteLine("3. Ver por año");
            Console.WriteLine("4. Ver todos");
            Console.WriteLine("5. Eliminar vehículo");
            Console.WriteLine("0. Salir");
            Console.Write("Opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    lista.Agregar();
                    break;
                case 2:
                    Console.Write("Ingrese placa: ");
                    lista.Buscar(Console.ReadLine());
                    break;
                case 3:
                    Console.Write("Ingrese año: ");
                    lista.MostrarPorAño(int.Parse(Console.ReadLine()));
                    break;
                case 4:
                    lista.MostrarTodos();
                    break;
                case 5:
                    Console.Write("Ingrese placa a eliminar: ");
                    lista.Eliminar(Console.ReadLine());
                    break;
            }

        } while (opcion != 0);
    }
}
