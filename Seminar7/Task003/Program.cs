/*  Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

int PromptInt(string mess)
{
    System.Console.Write($"{mess} > ");
    return Convert.ToInt32(Console.ReadLine());
}

int[,] CreateMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(0, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write($"{matr[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

void PrintArray(
    double[] array,
    int numberRound = 5)   
{
    foreach (double item in array)
    {
        System.Console.Write($"{Math.Round(item, numberRound)}\t");
    }
    System.Console.WriteLine();
}


double[] GetAveragesColumns(int[,] matrix)
{
    double[] result = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
        }
        result[j] = sum / matrix.GetLength(0);
    }
    return result;
}



int m = PromptInt("Введите количество строк массива");
int n = PromptInt("Введите количество столбцов массива");
if (m < 1) { System.Console.WriteLine($"Некорректное количество строк: {m}"); return; }
if (n < 1) { System.Console.WriteLine($"Некорректное количество столбцов: {n}"); return; }

int[,] matrix = CreateMatrix(m, n);
PrintMatrix(matrix);


double[] averages = GetAveragesColumns(matrix);
System.Console.WriteLine("Значения средних арифметических по столбцам матрицы:");
PrintArray(averages);
