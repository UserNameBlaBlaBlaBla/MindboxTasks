using Figures.Exceptions.Circle;

namespace Figures.Models
{
    /// <summary>
    /// Круг
    /// </summary>
    public class Circle : BaseFigure
    {
        /// <summary>
        /// Радиус
        /// </summary>
        public double Raduis { get; set; }

        public override double Square => Math.PI * Math.Pow(Raduis, 2);

        /// <summary>
        /// Конструктор круга
        /// </summary>
        /// <param name="radius">Радиус</param>
        /// <exception cref="NegativeCircleRadiusException"></exception>
        /// <exception cref="ZeroCircleRadiusException"></exception>
        public Circle(double radius)
        {
            if (radius < 0)
                throw new NegativeCircleRadiusException();
            if (radius == 0)
                throw new ZeroCircleRadiusException();
            Raduis = radius;
        }
    }
}
