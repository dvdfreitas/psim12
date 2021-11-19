using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritmos
{
    public partial class Form1 : Form
    {
        static int TOTAL = 10;
        static int LARGURA = 100;
        static int ALTURA = 100;

        Button[] tabuleiro = new Button[TOTAL];
        Button ex1Button = new Button();
        Button ex2Button = new Button();
        Button resultadoEx1 = new Button();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            criarBotoes();
            criarEx1();
            criarEx2();

        }

        public void criarBotoes()
        {
            for (int posX = 0; posX < TOTAL; posX++)
            {
                tabuleiro[posX] = new Button();
                tabuleiro[posX].Location = new Point(LARGURA * posX, 300);
                tabuleiro[posX].Height = ALTURA;
                tabuleiro[posX].Width = LARGURA;
                tabuleiro[posX].Font = new Font("Arial", 20);
                tabuleiro[posX].BackColor = Color.White;

                Controls.Add(tabuleiro[posX]);
            }
        }

        public void criarEx1()
        {
            ex1Button = new Button();
            ex1Button.Text = "Exercício 1";
            ex1Button.Click += new EventHandler(Ex1Button_Click);
            ex1Button.Width = 100;
            ex1Button.Height = 100;
            ex1Button.Location = new Point(0, 0);
            Controls.Add(ex1Button);


            resultadoEx1.Width = 100;
            resultadoEx1.Height = 100;
            resultadoEx1.BackColor = Color.White;
            resultadoEx1.Location = new Point(0, 100);
            resultadoEx1.Font = new Font("Arial", 20);

            Controls.Add(resultadoEx1);

            Random fabricaAleatorios = new Random();


            for (int i = 0; i < TOTAL; i++)
            {
                int nAleatorio = fabricaAleatorios.Next(100);
                tabuleiro[i].Text = "" + nAleatorio;
            }
        }

        public void criarEx2()
        {
            ex2Button = new Button();
            ex2Button.Text = "Exercício 2";
            ex2Button.Click += new EventHandler(Ex2Button_Click);
            ex2Button.Width = 100;
            ex2Button.Height = 100;
            ex2Button.Location = new Point(100, 0);
            Controls.Add(ex2Button);

            resultadoEx1.Width = 100;
            resultadoEx1.Height = 100;
            resultadoEx1.BackColor = Color.White;
            resultadoEx1.Location = new Point(0, 100);
            resultadoEx1.Font = new Font("Arial", 20);

            Random fabricaAleatorios = new Random();

            for (int i = 0; i < TOTAL; i++)
            {
                int nAleatorio = fabricaAleatorios.Next(100);
                tabuleiro[i].Text = "" + nAleatorio;
            }
        }

        private void Ex1Button_Click(object sender, EventArgs e)
        {

            ex1Button.Enabled = false;
            resultadoEx1.Text = tabuleiro[0].Text;
            tabuleiro[0].BackColor = Color.Blue;
            Thread.Sleep(500);
            Application.DoEvents();
            tabuleiro[0].BackColor = Color.White;

            int menor = Int32.Parse(tabuleiro[0].Text);

            for (int i = 1; i < TOTAL; i++)
            {
                tabuleiro[i].BackColor = Color.Blue;
                int posTestar = Int32.Parse(tabuleiro[i].Text);
                if (posTestar < menor)
                {
                    tabuleiro[i].BackColor = Color.Green;
                    resultadoEx1.Text = posTestar + "";
                    menor = posTestar;
                }
                Thread.Sleep(500);
                Application.DoEvents();
                tabuleiro[i].BackColor = Color.White;
            }
            ex1Button.Enabled = true;

        }

        private void Ex2Button_Click(object sender, EventArgs e)
        {
            for (int i=0; i<tabuleiro.Length-1; i++)
            {
                for (int j=i+1; j<tabuleiro.Length; j++)
                {
                    tabuleiro[i].BackColor = Color.Crimson;
                    tabuleiro[j].BackColor = Color.ForestGreen;

                    int inteiroPosI = Int32.Parse(tabuleiro[i].Text);
                    int inteiroPosJ = Int32.Parse(tabuleiro[j].Text);

                    if (inteiroPosJ < inteiroPosI)
                    {
                        String temp = tabuleiro[i].Text;
                        
                        tabuleiro[i].Font = new Font("Arial", 40);
                        tabuleiro[j].Font = new Font("Arial", 40);
                        
                        Thread.Sleep(500);
                        Application.DoEvents();
                        tabuleiro[i].Text = tabuleiro[j].Text;
                        tabuleiro[j].Text = temp;
                        Thread.Sleep(500);
                        Application.DoEvents();
                        tabuleiro[i].Font = new Font("Arial", 20);
                        tabuleiro[j].Font = new Font("Arial", 20);
                    }

                    Thread.Sleep(200);
                    Application.DoEvents();
                    tabuleiro[j].BackColor = Color.White;
                }
                tabuleiro[i].BackColor = Color.White;
            }
        }
    }
}

//Thread.Sleep(200);
//Application.DoEvents();