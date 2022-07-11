// See https://aka.ms/new-console-template for more information

Console.WriteLine("Choose an option: Elite Arrow, Beginner Arrow, or Marksman Arrow.");
Console.WriteLine("1. Elite Arrow");
Console.WriteLine("2. Beginner Arrow");
Console.WriteLine("3. Marksman Arrow");
Console.WriteLine("4. Make a custom arrow");

int input = Convert.ToInt32(Console.ReadLine()!);
Arrow arrow = processInput(input);
Console.WriteLine($"That arrow costs {arrow.GetCost()} gold.");


Arrow processInput(int input)
{
    return input switch
    {
        1 => Arrow.CreateEliteArrow(),
        2 => Arrow.CreateBeginnerArrow(),
        3 => Arrow.CreateMarksmanArrow(),
        4 => GetArrow(),
    };
}

Arrow GetArrow()
{
    Arrowhead arrowhead = GetArrowheadType();
    Fletching fletching = GetFletchingType();
    float length = getLength();
    return new Arrow(arrowhead, fletching, length);
}

Arrowhead GetArrowheadType()
{
    Console.WriteLine("Arrowhead Type (steel, wood, obsidian): ");
    string input = Console.ReadLine()!;
    return input switch
    {
        "steel" => Arrowhead.Steel,
        "wood" => Arrowhead.Wood,
        "obsidian" => Arrowhead.Obsidian
    };
}

Fletching GetFletchingType()
{
    Console.WriteLine("Fletching Type (plastic, turkey feather, goose feather): ");
    string input = Console.ReadLine()!;
    return input switch
    {
        "plastic" => Fletching.Plastic,
        "turkey feather" => Fletching.TurkeyFeathers,
        "goose feather" => Fletching.GooseFeathers
    };


}

float getLength()
{
    float length = 0;
    while (length < 60 || length > 100)
    {
        Console.WriteLine("Arrow length between 60-100: ");
        length = Convert.ToSingle(Console.ReadLine()!);
    }
    return length;
}


class Arrow
{
    private Arrowhead _arrowhead { get; set; }
    private Fletching _fletching { get; set; }
    private float _length { get; set; }
    public Arrow(Arrowhead arrowhead, Fletching fletching, float length)
    {
        _arrowhead = arrowhead;
        _fletching = fletching;
        _length = length;
    }
    public static Arrow CreateEliteArrow()
    {
        return new Arrow(Arrowhead.Steel, Fletching.Plastic, 95f);
    }
    public static Arrow CreateBeginnerArrow()
    {
        return new Arrow(Arrowhead.Wood, Fletching.GooseFeathers, 75f);
    }
    public static Arrow CreateMarksmanArrow()
    {
        return new Arrow(Arrowhead.Steel, Fletching.GooseFeathers, 65f);
    }
    public float GetCost()
    {
        float ahCost = _arrowhead switch
        {
            Arrowhead.Steel => 10,
            Arrowhead.Wood => 3,
            Arrowhead.Obsidian => 5
        };

        float fCost = _fletching switch
        {
            Fletching.Plastic => 10,
            Fletching.TurkeyFeathers => 5,
            Fletching.GooseFeathers => 3
        };
        float lCost = 0.05f * _length;

        return ahCost + fCost + lCost;
    }
}

enum Arrowhead { Steel, Wood, Obsidian }
enum Fletching { Plastic, TurkeyFeathers, GooseFeathers }





