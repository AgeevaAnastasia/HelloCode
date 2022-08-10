string[,] table = new string[2, 5];
table[1, 2] = "слово"; // это обращение к нужному нам элементу, например, в 1 строке 2 столбец. Далее работаем как с обычной переменной
// но считаем от нуля, как всегда. НЕ ЗАБЫТЬ! 5 столбец имеет индекс 4! 2 строка имеет индекс 1!
// table[0, 0]  table[0, 1]  table[0, 2]  table[0, 3]  table[0, 4]
// table[1, 0]  table[1, 1]  table[1, 2]  table[1, 3]  table[1, 4]

for (int rows = 0; rows < 2; rows++)
{
    for (int columns = 0; columns < 5; columns++)
    {
        Console.Write($"-{table[rows, columns]}-");
    }
    Console.WriteLine();
}

Console.WriteLine($"=======================================");

int[,] matrix = new int[3, 4];
PrintMatrix(matrix);
Console.WriteLine();
FillMatrixRnd(matrix);
PrintMatrix(matrix);



void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillMatrixRnd(int[,] matr1)
{
    Random rnd = new Random();
    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        for (int j = 0; j < matr1.GetLength(1); j++)
        {
            matr1[i, j] = rnd.Next(1, 10);
        }
    }
}



Console.WriteLine();
Console.WriteLine();

// Console.Write("Введите число, факториал которого нужно найти: ");
// int n = Int32.Parse(Console.ReadLine());


double Factorial(int n)
{
    if (n == 0) return 1;
    if (n == 1) return 1; // вернуть нужно 1, т.к. 1! = 1 (кстати, и 0! = 1)
    else return n * Factorial(n - 1);
}


// Console.WriteLine($"Факториал {n} = {Factorial(n)}");

for (int n = 0; n < 20; n++)
{
    Console.WriteLine($"{n}! = {Factorial(n)}");
}


double Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}

// Console.WriteLine($"Последовательность Фибоначчи для числа {n} = {Fibonacci(n)}");

for (int n = 1; n < 30; n++)
{
    Console.WriteLine($"f({n}) = {Fibonacci(n)}");
}