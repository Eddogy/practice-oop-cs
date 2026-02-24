## Lab 1

**Vardas Pavardė:** Edgaras Mitkus
**Grupė:** PS-5
**Paskaitos data:** 2026-02-14
**Random užduotis:** 5
**Fallback (jei #5 per sunki):** 3

### Paleidimas
dotnet run -- --challenge

### Kas įgyvendinta
**Užduotis #3: Konsolinis meniu**
- Sukurtos `Student` ir `Group` klasės pagal OOP principus
- Pilnas konsolinis meniu (1 - Pridėti, 2 - Rodyti, 0 - Išeiti)
- Dinaminis studentų sąrašas (`List<Student>`)

**Užduotis #5: Validacija + Refactoring + OOP**
- **Live validacija** įvedant naują studentą:
  - ID (tik skaičius)
  - Vardas (tik raidės, negali būti tuščias)
  - El. paštas (turi turėti `@` ir `.`)
  - Vidurkis (nuo 0 iki 10)
- **Pilnas refactoring** pagal Model / Service / Program architektūrą:
  - `Model` – tik duomenys, nė vieno `Console`
  - `Service` – veiksmai su duomenimis (pridėti, skaičiuoti vidurkį)
  - `Program` – visa Console logika, validacija, meniu
  - `private` laukai pakeisti į `public { get; }` kur reikia Service prieigos
  - Konstruktoriai su primary constructor sintakse (.NET 10)
- `TaskGenerator` klasė atsitiktinei užduočiai generuoti

### Struktūra

Lab1/
├── Program.cs             `– UI (Console, meniu, validacija)`
├── Models/
│   ├── Student.cs         `– Model (duomenys: id, vardas, el. paštas, vidurkis)`
│   └── Group.cs           `– Model (duomenys: pavadinimas, studentų sąrašas)`
├── Services/
│   └── GroupService.cs    `– Service (pridėti studentą, skaičiuoti vidurkį)`
└── Utilities/
    └── TaskGenerator.cs   `– pagalbinis įrankis atsitiktinei užduočiai generuoti`