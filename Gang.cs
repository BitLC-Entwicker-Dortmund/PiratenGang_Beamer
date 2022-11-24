using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiratenGang_Beamer {
    class Gang {
        public string Name { get; set; }
        public int GangId { get; set; }

        private List<Pirat> piraten = new List<Pirat> ( );

        public void AddPirat ( Pirat p, Gang meineGang) {
            p.SetGang ( meineGang );
            piraten.Add ( p );
        }

        public void AddPirat ( List<Pirat> pl , Gang meineGang ) {
            // sage jedem Pirat, in welcher Gang dieser ist
            foreach ( Pirat pirat in pl ) {
                pirat.SetGang ( meineGang );
            }
            // Aneinanderhängen der List pl an die Liste piraten
            piraten.AddRange ( pl );
        }

        public void ZeigePiratenDerGang ( ) {
            foreach ( Pirat einPirat in piraten ) {
                Console.WriteLine ( einPirat.GetGang().GangId 
                    +" " +einPirat.GetGang().Name +" " +einPirat.Name);
            }
        }

    }
}
