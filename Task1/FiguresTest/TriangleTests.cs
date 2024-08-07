using Figures.Exceptions.Triangle;
using Figures.Factories;
using Figures.Models.Triangles;

namespace FiguresTest
{
    [TestFixture]
    public class TriangleTests
    {
        private const double _delta = 0.01;

        [Test]
        public void CreateTriangle()
        {
            var triangle = TriangleFactory.CreateTriangle(2, 2, 3);
            Assert.That(triangle, Is.TypeOf<Triangle>());
        }

        [Test]
        public void CreateRightTriangle()
        {
            var triangle = TriangleFactory.CreateTriangle(3, 4, 5);
            Assert.That(triangle, Is.TypeOf<RightTriangle>());
        }

        [Test]
        public void CreateTriangle_ExceptionNegativeSide1()
        {
            Assert.Catch<NegativeTriangleSideException>(() => TriangleFactory.CreateTriangle(-1, 2, 3));
        }

        [Test]
        public void CreateTriangle_ExceptionNegativeSide2()
        {
            Assert.Catch<NegativeTriangleSideException>(() => TriangleFactory.CreateTriangle(1, -2, 3));
        }

        [Test]
        public void CreateTriangle_ExceptionNegativeSide3()
        {
            Assert.Catch<NegativeTriangleSideException>(() => TriangleFactory.CreateTriangle(1, 2, -3));
        }

        [Test]
        public void CreateTriangle_ExceptionZeroSide1()
        {
            Assert.Catch<ZeroTriangleSideException>(() => TriangleFactory.CreateTriangle(0, 2, 3));
        }

        [Test]
        public void CreateTriangle_ExceptionZeroSide2()
        {
            Assert.Catch<ZeroTriangleSideException>(() => TriangleFactory.CreateTriangle(1, 0, 3));
        }

        [Test]
        public void CreateTriangle_ExceptionZeroSide3()
        {
            Assert.Catch<ZeroTriangleSideException>(() => TriangleFactory.CreateTriangle(1, 2, 0));
        }

        [Test]
        public void CreateTriangle_ExceptionExistBySides1()
        {
            Assert.Catch<TriangleExistBySidesException>(() => TriangleFactory.CreateTriangle(6, 2, 3));
        }

        [Test]
        public void CreateTriangle_ExceptionExistBySides2()
        {
            Assert.Catch<TriangleExistBySidesException>(() => TriangleFactory.CreateTriangle(1, 5, 3));
        }

        [Test]
        public void CreateTriangle_ExceptionExistBySides3()
        {
            Assert.Catch<TriangleExistBySidesException>(() => TriangleFactory.CreateTriangle(1, 2, 4));
        }

        [Test]
        public void Triangle_Sqaure()
        {
            var sideA = 2;
            var sideB = 2;
            var sideC = 3;
            var semiperimeter = (sideA + sideB + sideC) / 2.0;
            var semiperimeterA = semiperimeter - sideA;
            var semiperimeterB = semiperimeter - sideB;
            var semiperimeterC = semiperimeter - sideC;
            var square = Math.Sqrt(semiperimeter * semiperimeterA * semiperimeterB * semiperimeterC);
            var triangle = TriangleFactory.CreateTriangle(sideA, sideB, sideC);
            Assert.That(triangle, Is.TypeOf<Triangle>());
            Assert.That(triangle.Square, Is.EqualTo(square).Within(_delta));
        }

        [Test]
        public void RightTriangle_Sqaure()
        {
            var cathet1 = 3;
            var cathet2 = 4;
            var hypotenuse = 5;
            var rightTriangle = TriangleFactory.CreateTriangle(hypotenuse, cathet1, cathet2);
            Assert.That(rightTriangle, Is.TypeOf<RightTriangle>());
            Assert.That(rightTriangle.Square, Is.EqualTo(cathet1 * cathet2 / 2.0).Within(_delta));
        }
    }
}
