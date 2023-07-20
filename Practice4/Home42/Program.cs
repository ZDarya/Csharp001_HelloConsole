// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int num1 = 0;
while (num>0)
{
    num1 = num%10;
    sum = sum + num1;
    num = num / 10;
}
Console.WriteLine("Сумма чисел: " + sum);