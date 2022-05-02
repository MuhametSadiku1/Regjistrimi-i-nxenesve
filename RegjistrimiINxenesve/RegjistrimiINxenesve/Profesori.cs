using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegjistrimiINxenesve
{
    class Profesori : Personi,IAdd<Nxenesi>
    {

        public Profesori()
        {
            Emri = "Behar";
            Mbiemri = "Vershevci";
            Adresa = "Rr.Tirana";
            NrTelefonit = "045233233";
            Paga = 500;
            Drejtimi = new Drejtimi();
            Lenda = new Lenda();


        }
        public Profesori(string emri, string mbiemri, string adresa, string nrTelefonit, double paga, Drejtimi drejtimi, Lenda lenda) : base(emri, mbiemri, adresa, nrTelefonit)
        {
            Paga = paga;
            Lenda = lenda;
            Drejtimi = drejtimi;
            Lenda = lenda;

        }
        public double Paga { get; set; }
        public Lenda Lenda { get; set; }
        public Drejtimi Drejtimi { get; set; }
        public List<Nxenesi> Nxenesat { get; set; } = new List<Nxenesi>();

        public void ShtoAntarNeLista(Nxenesi nxenesi)
        {

            Nxenesat.Add(nxenesi);
        }
    }
}
