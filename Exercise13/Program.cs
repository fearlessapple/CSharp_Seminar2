int EnterNumber()
{
    int number;
    while (true)
    {
        Console.Write("Введите число: ");
        if (int.TryParse(Console.ReadLine(), out number))
            break;
        Console.WriteLine($"Ошибка ввода!");
    }
    return number;
}

int number = EnterNumber();
int number1 = number / 100;
int number2 = number;

if(number1 == 0)
{
    Console.WriteLine($"{number} -> третьей цифры нет");
}
else
{
    while(number / 1000 != 0)
    {
        number = number / 10;
    }
    int number3 = number % 10;
    Console.WriteLine($"{number2} -> {number3}");

}

