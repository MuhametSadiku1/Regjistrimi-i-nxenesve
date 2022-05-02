using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegjistrimiINxenesve
{
    class Lenda
    {
        public static int count = 1;

        public Lenda()
        {
            Id = count++;
            Emri = "Teknologji e Informacionit";
            Drejtimi = new Drejtimi();
          
        }
        public Lenda(string emri, Drejtimi drejtimi, Profesori profesori)
        {
            Id = count++;
            Emri = emri;
            Drejtimi = drejtimi;
        }
        public int Id { get; set; }
        public string Emri { get; set; }
        public Drejtimi Drejtimi { get; set; }

    }
}
