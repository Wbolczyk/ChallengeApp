using ChallengeApp;

Console.WriteLine("Witamy w programie XYZ do oceny pracowników");
Console.WriteLine("===========================================");
Console.WriteLine();

var employee = new Employee("Wojciech", "Kowalski", 40);

while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    employee.AddGrade(input);
}

var statistics = employee.GetStatistics();
Console.WriteLine($"Pracownik: {employee.Name} {employee.SurName}, wiek {employee.Age}");
Console.WriteLine($"Ocena Min: {statistics.Min}");
Console.WriteLine($"Ocena Max: {statistics.Max}");
Console.WriteLine($"Średnia ocena pracownika: {statistics.Average:N2} ==> {statistics.AverageLetter}");
Console.WriteLine( );

SetSth(out statistics);
void SetSth(out Statistics statistics)
{
    statistics = new Statistics();
}