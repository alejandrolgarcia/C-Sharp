using System;

namespace Switch
{
  class Program
  {
    static void Main(string[] args)
    {
      //Variables necesarias
      float a = 0.0f;
      float b = 0.0f;
      float resultado = 0.0f;
      string valor = "";
      int opcion = 0;

      //Mostrando el menú
      Console.WriteLine("1. Suma");
      Console.WriteLine("2. Resta");
      Console.WriteLine("3. Multiplicación");
      Console.WriteLine("4. División\n");

      //Solicitar la opción
      Console.Write("Indique la operación: ");
      valor = Console.ReadLine();
      opcion = Convert.ToInt32(valor);

      //Pedimos los valores
      Console.Write("Ingrese el primer valor: ");
      valor = Console.ReadLine();
      a = Convert.ToSingle(valor);

      Console.Write("Ingrese el segundo valor: ");
      valor = Console.ReadLine();
      b = Convert.ToSingle(valor);

      switch (opcion)
      {
        case 1:
          resultado = a + b;
          break;
        case 2:
          resultado = a - b;
          break;
        case 3:
          resultado = a * b;
          break;
        case 4:
          if (b != 0)
          {
            resultado = a / b;
          }
          else
          {
            Console.WriteLine("Divisor 0 no valido");
          }

          break;
        default:
          Console.WriteLine("Opcion no valida");
          break;
      }

      Console.WriteLine("El resultado es {0}", resultado);
    }
  }
}
