// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел

Console.Clear();
Console.Write("Введите первое число: ");
int max = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = int.Parse(Console.ReadLine());
if(b > max)
{
    max = b;
}
if(c > max)
{
    max = c;
}
Console.WriteLine($"Максимальное значение - {max}");
