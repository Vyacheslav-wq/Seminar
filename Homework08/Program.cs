﻿//Задача 8: Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8
Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
int a = 0;
Console.Write($"{n}--> ");
while(a < (n - 1))
{
   a += 2;
   Console.Write($"{a}, ");
}
