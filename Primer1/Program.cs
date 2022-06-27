/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */

int a, b;
Console.WriteLine("Введите 1 чиcло: ");
a = Convert.ToInt32( Console.ReadLine());

Console.WriteLine("Введите 2 чиcло: ");
b = Convert.ToInt32( Console.ReadLine());

if(a > b) 
{
    Console.WriteLine($"Max = {a}  Min = {b}");
}
if(b > a)
{
    Console.WriteLine($"Max = {b}  Min = {a}");
}
if(b == a)
{
    Console.WriteLine("Числа равны");
}