using System;

class Program
{
    static void Main(string[] args)
    {
        string firstName = "Олексанлр";
        string lastName = "Шевченко";
        int age = 23;
        int yearsUntil40 = 40 - age;

        Console.WriteLine($"Моє повне ім'я та прізвище: {firstName} {lastName}");
        Console.WriteLine($"До початку нового життя залишилось {yearsUntil40} років");
    }
}
