using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int CantidadPersonas = 0, BajoPeso = 0, PesoIdeal = 0, SobrePeso = 0, Obesidad = 0, opcion = 0, opcion2 = 0;
            double Peso = 0, Altura = 0, IMC = 0;
            bool Funcionar = true, Menu = true;

            while (Funcionar)
            {
                Menu = true;
                Console.Clear();
                Console.WriteLine("#############################################");
                Console.WriteLine("##               Bienvenido               ###");
                Console.WriteLine("#############################################\n");

                Console.Write("Por favor ingrese la cantidad de personas a evaluar: ");
                CantidadPersonas = int.Parse(Console.ReadLine());
                Console.Write("\nRecuerde que el IMC se calcula con base a los datos del peso y la altura del usuario");

                for (int i = 1; i <= CantidadPersonas; i++)
                {
                    Console.WriteLine("\nPor favor ingrese el peso de la persona {0}: ", i);
                    Peso = double.Parse(Console.ReadLine());
                    Console.WriteLine("\nPor favor ingrese la altura (en metros) de la persona {0}: ", i);
                    Altura = double.Parse(Console.ReadLine());

                    IMC = Peso / (Math.Pow(Altura, 2));

                    if (IMC < 18.5)
                    {
                        BajoPeso++;
                    }
                    else if (IMC <= 24.9)
                    {
                        PesoIdeal++;
                    }
                    else if (IMC <= 29.9)
                    {
                        SobrePeso++;
                    }
                    else
                    {
                        Obesidad++;
                    }
                }

                while (Menu)
                {
                    Console.Clear();
                    Console.WriteLine("#############################################");
                    Console.WriteLine("##                  MENU                 ###");
                    Console.WriteLine("#############################################\n");
                    Console.WriteLine("\nPor Favor escoja la opción");
                    Console.WriteLine("1.Obtener los datos especificos");
                    Console.WriteLine("2.Calcular nuevos datos");
                    Console.WriteLine("3.Finalizar el programa\n");

                    opcion = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Hay un total de {0} personas con bajo peso en su IMC", BajoPeso);
                            Console.WriteLine("Hay un total de {0} personas con peso ideal en su IMC", PesoIdeal);
                            Console.WriteLine("Hay un total de {0} personas con sobre peso en su IMC", SobrePeso);
                            Console.WriteLine("Hay un total de {0} personas con obesidad en su IMC", Obesidad);
                            Console.WriteLine("\nUse cualquier tecla para continuar");
                            Console.ReadKey();

                            break;
                        case 2:

                            Console.WriteLine("\n1.Agregar datos nuevos");
                            Console.WriteLine("2.Borrar datos actuales e iniciar de nuevo");
                            opcion2 = int.Parse(Console.ReadLine());
                            switch (opcion2)
                            {
                                case 1:
                                    Console.WriteLine("El programa iniciara nuevamete, por favor agregue los nuevos datos");
                                    Console.WriteLine("use cualquier tecla para continuar");
                                    Console.ReadKey();
                                    Menu = false;
                                    break;
                                case 2:
                                    Console.WriteLine("El programa iniciara nuevamete, por favor ingrese los datos de nuevo");
                                    Console.WriteLine("use cualquier tecla para continuar");
                                    BajoPeso = 0;
                                    PesoIdeal = 0;
                                    SobrePeso = 0;
                                    Obesidad = 0;
                                    Console.ReadKey();
                                    Menu = false;
                                    break;
                                default:
                                    Console.WriteLine("Erro, por favor empiece de nuevo");
                                    break;
                            }

                            break;
                        case 3:
                            Console.WriteLine("Gracias por su atención, hasta luego");
                            Menu = false;
                            Funcionar = false;
                            break;

                        default:
                            Console.WriteLine("Por Favor ingrese una opción correcta");
                            break;
                    }
                }
            }

        }
    }
}
