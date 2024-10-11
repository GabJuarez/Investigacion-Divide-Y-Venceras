using System;

class Program
{
    static int SumaDivideYVenceras(int[] array, int inicio, int fin)
    {
        if (inicio == fin)
        {
            return array[inicio];
        }

        int medio = (inicio + fin) / 2;

        int sumaIzquierda = SumaDivideYVenceras(array, inicio, medio);

        int sumaDerecha = SumaDivideYVenceras(array, medio + 1, fin);

        return sumaIzquierda + sumaDerecha;
    }

    static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 5 };
        int resultado = SumaDivideYVenceras(array, 0, array.Length - 1);
        Console.WriteLine("La suma del arreglo es: " + resultado);
    }
}
