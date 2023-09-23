//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
int SumOddNums(int[] array)
{
    int sum = 0;
    int Length = array.Length;
    for(int i = 0; i < Length; i++)
    {
        if(i%2 > 0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
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
int[] array = new int[4];
array = FillArray(array, 1, 100);
int result = SumOddNums(array);
Console.WriteLine(string.Join(" ", array));
Console.WriteLine($"Сумма элементов массива с нечетными позициями равна {result}");