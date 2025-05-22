using System.Drawing;

namespace Ejercicio1_procedimental
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Definicion de Variables
            int Contador;
            int Acumulador;
            int Maximo;
            int Minimo;
            double Promedio;

            int Cantidad;
            #endregion

            #region Inicializar valores
            Contador = 0;
            Acumulador = 0;
            Maximo = 0;
            Minimo = 0;
            #endregion

            Console.WriteLine("Ingrese la cantidad de numeros a entrar.");
            Cantidad = Convert.ToInt32(Console.ReadLine());

            #region Iteración de Valores
            for (int n = 0; n < Cantidad; n++)
            {
                Console.WriteLine($"Ingrese el número {n + 1}");
                int numero = Convert.ToInt32(Console.ReadLine());

                Acumulador += numero;

                #region Comprobar valor Mayor y Menor
                if (n == 0 || Maximo < numero)
                {
                    Maximo = numero;
                }
                if (n == 0 || Minimo > numero)
                {
                    Minimo = numero;
                }
                #endregion
                Contador++;
            }

            #region Calcular Promedio
            Promedio = 1d * Acumulador / Contador;
            #endregion

            #region Escribir Resultados
            if (Contador > 0)
            {
                Console.WriteLine($"El promedio de los numeros es: {Promedio}");
                Console.WriteLine($"El mayor es {Maximo}, el menor es {Minimo}");
            }
            else
            {
                Console.WriteLine("No se ingresó ningun valor");
            }
            #endregion
        }
    }
}
