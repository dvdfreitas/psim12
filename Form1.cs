using System;
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
        Button resultadoEx1 = new Button();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            criarBotoes();
            criarEx1();
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

                Controls.Add(tabuleiro[posX]);
            }
        }

        public void criarEx1()
        {
            Button ex1Button = new Button();
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
        private void Ex1Button_Click(object sender, EventArgs e)
        {
            resultadoEx1.Text = tabuleiro[0].Text;
        }
    }
}
