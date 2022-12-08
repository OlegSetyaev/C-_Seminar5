// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

System.Console.WriteLine("Введите длинну массива: ");
int i = Convert.ToInt32(Console.ReadLine());
int[] array = new int[i];
int quantity = 0;
for (int j = 0; j < i; j++)
{
    array[j] = new Random().Next(100, 1000);
    if (array[j] % 2 == 0)
    {
        quantity += 1;
    }
}
System.Console.WriteLine($"[{string.Join(", ",array)}] -> {quantity}");




