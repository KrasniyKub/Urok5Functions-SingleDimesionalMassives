//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
int EvenNumberCounter(int[] array)
{
    int Count = 0;
    int Length = array.Length;
    for(int i = 0; i < Length; i++)
    {
        if(array[i]%2 == 0)
        {
            Count++;
        }
    }
    return Count;
}

int[] FillArray(int[] array, int Min, int Max)
{
    Random Rand = new Random();
    int Length = array.Length;
    for (int i = 0; i < Length; i++)
    {
        array[i] = Rand.Next(Min, Max);
    }
    return array;
}
// array = {1, 2, 3, 4, 5}
int[] array = new int[4];
array = FillArray(array, 100, 1000);
int EvenNumCount = EvenNumberCounter(array);
Console.WriteLine(string.Join(" ", array));
Console.WriteLine($"Колво четных чисел в массиве равно {EvenNumCount}");