// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да




int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);    
    }
    return res;
}

int InputNum(string text)
{
    Console.Write($"{text}: ");
    int tempNum = int.Parse(Console.ReadLine()!);
    return tempNum;
}

int SearchElement(int[] ourArray, int number)
{
    int count = 0;

    foreach(int elem in ourArray)
    {
        if (elem == number) count++;
    }

    return count;
}

void PrintResult(int[] array, int elementCounted, int searchNumber)
{
    if(elementCounted == 0)
    {
        Console.WriteLine($"В массиве ({String.Join(", ", array)}) заданное число {searchNumber} отсутствует");
    }
    else
    {
        Console.WriteLine($"В массиве ({String.Join(", ", array)}) присутствует заданное число {searchNumber}");
    }
}

void main()
{
    Console.Clear();
    int[] array = GetArray(100, 0, 150);
    int check = InputNum("Введите число, которое вы хотите найти");
    int elementCounted = SearchElement(array, check);
    PrintResult(array, elementCounted, check);
}

main();