// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] array = new int[new Random().Next(3, 10)];
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-100, 101);
    if (i > 0 && i % 2 != 0)
    {
        sum += array[i];
    }
}
System.Console.WriteLine($"[{string.Join(", ", (array))}] -> {sum}");




