/*Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */


int a, b, c; 
Console.WriteLine("Введите 1 число: ");
a = Convert.ToInt32( Console.ReadLine());
Console.WriteLine("Введите 2 число: ");
b = Convert.ToInt32( Console.ReadLine());
Console.WriteLine("Введите 3 число: ");
c = Convert.ToInt32( Console.ReadLine());

if (a > b && a > c)
{
 Console.WriteLine($"Max = {a}");
}
  else if (b > a && b > c )
    {
     Console.WriteLine($"Max = {b}");
    }
      else if (c > a && c > b)
       {
         Console.WriteLine($"Max = {c}");
       }
          else if (a == b && a == c)
            {  
             Console.WriteLine($"Числа равны");
            }