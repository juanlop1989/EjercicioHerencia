using System;

namespace EjercicioHerencia
{
    // Clase padre con tres métodos para operaciones matemáticas
    public class Operaciones
    {
        // Método para calcular el área de un rectángulo
        public double AreaRectangulo(double largo, double ancho)
        {
            return largo * ancho;
        }

        // Método para calcular el perímetro de un rectángulo
        public double PerimetroRectangulo(double largo, double ancho)
        {
            return 2 * (largo + ancho);
        }

        // Método para calcular el volumen de un cubo
        public double VolumenCubo(double lado)
        {
            return Math.Pow(lado, 3);
        }
    }
}