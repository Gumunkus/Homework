/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Не использовать Math.Pow
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

int Prompt(string message)
{
    Console.Write($"{message}: ");
    return Convert.ToInt32(Console.ReadLine());
}
int num1 = Prompt("Введите первое число");
int num2 = Prompt("Введите второе число");
int num = num1;
for (int i = 1; i < num2; i++)
{
    num = num * num1;
}
System.Console.WriteLine($"Число {num1} в степени {num2} равно: {num} ");