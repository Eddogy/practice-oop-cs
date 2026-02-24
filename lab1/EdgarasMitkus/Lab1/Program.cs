using Lab1.Models;
using Lab1.Services;
using Lab1.Utilities;

// Atsitiktinės užduoties generavimas
new TaskGenerator("Edgaras Mitkus", "PS-5", "2026-02-14").GeneruotiIrRodyti(args);

// Model ir Service sukūrimas
Group grupe = new("PS-5");
GroupService service = new();

Console.WriteLine("\n\nUŽDUOTIS #3 ir #5: Studentų valdymas + validacija");

// Meniu ciklas
while (true)
{
    Console.WriteLine("\nMeniu:");
    Console.WriteLine("1 - Pridėti studentą");
    Console.WriteLine("2 - Rodyti visus studentus");
    Console.WriteLine("0 - Išeiti");
    Console.Write("\nPasirinkimas: ");

    string pasirinkimas = Console.ReadLine() ?? "";

    if (pasirinkimas == "1")
    {
        // Validacija ir Console logika – čia, ne Group klasėje
        Console.WriteLine("\nNaujas studentas");

        int id;
        while (true)
        {
            Console.Write("Įvesk ID: ");
            if (int.TryParse(Console.ReadLine(), out id)) break;
            Console.WriteLine("KLAIDA: ID turi būti skaičius!");
        }

        string vardas;
        while (true)
        {
            Console.Write("Įvesk vardą: ");
            vardas = Console.ReadLine() ?? "";
            if (!string.IsNullOrWhiteSpace(vardas) && !vardas.Any(char.IsDigit)) break;
            Console.WriteLine("KLAIDA: Vardas turi būti žodis be skaičių!");
        }

        string elpastas;
        while (true)
        {
            Console.Write("Įvesk el. paštą: ");
            elpastas = Console.ReadLine() ?? "";
            if (elpastas.Contains('@') && elpastas.Contains('.')) break;
            Console.WriteLine("KLAIDA: El. paštas turi turėti @ ir . !");
        }

        double vidurkis;
        while (true)
        {
            Console.Write("Įvesk vidurkį: ");
            if (double.TryParse(Console.ReadLine(), out vidurkis) && vidurkis >= 0 && vidurkis <= 10) break;
            Console.WriteLine("KLAIDA: Vidurkis nuo 0 iki 10!");
        }

        Student naujas = new(id, vardas, elpastas, vidurkis);
        service.PridetiStudenta(grupe, naujas);
        Console.WriteLine("\nStudentas pridėtas!");
    }
    else if (pasirinkimas == "2")
    {
        // Rodymas – čia, ne Group klasėje
        Console.WriteLine($"\nStudentai grupėje: {grupe.Pavadinimas}");

        if (grupe.Studentai.Count == 0)
        {
            Console.WriteLine("Nėra studentų!");
        }
        else
        {
            foreach (Student s in grupe.Studentai)
            {
                Console.WriteLine(s.GetInfo());
            }
            Console.WriteLine($"Grupės bendras vidurkis: {service.SkaiciuotiVidurki(grupe):F2}");
        }
    }
    else if (pasirinkimas == "0")
    {
        Console.WriteLine("\nPrograma baigta.\n");
        break;
    }
    else
    {
        Console.WriteLine("Neteisingas pasirinkimas!");
    }
}