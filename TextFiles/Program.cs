using System;
using System.IO;

namespace TextFiles
{
  class Program
  {
    static void Main(string[] args)
    {
      /* Lectura en archivos */ 
      // Crear una instancia del objeto StreamReader para leer el archivo
      StreamReader reader = new StreamReader("Sample.txt");

      int lineNumber = 0;

      // Leer la primera linea del archivo
      string line = reader.ReadLine();

      // Leer otras lineas del archivo
      while (line != null)
      {
        lineNumber++;
        Console.WriteLine("Linea {0}: {1}", lineNumber, line);
        line = reader.ReadLine();
      }

      // Cerrar el archivo una vez haya finalizado su uso
      reader.Close();

      /* Escritura en archivos */

      // Crear una instancia del objeto StreamWrite
      StreamWriter writer = new StreamWriter("numbers.txt");

      // Asegurarse de cerrar la escritura cuando ya no se utilice
      using (writer)
      {
        // Ciclo para recorrer los numeros del 1 al 20 y escribirlos
        for (int i = 1; i <= 20; i++)
        {
          writer.WriteLine(i);
        }
      }

    }
  }
}
