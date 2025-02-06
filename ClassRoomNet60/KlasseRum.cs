using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    internal class KlasseRum
    {
        public string KlasseNavn { get; set; }
        public List<Studerende> Klasseliste { get; set; }
        public DateTime SemesterStart { get; set; }

        public KlasseRum() 
        { 
        Klasseliste = new List<Studerende>();
        }

        public void tælårstider() 
        { 
            var vinter = Klasseliste.Count(s => s.Årstid() == "Vinter");
            var Forår = Klasseliste.Count(s => s.Årstid() == "Forår");
            var Sommer = Klasseliste.Count(s => s.Årstid() == "Sommer");
            var Efterår = Klasseliste.Count(s => s.Årstid() == "Efterår");
            Console.WriteLine($"Der er så mange der har fødselsdag om vintern {vinter}");
            Console.WriteLine($"Der er så mange der har fødselsdag om Foråret {Forår}"); ;
            Console.WriteLine($"Der er så mange der har fødselsdag om Sommern {Sommer}");
            Console.WriteLine($"Der er så mange der har fødselsdag om Efteråret {Efterår}");
        }
    }
    
}
