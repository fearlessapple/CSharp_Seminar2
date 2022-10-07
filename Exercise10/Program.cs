int EnterNumber()
{
    int number;
    while (true)
    {
        Console.Write("Введите трёхзначное число: ");
        if (int.TryParse(Console.ReadLine(), out number))
            break;
        Console.WriteLine($"Ошибка ввода!");
    }
    return number;
}

int number = EnterNumber();

int number1 = number / 10;
int number2 = number1 % 10;

Console.WriteLine($"{number} -> {number2}");