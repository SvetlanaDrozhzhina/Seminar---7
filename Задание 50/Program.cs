// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Console.WriteLine("введите номер строки");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите номер столбца");
int m = Convert.ToInt32(Console.ReadLine());
int [,] numbers = new int [10,10];
FillArrayRandomNumbers(numbers);
if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
{
    Console.WriteLine("такого числа в массиве нет");
}
else
{
    Console.WriteLine($"значение элемента {n} строки и {m} столбца равно {numbers[n-1,m-1]}");
}
PrintArray(numbers);
void FillArrayRandomNumbers(int[,] array)
{
    for (int a = 0; a < array.GetLength(0); a++)
    {
        for (int b = 0; b < array.GetLength(1); b++)
        {
            array [a,b] = new Random().Next(-100, 100)/10;
        }
    }
}
void PrintArray(int[,] array)
{
    for (int a = 0; a < array.GetLength(0); a++)
    {
        Console.Write("[ ");
        for (int b = 0; b < array.GetLength(1); b++)
        {
            Console.Write(array[a,b] + " ");
        }
        Console.Write("]");
        Console.WriteLine(""); 
    }
}