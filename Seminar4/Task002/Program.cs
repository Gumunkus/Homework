/* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

int Prompt(string message)
{
    Console.Write($"{message}: ");
    return Convert.ToInt32(Console.ReadLine());
}
int num = Prompt("Введите  число");
int sum = 0;
while (num > 0)
{
    int size = num % 10;
    num = num / 10;
    sum = sum + size;
}
Console.WriteLine($"Сумма всех цифр в набранном числе равна {sum}");