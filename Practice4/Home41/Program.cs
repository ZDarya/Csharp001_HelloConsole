// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральную степень: ");
int b = Convert.ToInt32(Console.ReadLine());
int proizv = 1;
for (int i = 0; i < b; i++)
{
  proizv = proizv*a;
}
Console.WriteLine("Ответ: " + proizv);