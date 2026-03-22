using System;
using System.Collections.Generic;

class Nodo
{
    public int dato;
    public Nodo izquierda;
    public Nodo derecha;

    public Nodo(int valor)
    {
        dato = valor;
        izquierda = null;
        derecha = null;
    }
}

class ArbolBST
{
    public Nodo raiz;

    // INSERTAR
    public void Insertar(int valor)
    {
        raiz = InsertarRec(raiz, valor);
    }

    private Nodo InsertarRec(Nodo nodo, int valor)
    {
        if (nodo == null)
            return new Nodo(valor);

        if (valor < nodo.dato)
            nodo.izquierda = InsertarRec(nodo.izquierda, valor);
        else if (valor > nodo.dato)
            nodo.derecha = InsertarRec(nodo.derecha, valor);
        else
            Console.WriteLine("⚠ El valor ya existe.");

        return nodo;
    }

    // BUSCAR
    public bool Buscar(int valor)
    {
        return BuscarRec(raiz, valor);
    }

    private bool BuscarRec(Nodo nodo, int valor)
    {
        if (nodo == null) return false;
        if (nodo.dato == valor) return true;

        if (valor < nodo.dato)
            return BuscarRec(nodo.izquierda, valor);
        else
            return BuscarRec(nodo.derecha, valor);
    }

    // ELIMINAR
    public void Eliminar(int valor)
    {
        raiz = EliminarRec(raiz, valor);
    }

    private Nodo EliminarRec(Nodo nodo, int valor)
    {
        if (nodo == null) return null;

        if (valor < nodo.dato)
            nodo.izquierda = EliminarRec(nodo.izquierda, valor);
        else if (valor > nodo.dato)
            nodo.derecha = EliminarRec(nodo.derecha, valor);
        else
        {
            if (nodo.izquierda == null) return nodo.derecha;
            if (nodo.derecha == null) return nodo.izquierda;

            Nodo sucesor = MinimoNodo(nodo.derecha);
            nodo.dato = sucesor.dato;
            nodo.derecha = EliminarRec(nodo.derecha, sucesor.dato);
        }

        return nodo;
    }

    private Nodo MinimoNodo(Nodo nodo)
    {
        while (nodo.izquierda != null)
            nodo = nodo.izquierda;

        return nodo;
    }

    // RECORRIDOS
    public void Inorden(Nodo nodo)
    {
        if (nodo != null)
        {
            Inorden(nodo.izquierda);
            Console.Write(nodo.dato + " ");
            Inorden(nodo.derecha);
        }
    }

    public void Preorden(Nodo nodo)
    {
        if (nodo != null)
        {
            Console.Write(nodo.dato + " ");
            Preorden(nodo.izquierda);
            Preorden(nodo.derecha);
        }
    }

    public void Postorden(Nodo nodo)
    {
        if (nodo != null)
        {
            Postorden(nodo.izquierda);
            Postorden(nodo.derecha);
            Console.Write(nodo.dato + " ");
        }
    }

    // MIN, MAX, ALTURA
    public int Minimo()
    {
        Nodo actual = raiz;
        while (actual.izquierda != null)
            actual = actual.izquierda;

        return actual.dato;
    }

    public int Maximo()
    {
        Nodo actual = raiz;
        while (actual.derecha != null)
            actual = actual.derecha;

        return actual.dato;
    }

    public int Altura(Nodo nodo)
    {
        if (nodo == null) return 0;

        int izq = Altura(nodo.izquierda);
        int der = Altura(nodo.derecha);

        return 1 + Math.Max(izq, der);
    }

    // LIMPIAR
    public void Limpiar()
    {
        raiz = null;
    }
}

class Program
{
    static void Main()
    {
        ArbolBST arbol = new ArbolBST();
        int opcion;

        do
        {
            Console.WriteLine("\n===== MENÚ ÁRBOL BST =====");
            Console.WriteLine("1. Insertar");
            Console.WriteLine("2. Buscar");
            Console.WriteLine("3. Eliminar");
            Console.WriteLine("4. Inorden");
            Console.WriteLine("5. Preorden");
            Console.WriteLine("6. Postorden");
            Console.WriteLine("7. Mínimo");
            Console.WriteLine("8. Máximo");
            Console.WriteLine("9. Altura");
            Console.WriteLine("10. Limpiar árbol");
            Console.WriteLine("0. Salir");
            Console.Write("Opción: ");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese valor: ");
                    arbol.Insertar(int.Parse(Console.ReadLine()));
                    break;

                case 2:
                    Console.Write("Valor a buscar: ");
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine(arbol.Buscar(b) ? "✔ Existe" : "❌ No existe");
                    break;

                case 3:
                    Console.Write("Valor a eliminar: ");
                    arbol.Eliminar(int.Parse(Console.ReadLine()));
                    break;

                case 4:
                    Console.Write("Inorden: ");
                    arbol.Inorden(arbol.raiz);
                    Console.WriteLine();
                    break;

                case 5:
                    Console.Write("Preorden: ");
                    arbol.Preorden(arbol.raiz);
                    Console.WriteLine();
                    break;

                case 6:
                    Console.Write("Postorden: ");
                    arbol.Postorden(arbol.raiz);
                    Console.WriteLine();
                    break;

                case 7:
                    Console.WriteLine("Mínimo: " + arbol.Minimo());
                    break;

                case 8:
                    Console.WriteLine("Máximo: " + arbol.Maximo());
                    break;

                case 9:
                    Console.WriteLine("Altura: " + arbol.Altura(arbol.raiz));
                    break; 

                case 10:
                    arbol.Limpiar();
                    Console.WriteLine("Árbol eliminado.");
                    break;
            }

        } while (opcion != 0);
    }
}