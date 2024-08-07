using Figures.Exceptions.Circle;
using Figures.Models;

namespace FiguresTest
{
    [TestFixture]
    public class CircleTests
    {
        private const double _delta = 0.01;

        [Test]
        public void CreateCircle()
        {
            var radius = 3.0;
            var circle = new Circle(radius);
            Assert.That(circle.Raduis, Is.EqualTo(radius).Within(_delta));
        }

        [Test]
        public void CreateCircle_ExceptionZeroRadius()
        {
            Assert.Catch<ZeroCircleRadiusException>(() => new Circle(0));
        }

        [Test]
        public void CreateCircle_ExceptionNegativeRadius()
        {
            Assert.Catch<NegativeCircleRadiusException>(() => new Circle(-2.5));
        }

        [Test]
        public void Circle_Square()
        {
            var radius = 3.0;
            var circle = new Circle(radius);
            Assert.That(circle.Square, Is.EqualTo(Math.PI * Math.Pow(radius, 2)).Within(_delta));
        }
    }
}
