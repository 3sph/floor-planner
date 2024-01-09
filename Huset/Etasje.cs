using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;

namespace Huset
{
    internal class Etasje
    {
        public List<Rom> RomIEtasje { get; }
        private List<string> romTyper;

        public Etasje()
        {
            RomIEtasje = new List<Rom>();
            romTyper = new List<string>();
        }

        public void LeggTilRom(Rom rom)
        {
            if (RomIEtasje.Count >= 5)
            {
                Console.WriteLine("Beklager, du kan bare ha 5 rom per etasje.");
                return;
            }

            if (romTyper.Contains(rom.Romtype))
            {
                Console.WriteLine($"Beklager, et {rom.Romtype} finnes allerede på denne etasjen.");
                return;
            }

            RomIEtasje.Add(rom);
            romTyper.Add(rom.Romtype);
            Console.WriteLine($"La til {rom.Romnavn} på etasjen.");
        }
        public void VisRomPåEtasje()
        {
            Console.WriteLine("\nRom på etasjen:");
            foreach (var rom in RomIEtasje)
            {
                Console.WriteLine($"Romnavn: {rom.Romnavn}, Romtype: {rom.Romtype}");
            }
        }

    }
}
