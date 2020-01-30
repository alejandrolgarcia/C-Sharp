using System;

namespace Arreglos
{
  class Program
  {
    static void Main(string[] args)
    {
      // Variables necesarias
      int cantidad = 0;
      int salones = 0;
      string valor = "";

      // Variables para el promedio
      float suma = 0.0f;
      float promedio = 0.0f;

      float minima = 10.0f;
      float maxima = 0.0f;

      // Pedir la cantidad de salones
      Console.WriteLine("Ingrese cantidad de salores: ");
      valor = Console.ReadLine();
      salones = Convert.ToInt32(valor);

      // Pedir cantidad de alumnos
      Console.WriteLine("Ingrese cantidad de alumnos: ");
      valor = Console.ReadLine();
      cantidad = Convert.ToInt32(valor);

      // Instanciando el arreglo
      float[,] calificaciones = new float[salones, cantidad];

      // Capturamos la informacion
      for (int i = 0; i < salones; i++)
      {
        Console.WriteLine("Salon {0}", i);
        for (int j = 0; j < cantidad; j++)
        {
          Console.Write("Ingresa la calificacion: ");
          valor = Console.ReadLine();
          calificaciones[i, j] = Convert.ToSingle(valor);
        }
      }

      // Ciclo para encontrar el promedio
      for (int i = 0; i < salones; i++)
      {
        for (int j = 0; j < cantidad; j++)
        {
          suma += calificaciones[i, j];
        }
      }
      promedio = suma / (cantidad * salones);

      // Encontrar la calificacion minima
      for (int i = 0; i < salones; i++)
      {
        for (int j = 0; j < cantidad; j++)
        {
          if (calificaciones[i, j] < minima)
            minima = calificaciones[i, j];
        }
      }

      // Encontrar la calificacion maxima
      for (int i = 0; i < salones; i++)
      {
        for (int j = 0; j < cantidad; j++)
        {
          if (calificaciones[i, j] > maxima)
            maxima = calificaciones[i, j];
        }
      }

      // Desplegar los resultados
      Console.WriteLine("El promedio es {0}: ", promedio);
      Console.WriteLine("La calificacion minima es {0}: ", minima);
      Console.WriteLine("La calificacion maxima es {0}: ", maxima);
    }
  }
}
