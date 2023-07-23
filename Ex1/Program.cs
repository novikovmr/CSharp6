
/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 4
*/

Console.Clear();
Console.Write("Введите числа: ");
int[] array = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int count = 0;
foreach (int i in array)
    if (i > 0) count ++;
Console.WriteLine($"Ответ: {count}");

