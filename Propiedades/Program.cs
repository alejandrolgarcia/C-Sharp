using System;

namespace Propiedades
{
  class Program
  {
    static void Main(string[] args)
    {
      // Crear un objeto del tipo estudiante
      // El objeto data contiene cada uno de los parametros de la clase
      var data = new Estudiante() {
          Nombre = "Alex",
          Apellido = "Hernan",
          Edad = 26,
          Calificacion = 5
      };

      var data1 = new Estudiante()
      {
        Nombre = "Marisabel",
        Apellido = "Roman",
        Edad = 30,
        Calificacion = 4
      };

      var data2 = new Estudiante()
      {
        Nombre = "Paola",
        Apellido = "Herrera",
        Edad = 18,
        Calificacion = 4.5
      };

      var data3 = new Estudiante()
      {
        Nombre = "Rosaura",
        Apellido = "Alvarado",
        Edad = 28,
        Calificacion = 2
      };

      var school = new School();
      school.AddStudent(data);
      school.AddStudent(data1);
      school.AddStudent(data2);
      school.AddStudent(data3);

      bool valor = false;

      do
      {
        Console.WriteLine("Ingrese el nombre");
        String nombre = Console.ReadLine();
        valor = school.buscarPorNombre(nombre);
      } while (true);
      //Console.ReadKey();
    }
  }
}
