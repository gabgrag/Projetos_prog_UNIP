using Medico.Control;
using Medico.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CadCartas.View;

namespace Medico.View
{
    public partial class FRM_Medico : Form
    {
        medico medico;
        CTR_Medico CTR_Medico;

        public FRM_Medico()
        {
            InitializeComponent();
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            medico.cpf = Convert.ToInt16(textBox1.Text);
            medico.rg = Convert.ToInt16(textBox2.Text);
            medico.nome = textBox3.Text;
            medico.CRM = Convert.ToInt16(textBox4.Text);
            medico.numero = Convert.ToInt16(textBox5.Text);
            medico.sexo = textBox7.Text;
            medico.datanascimento = Convert.ToInt16(textBox8.Text);
            medico.endereco = textBox9.Text;
            medico.especialidade = textBox10.Text;
            CTR_Medico.C_novo(medico);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog abre_arq = new OpenFileDialog();
            // abre_arq.Filter = "*.xls|Microsoft Excel";

            abre_arq.Title = "Selecione o Arquivo";

            if (abre_arq.ShowDialog() == DialogResult.OK)
            {
                button1.Enabled = false;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;

                textBox6.Text = abre_arq.FileName;

                medico = new medico();
                CTR_Medico = new CTR_Medico(abre_arq.FileName);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            medico.cpf = Convert.ToInt16(textBox1.Text);
            textBox1.Text = Convert.ToString(medico.cpf);
            textBox2.Text = Convert.ToString(medico.rg);
            textBox3.Text = medico.nome;
            textBox4.Text = Convert.ToString(medico.CRM);
            textBox5.Text = Convert.ToString(medico.numero);
            textBox7.Text = medico.sexo;
            textBox8.Text = Convert.ToString(medico.datanascimento);
            textBox9.Text = medico.endereco;
            textBox10.Text = medico.especialidade;
            medico = CTR_Medico.R_buscar(medico);
            atualiza_textbox();
        }
        private void atualiza_textbox()
        {
            textBox1.Text = Convert.ToString(medico.cpf);
            textBox2.Text = Convert.ToString(medico.rg);
            textBox3.Text = medico.nome;
            textBox4.Text = Convert.ToString(medico.CRM);
            textBox5.Text = Convert.ToString(medico.numero);
            textBox7.Text = medico.sexo;
            textBox8.Text = Convert.ToString(medico.datanascimento);
            textBox9.Text = medico.endereco;
            textBox10.Text = medico.especialidade;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            medico.cpf = Convert.ToInt16(textBox1.Text);
            medico.rg = Convert.ToInt16(textBox2.Text);
            medico.nome = textBox3.Text;
            medico.CRM = Convert.ToInt16(textBox4.Text);
            medico.numero = Convert.ToInt16(textBox5.Text);
            medico.sexo = textBox7.Text;
            medico.datanascimento = Convert.ToInt16(textBox8.Text);
            medico.endereco = textBox9.Text;
            medico.especialidade = textBox10.Text;
            CTR_Medico.U_altera(medico);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            medico.cpf = Convert.ToInt16(textBox1.Text);
            CTR_Medico.D_exclui(medico);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FRM_Consulta FRM_Consulta = new FRM_Consulta();
            FRM_Consulta.ShowDialog();
        }
    }
}

