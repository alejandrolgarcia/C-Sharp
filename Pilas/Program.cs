using System;
using System.Collections;

namespace Pilas
{
  class Program
  {
    static void Main(string[] args)
    {
      // Variables
      int opcion = 0;
      string valor = "";
      int numero = 0;
      bool encontrado = false;

      //Crear el stack
      Stack miPila = new Stack();

      do
      {
        Console.Clear();

        //Mostrar el menu
        Console.WriteLine("1. Push");
        Console.WriteLine("2. Pop");
        Console.WriteLine("3. Clear");
        Console.WriteLine("4. Contains");
        Console.WriteLine("5. Mostrar valores de la pila");
        Console.WriteLine("6. Salir");
        Console.Write("Seleccione una opcion: ");
        valor = Console.ReadLine();
        opcion = Convert.ToInt32(valor);


        switch (opcion)
        {
          case 1:
            //Pedir valor a introducir
            Console.WriteLine("Ingrese el valor a cargar a la pila");
            valor = Console.ReadLine();
            numero = Convert.ToInt32(valor);

            // Adicionar el valor a la pila
            miPila.Push(numero);
            break;

          case 2:
            //Obtener un elemento
            numero = (int)miPila.Pop();

            //Mostrar el elemento
            Console.WriteLine("El valor obtenido es: {0}", numero);
            Console.ReadKey();
            break;

          case 3:
            //Limpiar el contenido de la pila(Stack)
            miPila.Clear();
            Console.WriteLine("Se limpio el contenido de la pila...");
            Console.ReadKey();
            break;

          case 4:
            Console.Write("Ingrese el valor a encontrar: ");
            valor = Console.ReadLine();
            numero = Convert.ToInt32(valor);

            // Validar si el elemento esta
            encontrado = miPila.Contains(numero);

            // Mostrar el resultado de la busqueda
            Console.WriteLine("Valor encontrado {0}", encontrado);
            break;

          case 5:
            //Mostrar informacion del stack
            Console.WriteLine("El Stack tiene {0} elementos", miPila.Count);
            foreach (int n in miPila)
            {
              Console.Write(" {0} ", n);
            }
            Console.WriteLine("\n-------------");
            Console.ReadKey();
            break;

          case 6:
            break;

          default:
            Console.WriteLine("Seleccione una opcion valida...");
            break;
        }

      } while (opcion != 6);
    }
  }
}
