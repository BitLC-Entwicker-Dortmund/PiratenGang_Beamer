using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiratenGang_Beamer {
    class Pirat {
        public string Name { get; set; }
        private Gang meineGang;

        public Pirat ( string n) {
            Name = n;
        }

        public void SetGang ( Gang gang) {
            meineGang = gang;
        }

        public Gang GetGang ( ) {
            return meineGang;
        }

        public string GetGangName ( ) {
            return meineGang.Name;
        }
    }
}
