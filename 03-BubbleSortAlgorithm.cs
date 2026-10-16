int[] numbers = { 5, 4, 7, 8, 1 };
int temp;

for (int i = 0; i < numbers.Length; i++)
{
    for (int j=0; j < 4; j++)
    {
        if (numbers[j] > numbers[j+ 1])
        {
            temp = numbers[j];
            numbers[j] = numbers[j+1];
            numbers[j+1] = temp;
        }

    }
}

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}
