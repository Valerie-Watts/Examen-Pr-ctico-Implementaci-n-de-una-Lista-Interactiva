using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasEjemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista lista = new Lista("Alumnos"); //lista de alumnos
            int opt;
            string nombre;
            string seguir; 
            

            //Crear una lista ya llena
            lista.InsertarUltimo("Chepe");
            lista.InsertarUltimo("Gina");
            lista.InsertarUltimo("Alex");
            lista.InsertarUltimo("Anton");
            lista.InsertarUltimo("George");


            Console.WriteLine("\nLista de Alumnos"); 


            do 
            {
                Console.WriteLine("\nQue desea realizar en la lista: \n" + "1. Agregar elemento al inicio\n" + "2. Agregar elemento al final");//mostrar las opciones que puedes elegir
                Console.WriteLine("3. Eliminar elemento al inicio\n" + "4. Eliminiar el ultimo elemento\n" + "5. Mostrar la lista\n" + "6. Salir");
                opt = Convert.ToInt32(Console.ReadLine()); //pedir que el usuario ingrees un numero

                switch (opt)
                {
                    case 1:
                        Console.WriteLine("Ingrese el nombre del alumno: "); //ingresar nombre al inicio
                       nombre =  Console.ReadLine(); 

                        lista.InsertarPrimero(nombre);
                        Console.WriteLine("Se ha agregado al inicio: " + nombre);

                        lista.Imprimir(); 

                        break; 

                    case 2:
                        Console.WriteLine("Ingrese el nombre del alumno: ");//ingresar al final
                        nombre = Console.ReadLine();

                        lista.InsertarUltimo(nombre);
                        Console.WriteLine("Se ha agregado al final: " + nombre);

                        lista.Imprimir();

                        break;
                    case 3:
                        Console.WriteLine(lista.BorrarPrimero()+ " ha sido borrada de la lista."); //borrar al inicio
                        lista.Imprimir();
                        break;
                    case 4:
                        Console.WriteLine(lista.BorrarUltimo() + " ha sido borrada de la lista."); //borrar al final
                        lista.Imprimir();
                        break;
                    case 5:
                        lista.Imprimir(); //imprimir la lista

                        break;
                    case 6:
                        Console.WriteLine("Adios");  //salir del programa
                        seguir = "n"; 

                        return;
                    default:
                        break;
                }

                Console.WriteLine("\nDesea seguir (y/n)");//pregutna si desea continuar
                seguir = Console.ReadLine(); 

            } while (seguir == "Y" || seguir == "y"); //continua mientras se siga eligiendo "Y" o "y"

            Console.WriteLine("Adios"); //despedirse

            
        }
    }
}
