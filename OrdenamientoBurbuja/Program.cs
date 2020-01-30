using System;

namespace OrdenamientoBurbuja
{
  class Program
  {

    // Funcion para cargar el arreglo con numeros aleatorios.
    // Con la clase Random se genera un numero aleatorio.
    static int[] GenerarAleatorios(int tamaño)
    {
      int[] arreglo = new int[tamaño];

      Random r = new Random();

      // Cargar el arreglo con un for
      for (int i = 0; i < arreglo.Length; i++)
      {
        arreglo[i] = r.Next(0, 1001);
      }

      Console.WriteLine("Arreglo desordenado");
      ImprimirArreglo(arreglo);
      Console.WriteLine();
      return arreglo;
    }

    // Funcion que ordena el array
    static void Bubble_Sort(int[] arreglo)
    {

      int iteracion = 0;
      bool permutation = true;
      int actual;

      while (permutation)
      {
        permutation = false;
        iteracion++;
        for (actual = 0; actual < arreglo.Length - iteracion; actual++)
        {
          if (arreglo[actual] > arreglo[actual + 1])
          {
            permutation = true;
            //Intercambiar los dos elementos
            int temp = arreglo[actual];
            arreglo[actual] = arreglo[actual + 1];
            arreglo[actual + 1] = temp;
          }
        }
      }

      Console.WriteLine("Arreglo ordenado");
      ImprimirArreglo(arreglo);
    }

    // Funcion para imprimir el arreglo ya ordenado
    static void ImprimirArreglo(int[] vector)
    {
      for (int i = 0; i < vector.Length; i++)
      {
        Console.Write(" {0},", vector[i]);
      }
    }

    // FUNCION PRINCIPAL
    static void Main(string[] args)
    {
      Bubble_Sort(GenerarAleatorios(15));
    }
  }
}
