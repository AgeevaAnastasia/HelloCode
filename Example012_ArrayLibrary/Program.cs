void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0; 
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10); // это полуинтервал [1; 10)
        index++;
    }
}


void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0; //вместо индекс
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }

}


int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (collection [index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; // задали новый массив из 10 элементов

FillArray (array); // вызвали ранее описанный метод FillArray  для заполнения этого массива из 10 эл-в псевдослучайными числами
array[4] = 4;
array[6] = 4;
PrintArray(array); // вызвали ранее описанный метод PrintArray для печати этого массива

Console.WriteLine();

int pos = IndexOf(array, 444);
Console.WriteLine(pos);