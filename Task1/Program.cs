// ДАНО ЧИСЛО, ОБОЗНАЧАЮЩЕЕ ДЕНЬ НЕДЕЛИ. ВЫЯСНИТЬ, ЯВЛЯЕТСЯ НОМЕР ДНЯ НЕДЕЛИ ВЫХОДНЫМ.

Console.WriteLine("Введите номер дня недели: 1, 2, 3, 4, 5, 6, 7");
//int number = new Random().Next(1, 7);
int number = int.Parse(Console.ReadLine());
if(number >= 6)
{
    Console.WriteLine("Сегодня выходной день недели");
}
else
{
    Console.WriteLine("Сегодня рабочий день недели");
}
