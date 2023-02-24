/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1, 7 -> такого числа в массиве нет
1, 1 -> 1 */

(int value, bool flag) getElement(int[,] arr, int indexRow, int indexCol)
{
    
    bool flag = (indexRow >= 0 && indexRow < arr.GetLength(0) 
    && indexCol >= 0 && indexCol < arr.GetLength(1));

    int value = flag ? arr[indexRow, indexCol] : 0;     
    return (value, flag);  
}

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

int m = PromptInt("Введите количество строк массива");
int n = PromptInt("Введите количество столбцов массива");
if (m < 1){ System.Console.WriteLine($"Некорректное количество строк: {m}"); return; }
if (n < 1){ System.Console.WriteLine($"Некорректное количество столбцов: {n}"); return; }
int[,] matrix = CreateMatrix(4, 5);
PrintMatrix(matrix);

int indexRow = PromptInt("Введите индекс строки в массиве");
int indexCol = PromptInt("Введите индекс столбца в массиве");
(int value, bool flag) = getElement(matrix, indexRow, indexCol);
if (flag){
    System.Console.WriteLine($"Элемент с индексами [{indexRow}, {indexCol}] имеется, значение: {matrix[indexRow, indexCol]}");
}else{
    System.Console.WriteLine($"Элемент с индексами [{indexRow}, {indexCol}] в массиве не найден");
}