using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjRepaso3
{
    class Program
    {
        

        static void Main(string[] args)
        {

             bool Palindromo(string pali)
            {
                return pali.SequenceEqual(pali.Reverse());
            }
            //Ejercicio III
            //Crear una aplicación que indique, cuando el usuario ingresa una palabra, si ésta es un palíndromo.
            //Nota: Palíndromo son palabras que al derecho y al revés se leen igual, como "ananá".

            string _palabra = "";
            bool _palabraRev;

            
            Console.WriteLine("Ingrese una palabra");
            _palabra = Console.ReadLine();

            
            if (Palindromo(_palabra))
            {
                Console.WriteLine("La palabra es palíndromo");
            }
            else
            {
                Console.WriteLine("La palabra NO es palíndromo");
            }
            
            Console.ReadKey();






        }
    }
}
