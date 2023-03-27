using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColoA_InfoTest
{
    public abstract class ColoA_Candidato
    {
        private int ColoA_matricola;
        private string ColoA_nome;
        public string ColoA_Nome
        {
            get { return ColoA_nome; }
            set { ColoA_nome = value; }
        }
        public int ColoA_Matricola
        {
            get { return ColoA_matricola; }
            set { ColoA_matricola = value; }
        }
        public ColoA_Candidato()
        {
            ColoA_nome = null;
            ColoA_matricola = 0;
        }
        public ColoA_Candidato(int matricola)
        {
            ColoA_Matricola = matricola;
            ColoA_nome = null;
        }
        public ColoA_Candidato(string nome)
        {
            ColoA_matricola = 0;
            ColoA_Nome = nome;
        }
        public ColoA_Candidato(int matricola, string nome)
        {
            ColoA_Nome = nome;
            ColoA_Matricola = matricola;
        }
        public abstract bool isIdoneo();
        public abstract int punteggio();
    }
}