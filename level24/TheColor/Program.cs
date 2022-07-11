// See https://aka.ms/new-console-template for more information


public class Color
{
    public int red { get; set; }
    public int green { get; set; }
    public int blue { get; set; }
    public Color(int r, int g, int b)
    {
        red = r;
        green = g;
        blue = b;
    }
    public static Color White()
    {
        return new Color(255, 255, 255);
    }
    public static Color Black()
    {
        return new Color(0, 0, 0);
    }
    public static Color Red()
    {
        return new Color(255, 0, 0);
    }
    public static Color Orange()
    {
        return new Color(255, 165, 0);
    }
    public static Color Yellow()
    {
        return new Color(255, 255, 0);
    }
    public static Color Green()
    {
        return new Color(0, 128, 0);
    }
    public static Color Blue()
    {
        return new Color(0, 0, 225);
    }
    public static Color Purple()
    {
        return new Color(128, 0, 128);
    }
}
