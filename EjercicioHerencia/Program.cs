using System;

namespace EjercicioHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear instancia de Calculos (que hereda de Operaciones)
            Calculos calculos = new Calculos();


            Console.WriteLine("******** Cálculos Varios *********");
            // Pedir dos números al usuario
            Console.Write("Ingrese el primer número: ");
            double numero1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
                // Realizar operaciones y obtener resultados
            double areaRectangulo = calculos.AreaRectangulo(numero1, numero2);
            double perimetroRectangulo = calculos.PerimetroRectangulo(numero1, numero2);
            double volumenCubo = calculos.VolumenCubo(numero1);

            // Imprimir resultados usando el método Imprimir
            calculos.Imprimir(areaRectangulo, perimetroRectangulo, volumenCubo);
        }
    }
}