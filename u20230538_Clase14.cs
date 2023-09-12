using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {

          //Declaracion de variables int para opciones.

          int opciones; 

          do
          {
                Console.WriteLine("\n\n                    MENU                      ");
                Console.WriteLine("1.Programa que sume los numeros pares hasta el 75.");
                Console.WriteLine("2.Lista de 9 numeros enteros y encontrar el numero mas grande.");
                Console.WriteLine("3.Tabla de multiplicar un numero n, del 1 al 12 y sumarle 2 al resultado.");
                Console.WriteLine("4.Salir del menu.");    
                Console.WriteLine("\nSeleccione una opcion (1-4): ");
                
                if (int.TryParse(Console.ReadLine(), out opciones))
                {
                   switch (opciones)
                   {
                    case 1: //Programa que suma los numeros pares hasta el numero 75. 
                        
                        int suma = 0; 

                        for (int i =2; i <= 75; i+=2)
                        {
                            suma += i;
                        }
                        Console.WriteLine("La suma de los numeros pares hasta el numero 75 es: " + suma); 

                        break;
                    case 2: //Lista de 9 numeros enteros encontrando el numero mas grande.
                        
                        //Creamos la lista de numeros enteros.
                        List<int> numeros = new List<int> {11,13,25,67,93,42,38,23,7,78}; 

                        //Variable para almacenar el numero mas grande.
                        int numeroMayor = int.MinValue; 

                        //Recorriendo la lista con el bucle foreach
                        foreach (int numero in numeros)
                        {
                            if (numero > numeroMayor)
                            {
                                numeroMayor = numero; 
                            }
                        } 
                        Console.WriteLine("El numero mas grande en la lista es: " + numeroMayor);
        
                        break;
                    case 3://Tabla de multiplicar un numero n, del 1 al 12 y sumarle 2 al resultado.
                        Console.WriteLine("Ingrese un numero para elaborar su tabla de multiplicacion:");
                        int numeroMulti=Convert.ToInt32(Console.ReadLine());

                        for (int i = 1; i <= 12 ; i++)
                        {
                            int multiplicacion = numeroMulti * i + 2;

                            Console.WriteLine($"{numeroMulti} x {i} = {multiplicacion}");
                        } 

                        break;
                    case 4:
                        break;            
                    default:
                       Console.ForegroundColor= ConsoleColor.Red; 
                        Console.WriteLine("Opcion no valida. Por favor, seleccione una opcion del (1-4)");
                        break;
                   }                                   
                }         
                else
                {
                    Console.ForegroundColor= ConsoleColor.Red;
                    Console.WriteLine("Entrada no valida. Debe ingresar una opcion valida (1-4).");
                }
                    Console.ResetColor();
          }     while (opciones !=4);          
        }
    }
}