using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        LinkedList<double> listaPrincipal = new LinkedList<double>();
        LinkedList<double> listaMenores = new LinkedList<double>();
        LinkedList<double> listaMayores = new LinkedList<double>();

        Console.Write("Cantidad de datos: ");
        int n = int.Parse(Console.ReadLine());

        double suma = 0;

        for (int i = 0; i < n; i++)
        {
            Console.Write("Ingrese número: ");
            double num = double.Parse(Console.ReadLine());
            listaPrincipal.AddLast(num);
            suma += num;
        }

        double promedio = suma / n;

        foreach (double num in listaPrincipal)
        {
            if (num <= promedio)
                listaMenores.AddLast(num);
            else
                listaMayores.AddLast(num);
        }

        Console.WriteLine("\nLista principal:");
        foreach (double num in listaPrincipal)
            Console.Write(num + " ");

        Console.WriteLine("\n\nPromedio: " + promedio);

        Console.WriteLine("\nMenores o iguales al promedio:");
        foreach (double num in listaMenores)
            Console.Write(num + " ");

        Console.WriteLine("\n\nMayores al promedio:");
        foreach (double num in listaMayores)
            Console.Write(num + " ");
    }
}
