// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223-> 3

Console.Write("Введите M чисело: ");
int Array = Convert.ToInt32(Console.ReadLine());

int Numbers(int number, int arr)
{
    int counter = default;
    for (int i = 0; i < arr; i++)
    {
        Console.Write("Введите число: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num > number) counter++;
    }
    return counter;
}
int arrnum = Numbers(0, Array);
Console.WriteLine($"Ответ| {arrnum}");