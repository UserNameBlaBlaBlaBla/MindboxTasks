namespace Figures.Models.Triangles
{
    /// <summary>
    /// Прямоугольный треугольник
    /// </summary>
    public class RightTriangle : Triangle
    {
        public double Hypotenuse
        {
            get => SideA;
            set => SideA = value;
        }

        public double Cathet1
        {
            get => SideB;
            set => SideB = value;
        }

        public double Cathet2
        {
            get => SideC;
            set => SideC = value;
        }

        public override double Square => Cathet1 * Cathet2 / 2.0;

        /// <summary>
        /// Конструктор прямоугольного треугольника
        /// </summary>
        /// <param name="hypotenuse"></param>
        /// <param name="cathet1"></param>
        /// <param name="cathet2"></param>
        public RightTriangle(double hypotenuse, double cathet1, double cathet2) : base(hypotenuse, cathet1, cathet2)
        {
        }
    }
}
