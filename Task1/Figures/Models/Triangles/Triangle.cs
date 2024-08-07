using Figures.Exceptions.Triangle;

namespace Figures.Models.Triangles
{
    /// <summary>
    /// Треугольник
    /// </summary>
    public class Triangle : BaseFigure
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public override double Square => Math.Sqrt(Semiperimeter * SemiperimeterA * SemiperimeterB * SemiperimeterC); // формула Герона

        /// <summary>
        /// Полупериметр
        /// </summary>
        public double Semiperimeter => (SideA + SideB + SideC) / 2.0;

        /// <summary>
        /// Полупериметр с вычетом стороны А
        /// </summary>
        public double SemiperimeterA => Semiperimeter - SideA;

        /// <summary>
        /// Полупериметр с вычестом стороны B
        /// </summary>
        public double SemiperimeterB => Semiperimeter - SideB;

        /// <summary>
        /// Полупериметр с вычестом стороны C
        /// </summary>
        public double SemiperimeterC => Semiperimeter - SideC;

        /// <summary>
        /// Конструктор треугольника
        /// </summary>
        /// <param name="sideA"></param>
        /// <param name="sideB"></param>
        /// <param name="sideC"></param>
        /// <exception cref="NegativeTriangleSideException"></exception>
        /// <exception cref="ZeroTriangleSideException"></exception>
        public Triangle(double sideA, double sideB, double sideC)
        {
            List<double> sides = new List<double>() { sideA, sideB, sideC };

            if (sides.Any(x => x < 0))
                throw new NegativeTriangleSideException();
            if (sides.Any(x => x == 0))
                throw new ZeroTriangleSideException();

            if (!Utils.IsTriangleExistBySides(sideA, sideB, sideC))
                throw new TriangleExistBySidesException();

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }
    }
}
