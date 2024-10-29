using System;
using System.Collections;
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
    public partial class Form1 : Form
    {
        string auxiliar = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnExercicio1_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[20]; // sintaxe para criar vetor

            for(int i = 0; i < 20; i++)
            {
                auxiliar = Interaction.InputBox("Digite um número", "Entrada de dados"); // para incluir entrar no menu Projeto
                //> Adicionar Referencia
                //> Selecionar microsoft.visualbasic.
                //Depois adicionar nas bibliotecas 'using Microsoft.VisualBasic;'
                // O primeiro parametro é o texto ao lado da caixa de entrada
                // O segundo é p texto de cabeçalho

                if(!int.TryParse(auxiliar, out vetor[i]))
                {
                    MessageBox.Show("Número inválido");
                    i--; // decrementa um i para ler de novo 
                }
            }

            Array.Reverse(vetor);
            auxiliar = "";
            foreach(int i in vetor)
            {
                auxiliar += i + "\n";
            }

            MessageBox.Show(auxiliar);
        }

        private void btnExercicio2_Click(object sender, EventArgs e)
        {
            string aux = "";

            ArrayList lista = new ArrayList() // Sintaxe de criação de uma lista dinâmica. Necessario ter "using System.Collections
            {
                "Ana", "André", "Débora","Fátima", "João", "Janete", "Otávio", "Marcelo", "Pedro", "Thais"
            };
            lista.Remove("Otávio");

            foreach(string i in lista)
            {
                aux += i + "\n";
            }

            MessageBox.Show(aux);
        }

        private void btnExercicio3_Click(object sender, EventArgs e)
        {
            double[] medias = new double[20];
            double[,] notas = new double[20, 3]; //Sintaxe para criação de matriz
            string resultado = "";
            for(int i = 0; i < 20; i++)// Para acessar os alunos
            {
                for(int j = 0; j < 3; j++)// Para acessar as notas
                {
                    auxiliar = "";
                    auxiliar = Interaction.InputBox($"Dígite as notas do {i+1}º aluno", "Entrada das notas");

                    if (!Double.TryParse(auxiliar, out notas[i, j]))
                    {
                        MessageBox.Show("Valor inválido");
                    }
                    if (notas[i,j] < 0 || notas[i,j] > 10)
                    {
                        MessageBox.Show("As notas precisam estar entre 0 e 10");
                        j--;
                    }
                }
            }

            for(int i = 0; i < 20;i++)//Percorre os alunos e calcula a media
            {
                medias[i] = (notas[i, 0] + notas[i, 1] + notas[i, 2]) / 3;
            }

            for(int i = 0; i < 20; i++)//Atribui cada media no vetor ao resultado usando cocaternação
            {
                resultado += "Aluno: " + (i + 1) + " Média: " + medias[i] + "\n";
            }

            MessageBox.Show(resultado);
        }

        private void btnExercicio4_Click(object sender, EventArgs e)
        {
            frmExercicio4 obj = new frmExercicio4();
            obj.Show();
        }
    }
}
