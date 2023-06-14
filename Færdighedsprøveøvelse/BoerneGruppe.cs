using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Færdighedsprøveøvelse
{
    public class BoerneGruppe
    {
        public int ID { get; set; }
        public string Navn { get; set; }
        public string Aldersgruppe { get; set; }
        public int AntalDeltagere { get; set; }

        public override string ToString ()
        { return $"ID" + ID + "Navn" + Navn + "Aldersgruppe" + Aldersgruppe + "AntalDeltagere" + AntalDeltagere; }
        
      
    }
    
}
