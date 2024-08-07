namespace Figures
{
    public class Utils
    {
        /// <summary>
        /// Существует ли треугольник с заданными сторонами
        /// </summary>
        /// <param name="sideA"></param>
        /// <param name="sideB"></param>
        /// <param name="sideC"></param>
        /// <returns></returns>
        public static bool IsTriangleExistBySides(double sideA, double sideB, double sideC)
        {
            if (sideA + sideB < sideC)
                return false;
            if (sideA + sideC < sideB)
                return false;
            if (sideB + sideC < sideA)
                return false;
            return true;
        }

        /// <summary>
        /// Является ли треугольник с заданными сторонами прямоугольным
        /// </summary>
        /// <param name="hypotenuse">Гипотенуза</param>
        /// <param name="cathet1">Катет 1</param>
        /// <param name="cathet2">Катет 2</param>
        /// <returns></returns>
        public static bool IsTriangleRight(double hypotenuse, double cathet1, double cathet2)
        {
            return Math.Pow(hypotenuse, 2) == Math.Pow(cathet1, 2) + Math.Pow(cathet2, 2);
        }
    }
}
