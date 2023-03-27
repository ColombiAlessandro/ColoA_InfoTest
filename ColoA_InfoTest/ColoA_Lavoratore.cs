using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColoA_InfoTest
{
    public  class ColoA_Lavoratore : ColoA_Candidato
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
    }
}
