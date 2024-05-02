using System;

namespace EjercicioHerencia
{
    // Clase derivada que hereda de Operaciones
    public class Calculos : Operaciones
    {

        // Método para imprimir resultados de operaciones
        public void Imprimir(double areaRectangulo, double perimetroRectangulo, double volumenCubo)
        {
            Console.WriteLine("Resultados de las Operaciones:");
            Console.WriteLine($"Área del rectángulo: {areaRectangulo}");
            Console.WriteLine($"Perímetro del rectángulo: {perimetroRectangulo}");
            Console.WriteLine($"Volumen del cubo: {volumenCubo}");
        }
    }
}
