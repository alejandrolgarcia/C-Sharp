using System;
using System.Collections.Generic;

namespace Propiedades
{
  public class School
  {
    // Atributos
    private List<Estudiante> estudiantes;

    // Metodo constructor
    public School()
    {
      estudiantes = new List<Estudiante>();
    }

    // Metodo que recibe un parametro
    public void AddStudent(Estudiante nuevoEstudiante)
    {
      estudiantes.Add(nuevoEstudiante);
    }

    // Metodo recibe un parametro y devuelve true o false
    public bool buscarPorNombre(String nombre)
    {
      bool encontrado = false;
      int i = 0;

      while (encontrado == false && i < estudiantes.Count)
      {
        if (estudiantes[i].Nombre.Equals(nombre))
        {
          encontrado = true;
        }
        else
        {
          i++;
        }
      }

      if (encontrado)
      {
        Console.WriteLine("Nombre: " + estudiantes[i].Nombre + "\n"
          + "Apellido: " + estudiantes[i].Apellido + "\n"
          + "Edad: " + estudiantes[i].Edad + "\n"
          + "Calificacion: " + estudiantes[i].Calificacion);
        return false;
      }
      else
      {
        Console.WriteLine("No existe el nombre, intente nuevamente...");
        return true;
      }
    }
  }
}
