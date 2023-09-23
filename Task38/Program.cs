// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
double DiffMaxMin(double[] array)
{
    double Max = array[0];
    double Min = array[0];
    int Length = array.Length;
    for(int i = 1; i < Length; i++)
    {
        if(array[i] > Max)
        {
            Max = array[i];
        }
        else
        {
            if(array[i] < Min)
            {
                Min = array[i];
            }
        }
    }
    return Max-Min;
}

double[] FillArray(double[] array, int Min, int Max)
{
    Random Rand = new Random();
    int Length = array.Length;
    for (int i = 0; i < Length; i++)
    {
        array[i] = Rand.Next(Min, Max) + Rand.Next(1, 100)*0.01;
    }
    return array;
}
double[] array = new double[4];
array = FillArray(array, 1, 100);
double result = DiffMaxMin(array);

Console.WriteLine(string.Join(" ", array));
Console.WriteLine($"Разница между наибольшим элементом массива и наименьшим равна {result}");