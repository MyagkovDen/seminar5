/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

/////////////////////////////////////////////////////////////////////////////////////////////////////

double[] array = GetArray(12, -10, 10);
double difference = CountDifMaxMin(array);
Console.WriteLine($"[{String.Join(" ", array)}] -> {difference}");

//////////////////////////////////////////////////////////////////////////////////////////////////////
double[] GetArray(int size, int minValue, int maxValue)
{
    double[] arr = new double[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue) * new Random().NextDouble();
    }
    return arr;
}

double CountDifMaxMin(double[] arr)
{
    double arrMin = arr[0];
    double arrMax = arr[0];

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < arrMin) arrMin = arr[i];
        else if (arr[i] > arrMax) arrMax = arr[i];
    }

    double dif = arrMax - arrMin;
    return dif;
}

