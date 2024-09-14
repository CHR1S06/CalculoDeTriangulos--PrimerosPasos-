using CalculadoraDeTriangulos.Clases_App;
using System;

namespace CalculadoraDeTriangulos
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Se crea una instancia de la clase AppTriangulos
            AppTriangulos appTriangulos = new AppTriangulos();

            // Se llama al método Triangulos, que realiza el cálculo de áreas de los triángulos
            appTriangulos.Triangulos();
        }
    }
}
