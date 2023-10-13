using ChallengeApp;

var employee = new Employee("Wojciech", "Kowalski", 40);

employee.AddGrade(1);
employee.AddGrade(2);
employee.AddGrade("10");
employee.AddGrade("20");
employee.AddGrade(30);

var statistics = employee.GetStatisticsWithForeach();
Console.WriteLine("Wyniki dla pętli Foreach:");
Console.WriteLine($"Pracownik: {employee.Name} {employee.SurName}, wiek {employee.Age}");
Console.WriteLine($"Średnia ocena pracownika: {statistics.Average:N2}");
Console.WriteLine($"Ocena Min: {statistics.Min}");
Console.WriteLine($"Ocena Max: {statistics.Max}");
Console.WriteLine();

var statistics2 = employee.GetStatisticsWithFor();
Console.WriteLine("Wyniki dla pętli For:");
Console.WriteLine($"Pracownik: {employee.Name} {employee.SurName}, wiek {employee.Age}");
Console.WriteLine($"Średnia ocena pracownika: {statistics2.Average:N2}");
Console.WriteLine($"Ocena Min: {statistics2.Min}");
Console.WriteLine($"Ocena Max: {statistics2.Max}");
Console.WriteLine();

var statistics3 = employee.GetStatisticsWithDoWhile();
Console.WriteLine("Wyniki dla pętli DoWhile:");
Console.WriteLine($"Pracownik: {employee.Name} {employee.SurName}, wiek {employee.Age}");
Console.WriteLine($"Średnia ocena pracownika: {statistics3.Average:N2}");
Console.WriteLine($"Ocena Min: {statistics3.Min}");
Console.WriteLine($"Ocena Max: {statistics3.Max}");
Console.WriteLine();

var statistics4 = employee.GetStatisticsWithWhile();
Console.WriteLine("Wyniki dla pętli While:");
Console.WriteLine($"Pracownik: {employee.Name} {employee.SurName}, wiek {employee.Age}");
Console.WriteLine($"Średnia ocena pracownika: {statistics4.Average:N2}");
Console.WriteLine($"Ocena Min: {statistics4.Min}");
Console.WriteLine($"Ocena Max: {statistics4.Max}");


SetSth(out statistics);
void SetSth(out Statistics statistics)
{
    statistics = new Statistics();
}