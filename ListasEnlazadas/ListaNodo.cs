using System;
namespace ListasEnlazadas
{
  public class ListaNodo
  {
    // Esta clase tendra dos atributos
    private Nodo primero;
    private int size;

    // Metodo constructor
    public ListaNodo()
    {
      primero = null;
      size = 0;
    }

    public void addNodo(int dato)
    {
      // Agregamos el nodo en la coleccion de nodos
      Nodo nuevo = new Nodo(dato);

      Nodo valor1, valor2;

      // crear el nodo actual
      if (primero == null)
      {
        primero = nuevo;
        // apuntar al nodo siguiente
        nuevo.siguiente = null;
      }
      else
      {
        valor1 = primero;

        // verificar si valor1 es null, si es distinto es porque tiene datos
        while (valor1 != null)
        {
          valor2 = valor1.siguiente;

          // Condicion que verifica si el numero debe ir de primero
          if (nuevo.dato <= valor1.dato)
          {
            nuevo.siguiente = primero;
            primero = nuevo;
            break;
          }
          else
          {
            //Condicion que verifica si el numero entrante debe ir al ultimo
            if (nuevo.dato > valor1.dato && valor2 == null)
            {
              valor1.siguiente = nuevo;
              nuevo.siguiente = null;
              break;
            }
            else
            {
              // Condicion que evalua si el numero entrante debe ir en medio de otro nodo
              if (valor1.dato < nuevo.dato && valor2.dato >= nuevo.dato)
              {
                valor1.siguiente = nuevo;
                nuevo.siguiente = valor2;
                break;
              }
              else
              {
                valor1 = valor1.siguiente;
              }
            }
          }
        }
      }
    }
  }
}
