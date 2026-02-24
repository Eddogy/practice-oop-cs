using Lab1.Models;

namespace Lab1.Services;

// Service – veiksmai su duomenimis
public class GroupService
{
    // Prideda studentą į grupę
    public void PridetiStudenta(Group grupe, Student studentas)
    {
        grupe.Studentai.Add(studentas);
    }

    // Skaičiuoja grupės vidurkį
    public double SkaiciuotiVidurki(Group grupe)
    {
        if (grupe.Studentai.Count == 0) return 0;
        return grupe.Studentai.Average(s => s.GetVidurkis());
    }
}