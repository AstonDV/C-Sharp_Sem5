// Напишите программу замена элементов массива: положительные элементы 
// замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    
    }
    return res;
}

void ReverseValues(int[] arrayToReverse)
{
    for(int i = 0; i < arrayToReverse.Length; i++)
    {
        arrayToReverse[i] = -arrayToReverse[i];
    }
}

void PrintResult(int[] array)
{
    Console.WriteLine($"{String.Join(", ", array)}");
}

void main()
{
    Console.Clear();
    int[] array = GetArray(10, -100, 100);
    PrintResult(array);
    ReverseValues(array);
    PrintResult(array);
}

main();

// void main()
// {
//     Console.Clear();
//     int[] array = GetArray(100, 0, 150);
//     int check = InputNum("Введите число, которое вы хотите найти");
//     int elementCounted = SearchElement(array, check);
//     PrintResult(array, elementCounted, check);
// }

// main();