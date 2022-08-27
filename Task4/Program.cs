// НАЙТИ РАССТОЯНИЕ МЕЖДУ ТОЧКАМИ В ПРОСТРАНСТВЕ 2D

Console.WriteLine("Введите координату X первой точки");
double x1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Y первой точки");
double y1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату X второй точки");
double x2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Y второй точки");
double y2 = double.Parse(Console.ReadLine());
// a это первый катет
// b это второй катет
// с это гипотенуза
double a = y1 - y2;
double b = x1 - x2;
double result = a*a + b*b;
double c = Math.Sqrt(result);
Console.Write("Расстояние между точками = ");
Console.WriteLine(c);