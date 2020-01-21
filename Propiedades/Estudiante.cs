using System;
namespace Propiedades
{
  public class Estudiante
  {
    // Para poder asignar propiedades se definen como publicas
    // para que cualquier clase tenga acceso a estas propiedades.
    // Para poder obtener y asignar datos se debe utilizar las palabras get; set;
    // Con get se obtiene y con set se hace la asignacion
    // Estas propiedades tambien se pueden inicializar

    private String apellido;

    public String Nombre { get; set; }

    // Esta es otra forma de asignar get y set a las propiedades

    public String Apellido
    {
      get { return apellido; }
      set { apellido = value; }
    }

    public int Edad { get; set; }

    public double Calificacion { get; set; }

  }
}
