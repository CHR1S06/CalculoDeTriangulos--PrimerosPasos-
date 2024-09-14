using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CalculadoraDeTriangulos.Clases_App
{
    public class AppTriangulos
    {
        // Límite de área de un triángulo para determinar si excede el valor permitido
        private int LimiteTriangulo = 12;

        // Variables para contar cuántos triángulos exceden o no el límite
        private int TriangulosExcedidos = 0;
        private int TriangulosNoExcedidos = 0;

        // Método principal que calcula las áreas de los triángulos
        public void Triangulos()
        {
            Console.WriteLine("Bienvenido al programa de calculo de triangulos.\n");

            // Solicita la cantidad de triángulos a calcular
            Console.Write("Favor ingresar la cantidad de triangulos a calcular: ");
            int CantidadDeTriangulos;

            // Bucle para asegurarse de que se ingrese un número válido
            while (true)
            {
                try
                {
                    CantidadDeTriangulos = Convert.ToInt32(Console.ReadLine());
                    if (CantidadDeTriangulos > 0)
                    {
                        break;// Si el número es válido, sale del bucle
                    }
                    else
                    {
                        Console.WriteLine("Por favor ingrese una cantidad valida.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);// Muestra el error si hay un problema
                }
            }

            Console.Clear();
            Console.WriteLine("\nPor favor ingrese los datos de los triangulos:");
            double baseTriang;
            double areaTriang;

            // Bucle que procesa cada triángulo
            for (int i = 1; i <= CantidadDeTriangulos; i++)
            {
                Console.WriteLine($"Triangulo {i}:");

                // Solicita y valida la base del triángulo
                while (true)
                {
                    try
                    {
                        Console.Write("Base: ");
                        baseTriang = Convert.ToDouble(Console.ReadLine());
                        if (baseTriang > 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Por favor limitese a introducir una cantidad valida.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

                Console.Write("");//salto de linea
                double alturaTriang;

                // Solicita y valida la altura del triángulo
                while (true)
                {
                    try
                    {
                        Console.Write("Altura: ");
                        alturaTriang = Convert.ToDouble(Console.ReadLine());
                        if (alturaTriang > 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Por favor limitese a introducir una cantidad valida.");
                        }
                    }
                    catch (FormatException ex)  // Captura de una excepción más específica
                    {
                        Console.WriteLine($"Error de formato: {ex.Message}");  // Verifica si llega aquí
                    }
                    catch (OverflowException ex)  // Para valores fuera del rango de un int
                    {
                        Console.WriteLine($"Error de desbordamiento: {ex.Message}");
                    }
                    catch (Exception ex)  // Captura cualquier otro tipo de excepción
                    {
                        Console.WriteLine($"Error inesperado: {ex.Message}");
                    }
                }

                // Calcula el área del triángulo
                areaTriang = baseTriang * alturaTriang / 2;
                Console.WriteLine($"El area del triangulo:{areaTriang}\n");

                // Clasifica el triángulo según si excede o no el límite de área
                if (areaTriang > LimiteTriangulo)
                {
                    TriangulosExcedidos++;
                }
                else
                {
                    TriangulosNoExcedidos++;
                }
            }

            // Pausa el programa por 3 segundos y luego limpia la pantalla
            Thread.Sleep(3000);
            Console.Clear();

            // Llama al método que muestra los resultados
            ComprobacionDeTriangulos();
        }

        // Método que muestra cuántos triángulos excedieron o no el límite
        public void ComprobacionDeTriangulos()
        {
            Console.Clear();
            Console.WriteLine($"Los triangulo que excedieron el limite de area de 12uc son: {TriangulosExcedidos}");
            Console.WriteLine($"Los triangulo que no excedieron el limite de area son: {TriangulosNoExcedidos}");
        }
    }
}
