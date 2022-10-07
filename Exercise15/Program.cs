int EnterNumber()
{
    int number;
    while (true)
    {
        Console.Write("Введите день недели: ");
        if (int.TryParse(Console.ReadLine(), out number))
            break;
        Console.WriteLine($"Ошибка ввода!");
    }
    return number;
}

int number = EnterNumber();

if (number > 7)
{
    Console.WriteLine($"{number} -> Нет такого дня недели!");
}
else if (number <= 5)
{
    Console.WriteLine($"{number} -> Нет");
}
else
{
    Console.WriteLine($"{number} -> Да");
}