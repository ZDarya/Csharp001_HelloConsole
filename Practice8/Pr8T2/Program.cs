﻿// Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных. 

int[,] nums = new int[5, 5]; 
for (int i = 0; i < nums.GetLength(0); i++) 
{ 
    for (int j = 0; j < nums.GetLength(1); j++) 
    { 
        nums[i, j] = new Random().Next(0, 20); 
    } 
} 

for (int i = 0; i < nums.GetLength(0); i++) 
{ 
    for (int j = 0; j < nums.GetLength(1); j++) 
    { 
        Console.Write(nums[i, j] + " "); 
    } 
    Console.WriteLine(); 
} 

Console.WriteLine(); 

int [] numbers = new int [20]; 

for (int i = 0; i < nums.GetLength(0); i++) 
{ 
    for (int j = 0; j < nums.GetLength(1); j++) 
    { 
        numbers[nums[i,j]] +=1; 
} 
} 

for (int i = 0; i<numbers.Length; i++){ 
    Console.Write($"{i} - {numbers[i]}"); 
    Console.WriteLine(); 
}