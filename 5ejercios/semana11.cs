using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static Dictionary<string, string> diccionario = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

    static void Main(string[] args)
    {
        CargarPalabrasIniciales();
        MostrarMenu();
    }

    // Cargar palabras base
    static void CargarPalabrasIniciales()
    {
        diccionario.Add("time", "tiempo");
        diccionario.Add("person", "persona");
        diccionario.Add("year", "año");
        diccionario.Add("way", "camino");
        diccionario.Add("day", "día");
        diccionario.Add("thing", "cosa");
        diccionario.Add("man", "hombre");
        diccionario.Add("world", "mundo");
        diccionario.Add("life", "vida");
        diccionario.Add("hand", "mano");
        diccionario.Add("eye", "ojo");
        diccionario.Add("woman", "mujer");
        diccionario.Add("work", "trabajo");
        diccionario.Add("week", "semana");
        diccionario.Add("government", "gobierno");
        diccionario.Add("company", "empresa");
        diccionario.Add("child", "niño");
        diccionario.Add("place", "lugar");
        diccionario.Add("point", "punto");
        diccionario.Add("case", "caso");
    }

    static void MostrarMenu()
    {
        int opcion;

        do
        {
            Console.WriteLine("\n==================== MENÚ ====================");
            Console.WriteLine("1. Traducir una frase");
            Console.WriteLine("2. Agregar palabra al diccionario");
            Console.WriteLine("3. Mostrar palabras registradas");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Ingrese un número válido.");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    TraducirFrase();
                    break;
                case 2:
                    AgregarPalabra();
                    break;
                case 3:
                    MostrarDiccionario();
                    break;
                case 0:
                    Console.WriteLine("Gracias por usar el traductor, Leidy 😊");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

        } while (opcion != 0);
    }

    static void TraducirFrase()
    {
        Console.Write("\nIngrese la frase a traducir: ");
        string frase = Console.ReadLine();

        string[] palabras = frase.Split(' ');
        StringBuilder resultado = new StringBuilder();

        foreach (string palabra in palabras)
        {
            string limpia = palabra.Trim(',', '.', ';', ':', '¡', '!', '¿', '?');

            // Traducción Inglés -> Español
            if (diccionario.ContainsKey(limpia))
            {
                resultado.Append(diccionario[limpia] + " ");
            }
            // Traducción Español -> Inglés
            else if (diccionario.ContainsValue(limpia))
            {
                foreach (var item in diccionario)
                {
                    if (item.Value.Equals(limpia, StringComparison.OrdinalIgnoreCase))
                    {
                        resultado.Append(item.Key + " ");
                        break;
                    }
                }
            }
            else
            {
                resultado.Append(palabra + " ");
            }
        }

        Console.WriteLine("\nTraducción parcial:");
        Console.WriteLine(resultado.ToString());
    }

    static void AgregarPalabra()
    {
        Console.Write("\nIngrese palabra en inglés: ");
        string ingles = Console.ReadLine();

        Console.Write("Ingrese su traducción en español: ");
        string español = Console.ReadLine();

        if (!diccionario.ContainsKey(ingles))
        {
            diccionario.Add(ingles, español);
            Console.WriteLine("Palabra agregada correctamente.");
        }
        else
        {
            Console.WriteLine("La palabra ya existe en el diccionario.");
        }
    }

    static void MostrarDiccionario()
    {
        Console.WriteLine("\nPalabras registradas:");
        foreach (var item in diccionario)
        {
            Console.WriteLine($"{item.Key} -> {item.Value}");
        }
    }
}