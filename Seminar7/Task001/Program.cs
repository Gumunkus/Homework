﻿/* Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */


int PromptInt(string mess)
{
    System.Console.Write($"{mess} > ");
    return Convert.ToInt32(Console.ReadLine());
}

double[,] CreateRandomMatrix(
    int rows,
    int columns,
    double minValue = 0,
    double maxValue = 10)
{
    double[,] result = new double[rows, columns];
    double delta = maxValue - minValue;
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = minValue + delta * rnd.NextDouble();
        }
    }
    return result;
}

void PrintMatrixDouble(
    double[,] matr,
    int numberRound = 5)   
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write($"{Math.Round(matr[i, j], numberRound)}\t");
        }
        System.Console.WriteLine();
    }
}

int m = PromptInt("Введите количество строк массива");
int n = PromptInt("Введите количество столбцов массива");
if (m < 1){ System.Console.WriteLine($"Некорректное количество строк: {m}"); return; }
if (n < 1){ System.Console.WriteLine($"Некорректное количество столбцов: {n}"); return; }

PrintMatrixDouble(CreateRandomMatrix(m, n));

