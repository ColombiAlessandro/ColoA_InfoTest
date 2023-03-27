using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColoA_InfoTest
{
    public class ColoA_Disoccupato : ColoA_Candidato
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
    }
}