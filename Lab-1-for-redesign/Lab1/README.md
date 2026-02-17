## Lab 1

**Vardas Pavardė:** 
**Grupė:** PS-5
**Paskaitos data:** 
**Random užduotis:** 5
**Fallback (jei #5 per sunki):** 3

### Paleidimas
dotnet run -- --challenge

### Kas įgyvendinta
**Užduotis #3: Konsolinis meniu**
- Student ir Group klasės su properties
- Meniu sistema (Add/Show/Exit)
- Dinaminis studentų sąrašas (List<Student>)

**Užduotis #5: Validacija + Refactoring**
- Live validacija: ID, vardas, el. paštas (@, .), vidurkis (0-10)
- Refactoring: logika perkelta iš Program.cs į klases
- TaskGenerator klasė random užduoties generavimui

### Struktūra
- `Program.cs` - koordinavimas
- `Student.cs` - studentas (savybės)
- `Group.cs` - grupė su validacija ir metodais
- `TaskGenerator.cs` - atsitiktinės užduoties generavimas