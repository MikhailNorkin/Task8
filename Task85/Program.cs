/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/



void FillArray()
{
    int n = 1, m = 0;
    int a = 0, b = 1;
    int[,] array = new int[4,4];

    for (int i = 0;;)
    {
        for (int j = 0;;)
        {   
            if (m == 15)
            {
                for (int ii = 0; ii < 4; ii++)
                    {
                        for(int jj = 0; jj < 4; jj++)
                        {
                            Console.Write($"i = {ii} j = {jj} {array[ii,jj]}    ");
                        }
                        Console.WriteLine();
                    }
                return;    
            }


            m = m + 1;
            array[i,j] = m;
            Console.WriteLine($"i= {i} ");
            Console.WriteLine($"j= {j} ");
            Console.WriteLine($"{array[i,j]} ");
            i+=a;
            j+=b;            

            //Console.WriteLine($"{j} ");
            if      (j==4 )  {i=1; j=3; n = 2;}
            else if (i==4 )  {i=3; j=2; n = 3;}
            else if (j==-1)  {i=2; j=0; n = 4;}
            if (m>11 )
                {
                    if (n==4)
                    {

                        if (array[i-1,j] != 0) {n=1;}
                         
                    }
                    else if (n==1)
                    {
                        if (array[i+1,j] != 0) {n=2;}
                    }
                    else if (n==2)
                    {
                        if (array[i,j+1] != 0) {n=3;}
                    }
                    else if (n==3)
                    {
                        if (array[i-1,j] != 0) {n=4;}
                    }
                }

            if (n==1) {a = 0; b = 1; }
            if (n==2) {a = 1; b = 0; }
            if (n==3) {a = 0; b = -1;}
            if (n==4) {a = -1; b = 0;}
          
        }
    }
}                   

FillArray();
