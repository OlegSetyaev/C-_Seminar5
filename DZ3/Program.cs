// See https://aka.ms/new-console-template for more information

float[] array = new float[new Random().Next(3, 10)];
float min = 100;
float max = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 100);
    if (array[i] > max)
    {
        max = array[i];
    }
    else if (array[i]<min)
    {
        min = array[i];
    }
}
System.Console.WriteLine($"[{string.Join(", ",array)}] -> {max - min}");

