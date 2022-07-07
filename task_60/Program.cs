/*
Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно
выводить массив, добавляя индексы каждого элемента.

массив размером 2 x 2 x 2
12(0,0,0) 22(0,0,1)
45(0,1,0) 53(0,1,1)
32(1,0,0) 41(1,0,1)
66(1,1,0) 88(1,1,1)
*/

using static System.Console;



Clear();
Clear();
WriteLine("Введите размер матрицы через точку: ");
string[] sizeS = ReadLine().Split('.', StringSplitOptions.RemoveEmptyEntries);
int m = int.Parse(sizeS[0]);
int n = int.Parse(sizeS[1]);
int h = int.Parse(sizeS[2]);
Print3DArray(Get3DArray(m,n,h));


int [,,] Get3DArray(int row, int column, int height)
{
    int [,,] result=new int[row, column, height];
    for(int i=0; i<row; i++)
    {
        for(int j=0; j<column; j++)
        {
            for(int k=0; k<height; k++)
            {
                result[i,j,k]=new Random().Next(10,100);
            }
        }
    }
    return result;
}

void Print3DArray (int [,,] array)
{
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            for(int k=0; k<array.GetLength(2); k++)
            {
                Write($"{array[i,j,k]}({i},{j},{k}) \t");
            }
            WriteLine();
        }
    }
}

int [,,] NRepeatingElements(int [,,] array)
{
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            for(int k=0; k<array.GetLength(2); k++)
            {
                int temp=array[i,j,k];
                for(int i=0; i<array.GetLength(0); i++)
                {
                    for(int j=0; j<array.GetLength(1); j++)
                    {
                        for(int k=0; k<array.GetLength(2); k++)
                        {
                            if(temp==array[i,j,k])
                        }
                    }
                }
            }
        }
    }
    return array;
}