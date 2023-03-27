using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColoA_InfoTest
{
    public class ColoA_Disoccupato : ColoA_Candidato, IEquatable<ColoA_Disoccupato>, IComparable<ColoA_Disoccupato>
    {
        private int ColoA_voto;
        private bool ColoA_lode;
        public int ColoA_Voto
        {
            get { return ColoA_voto; }
            set {
                if (value >= 0 && value <= 110)
                {
                    ColoA_voto = value;
                }
                
            }
        }
        public bool ColoA_Lode
        {
            get { return ColoA_lode; }
            set { ColoA_lode = value; }
        }
        public ColoA_Disoccupato(): base()
        {
            ColoA_Voto = 0;
            ColoA_Lode = false;
        }
        public ColoA_Disoccupato(int voto, bool lode, int matricola, string nome): base (matricola, nome)
        {
            ColoA_Voto = voto;
            ColoA_Lode= lode;
        }
        public override int punteggio()
        {
            int tmp = (ColoA_Voto * 100) / 110;
            if (ColoA_Lode)
            {
                tmp += 5;
            }
            return tmp;
        }
        public override bool isIdoneo()
        {
            return this.punteggio() >= 72;
        }
        public override string ToString()
        {
            return base.ToString() + ColoA_Voto.ToString() + ";" + ColoA_Lode.ToString() + ";";
        }
        public bool Equals(ColoA_Disoccupato cand)
        {
            bool controllo = base.Equals(cand);
            if (cand.ColoA_Lode != this.ColoA_Lode)
            {
                controllo = false;
            }
            if (cand.ColoA_Voto != this.ColoA_Voto)
            {
                controllo = false;
            }
            return controllo;
        }
        public int CompareTo(ColoA_Disoccupato dis)
        {
            if (this.punteggio() < dis.punteggio())
            {
                return -1;
            } else if(this.punteggio() > dis.punteggio())
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