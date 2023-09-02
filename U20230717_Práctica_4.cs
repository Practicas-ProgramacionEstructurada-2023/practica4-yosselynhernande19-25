
using System.ComponentModel;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
        Console.WriteLine("\n***************Sintaxis de estructura de control selectiva en C#**********");
        Console.WriteLine("\nOPCIONES:");
        Console.WriteLine("\n1.Determinar si el numero es positivo, negativo o igual a cero: ");
        Console.WriteLine("\n2.Motrar fecha y hora actual:");
        Console.WriteLine("\n3.Determianr si puede votar y conducir ilegalmente:");
        Console.WriteLine("\n4. Determinar si el numero es par o impar:");
        Console.WriteLine("\nElija una opcion:");
        int opcion=Convert.ToInt32(Console.ReadLine());

            if (opcion ==1){
                Console.WriteLine("Ingrese un numero");
                int numero = Convert.ToInt32(Console.ReadLine());
        
                if (numero > 0){

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nSu numero es positivo.");
                }
  
                else if (numero < 0)
                {
                Console.ForegroundColor = ConsoleColor.Red;  
                Console.WriteLine("\nSu numero es negativo.");  
                }

         
                else{
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nSu numero es igual a cero.");
                }
           }  
        
                else if (opcion ==2)
                {
                Console.ForegroundColor = ConsoleColor.Red;
                DateTime FechaHora = DateTime.Now;
                Console.WriteLine("\nLa fecha y hora actual es: " + FechaHora + "\n");

                 }

                 else
                 {
                    switch (opcion){
                    case 3:
                    Console.WriteLine("\nIngrese su edad:");
                    int edad = Convert.ToInt32(Console.ReadLine());

                    if (edad >= 18)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nEres mayor de edad, puedes votar y conducir ilegalmente.\n"); 
                    }
    
                     else
                    {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nNo eres mayor de edad, no puedes votar ni conducir legalmente.\n"); 
                    }
                     break;

                    case 4:
                     Console.WriteLine("\nIngrese un numero");
                     int numero = Convert.ToInt32(Console.ReadLine());

                     if (numero % 2 ==0)
                    {
                         Console.ForegroundColor = ConsoleColor.Red;
                         Console.WriteLine("\nE l numero ingresado es impar");
                    }
                    break;
                    default:
                         Console.WriteLine("\nOpcion invalido, intente de nuevo.\n");
                    break;  
                }


            } 
            Console.ReadKey();
            Console.ResetColor();
        }
    }
}
