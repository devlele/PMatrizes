using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace PMatrizes
{
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            string[] vetorNomes = new string[10];
            string[] vetor = new string[10];
            int[] tamanhoNome = new int[10];
            string[] saida = new string[10];

            for (int i = 0; i < 10; i++)
            {
                vetorNomes[i] = Interaction.InputBox($"Digite o {i+1}º nome", "Coleta de nomes");
                vetor[i] = vetorNomes[i].Replace(" ", "");
                tamanhoNome[i] = vetor[i].Length;
            }
            for(int i = 0; i < 10;i++)
            {
                saida[i] += "\nO nome: " + vetorNomes[i] + " tem " + tamanhoNome[i] + " caracteres" + "\n";
            }
            
            for(int i = 0; i < 10; i++)
            {
                lstbxSaida.Items.Add(saida[i]);
            }
            

        }
    }
}
