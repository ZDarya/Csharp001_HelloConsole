// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
Console.WriteLine("Какое число найти в массиве?");
int num = Convert.ToInt32(Console.ReadLine());
int[] nums = new int[12];

for (int i = 0; i < nums.Length; i++)
{
    nums[i] = new Random().Next(-9, 10);
    Console.Write(nums[i] + " ");
}
Console.WriteLine();
string result = "нет";
for (int j = 0; j < nums.Length; j++)
{
if(nums[j]==num)
    {
        result = "Это число есть в массиве";
        break;
    }
        }
Console.WriteLine(result); 