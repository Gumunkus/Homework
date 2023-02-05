/* Задача 1: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */
int array = 5;
int count = 0;
while (array > 0)
{
    Console.Write("Введите число ");
    string num = Console.ReadLine();
    int number = Convert.ToInt32(num);
    if (number > 0)
    {
        count++;
        array--;
    }
}
System.Console.WriteLine();
System.Console.WriteLine($"Количество чисел больше 0 в заданном массиве: {count}");

