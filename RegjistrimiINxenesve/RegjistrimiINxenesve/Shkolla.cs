using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Collections.Generic;

namespace RegjistrimiINxenesve
{
    class Shkolla : IAdd<Klasa>
    {

        public Shkolla()
        {
            EmriShkolles = "Sami Frasheri";
            Komuna = "Prishtine";
            Klaset = new List<Klasa>();
        }

        public string EmriShkolles { get; set; }
        public string Komuna { get; set; }
        public List<Klasa> Klaset { get; set; }
        public List<Nxenesi> Nxenesat{ get; set; }

        public void ShtoAntarNeLista(Klasa klasa)
        {
            Klaset.Add(klasa);
        }

        public void ShfaqKlasat()
        {
            foreach (var item in Klaset)
            {
                if (item == null)
                {
                    
                }
                else
                {   
                    Console.Write("Ne klasen {0}/{1} vijojne mesim: ",item.VitiShkollor,item.Paralelja);
                    item.Nxenesat.ForEach(x => Console.WriteLine("{0},{1}",x.Emri,x.Mbiemri));
                }
                

            }
            


        }
    }
}
