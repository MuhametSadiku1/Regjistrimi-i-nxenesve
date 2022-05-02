using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegjistrimiINxenesve
{
    class Klasa : IAdd<Nxenesi>
    {
        public static int count = 1;
        public Klasa()
        {
            Id = count++;
            Paralelja = 1;
        }
        public Klasa(int vitiShkollor, int paralelja, Drejtimi drejtimi)
        {
            Id = count++;
            VitiShkollor = vitiShkollor;
            Paralelja = paralelja;
            Drejtimi = drejtimi;
            Nxenesat = new List<Nxenesi>();
        }
        public int VitiShkollor { get; set; }
        public int Paralelja { get; set; }
        public Drejtimi Drejtimi { get; set; }
        public int Id { get; set; }
        public int NrNxenesve { get { return Nxenesat.Count; } }
        public List<Nxenesi> Nxenesat { get; set; }

        public void ShtoAntarNeLista(Nxenesi nxënesi)
        {
            if (NrNxenesve == 30)
            {
                Console.WriteLine("Nxenesi nuk mund te shtohet tek kjo klase pasi qe" +
                    "kjo klase ka 30 nxenes");
            }
            else
            {
                Nxenesat.Add(nxënesi);
            }
     
        }

    }
}
