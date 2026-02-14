namespace Lab1;

public class Group
    {
        public string Pavadinimas { get; set; } = "";

        // Sąrašas studentų (List = dinaminis masyvas)
        public List<Student> Studentai { get; set; } = [];

        // Metodas: pridėti studentą į grupę
        public void PridetiStudenta(Student studentas)
        {
            Studentai.Add(studentas);
        }

        // Metodas: parodyti visus studentus
        public void RodytiVisus()
        {
            Console.WriteLine("\nStudentai grupėje: " + Pavadinimas);

            if (Studentai.Count == 0)
            {
                Console.WriteLine("Nėra studentų!");
                return;
            }

            foreach (Student s in Studentai)
            {
                Console.WriteLine($"ID: {s.Id}, Vardas: {s.Vardas}, El.paštas: {s.ElPastas}, Vidurkis: {s.Vidurkis}");
            }
        }

        // UŽDUOTIS #5
        // Metodas: pridėti naują studentą su validacija
        public void PridetiNaujaStudenta()
        {
            Console.WriteLine("\nNaujas studentas");

            // ID įvedimas su validacija
            int id;
            while (true)
            {
                Console.Write("Įvesk ID: ");
                string input = Console.ReadLine() ?? "";

                if (int.TryParse(input, out id))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("KLAIDA: ID turi būti skaičius!");
                }
            }

            // Vardo įvedimas su validacija
            string vardas;
            while (true)
            {
                Console.Write("Įvesk vardą: ");
                vardas = Console.ReadLine() ?? "";

                if (!string.IsNullOrWhiteSpace(vardas) && !vardas.Any(char.IsDigit))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("KLAIDA: Vardas turi būti žodis");
                }
            }

            // El. pašto įvedimas su validacija
            string elpastas;
            while (true)
            {
                Console.Write("Įvesk el. paštą: ");
                elpastas = Console.ReadLine() ?? "";

                if (elpastas.Contains('@') && elpastas.Contains('.'))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("KLAIDA: El. paštas turi turėti @ ir . (pvz: vardas@gmail.com)!");
                }
            }

            // Vidurkio įvedimas su validacija
            double vidurkis;
            while (true)
            {
                Console.Write("Įvesk vidurkį: ");
                string input = Console.ReadLine() ?? "";

                if (double.TryParse(input, out vidurkis) && vidurkis >= 0 && vidurkis <= 10)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("KLAIDA: Vidurkis turi būti skaičius nuo 0 iki 10!");
                }
            }

            // Sukuriame studentą
            Student naujas = new()
            {
                Id = id,
                Vardas = vardas,
                ElPastas = elpastas,
                Vidurkis = vidurkis
            };

            // Pridedame į sąrašą
            Studentai.Add(naujas);
            Console.WriteLine("\nstudentas pridėtas!");
        }
    }
