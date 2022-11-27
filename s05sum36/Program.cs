/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
/////////////////////////////////////////////////////////////////////////////////////////////////////

Console.Clear();
int[] array = GetArray(4, -99, 99);
int sumOdd = SumOddNumbers(array);
Console.WriteLine($"[{String.Join(" ", array)}] -> {sumOdd}");

/////////////////////////////////////////////////////////////////////////////////////////////////////

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue);
    }
    return res;
}

int SumOddNumbers(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0) sum += arr[i];
    }
    return sum;
}