using GeometryLibrary_HW;
using Xunit;

namespace GeometryLibrary_HW.Test
{
    public class CircleTests
    {
        [Fact]
        public void CalculateArea_ReturnsCorrectArea_Circle() //Вычисление площади возвращает правильную площадь круга
        {
            // Arrange
            double radius = 5;
            Circle circle = new Circle(radius);
            // Act
            double area = circle.CalculateArea();
            // Assert
            Assert.Equal(78.53981633974483, area);
        }
    }
}