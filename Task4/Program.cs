// Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
// 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

bool ReturnTassRool(int elementArray)
{
    if(10 <= elementArray && elementArray <= 99) return true;
    else return false;
}

int CountElements(int[] ourArray)
{
    int count = 0;

    foreach(int elem in ourArray)
    {
        if (ReturnTassRool(elem)) count++;
    }

    return count;
}

void PrintResult(int[] array, int count)
{
    Console.WriteLine($"В массиве ({String.Join(", ", array)}) на отрезке от 0 до 99 лежит {count} элементов");
}

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    
    }
    return res;
}

void main()
{
    int[] array = GetArray(123, 0, 150);
    int elementsCounted = CountElements(array);
    PrintResult(array, elementsCounted);
}

main();