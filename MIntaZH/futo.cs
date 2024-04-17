using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIntaZH
{
    public class futo
    {
        //VersenyzoID,Nev,Nemzetiseg,EredmenyPerc,Kategoria
        public int VersenyzoID { get; set; }
        public string Nev { get; set; } = string.Empty;
        public string Nemzetiseg { get; set; } = string.Empty;
        public int EredmenyPerc { get; set; }
        public string Kategoria { get; set; } = string.Empty;

        internal void Add(futo futo)
        {
            throw new NotImplementedException();
        }
    }
}
