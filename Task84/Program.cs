/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента. Массив размером 2 x 2 x 2

66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/



int FillArray(int[,,] array, int ii, int jj, int yy)
{
    int flag = 1;
    int newZnach = 0;
    // зададим новое значение и проверим есть ли такое значение в массиве:
    while (flag == 1) 
    {
        flag = 0;
        newZnach = new Random().Next(10,20);
        for (int i = 0; i < 2; i++)
        {
            for(int j = 0; j < 2; j++)
            {
                for(int y = 0; y < 2; y++)
                {
                    if (ii==i && jj==j && yy==y && flag == 0)
                    {
                        return newZnach;
                    }
                    else if (array[i,j,y] == newZnach)
                    {
                        flag = 1;
                    }
                }
            }
        }
    }
    return newZnach;
}

int[,,] array = new int[2,2,2];

for (int i = 0; i < 2; i++)
{
    for(int j = 0; j < 2; j++)
    {
        for(int y = 0; y < 2; y++)
        {
            //заполним элмент неповторяющимся значением
            array[i,j,y] = FillArray(array, i,j,y);
            Console.Write($"{array[i,j,y]} ");
        }
    }
    Console.WriteLine();
}