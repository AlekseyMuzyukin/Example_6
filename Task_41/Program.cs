Console.Write("Введите числа (через пробел): ");
int[] array = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

int PositiveNum(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }

    }

    return count;

}

int result = PositiveNum(array);

Console.WriteLine($"Количество элементов больше нуля -> {result}");