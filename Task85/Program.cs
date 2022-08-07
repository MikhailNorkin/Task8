/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/



int FillArray(int[,,] array)
{
    int n = 1, m = 0;
    int a = 0, b = 1;

    for (int i = 0;;)
    {
        for (int j = 0;;)
        {   
            if (m = 15)
            {
                return array;
            }

            m = m + 1;
            array[i,j] = m;

            i+=a;
            j+=b;

            if      (j=4 )  {i=1; j=3; n = n + 1;}
            else if (i=4 )  {i=2; j=3; n = n + 1;}
            else if (j=-1)  {i=0; j=2; n = n + 1;}
            else if (m>11)
                {
                    if (n=4)
                    {
                        if (array[i,j-1] =! 0) {n=1}
                    }
                    else if (n=1)
                    {
                        if (array[i+1,j] =! 0) {n=2}
                    }
                    else if (n=2)
                    {
                        if (array[i,j+1] =! 0) {n=3}
                    }
                    else if (n=3)
                    {
                        if (array[i-1,j] =! 0) {n=4}
                    }
                }

            if (n=1) {a = 0; b = 1; }
            if (n=2) {a = 1; b = 0; }
            if (n=3) {a = 0; b = -1;}
            if (n=4) {a = -1; b = 0;}
        }
    }
}                   

int[,] array = new int[4,4];
array[,] = FillArray(array);
for (int i = 0; i < 4; i++)
{
    for(int j = 0; j < 4; j++)
    {
        Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
}