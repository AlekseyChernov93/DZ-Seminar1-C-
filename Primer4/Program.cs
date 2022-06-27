/* Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8 */

int n, i;
Console.WriteLine("Введите число: ");
n = Convert.ToInt32(Console.ReadLine());

for ( i = 2; i <= n; i += 2)
{
     Console.Write(  i + " ");
}