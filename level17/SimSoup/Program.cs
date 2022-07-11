// See https://aka.ms/new-console-template for more information

(SoupType St, MainIngredient Mi, Seasoning Se) soup = GetSoup();
Console.WriteLine($"{soup.Se} {soup.Mi} {soup.St}");

(SoupType, MainIngredient, Seasoning) GetSoup() {

    SoupType St = GetSoupType();
    MainIngredient Mi = GetMainIngredient();
    Seasoning Se = GetSeasoning();
    return (St, Mi, Se);
}

SoupType GetSoupType()
{
    Console.WriteLine("Pick a soup type (soup, stew, gumbo): ");
    string input = Console.ReadLine()!;
    return input switch
    {
        "soup" => SoupType.Soup,
        "stew" => SoupType.Stew,
        "gumbo" => SoupType.Gumbo,
    };

}

MainIngredient GetMainIngredient()
{
    Console.WriteLine("Pick a Main Ingredient (mushrooms, chicken, carrots, potatoes): ");
    string input = Console.ReadLine()!;
    return input switch
    {
        "mushrooms" => MainIngredient.Mushrooms,
        "chicken" => MainIngredient.Chicken,
        "carrots" => MainIngredient.Carrots,
        "potatoes" => MainIngredient.Potatoes,
    };

}
Seasoning GetSeasoning()
{
    Console.WriteLine("Pick a seasoning (spicy, salty, sweet): ");
    string input = Console.ReadLine();
    return input switch
    {
        "spicy" => Seasoning.Spicy,
        "salty" => Seasoning.Salty,
        "sweet" => Seasoning.Sweet,
    };
}

enum SoupType { Soup, Stew, Gumbo }
enum MainIngredient { Mushrooms, Chicken, Carrots, Potatoes }
enum Seasoning { Spicy, Salty, Sweet }
