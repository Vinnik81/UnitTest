namespace GeometryLibrary_HW.Test
{
    public class TriangleTests
    {
        [Fact]
        public void CalculateArea_ReturnsCorrectArea_Triangle() // Вычисление площади возвращает правильную площадь треугольника
        {
            // Arrange
            double a = 3, b = 4, c = 5;
            Triangle triangle = new Triangle(a, b, c);
            // Act
            double area = triangle.CalculateArea();
            // Assert
            Assert.Equal(6, area);
        }

        [Fact]
        public void IsRightTriangle_ReturnsTrueForRightTriangle() // Верно ли возвращение прямоугольного треугольника для прямоугольного треугольника
        {
            // Arrange
            double a = 3, b = 4, c = 5;
            Triangle triangle = new Triangle(a, b, c);
            // Act
            bool isRightTriangle = triangle.IsRightTriangle();
            // Assert
            Assert.True(isRightTriangle);
        }

        [Fact]
        public void IsRightTriangle_ReturnsFalseForNonRightTriangle() // Прямоугольный треугольник возвращает ложь для непрямоугольного треугольника
        {
            // Arrange
            double a = 2, b = 3, c = 4;
            Triangle triangle = new Triangle(a, b, c);
            // Act
            bool isRightTriangle = triangle.IsRightTriangle();
            // Assert
            Assert.False(isRightTriangle);
        }
    }
}
