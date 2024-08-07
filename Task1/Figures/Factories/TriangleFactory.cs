using Figures.Models.Triangles;

namespace Figures.Factories
{
    /// <summary>
    /// Фабрика треугольников
    /// </summary>
    public class TriangleFactory
    {
        /// <summary>
        /// Создать треугольник с заданными сторонами
        /// </summary>
        /// <param name="sideA"></param>
        /// <param name="sideB"></param>
        /// <param name="sideC"></param>
        /// <returns></returns>
        public static Triangle CreateTriangle(double sideA, double sideB, double sideC)
        {
            if (Utils.IsTriangleRight(sideA, sideB, sideC))
                return new RightTriangle(sideA, sideB, sideC);
            if (Utils.IsTriangleRight(sideB, sideA, sideC))
                return new RightTriangle(sideB, sideA, sideC);
            if (Utils.IsTriangleRight(sideC, sideA, sideB))
                return new RightTriangle(sideC, sideA, sideB);
            return new Triangle(sideA, sideB, sideC);
        }
    }
}
