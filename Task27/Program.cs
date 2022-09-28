// Задача 27: 
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();

Console.Write("Введите число ");
int num=Convert.ToInt32(Console.ReadLine());

int result=0;

for (int i = 0; i < 10; i++)
{
    result=result + num%10;
    num=num/10;
}
Console.Write($"Сумма чисел равна = {result}");