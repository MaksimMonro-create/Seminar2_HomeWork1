// ПО ДВУМ ЗАДАННЫМ ЧИСЛАМ ПРОВЕРИТЬ, ЯВЛЯЕТСЯ ЛИ ОДНО ЧИСЛО КВАДРАТОМ ДРУГОГО

Console.WriteLine("Введите первое число");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = int.Parse(Console.ReadLine());
int result = number2 / number1;
Console.WriteLine("Сейчас будет осуществлена проверка, является ли второе число квадратом первого числа");
if(result == number1)
{
    Console.WriteLine("Второе число является квадратом первого числа");
}
else
{
    Console.WriteLine("Второе число не является квадратом первого числа");
}
