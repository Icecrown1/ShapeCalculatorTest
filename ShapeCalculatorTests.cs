namespace ShapeCalculatorLibrary.Tests
{
    [TestFixture]
    public class ShapeCalculatorTests
    {
        [Test]
        public void Circle_AreaCalculation_ReturnsCorrectArea()
        {
            // Arrange
            double radius = 5;
            var circle = new Circle(radius);
            var areaCalculator = new AreaCalculatorVisitor();

            // Act
            double area = circle.Accept(areaCalculator);

            // Assert
            double expectedArea = Math.PI * Math.Pow(radius, 2);
            Assert.AreEqual(expectedArea, area, 0.001); // Using delta for comparison
        }

        [Test]
        public void Triangle_AreaCalculation_ReturnsCorrectArea()
        {
            // Arrange
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            var triangle = new Triangle(sideA, sideB, sideC);
            var areaCalculator = new AreaCalculatorVisitor();

            // Act
            double area = triangle.Accept(areaCalculator);

            // Assert
            double expectedArea = 6;
            Assert.AreEqual(expectedArea, area, 0.001); // Using delta for comparison
        }

        [Test]
        public void Triangle_IsRightTriangle_ReturnsTrueForRightTriangle()
        {
            // Arrange
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            var triangle = new Triangle(sideA, sideB, sideC);

            // Act
            bool isRightTriangle = triangle.IsRightTriangle();

            // Assert
            Assert.IsTrue(isRightTriangle);
        }

        [Test]
        public void Triangle_IsRightTriangle_ReturnsFalseForNonRightTriangle()
        {
            // Arrange
            double sideA = 2;
            double sideB = 3;
            double sideC = 4;
            var triangle = new Triangle(sideA, sideB, sideC);

            // Act
            bool isRightTriangle = triangle.IsRightTriangle();

            // Assert
            Assert.IsFalse(isRightTriangle);
        }
    }
}
