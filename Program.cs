using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiratenGang_Beamer {
    class Program {
        static void Main ( string [ ] args ) {
            Pirat pirat = new Pirat ( "Svenni" );
            Gang g = new Gang ( );
            g.GangId = 1;
            g.Name = "Standardgang";

            g.AddPirat ( pirat, g );

            Console.WriteLine ( pirat.GetGangName() );

            List<Pirat> piratenListe = Get0815Piraten ( );

            

            
            Console.Read ( );
        } // ende Hauptprogramm

        public static List<Pirat> Get0815Piraten ( ) {
            List<Pirat> pl = new List<Pirat>();

            return pl;
        }
    }
}
