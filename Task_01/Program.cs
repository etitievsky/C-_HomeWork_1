// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее

Console.Clear();
Console.Write("Введите первое число:");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число:");
int b = int.Parse(Console.ReadLine());
int max;
int min;
if(a > b)
{
    max = a;
    min =b;
}
else
{
    max = b;
    min =a;
}
Console.WriteLine($"Максимальное значение - {max}");
Console.WriteLine($"Минимальное значение - {min}");