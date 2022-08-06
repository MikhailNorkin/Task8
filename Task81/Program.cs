/* 
Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int n = 0, m= 0;
Console.WriteLine("Введите количество строк массива:");
m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива");
n = int.Parse(Console.ReadLine());

int[,] array = new int[m,n];

for (int i = 0; i < m; i++)
{
    for(int j = 0; j < n; j++)
    {
        array[i,j] = new Random().Next(10);
        Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
}

int p = 1;
int max = 0;

for (int i = 0; i < m; i++)
{
    do
    {
        for(int j = 0; n-p > j; j++)
        {
            if (array[i,j+1]> array[i,j])
            {
                max = array[i,j];
                array[i,j] = array[i,j+1];
                array[i,j+1] = max; 
            }    
        }
        p = p + 1;
    }
    while (p < n);
    p = 1;
}

Console.WriteLine();

for (int i = 0; i < m; i++)
{
    for(int j = 0; j < n; j++)
    {
        Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
}