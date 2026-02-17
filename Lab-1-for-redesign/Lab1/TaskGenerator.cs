namespace Lab1;

public class TaskGenerator
    {
        // Sugeneruoja random užduotį ir atspausdina informacija
        public static void GeneruotiIrRodyti(string[] args)
        {
            // Tikriname, ar paleista su --challenge
            bool allowChallenge = args.Contains("--challenge");

            // Nustatome maksimalų užduoties numerį: 4 arba 5
            int max = allowChallenge ? 5 : 4;

            // Sukuriame Random objektą
            Random rnd = new();

            // Sugeneruojame užduoties numerį
            int task = rnd.Next(1, max + 1);

            // Jei iškrito 5 – generuojame fallback
            int fallback = 0;
            if (task == 5)
            {
                fallback = rnd.Next(1, 5);
            }

            // Spausdiname bloką (kopijuoti į README.md)
            Console.WriteLine("## Lab 1");
            Console.WriteLine("");
            Console.WriteLine("**Vardas Pavardė:**");
            Console.WriteLine("**Grupė:** PS-5");
            Console.WriteLine("**Paskaitos data:** 2026-02-14");
            Console.WriteLine($"**Random užduotis:** {task}");

            if (fallback > 0)
            {
                Console.WriteLine($"**Fallback (jei #5 per sunki):** {fallback}");
            }

            Console.WriteLine("");
            Console.WriteLine("### Paleidimas");
            Console.WriteLine("dotnet run -- --challenge");
            Console.WriteLine("");
            Console.WriteLine("### Kas įgyvendinta");
            Console.WriteLine("**Užduotis #3: Konsolinis meniu**");
            Console.WriteLine("- Student ir Group klasės su properties");
            Console.WriteLine("- Meniu sistema (Add/Show/Exit)");
            Console.WriteLine("- Dinaminis studentų sąrašas (List<Student>)");
            Console.WriteLine("");
            Console.WriteLine("**Užduotis #5: Validacija + Refactoring**");
            Console.WriteLine("- Live validacija: ID, vardas, el. paštas (@, .), vidurkis (0-10)");
            Console.WriteLine("- Refactoring: logika perkelta iš Program.cs į klases");
            Console.WriteLine("- TaskGenerator klasė random užduoties generavimui");
            Console.WriteLine("");
            Console.WriteLine("### Struktūra");
            Console.WriteLine("- `Program.cs` - koordinavimas");
            Console.WriteLine("- `Student.cs` - studentas (savybės)");
            Console.WriteLine("- `Group.cs` - grupė su validacija ir metodais");
            Console.WriteLine("- `TaskGenerator.cs` - atsitiktinės užduoties generavimas");
        }
    }