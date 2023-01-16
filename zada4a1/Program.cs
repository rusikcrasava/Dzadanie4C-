int numberA = ReadInt("Введите число A: ");
int numberB = ReadInt("Введите число B: ");
Stepen(numberA, numberB);


// Функция возведения в степень
void Stepen(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine(result);
}

// Функция ввода
int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
