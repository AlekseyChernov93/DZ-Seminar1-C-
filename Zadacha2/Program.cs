﻿/*
 Напишите программу, которая выводит третью цифру заданного числа или сообщает,
что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/ 
// Я взял данное значение +n.ToString()[2]); из интернета  хотя  до конца не  понимаю как она работает я понял что оно выдергивает цифру из числа  без всяких математических действий!!!

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 99) Console.WriteLine("Третьей цифры нет");
if (n > 99) Console.WriteLine("Третья цифра в числе "+n.ToString()[2]);