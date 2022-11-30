// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
void IntersectionXY(double b1,double b2,double k1,double k2)
{
    if (k1 == k2) Console.Write("Прямые не пересекаются!");
    else 
    {
        double numberX = (b2 - b1) / (k1 - k2);
        numberX = Math.Round(numberX, 1);
        double  numberY = k1 * numberX + b1;
        numberY= Math.Round(numberY, 1);
        Console.Write($"Точка пересечения двух прямых = ({numberX}; {numberY})");
    }
}
Console.WriteLine("Введите значения переменных:");
Console.Write("b1 = ");
double numberB1 = Convert.ToDouble(Console.ReadLine());
Console.Write("b2 = ");
double numberB2 = Convert.ToDouble(Console.ReadLine());
Console.Write("k1 = ");
double numberK1 = Convert.ToDouble(Console.ReadLine());
Console.Write("k2 = ");
double numberK2 = Convert.ToDouble(Console.ReadLine());
IntersectionXY(numberB1,numberB2,numberK1,numberK2);
Console.WriteLine();
Console.Write("Exit.");
Console.ReadLine();

