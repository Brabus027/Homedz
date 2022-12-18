/*
"Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8"
*/

Console.Write("Введи число N=");
int N = Convert.ToInt32(Console.ReadLine());
int count = 1;
if (N>1)
{
  while (count<N)
  {
    Console.WriteLine(count+1);
    count=count+2;  
  }
}
else
{
Console.Write("Нет чётных чисел");
}