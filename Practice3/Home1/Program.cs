﻿// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// (Использовать только математические операции, нельзя использовать число как строку по типу number[1])
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 10000 || num > 99999)
{
 Console.Write($"{num} не является пятизначным");
 return;
}
int num1 = num / 10000;
int num2 = num / 1000 % 10;
int num4 = num / 10 % 10;
int num5 = num % 10;
if (num1 == num5 && num2 == num4)
{
 Console.WriteLine ($"{num} является палиндромом");
}
else
{
 Console.WriteLine ($"{num} не является палиндромом");
}