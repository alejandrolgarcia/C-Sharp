using System;

namespace Funciones
{
  class Program
  {
    // Función para el Menú
    static void Menu()
    {
      Console.WriteLine("1...Suma");
      Console.WriteLine("2...Resta");
      Console.WriteLine("3...Multiplicación");
      Console.WriteLine("4...División\n");
    }

    // Funcion Suma que no devuelve ningun valor y no lleva parametros.
    static void Suma()
    {
      //Variables
      float a = 0;
      float b = 0;
      float r = 0;
      string numero = "";

      // Pedir la opción
      Console.Write("Ingrese primer valor: ");
      numero = Console.ReadLine();
      a = Convert.ToSingle(numero);

      // Pedir la opción
      Console.Write("Ingrese segundo valor: ");
      numero = Console.ReadLine();
      b = Convert.ToSingle(numero);

      // Calculo
      r = a + b;

      Console.WriteLine("El resultado es {0}", r);
    }

    // Funciones que devuelven valores.
    static float Resta()
    {
      // Variables
      float a = 0;
      float b = 0;
      float r = 0;
      string numero = "";

      // Pedir la opción
      Console.Write("Ingrese primer valor: ");
      numero = Console.ReadLine();
      a = Convert.ToSingle(numero);

      // Pedir la opción
      Console.Write("Ingrese segundo valor: ");
      numero = Console.ReadLine();
      b = Convert.ToSingle(numero);

      r = a - b;

      // Regresamos el resultado.
      return r;
    }

    // Funciones que reciben valores
    static void Multiplicacion(float a, float b)
    {
      // variables
      float r;

      // Calculo
      r = a * b;

      // Mostrar valor
      Console.WriteLine("El resultado es {0}", r);
    }

    // Funciones que reciben valores y devuelven un valor

    static float Division(float dividendo, float divisor)
    {
      //variables
      float r = 0;

      if (divisor == 0)
      {
        Console.WriteLine("No es posible dividir entre 0");
        return 0.0f;
      }
      else
      {
        r = dividendo / divisor;
        return r;
      }
    }

    // FUNCION PRINCIPAL

    static void Main(string[] args)
    {
      int opcion = 0;
      string valor = "";

      // Invocar función Menú
      Menu();

      // Pedir la opción
      Console.Write("Selecciona una opción: ");
      valor = Console.ReadLine();

      opcion = Convert.ToInt32(valor);

      switch (opcion)
      {
        case 1:
          Suma();
          break;

        case 2:
          float resultado = Resta();
          Console.WriteLine("El resultado de la resta es {0}", resultado);
          break;

        case 3:
          // Variables
          float a = 0;
          float b = 0;
          string numero = "";

          // Pedir la opción
          Console.Write("Ingrese primer valor: ");
          numero = Console.ReadLine();
          a = Convert.ToSingle(numero);

          // Pedir la opción
          Console.Write("Ingrese segundo valor: ");
          numero = Console.ReadLine();
          b = Convert.ToSingle(numero);

          // Invocar a la funcion multiplicacion
          Multiplicacion(a, b);
          break;

        case 4:
          // Variables
          float n1 = 0;
          float n2 = 0;
          float division = 0;
          string dato = "";

          // Pedir la opción
          Console.Write("Ingrese primer valor: ");
          dato = Console.ReadLine();
          n1 = Convert.ToSingle(dato);

          // Pedir la opción
          Console.Write("Ingrese segundo valor: ");
          dato = Console.ReadLine();
          n2 = Convert.ToSingle(dato);

          // Pasar parametros y obtener un resultado
          division = Division(n1, n2);

          // Imprimir el resultado
          Console.WriteLine("La division es {0}", division);

          break;

        default:
          Console.WriteLine("Opción no valida...");
          break;
      }
    }
  }
}
