using ChallengeApp;

Employee pracownik1 = new Employee("Wojciech", "Kowalski", 40, 0);
Employee pracownik2 = new Employee("Aleksandra", "Nowak", 44, 0);
Employee pracownik3 = new Employee("Sławomir", "Nowak", 46, 0);

pracownik1.AddScore(1);
pracownik1.AddScore(2);
pracownik1.AddScore(3);
pracownik1.AddScore(4);
pracownik1.AddScore(5);

pracownik2.AddScore(3);
pracownik2.AddScore(4);
pracownik2.AddScore(5);
pracownik2.AddScore(6);
pracownik2.AddScore(7);

pracownik3.AddScore(2);
pracownik3.AddScore(3);
pracownik3.AddScore(4);
pracownik3.AddScore(5);
pracownik3.AddScore(6);

var result1 = pracownik1.Result;
var result2 = pracownik2.Result;
var result3 = pracownik3.Result;

Console.WriteLine("Wyniki pracowników to " + pracownik1.Name + " => " + result1 + " " + pracownik2.Name + " => " + result2
    + " " + pracownik3.Name + " => " + result3);

List<Employee> pracownicy = new List<Employee>()
{
pracownik1, pracownik2, pracownik3,
};

int maxResult = -1;
Employee pracownikWithMaxResult = null;

foreach (var employee in pracownicy)
{
    if (employee.Result > maxResult)
    {
        maxResult = employee.Result;
        pracownikWithMaxResult = employee;
    }
}

Console.WriteLine("Najlepszy wynik ma " + pracownikWithMaxResult.Name + " " 
    + pracownikWithMaxResult.SurName + ", Wiek " + pracownikWithMaxResult.Age
    + ", Liczba punktów " + pracownikWithMaxResult.Result);