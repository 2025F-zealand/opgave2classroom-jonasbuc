using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    internal class Studerende
    {
        public string Navn { get; private set; }
        public int Fødselsmåned { get; private set; }
        public int Fødselsdag { get; private set; }

        public Studerende(string navn, int fødselsmåned, int fødselsdag)
        {
            Navn = navn;
            if (fødselsmåned > 1 && fødselsmåned < 12) 
            {
                throw new ArgumentException("indtast en Dato mellem 1 og 12");
            }
            Fødselsmåned = fødselsmåned;
            Fødselsdag = fødselsdag;
        }
        public string Årstid()
        {
            if (Fødselsmåned == 12 || Fødselsmåned == 1 || Fødselsmåned == 2)
                return "Vinter";
            else if (Fødselsmåned >= 3 && Fødselsmåned <= 5)
                return "Forår";
            else if (Fødselsmåned >= 6 && Fødselsmåned <= 8)
                return "Sommer";
            else
                return "Efterår";
        }
    }

    
}
