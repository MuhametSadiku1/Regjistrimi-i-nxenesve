using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegjistrimiINxenesve
{
    abstract class Personi
    {
        public static int count = 1;
        public Personi()
        {
            Id = count++;
        }
        public Personi(string emri, string mbiemri, string adresa, string nrTelefonit)
        {
            Id = count++;
            Emri = emri;
            Mbiemri = mbiemri;
            Adresa = adresa;
            NrTelefonit = nrTelefonit;
        }
        public int Id { get; set; }
        public string Emri { get; set; }
        public string Mbiemri { get; set; }
        public string Adresa { get; set; }
        public string NrTelefonit { get; set; }






    }
}
