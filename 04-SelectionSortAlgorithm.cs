// SELECTION SORT ALGORITHM

int[] numbers = { 9, 6, 7, 3, 4 };

for (int i = 0; i < numbers.Length - 1; i++)
{
    int minIndex = i;

    for (int j = i + 1; j < numbers.Length; j++)
    {
        if (numbers[j] < numbers[minIndex])
        {
            minIndex = j;
        }
    }

    int temp = numbers[i];
    numbers[i] = numbers[minIndex];
    numbers[minIndex] = temp;
}

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}
