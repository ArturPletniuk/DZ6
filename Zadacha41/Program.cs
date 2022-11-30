//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//-1, -7, 567, 89, 223 3->
int[] CreatingAnArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("Введите число:");
        int Number = Convert.ToInt32(Console.ReadLine());
        array[i] = Number;
    }
    return array;
}
void PrintArray(int[] list)
{
    for (int i = 0; i < list.Length; i++)
    {
        if (i < list.Length - 1) Console.Write($"{list[i]}, ");
        else Console.Write($"{list[i]}");
    }
    Console.Write($" --> ");
}
int SumNumber(int[] array)
{
    int score = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) score++;
    }
    return score;
}
Console.Write("Введите количество М чисел:");
int numbers = Convert.ToInt32(Console.ReadLine());
int[] arrayVariable = CreatingAnArray(numbers);
int scoreNumber = SumNumber(arrayVariable);
PrintArray(arrayVariable);
Console.WriteLine(scoreNumber);
Console.WriteLine();
Console.Write("Exit.");
Console.ReadLine();
