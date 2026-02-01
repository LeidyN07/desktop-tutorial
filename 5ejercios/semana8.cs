using System;
using System.Collections.Generic;

namespace GuiaPractica02
{
    class Persona
    {
        public string Nombre { get; set; }
        public int Asiento { get; set; }

        public Persona(string nombre, int asiento)
        {
            Nombre = nombre;
            Asiento = asiento;
        }
    }

    class Atraccion
    {
        private Queue<Persona> cola = new Queue<Persona>();
        private List<Persona> asientosOcupados = new List<Persona>();
        private const int MAX_ASIENTOS = 30;
        private int contadorAsientos = 1;

        public void RegistrarPersona(string nombre)
        {
            if (contadorAsientos > MAX_ASIENTOS)
            {
                Console.WriteLine("No hay asientos disponibles.");
                return;
            }

            Persona persona = new Persona(nombre, contadorAsientos);
            cola.Enqueue(persona);
            contadorAsientos++;

            Console.WriteLine("Persona registrada correctamente.");
        }

        public void MostrarFila()
        {
            Console.WriteLine("\nPersonas en la fila:");

            if (cola.Count == 0)
            {
                Console.WriteLine("La fila está vacía.");
                return;
            }

            foreach (var persona in cola)
            {
                Console.WriteLine("Nombre: " + persona.Nombre + " | Asiento: " + persona.Asiento);
            }
        }

        public void IniciarAtraccion()
        {
            if (cola.Count == 0)
            {
                Console.WriteLine("No hay personas para iniciar la atracción.");
                return;
            }

            Console.WriteLine("\nAsignando asientos...");

            while (cola.Count > 0)
            {
                Persona p = cola.Dequeue();
                asientosOcupados.Add(p);
                Console.WriteLine(p.Nombre + " tomó el asiento " + p.Asiento);
            }
        }

        public void MostrarAsientosOcupados()
        {
            Console.WriteLine("\nAsientos ocupados:");

            if (asientosOcupados.Count == 0)
            {
                Console.WriteLine("Aún no se ha iniciado la atracción.");
                return;
            }

            foreach (var persona in asientosOcupados)
            {
                Console.WriteLine("Asiento " + persona.Asiento + " - " + persona.Nombre);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Atraccion atraccion = new Atraccion();
            int opcion = 0;

            do
            {
                Console.WriteLine("\n--- Sistema de Atracción ---");
                Console.WriteLine("1. Registrar persona");
                Console.WriteLine("2. Mostrar fila");
                Console.WriteLine("3. Iniciar atracción");
                Console.WriteLine("4. Mostrar asientos ocupados");
                Console.WriteLine("5. Salir");
                Console.Write("Opción: ");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Nombre de la persona: ");
                        string nombre = Console.ReadLine();
                        atraccion.RegistrarPersona(nombre);
                        break;

                    case 2:
                        atraccion.MostrarFila();
                        break;

                    case 3:
                        atraccion.IniciarAtraccion();
                        break;

                    case 4:
                        atraccion.MostrarAsientosOcupados();
                        break;

                    case 5:
                        Console.WriteLine("Programa finalizado.");
                        break;

                    default:
                        Console.WriteLine("Opción incorrecta.");
                        break;
                }

            } while (opcion != 5);
        }
    }
}
