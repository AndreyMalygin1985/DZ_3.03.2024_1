using static System.Console;

// Напишите метод, который отображает квадрат из некоторого символа.
// Метод принимает в качестве параметра: длину стороны квадрата, символ.

class Program
{
    static void Main()
    {
        WriteLine("Введите длину стороны квадрата:");
        int sideLength = Convert.ToInt32(ReadLine());

        Write("Введите символ для отображения квадрата: ");
        char symbol = ReadKey().KeyChar;

        WriteLine("\n");
        DrawSquare(sideLength, symbol);
    }

    static void DrawSquare(int sideLength, char symbol)
    {
        for (int i = 0; i < sideLength; i++)
        {
            for (int j = 0; j < sideLength; j++)
            {
                Write(symbol + " ");
            }
            WriteLine();
        }
    }
}