// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());


int Ack(int n, int m)
{
    if (n == 0) return m + 1;
    else if (m == 0) return Ack(n - 1, 1);
    else return Ack(n - 1, Ack (n, m - 1));

}

int ackerman = Ack(n, m);
Console.Write($"Результат: {ackerman}");