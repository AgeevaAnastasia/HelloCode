// Сортировка методом минимального-максимального.
// 1. Найти позицию минимального элемента в НЕОТСОРТИРОВАННОЙ части массива
// 2. Произвести обмен этого значения со значением первой неотсортированной позиции
// 3. Повторять, пока есть неотсортированные элементы

Console.Clear();

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSortFromMinToMax(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i+1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}


void SelectionSortFromMaxToMin(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;

        for (int j = i+1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition]) maxPosition = j;
        }

        int temp = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temp;
    }
}



PrintArray(arr);

SelectionSortFromMinToMax(arr);
PrintArray(arr);

SelectionSortFromMaxToMin(arr);
PrintArray(arr);