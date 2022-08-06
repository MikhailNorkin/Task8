/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int n = 0, m= 0;
Console.WriteLine("Введите количество строк массива:");
m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива");
n = int.Parse(Console.ReadLine());

int sum = 0, min=0, st = 1;
int[,] array = new int[m,n];

for (int i = 0; i < m; i++)
{
    for(int j = 0; j < n; j++)
    {
        array[i,j] = new Random().Next(10);
        sum = sum + array[i,j];
        Console.Write($"{array[i,j]} ");
    }

    if (i == 0)
    {
        min = sum;
    }
    else if (sum < min)
    {
        min = sum;
        st = i;
    }
    sum = 0;

    Console.WriteLine();
}

Console.WriteLine($"номер строки с наименьшей суммой элементов: {st+1}");