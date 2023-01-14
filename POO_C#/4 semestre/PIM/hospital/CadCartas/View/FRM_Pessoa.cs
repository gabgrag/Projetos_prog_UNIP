using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pessoa.Model;
using Pessoa.Control;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CadCartas.View
{
    public partial class FRM_Pessoa : Form
    {
        pessoa pessoa;
        CTR_Pessoa CTR_Pessoa;

        public FRM_Pessoa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog abre_arq = new OpenFileDialog();
            // abre_arq.Filter = "*.xls|Microsoft Excel";

            abre_arq.Title = "Selecione o Arquivo";

            if (abre_arq.ShowDialog() == DialogResult.OK)
            {
                button2.Enabled = false;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;

                textBox8.Text = abre_arq.FileName;

                pessoa = new pessoa();
                CTR_Pessoa = new CTR_Pessoa(abre_arq.FileName);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pessoa.cpf = Convert.ToInt16(textBox1.Text);
            textBox1.Text = Convert.ToString(pessoa.cpf);
            textBox2.Text = Convert.ToString(pessoa.rg);
            textBox3.Text = pessoa.nome;
            textBox4.Text = Convert.ToString(pessoa.numero);
            textBox5.Text = pessoa.sexo;
            textBox6.Text = Convert.ToString(pessoa.datanascimento);
            textBox7.Text = pessoa.endereco;
            pessoa = CTR_Pessoa.R_buscar(pessoa);
            atualiza_textbox();
        }
        private void atualiza_textbox()
        {
            textBox1.Text = Convert.ToString(pessoa.cpf);
            textBox2.Text = Convert.ToString(pessoa.rg);
            textBox3.Text = pessoa.nome;
            textBox4.Text = Convert.ToString(pessoa.numero);
            textBox5.Text = pessoa.sexo;
            textBox6.Text = Convert.ToString(pessoa.datanascimento);
            textBox7.Text = pessoa.endereco;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            pessoa.cpf = Convert.ToInt16(textBox1.Text);
            pessoa.rg = Convert.ToInt16(textBox2.Text);
            pessoa.nome = textBox3.Text;
            pessoa.numero = Convert.ToInt16(textBox4.Text);
            pessoa.sexo = textBox5.Text;
            pessoa.datanascimento = Convert.ToInt16(textBox6.Text);
            pessoa.endereco = textBox7.Text;
            CTR_Pessoa.C_novo(pessoa);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pessoa.cpf = Convert.ToInt16(textBox1.Text);
            pessoa.rg = Convert.ToInt16(textBox2.Text);
            pessoa.nome = textBox3.Text;
            pessoa.numero = Convert.ToInt16(textBox4.Text);
            pessoa.sexo = textBox5.Text;
            pessoa.datanascimento = Convert.ToInt16(textBox6.Text);
            pessoa.endereco = textBox7.Text;
            CTR_Pessoa.U_altera(pessoa);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pessoa.cpf = Convert.ToInt16(textBox1.Text);
            CTR_Pessoa.D_exclui(pessoa);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
