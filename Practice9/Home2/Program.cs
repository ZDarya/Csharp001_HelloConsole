// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());


int NumbersSum(int m, int n, int sum)
{
    if (m > n) return sum;
    else
    {
        sum += m;
        return NumbersSum(m + 1, n, sum);
    }

}

int sum = NumbersSum(m, n, 0);
Console.Write($"Сумма натуральных элементов в промежутке от {m} до {n} = {sum}");