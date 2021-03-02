using System;

namespace Funciones_de_numeros_primos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su edad: ");
            int edad1= Int32.Parse(Console.ReadLine());
            string usuario= edad(edad1);
            Console.WriteLine("El usuario " + usuario);
        }
        static string edad(int edadusuario)
        {
            if (edadusuario <= 3){
            return "Es un bebe";
            }
            if (edadusuario > 3 && edadusuario <=15){
                return "Es un Niño";
           }
           if (edadusuario > 15 && edadusuario <= 25){
               return "Es un Joven";
           }
           if (edadusuario > 25 && edadusuario <= 40){
               return "Es Adulto";
           }
           if (edadusuario > 40 && edadusuario <= 50){
               return "Es Señor";
            }
            if (edadusuario > 50){
                return "Es Anciano";
            }
            return "";
        }
    
    }
}