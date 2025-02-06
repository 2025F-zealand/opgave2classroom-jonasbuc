using ClassRoomNet60;
using System.Threading.Channels;

public class Program
{
    public static void Main()
    {
        KlasseRum klasseRum = new KlasseRum
        {
            KlasseNavn = "3B",
            SemesterStart = new DateTime(2022, 9, 1)
        };

        try
        {
            Studerende studerende0 = new Studerende("Jonas Büchner", 11, 17);
            klasseRum.Klasseliste.Add(studerende0);

            Studerende studerende1 = new Studerende("Gorm Wissing", 8, 20);
            klasseRum.Klasseliste.Add(studerende1);

            Studerende studerende2 = new Studerende("Oliver Voigt Brixvig", 4, 12);
            klasseRum.Klasseliste.Add(studerende2);

            Studerende studerende3 = new Studerende("Kevin Warweru", 2, 16);
            klasseRum.Klasseliste.Add(studerende3);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }

        Console.WriteLine($"Klassenavn: {klasseRum.KlasseNavn}");
        Console.WriteLine($"Semesterstart: {klasseRum.SemesterStart.ToShortTimeString}");
        Console.WriteLine($"Studerne");
        foreach (var student in klasseRum.Klasseliste)
        {
            Console.WriteLine($"Navn: {student.Navn}, Fødselsdato: {student.Fødselsdag}/{student.Fødselsmåned} Årstid: {student.Årstid()} ");
        }
        
        klasseRum.tælårstider();
        
    }
    
}