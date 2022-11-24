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

            List<Pirat> piratenListe = Program.Get0815Piraten ( 20 );
            g.AddPirat ( piratenListe, g );

            g.ZeigePiratenDerGang ( );

            Console.Read ( );
        } // ende Hauptprogramm

        public static List<Pirat> Get0815Piraten ( int anzahl) {
            List<Pirat> pl = new List<Pirat>();
            Random zg = new Random ( );

            // Liste mit 0815 Piraten erzeugen
            for ( int i = 0 ; i < anzahl ; i++ ) {
                pl.Add ( new Pirat ( zg.Next(0815, 1816) +"-0815 Pirat" ) );
                
                //pl [ i ] = new Pirat ( "0815" );
            }

            return pl;
        }
    }
}
