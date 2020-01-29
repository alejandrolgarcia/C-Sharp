using System;

namespace Operadores
{
  class Program
  {
    static void Main(string[] args)
    {
      // Operadores Aritmeticos en C#
      // Los operadores aritmeticos permiten realizar operaciones basicas
      // como suma, resta, multiplicaciones o divisiones.

      int numero1 = 8;
      int numero2 = 4;

      // suma
      var suma = numero1 + numero2;
      Console.WriteLine("Suma: {0}", suma);

      // Resta
      var resta = numero1 + numero2;
      Console.WriteLine("Resta: {0}", resta);

      // Multiplicacion
      var mult = numero1 + numero2;
      Console.WriteLine("Multiplicacion: {0}", mult);

      // Division
      var div = numero1 + numero2;
      Console.WriteLine("Division: {0}", div);

      // Operadores de comparacion de tipos y relacionales

      // Devuelven valores verdaderos o falsos dependiendo si se cumple la comparacion
      // Se pueden dar las siguintes comparaciones: >=, <=, <, >

      var data = numero1 < numero2;
      var data2 = numero1 >= numero2;

      // Operadores de igualdad
      var data3 = numero1 == numero2;  // Verifica si los datos son iguales
      var data4 = numero2 != numero1;  // Verifica si los datos son diferentes
    }
  }
}
