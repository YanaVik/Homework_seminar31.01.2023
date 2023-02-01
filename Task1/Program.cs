// Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write("Введите элементы, используя между ними запятую: ");
int[] array = Array.ConvertAll(Console.ReadLine().Split(","), int.Parse);
int count = array.Count(x => x > 0);
Console.WriteLine($"Количество элементов больше ноля: {count}");