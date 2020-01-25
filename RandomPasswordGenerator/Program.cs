using System;
using System.Text;

namespace RandomPasswordGenerator
{
  class Program
  {
    // Definicion de constantes
    // La palabra clave "const" se usa para declarar un campo constante o una local
    // constante. Los campos locales constantes no son variables y no se pueden
    // modificar.

    private const string CapitalLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

    private const string SmallLetters = "abcdefghijklmnopqrstuvwxyz";

    private const string Digits = "0123456789";

    private const string SpecialChars = "~!@#$%^&*()_+=`{}[]\\|':;.,/?<>";

    private const string AllChars = CapitalLetters + SmallLetters + Digits + SpecialChars;

    // La clase Random genera numeros seudoaleatorios que cumplen determinados requisitos
    // estadisticos de aleatoriedad.

    private static Random rnd = new Random();

    private static void InsertAtRandomPosition( StringBuilder password, char character )
    {
      int randomPosition = rnd.Next( password.Length + 1 );
      password.Insert(randomPosition, character);
    }

    private static char GenerateChar( string availableChars )
    {
      int randomIndex = rnd.Next( availableChars.Length );
      char randomChar = availableChars[randomIndex];
      return randomChar;
    }

    static void Main(string[] args)
    {
      // Los objetos StringBuilder son mutables, pueden ser modificados, no es
      // necesario que internamente se cree un nuevo objeto en memoria cada vez que
      // se modifique su valor, en cambio se opta por expandir el espacio de memoria
      // ya asignado segun sea necesario.

      StringBuilder password = new StringBuilder();

      // Generar dos letras aleatorias mayusculas
      for (int i = 1; i <= 2; i++)
      {
        char capitalLetter = GenerateChar(CapitalLetters);
        InsertAtRandomPosition(password, capitalLetter);
      }

      // Generar dos letras aleatorias mayusculas
      for (int i = 1; i <= 2; i++)
      {
        char capitalLetter = GenerateChar(CapitalLetters);
        InsertAtRandomPosition(password, capitalLetter);
      }

      // Generar dos letras aleatorias minusculas
      for (int i = 1; i <= 2; i++)
      {
        char smallLetter = GenerateChar(SmallLetters);
        InsertAtRandomPosition(password, smallLetter);
      }

      // Generar un digito aleatorio
      char digit = GenerateChar(Digits);
      InsertAtRandomPosition(password, digit);

      // Generar tres caracteres especiales
      for (int i = 1; i <= 3; i++)
      {
        char specialChar = GenerateChar(SpecialChars);
        InsertAtRandomPosition(password, specialChar);
      }

      // Generar algunos caracteres aleatorios ( entre 0 y  7 )
      int count = rnd.Next(8);
      for (int i = 0; i <= count; i++)
      {
        char specialChar = GenerateChar(AllChars);
        InsertAtRandomPosition(password, specialChar);
      }

      Console.WriteLine(password);

    }
  }
}
