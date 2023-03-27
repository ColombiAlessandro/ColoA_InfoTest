using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColoA_InfoTest
{
    public partial class Form1 : Form
    {
        List<ColoA_Candidato> ColoA_Candidati;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] Intestazione = new string[] { "Matricola", "Nome" };
            foreach(string intestazione in Intestazione)
            {
                listView1.Columns.Add(intestazione);
            }
        }
        public void AddCandidato(ColoA_Candidato cand)
        {
            if (cand != null)
            {
                ColoA_Candidati.Add(cand);
            }
            else throw new Exception("Il valore inserito è nullo");
        } 
        public string[] Visualizza()
        {
            string[] elenco = new string[ColoA_Candidati.Count];
            for(int i=0; i < ColoA_Candidati.Count; i++)
            {
                elenco[i] = ColoA_Candidati[i].ToString();  
            }
            return elenco;
        }
        public void Modifica(string nome, int matricolaRicerca)
        {
            for(int i=0; i < ColoA_Candidati.Count; i++)
            {
                if (ColoA_Candidati[i].ColoA_Matricola == matricolaRicerca)
                {
                    ColoA_Candidati[i].ColoA_Nome = nome;
                }
            }
        }
        public ColoA_Candidato Elimina(int matricolaRicerca)
        {
            for (int i = 0; i < ColoA_Candidati.Count; i++)
            {
                if (ColoA_Candidati[i].ColoA_Matricola == matricolaRicerca)
                {
                    ColoA_Candidato tmp = ColoA_Candidati[i];
                    ColoA_Candidati.RemoveAt(i);
                    return tmp;
                }
            }
            throw new Exception("Candidato non trovato");
        }
        public string[] visualizzaIdonei()
        {
            string[] visualizzaIdonei = new string[ColoA_Candidati.Count];
            int i = 0;
            foreach(ColoA_Candidato can in ColoA_Candidati)
            {

                if (can.isIdoneo())
                {
                    visualizzaIdonei[i] = can.ToString();
                }
                i++;
            }
            return visualizzaIdonei;
        }
        public void OrdinaDec()
        {
            ColoA_Candidati.Sort();
            ColoA_Candidati.Reverse();
        }
    }
}
