using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework
    ;


namespace Jaratkezelo
{
    class JaratKezelo
    {
        private List<Jarat> jaratLista = new List<Jarat>();
        public void UjJarat(string jaratSzam, string repterHonnan, string repterHova, DateTime indulas) {
            Jarat j1 = new Jarat(jaratSzam, repterHonnan, repterHova, indulas, 0);
            jaratLista.Add(j1);
        }
        public void Keses(string jaratSzam, int keses) {
            foreach (Jarat item in jaratLista)
            {
                if (jaratSzam == item.JaratSzam)
                {
                    item.Keses = keses;
                }
            }

        }
        public DateTime MikorIndul(string jaratSzam) {
            foreach (Jarat item in jaratLista)
            {
                if (jaratSzam == item.JaratSzam)
                {
                    return item.Indulas;
                }
            }
            return DateTime.Parse("00:00");
            
        }
        public List<string> JaratokRepuloterrol(string repter) {
            List<string> repterLista = new List<string>();

            foreach (Jarat item in jaratLista)
            {
                if (repter == item.HonnanRepter)
                {
                    repterLista.Add(repter);
                }
            }
            return repterLista;

        }
    }
}
