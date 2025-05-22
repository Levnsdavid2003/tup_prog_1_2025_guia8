using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        #region Declaración de Variables
        static int contador;
        static int acumulador;
        static int Maximo;
        static int Minimo;
        #endregion

        #region Resolución del Problema
        static void RegistrarValor(int valor)
        {
            acumulador += valor;

            if (valor > Maximo || contador == 0)
            {
                Maximo = valor;
            }
            if (valor < Minimo || contador == 0)
            {
                Minimo = valor;
            }
            contador++;
        }
        static double CalcularPromedio()
        {
            double promedio = 0;
            if (contador > 0)
            {
                promedio = 1d * acumulador / contador;
            }
            return promedio;
        }
        #endregion

        #region Metodos de Pantalla

        static int MostrarPantallaSolicitarOpcionMenu()
        {
            Console.Clear();
            Console.WriteLine(
                @"Procesar Números

        1 - Procesar un solo número.
        2 - Procesar varios números.
        3 - Mostrar máximo y mínimo.
        4 - Mostrar promedio.
        5 - Mostrar cantidad de números ingresados.
        6 - Reiniciar variables.");
            int eleccion = Convert.ToInt32(Console.ReadLine());
            

            return eleccion;
        }
        static void SolicitarPantallaIngresarNumero()
        {
            Console.Clear();
            Console.WriteLine("\tSolicitud de Ingreso de Número\n");
            Console.WriteLine("Ingrese un número:");
            int valor = Convert.ToInt32(Console.ReadLine());
            RegistrarValor(valor);
        }
        static void MostrarMaximoyMinimo()
        {
            Console.Clear();
            Console.WriteLine("\t\t Mostrar Máximo y Minimo\n");
            Console.WriteLine($"El número máximo es: {Maximo}");
            Console.WriteLine($"El número minimo es: {Minimo}\n\n");
            Console.WriteLine("Presione cualquier tecla para salir.");
            Console.ReadKey();
        }

        static void ReiniciarValores()
        {
            contador = 0;
            acumulador = 0;
            Maximo = 0;
            Minimo = 0;
        }

        #endregion


        static void Main(string[] args)
        {

            int op = MostrarPantallaSolicitarOpcionMenu();

            while (op != -1)
            {
                switch (op)
                {
                    case 1:
                        SolicitarPantallaIngresarNumero();
                        break;
                    case 2:
                        break;
                    case 3:
                        MostrarMaximoyMinimo();
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        ReiniciarValores();
                        break;
                    default:
                        op = -1;
                        break;
                }
                op = MostrarPantallaSolicitarOpcionMenu();
            }













            //#region Inicializar valores
            //int cantidad;

            //contador = 0;
            //acumulador = 0;
            //#endregion

            //#region Leer cantidad de números a ingresar
            //Console.WriteLine("Ingrese la cantidad de numeros a entrar.");
            //cantidad = Convert.ToInt32(Console.ReadLine());
            //#endregion

            //#region Iteración de valores
            //for (int n = 0; n < cantidad; n++)
            //{
            //    #region Solicitar ingreso
            //    Console.WriteLine($"Ingrese el número {n + 1}");
            //    int numero = Convert.ToInt32(Console.ReadLine());
            //    RegistrarValor(numero);
            //    #endregion

            //    #region Verificar mayor y menor
            //    if (n == 0 || Maximo < numero)
            //    {
            //        Maximo = numero;
            //    }
            //    if (n == 0 || Minimo > numero)
            //    {
            //        Minimo = numero;
            //    }
            //    #endregion
            //    contador++;
            //}
            //#endregion

            //#region Mostrar Resultados
            //if (contador > 0)
            //{
            //    Console.WriteLine($"El promedio de los numeros es: {CalcularPromedio()}");
            //    Console.WriteLine($"El mayor es {Maximo}, el menor es {Minimo}");
            //}
            //else
            //{
            //    Console.WriteLine("No se ingresó ningun valor");
            //}
            //#endregion
        }
    }
}