string name = "Ewa";
bool isWomen = true;
var age = 33;

if (isWomen == true)
    if (age < 30)
    {
        Console.WriteLine("Kobieta poniżej 30 lat.");
    }
    else if (name == "Ewa" && age == 33)
    {
        Console.WriteLine("Ewa, lat 33");
    }
    else
    {
        Console.WriteLine("Jestem kobietą po 30.");
    }
if (!(isWomen) && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}