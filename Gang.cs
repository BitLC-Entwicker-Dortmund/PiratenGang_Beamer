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
    }
}
