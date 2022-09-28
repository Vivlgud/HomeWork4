// Задача 29: 
// Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();

int[] array=new int[8];
Console.WriteLine("Введите 8 чисел для заполнения массива");
for (int i = 0; i < array.Length; i++)
{
    array[i]=Convert.ToInt32(Console.ReadLine());
}
Console.Write("Полученный массив ");
Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
    if (i<array.Length-1) Console.Write($"{array[i]},");
    else Console.Write($"{array[i]}");
}
Console.Write("]");