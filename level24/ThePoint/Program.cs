// See https://aka.ms/new-console-template for more information
// Yes. We choose to do this so that the set methods can alter the coordinates.
Point point = new Point(2,3);
Point point2 = new Point(-4, 0);


Console.WriteLine($"({point.X}, {point.Y})");
Console.WriteLine($"({point2.X}, {point2.Y})");
public class Point
{
    public int X { get; set; }
    public int Y { get; set; }
    public Point()
    {
        X = 0;
        Y = 0;
    }
    public Point(int newX, int newY)
    {
        X = newX;
        Y = newY;
    }
}
