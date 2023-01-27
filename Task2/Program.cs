// Напишите программу замена элементов массива: положительные элементы 
// замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// void PrintResult(int[] someArrayOfInt)
// {
//     string usersArray = 
// }

int[] ReverseValues(int[] arrayToReverse)
{
    for(int index = 0; index < arrayToReverse.Length; index++)
    {
        arrayToReverse[index] = -arrayToReverse[index];
    }

    return arrayToReverse;
}

int[] GetArray(int length, int minValue, int maxValue)
{
    int[] randIntArray;
    
    for(int elem = 0; elem < randIntArray.Length; elem++)
    {
       randIntArray[elem] = new Random().Next(minValue, maxValue + 1);
    }

    return randIntArray;
}

Console.WriteLine(arrayToReverse);

// void main()
// {
//     int myRandomArray = GetArray(maxValue: 12, length: 0; minValue: -12);
//     string 
// }