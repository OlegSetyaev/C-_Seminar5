// Статистика.


System.Console.WriteLine("Введите длинну массива: ");
int inputArraySize = Convert.ToInt32(Console.ReadLine());

int[] array = new int[inputArraySize];
List<int> arrayFours = new List<int>();
List<int> arrayTriples = new List<int>();

for (int i = 0; i < inputArraySize; i++)
{
    array[i] = new Random().Next(1, 32);
    if (array[i] % 2 == 0)
    {
        arrayFours.Add(array[i]);
    }
    else
    {
        arrayTriples.Add(array[i]);
    }
}
if (arrayFours.Count > arrayTriples.Count)
{
    System.Console.WriteLine($"[{string.Join(", ", arrayTriples)}]");
    System.Console.WriteLine($"[{string.Join(", ", arrayFours)}]");
    System.Console.WriteLine("yes");
}
else
{
    System.Console.WriteLine($"[{string.Join(", ", arrayTriples)}]");
    System.Console.WriteLine($"[{string.Join(", ", arrayFours)}]");
    System.Console.WriteLine("no");
}





