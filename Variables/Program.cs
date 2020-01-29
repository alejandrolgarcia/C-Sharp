using System;

namespace Variables
{
  class Program
  {
    static void Main(string[] args)
    {
      // float 7 digitos 32 bits
      // double 15-16 digitos 64 bits
      // decimal 28-29 digitos, 128 bits

      int year = Convert.ToInt32("20");
      double doble = 2.5;
      string nombre = "Joel";
      // Estructura de valor String
      String nombres = "Alex Joel";
      decimal decimals = 2.07M;
      float flotante = 8.0F;
      char letra = 'A';
      bool valor = true;
      // Estructura de valor Decimal
      Decimal dec = 28.9M;
      // Estructura de valor Boolean
      Boolean valor2 = false;
      Console.WriteLine(nombres + " {0} {1} {2} {3} {4}", year, doble, decimals, valor, letra);
    }
  }
}
