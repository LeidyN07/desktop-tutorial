using System;
using System.Collections.Generic;

class ProgramaVacunacion
{
    static void Main(string[] args)
    {
        // Generación de conjuntos principales
        HashSet<string> ciudadanos = GenerarCiudadanos(500);
        HashSet<string> pfizer = GenerarVacunados("Ciudadano", 1, 75);
        HashSet<string> astrazeneca = GenerarVacunados("Ciudadano", 50, 124);

        // Aplicación de operaciones de teoría de conjuntos
        HashSet<string> vacunados = Union(pfizer, astrazeneca);
        HashSet<string> noVacunados = Diferencia(ciudadanos, vacunados);
        HashSet<string> ambasDosis = Interseccion(pfizer, astrazeneca);
        HashSet<string> soloPfizer = Diferencia(pfizer, astrazeneca);
        HashSet<string> soloAstraZeneca = Diferencia(astrazeneca, pfizer);

        // Mostrar resultados
        MostrarResultados("Ciudadanos no vacunados", noVacunados);
        MostrarResultados("Ciudadanos con ambas dosis", ambasDosis);
        MostrarResultados("Ciudadanos solo Pfizer", soloPfizer);
        MostrarResultados("Ciudadanos solo AstraZeneca", soloAstraZeneca);
    }

    // Método para generar ciudadanos
    static HashSet<string> GenerarCiudadanos(int cantidad)
    {
        HashSet<string> conjunto = new HashSet<string>();
        for (int i = 1; i <= cantidad; i++)
        {
            conjunto.Add("Ciudadano " + i);
        }
        return conjunto;
    }

    // Método para generar vacunados por rango
    static HashSet<string> GenerarVacunados(string prefijo, int inicio, int fin)
    {
        HashSet<string> conjunto = new HashSet<string>();
        for (int i = inicio; i <= fin; i++)
        {
            conjunto.Add(prefijo + " " + i);
        }
        return conjunto;
    }

    // Operación Unión
    static HashSet<string> Union(HashSet<string> conjuntoA, HashSet<string> conjuntoB)
    {
        HashSet<string> resultado = new HashSet<string>(conjuntoA);
        resultado.UnionWith(conjuntoB);
        return resultado;
    }

    // Operación Intersección
    static HashSet<string> Interseccion(HashSet<string> conjuntoA, HashSet<string> conjuntoB)
    {
        HashSet<string> resultado = new HashSet<string>(conjuntoA);
        resultado.IntersectWith(conjuntoB);
        return resultado;
    }

    // Operación Diferencia
    static HashSet<string> Diferencia(HashSet<string> conjuntoA, HashSet<string> conjuntoB)
    {
        HashSet<string> resultado = new HashSet<string>(conjuntoA);
        resultado.ExceptWith(conjuntoB);
        return resultado;
    }

    // Método para mostrar resultados
    static void MostrarResultados(string titulo, HashSet<string> conjunto)
    {
        Console.WriteLine("\n=== " + titulo + " ===");
        Console.WriteLine("Total: " + conjunto.Count);
    }
}