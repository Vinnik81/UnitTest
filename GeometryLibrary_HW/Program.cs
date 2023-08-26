using GeometryLibrary_HW;

Console.Write("Введите радиус круга: ");
double radius = double.Parse(Console.ReadLine());

IShape shape = new Circle(radius);
var areaC = shape.CalculateArea();
Console.WriteLine($"Площадь круга равна: {areaC}");

Console.Write("Введите сторону a: ");
double a = double.Parse(Console.ReadLine());
Console.Write("Введите сторону b: ");
double b = double.Parse(Console.ReadLine());
Console.Write("Введите сторону c: ");
double c = double.Parse(Console.ReadLine());

IShape shape1 = new Triangle(a, b, c);
var areaT = shape1.CalculateArea();
if (shape1 is Triangle triangle)
{
    bool isRightTriangle = triangle.IsRightTriangle();
    if (isRightTriangle) Console.WriteLine("Треугольник прямоугольный.");
    else Console.WriteLine("Треугольник не прямоугольный.");
}
Console.WriteLine($"Площадь треугольника равна: {areaT}");
