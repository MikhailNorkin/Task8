/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

//int[,] array1 = new int[m,n];

void FillArray(int[,] array)
{
    for (int i = 0; i < 2; i++)
    {
        for(int j = 0; j < 2; j++)
        {
            array[i,j] = new Random().Next(6);
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}
int[,] array1 = new int[2,2];
int[,] array2 = new int[2,2];
FillArray(array1);
Console.WriteLine();
FillArray(array2);
Console.WriteLine();

int[,] array = new int[2,2];
for (int i = 0; i < 2; i++)
{
    for(int j = 0; j < 2; j++)
    {
        array[i,j] = array1[i,j]*array2[i,j];
        Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
}
