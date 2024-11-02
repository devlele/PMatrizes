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
    public partial class frmEercicio5 : Form
    {
        string auxiliar = "";

        public frmEercicio5()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            char[,] respostas = new char[10, 10];
            char[] gabarito = new char[10] { 'A', 'C', 'D', 'E', 'A', 'B', 'B', 'C', 'A', 'A' };
            string[,] saida = new string[10,10];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    auxiliar = Interaction.InputBox($"Digite a resposta da {j + 1}º questão do {i+1}º aluno", "Entrada de respostas");

                    if (!char.TryParse(auxiliar, out respostas[i, j]))
                    {
                        MessageBox.Show("Valor inválido");
                        j--;
                        continue;
                    }

                    if (auxiliar != "A" && auxiliar != "B" && auxiliar != "C" && auxiliar != "D" && auxiliar != "E")
                    {
                        MessageBox.Show("A resposta deve ser A, B, C, D ou E");
                        j--;
                        continue;
                    }
                }
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (gabarito[j] == respostas[i, j])
                    {
                        saida[i,j] = $"\n O aluno: {i + 1} acertou a questão {j + 1}: era {gabarito[j]}, escolheu {respostas[i, j]}\n";
                    }
                    else
                    {
                        saida[i,j] = $"\nO aluno: {i + 1} errou a questão {j + 1}: era {gabarito[j]}, escolheu {respostas[i, j]}\n";
                    }
                }
            }

            for (int i = 0; i < 10; i++)
            {
                for(int j = 0;  j < 10; j++)
                {
                    lstbxResultado.Items.Add(saida[i,j]);
                }
            }
        }
    }

}
