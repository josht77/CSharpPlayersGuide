// See https://aka.ms/new-console-template for more information

Arrow arrow = GetArrow();
Console.WriteLine($"That arrow costs {arrow.GetCost()} gold.");


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
    private Arrowhead _arrowhead;
    private Fletching _fletching;
    private float _length;
    public Arrow(Arrowhead arrowhead, Fletching fletching, float length)
    {
        _arrowhead = arrowhead;
        _fletching = fletching;
        _length = length;
    }

    private Arrowhead GetAH() => _arrowhead;
    private void SetAH(Arrowhead setTo) => _arrowhead = setTo;
    
    private float GetLength() => _length;
    private void SetLength(float setTo) => _length = setTo;

    private Fletching GetFletching() => _fletching;
    private void SetFletching(Fletching setTo) => _fletching = setTo;
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




