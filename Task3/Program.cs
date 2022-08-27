// ЗАДАТЬ НОМЕР ЧЕТВЕРТИ. ПОКАЗАТЬ ДИАПАЗОНЫ ДЛЯ ВОЗМОЖНЫХ КООРДИНАТ

Console.WriteLine("Введите номер четверти: 1, 2, 3 или 4");
int number = int.Parse(Console.ReadLine());
if(number == 1)
{
    Console.WriteLine("Выбрана первая четверть.");
    Console.WriteLine("Диапазоны возможных координат: ");
    Console.WriteLine("X > 0");
    Console.WriteLine("Y > 0");
}
if(number == 2)
{
    Console.WriteLine("Выбрана вторая четверть.");
    Console.WriteLine("Диапазоны возможных координат: ");
    Console.WriteLine("X < 0");
    Console.WriteLine("Y > 0");
}
if(number == 3)
{
    Console.WriteLine("Выбрана третья четверть.");
    Console.WriteLine("Диапазоны возможных координат: ");
    Console.WriteLine("X < 0");
    Console.WriteLine("Y < 0");
}
if(number == 4)
{
    Console.WriteLine("Выбрана четвертая четверть.");
    Console.WriteLine("Диапазоны возможных координат: ");
    Console.WriteLine("X > 0");
    Console.WriteLine("Y < 0");
}
