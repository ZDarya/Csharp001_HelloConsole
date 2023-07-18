// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int result = 0;

while(num > 0){
num = num / 10;
result = result + 1;
}
Console.WriteLine(result);