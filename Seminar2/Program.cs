//Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Обязательна проверка на ввод чисел больше/меньше 3-х знаков
//456 -> 5
//782 -> 8
//918 -> 1
Console.Write("Введите трехзначное число: ");
string? number = Console.ReadLine();
int num = 0;
while(!int.TryParse(number, out num) || num < 100 || num >= 1000)
{
    Console.WriteLine("Введеное выражение не является трехзначным числом");
    Console.Write("Введите трехзначное число: ");
    number = Console.ReadLine();
}
num = (num - num/100*100) / 10;
Console.Write($"Вторая цифра введенного числа: {num}");

//Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Берем числа до 100000
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Введи число");
int number = Convert.ToInt32(Console.ReadLine());
string str = Convert.ToString(number);
if (str.Length < 3)
{
Console.WriteLine("Третьей цифры нет");
}
Console.WriteLine($"{str[2]}");

//Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным. Обязательна проверка на ввод числа <1 и >7
//6 -> да
//7 -> да
//1 -> нет

Console.Write("Введите номер дня недели: ");
string? day = Console.ReadLine();
int weekday = 0;
while(!int.TryParse(day, out weekday) || weekday < 1 || weekday > 7)
{
    Console.Write("Введите число от 1 до 7: ");
    day = Console.ReadLine();
}
if (weekday >= 6) Console.WriteLine("Выходной!!");
else Console.WriteLine("Мучительные будни(");