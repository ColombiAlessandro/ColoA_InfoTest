using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColoA_InfoTest
{
    public  class ColoA_Lavoratore : ColoA_Candidato, IEquatable<ColoA_Lavoratore>, IComparable<ColoA_Lavoratore>
    {
        private int ColoA_esperienze;
        public int ColoA_Esperienze
        {
            get { return ColoA_esperienze; }
            set { if (value >= 0 && value <= 5)
                {
                    ColoA_esperienze = value;
                }
            }
        }
        public ColoA_Lavoratore(): base()
        {
            ColoA_Esperienze = 0;
        }
        public ColoA_Lavoratore(int esperienze, int matricola, string nome) : base (matricola, nome)
        {
            ColoA_Esperienze = esperienze;
        }
        public override int punteggio()
        {
            return 20 * ColoA_Esperienze;
        }
        public override bool isIdoneo()
        {
            return punteggio() >= 60;
        }
        public override string ToString()
        {
            return base.ToString() + ColoA_Esperienze.ToString() + ";";
        }
        public bool Equals(ColoA_Lavoratore cand)
        {
            bool controllo = base.Equals(cand);
            if (cand.ColoA_Esperienze != this.ColoA_Esperienze)
            {
                controllo = false;
            }
            return controllo;
        }
        public int CompareTo(ColoA_Lavoratore lav)
        {
            if (this.punteggio() < lav.punteggio())
            {
                return -1;

            } else if(this.punteggio()> lav.punteggio())
            {
                return 1;
            }
            return 0;

        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
