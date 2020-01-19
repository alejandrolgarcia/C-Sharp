using System;
using System.Collections.Generic;

namespace ClaseGenericaList
{
  class Program
  {
    static void Main(string[] args)
    {
      // Dentro del operador se indica el tipo de dato
      // Puede ser de tipo entero, string, objetos, etc.
      // Se puede inicializar asignandole la instancia de la misma clase
      // Si se le indica tipo Object, puede manejar cualquier tipo de dato.
      List<Object> lista = new List<Object>();

      // Con el metodo Add se agregan elementos a la lista
      // Como es de clase Object, se puede agregar cualquier tipo de dato
      lista.Add("Alejandro");
      lista.Add(32);
      lista.Add("Alejandro");
      lista.Add(true);
      lista.Add("Alejandro");
      lista.Add(567.23);

      // Para poder obtener una valor de la lista se puede indicar la posicion
      Console.WriteLine(lista[0]);
      Console.WriteLine(lista[2]);

      // Con el metodo Insert se puede insertar un valor en una posicion determinada.
      // el valor entero define la posicion.
      // Tener cuidado ya que si se indica una posicion que aun no existe, genera una excepcion.
      lista.Insert(2,"Johana");

      // La propiedad Count devuelve la cantidad de elementos que estan almacenados
      // en la lista
      Console.WriteLine(lista.Count);

      // El metodo IndexOf devuelve valor de tipo entero que es la posicion
      // Si le indicamos un segundo parametro es desde donde queremos que empiece a buscar
      // El tercer parametro indica hasta donde busque el elemento
      // Si el elemento no es encontrado devuelve -1, si lo encuentra devuelve 1
      Console.WriteLine(lista.IndexOf(32));
      Console.WriteLine(lista.IndexOf(32,2));
      Console.WriteLine(lista.IndexOf(32,0,3));

      // El metodo LastIndexOf obtiene el ultimo elemento de la lista aunque se repitan.
      Console.WriteLine(lista.LastIndexOf("Alejandro"));

      // El metodo Reverse revierte los elementos de la lista
      lista.Reverse();
      Console.WriteLine(lista.LastIndexOf("Alejandro"));

      // El metodo Contains busca un dato en la coleccion de datos y devuelve
      // true si es encontrado y false si no lo encuentra
      Console.WriteLine(lista.Contains(356));

      // El metodo Exists recibe como parametro un predicado y lo pasamos con la expresion lambda
      // devuelve true si es encontrado y false si no lo encuentra
      Console.WriteLine(lista.Exists(e => e.Equals("Alej")));

      // El metodo Remove sirve para eliminar un elemento, se le debe proporcionar
      // el elemento que queremos eliminar
      lista.Remove(32);
      Console.WriteLine(lista.Count);

      Console.WriteLine("- - - -");

      // El metodo ForEach sirve para recorrer la lista con una expresion lambda
      lista.ForEach(item => {
        Console.WriteLine(item);
      });

      Console.WriteLine("- - - -");

      // Tambien se puede usar el ciclo for para recorrer la lista si queremos obtener la posicion
      // Con el metodo Count se puede obtener la cantidad de elementos para detener
      // el ciclo for
      for (int i = 0; i < lista.Count; i++)
      {
        Console.WriteLine(lista[i]);
      }

      // Otra forma de utilizar el ciclo for
      int j = 0;
      for ( ; ; )
      {
        if (j < lista.Count)
        {
          Console.WriteLine(lista[j]);
          j++;
        }
        else
        {
          // break sirve para detener una vez no se cumpla la condicion de arriba.
          break;
        }
      }

      Console.WriteLine("- - - -");

      // Tambien se puede recorrer con la estructura basica foreach
      foreach (var item in lista)
      {
        Console.WriteLine(item);
      }

      // El metodo Clear limpia todos los elementos de la lista.
      lista.Clear();

      Console.WriteLine("Elementos de la lista:");

      lista.ForEach(item => {
        Console.WriteLine(item);
      });
    }
  }
}
