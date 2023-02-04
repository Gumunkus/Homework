/* Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

double[] GenerateArray(int len = 5)
{
    double[] array = new double[len];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.NextDouble() * 100;
    }
    return array;
}

void PrintArray(double[] array)
{
    double difference = 0;
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + $"\t");
        System.Console.WriteLine();
        difference = array.Max() - array.Min();
    }
    System.Console.WriteLine();
    System.Console.WriteLine($"Минимальное значение массива - {array.Min()}, максимальное значение массива - {array.Max()} ");
    System.Console.WriteLine();
    System.Console.WriteLine($"Разница между максимальным и минимальным элементами массива составляет -> {difference} ");
}
double[] array = GenerateArray(5);
PrintArray(array);