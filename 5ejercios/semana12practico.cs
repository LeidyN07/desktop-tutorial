using System;
using System.Collections.Generic;

namespace TorneoFutbol
{
    // Clase para representar un jugador
    public class Jugador
    {
        public string Nombre { get; set; }

        public Jugador(string nombre)
        {
            Nombre = nombre;
        }

        public override string ToString()
        {
            return Nombre;
        }
    }

    // Clase para representar un equipo
    public class Equipo
    {
        public string Nombre { get; set; }
        public HashSet<Jugador> Jugadores { get; set; }

        public Equipo(string nombre)
        {
            Nombre = nombre;
            Jugadores = new HashSet<Jugador>();
        }

        // Agregar jugador al equipo, evita duplicados
        public bool AgregarJugador(Jugador jugador)
        {
            if (Jugadores.Add(jugador))
            {
                Console.WriteLine($"Jugador '{jugador.Nombre}' agregado al equipo '{Nombre}'.");
                return true;
            }
            else
            {
                Console.WriteLine($"El jugador '{jugador.Nombre}' ya existe en el equipo '{Nombre}'.");
                return false;
            }
        }

        public override string ToString()
        {
            return Nombre;
        }
    }

    class Programa
    {
        // Diccionario para asociar equipos y sus jugadores
        static Dictionary<string, Equipo> equipos = new Dictionary<string, Equipo>();

        static void Main(string[] args)
        {
            Console.WriteLine("=== Registro de Jugadores y Equipos - Torneo de Fútbol ===");

            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("\nOpciones:");
                Console.WriteLine("1 - Agregar Equipo");
                Console.WriteLine("2 - Agregar Jugador a Equipo");
                Console.WriteLine("3 - Mostrar Equipos y Jugadores");
                Console.WriteLine("4 - Salir");
                Console.Write("Seleccione una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        AgregarEquipo();
                        break;
                    case "2":
                        AgregarJugadorEquipo();
                        break;
                    case "3":
                        MostrarEquipos();
                        break;
                    case "4":
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Intente de nuevo.");
                        break;
                }
            }

            Console.WriteLine("Gracias por usar el sistema. ¡Hasta luego!");
        }

        // Método para agregar un equipo
        static void AgregarEquipo()
        {
            Console.Write("Ingrese el nombre del equipo: ");
            string nombreEquipo = Console.ReadLine();

            if (equipos.ContainsKey(nombreEquipo))
            {
                Console.WriteLine("El equipo ya está registrado.");
            }
            else
            {
                Equipo equipo = new Equipo(nombreEquipo);
                equipos.Add(nombreEquipo, equipo);
                Console.WriteLine($"Equipo '{nombreEquipo}' agregado correctamente.");
            }
        }

        // Método para agregar jugador a un equipo
        static void AgregarJugadorEquipo()
        {
            if (equipos.Count == 0)
            {
                Console.WriteLine("No hay equipos registrados. Primero agregue un equipo.");
                return;
            }

            Console.Write("Ingrese el nombre del equipo: ");
            string nombreEquipo = Console.ReadLine();

            if (!equipos.ContainsKey(nombreEquipo))
            {
                Console.WriteLine("El equipo no existe. Primero agregue el equipo.");
                return;
            }

            Console.Write("Ingrese el nombre del jugador: ");
            string nombreJugador = Console.ReadLine();

            Jugador jugador = new Jugador(nombreJugador);
            equipos[nombreEquipo].AgregarJugador(jugador);
        }

        // Método para mostrar todos los equipos y sus jugadores
        static void MostrarEquipos()
        {
            if (equipos.Count == 0)
            {
                Console.WriteLine("No hay equipos registrados.");
                return;
            }

            Console.WriteLine("\n=== Equipos y Jugadores ===");
            foreach (var equipo in equipos.Values)
            {
                Console.WriteLine($"\nEquipo: {equipo.Nombre}");
                if (equipo.Jugadores.Count == 0)
                {
                    Console.WriteLine("  No hay jugadores registrados.");
                }
                else
                {
                    foreach (var jugador in equipo.Jugadores)
                    {
                        Console.WriteLine($"  - {jugador.Nombre}");
                    }
                }
            }
        }
    }
}