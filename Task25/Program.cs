﻿// Задача 25: 
//Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();

Console.Write("Введите первое число A = ");
int a=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Второе число В = ");
int b=Convert.ToInt32(Console.ReadLine());
int result=1;
for (int i = 1; i <= b; i++)
{
    result=result*a;
}
Console.Write($"Число {a} в степени {b} равно {result}");