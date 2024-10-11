using System;

class Program
{
    static int BusquedaBinaria(int[] arr, int inicio, int fin, int objetivo)
    {
        if (inicio <= fin)
        {
            int medio = inicio + (fin - inicio) / 2; 

         
            if (arr[medio] == objetivo)
                return medio;

            if (arr[medio] > objetivo)
                return BusquedaBinaria(arr, inicio, medio - 1, objetivo);

            return BusquedaBinaria(arr, medio + 1, fin, objetivo);
        }

        return -1;
    }

    static void Main()
    {
        int[] arr = { 2, 3, 4, 10, 40 }; 

        int objetivo = 10;

        int resultado = BusquedaBinaria(arr, 0, arr.Length - 1, objetivo);

        if (resultado == -1)
            Console.WriteLine("El elemento no fue encontrado en el arreglo");
        else
            Console.WriteLine("El elemento está presente en el índice: {0} " , resultado);
    }
}
