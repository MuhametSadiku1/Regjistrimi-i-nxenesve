using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegjistrimiINxenesve
{
    class Nxenesi :Personi,  IAdd<Profesori>
    {
        
        public Nxenesi() :base()
        {

        }
        
        public int VitiShkollor { get; set; }
        private double mesatarja;

        public double Mesatarja
        {
            get { return mesatarja; }
            set
            {
                if (value > 3)
                {

                    mesatarja = value;
                }
                else
                {
                    throw new Exception("Mesatarja duhet te jete me e madhe se 3");
                }
            }
        }

        public Drejtimi Drejtimi { get; set; }
        //public Klasa Klasa { get; set; }
        public List<Profesori> Profesoret { get; set; } = new List<Profesori>();


        public void InicializoTeDhenat()
        {
            Console.Write("Emri: ");
            Emri = Console.ReadLine();
            Console.Write("Mbiemri: ");
            Mbiemri = Console.ReadLine();
            Console.Write("Adresa: ");
            Adresa = Console.ReadLine();
            Console.Write("Nr I Telefonit: ");
            NrTelefonit = Console.ReadLine();

            Mesa:
            Console.Write("Mesatarja: ");
            try
            {
                Mesatarja = double.Parse(Console.ReadLine());
            }
            catch(NullReferenceException nex)
            {
                Console.WriteLine("{0}",nex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine("{0}",ex.Message);
                goto Mesa;
            }
             
        }
        public void ShtoAntarNeLista(Profesori profesori)
        {
            Profesoret.Add(profesori);

        }

    }
}
