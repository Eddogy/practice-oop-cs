namespace Lab1.Models;

// Primary constructor
// Model – tik saugo duomenis
public class Group(string pavadinimas)
{
    // Grupės pavadinimas – tik skaityti iš išorės
    public string Pavadinimas { get; } = pavadinimas;

    // Studentų sąrašas – GroupService galės matyti ir pridėti studentus
    public List<Student> Studentai { get; } = [];
}