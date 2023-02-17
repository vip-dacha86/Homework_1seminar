// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//  5 -> 2, 4   8 -> 2, 4, 6, 8

int i = 1;

Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine());

Console.WriteLine("Чётные числа от 1 до " + num);
bool not = true;
while (i <= num)
{
    if (i % 2 != 1)
    {
        Console.Write(i + ", ");
        not = false;
    }
    i++;
}

if (not)
{
    Console.WriteLine("Нет чётных чисел!");
}
System.Console.WriteLine();