using System;
using System.Collections.Generic;

namespace ListasEnlazadas
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
       * List<T> en .Net es la alternativa en Java de ArrayList<T>.
       * Esto significa que esto es como envoltura de una matriz. Asi que
       * se asigna en la memoria como un bloque de datos contiguos.
       * Si el tamaño de los datos asignados supera los 85k bytes, se movera a
       * Large Object Head. Dependiendo del tamaño, esto puede conducir a la
       * fragmentacion del monton (una forma leve de perdida de memoria). Pero al
       * mismo tiempo, si el tamaño es <84k, esto proporciona una representacion muy
       * compacta y de acceso rapido en la memoria.
       */
      List<Object> lista = new List<Object>();

      /*
       * LinkedList<T> es una colección basada en punteros de nodo. En .Net está
       * en implementacion doblemente enlazada. Esto significa que los elementos
       * anteriores / siguientes tienen un enlace al elemento actual. Y los datos
       * están fragmentados: los diferentes objetos de la lista se pueden ubicar
       * en diferentes lugares de la RAM. También habrá más memoria utilizada para
       * LinkedList<T> que para List<T> o Array.
       */

      LinkedList<String> nodos = new LinkedList<string>();

    
    }
  }
}
