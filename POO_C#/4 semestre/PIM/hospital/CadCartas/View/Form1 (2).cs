using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CadCartas.Model;
using CadCartas.Control;

namespace CadCartas
{
    public partial class Form1 : Form
    {
        Carta carta;
        Ctr_Carta ctr_carta;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog abre_arq = new OpenFileDialog();
           // abre_arq.Filter = "*.xls|Microsoft Excel";
           
            abre_arq.Title = "Selecione o Arquivo de Cartas";

            if(abre_arq.ShowDialog() == DialogResult.OK)
            {
                button1.Enabled = false;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                textBox6.Text = abre_arq.FileName;

                carta = new Carta();
                ctr_carta = new Ctr_Carta(abre_arq.FileName);

            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            carta.cod = Convert.ToInt16(textBox1.Text);
            carta=ctr_carta.R_buscar(carta);
            atualiza_textbox();
        }
        private void atualiza_textbox()
        {
            textBox1.Text = Convert.ToString(carta.cod);
            textBox2.Text = carta.nome;
            textBox3.Text = Convert.ToString(carta.valor);
            textBox4.Text = carta.frente;
            textBox5.Text = carta.costa;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            carta.cod = Convert.ToInt16(textBox1.Text);
            carta.nome = textBox2.Text;
            carta.valor = Convert.ToInt16(textBox3.Text);
            carta.frente = textBox4.Text;
            carta.costa = textBox5.Text;
            ctr_carta.C_novo(carta);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            carta.cod = Convert.ToInt16(textBox1.Text);
            carta.nome = textBox2.Text;
            carta.valor = Convert.ToInt16(textBox3.Text);
            carta.frente = textBox4.Text;
            carta.costa = textBox5.Text;
            ctr_carta.U_altera(carta);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            carta.cod = Convert.ToInt16(textBox1.Text);
            ctr_carta.D_exclui(carta);
        }
    }
}
