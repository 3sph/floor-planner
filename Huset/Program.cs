using Huset;
using System;
using System.Runtime.Intrinsics.Arm;

internal class Program
{
    private static void Main(string[] args)
    {
        Etasje etasje = new Etasje();

        Console.WriteLine("Hei og velkommen til Min husbygger.");
        Console.WriteLine("\nHer kan du legge til rom i en etasje, for å bygge ditt eget hus.");
        Console.WriteLine("Legg til rom på etasjen (skriv 'ferdig' når du er ferdig med rommene):");

        while (true)
        {
            Console.Write("Rom navn: ");
            string romnavn = Console.ReadLine();

            if (romnavn.ToLower() == "ferdig")
            {
                etasje.VisRomPåEtasje();
                break; 
            }

            Console.Write("Rom type: ");
            string romtype = Console.ReadLine();

            
            Rom nyttRom = new Rom(romnavn, romtype);
            {
                romnavn = romnavn;
                romtype = romtype;
            };
            etasje.LeggTilRom(nyttRom);
        }
        Console.WriteLine("Du er nå ferdig med etasjen din.");
    }
}
