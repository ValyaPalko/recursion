// Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.
void ArrayBackward(int[] array, int i = 0)
{
    if (i < 10)
    {
        ArrayBackward(array, i + 1);
        Console.WriteLine(array[i]);
    }
}
int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
ArrayBackward(array);



