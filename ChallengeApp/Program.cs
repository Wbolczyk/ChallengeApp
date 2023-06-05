var name = "Ewa";
int age = 33;
bool isWomen = true;

if (name != "Ewa" && age < 30 && isWomen == true)

    Console.WriteLine("Kobieta poniżej 30 lat");

else if (age < 17 && isWomen == false)

    Console.WriteLine("Niepełnoletni mężczyzna");

else if (name == "Ewa" && age == 33)

    Console.WriteLine("Ewa lat 33");

else

    Console.WriteLine("Żaden warunek nie jest spełniony");