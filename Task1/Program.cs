namespace Task1;

class Task1
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите радиус r:");
        double r = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите координату точки x:");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите координаты y:");
        double y = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите координаты x0:");
        double x0 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите координату точки y0:");
        double y0 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Длина окружности: {Circle.FindLenght(r)}.");
        Console.WriteLine($"Площадь круга: {Circle.FindSquare(r)}.");

        bool inside = Circle.IsBelongsToCircle(x, y, x0, y0, r);

        if (inside)
        {
            Console.WriteLine($"Точка ({x}, {y}) принадлежит кругу.");
        }
            
        else
        {
            Console.WriteLine($"Точка ({x}, {y}) не принадлежит кругу.");
        }
            
        Console.WriteLine("Для выхода нажмите любую клавишу:");
        Console.ReadKey();
    }
}