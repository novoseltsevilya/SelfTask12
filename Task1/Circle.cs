namespace Task1
{
    static class Circle
    {
        static public double FindLenght(double r)
        {
            return 2 * Math.PI * r;
        }

        static public double FindSquare(double r)
        {
            return Math.PI * r * r;
        }

        static public bool IsBelongsToCircle(double x, double y, double x0, double y0, double r)
        {
            double dx = x - x0;
            double dy = y - y0;

            return dx * dx + dy * dy <= r * r;
        }
    }
}