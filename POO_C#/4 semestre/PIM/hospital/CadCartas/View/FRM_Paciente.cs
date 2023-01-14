using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Paciente.Model;
using Paciente.Control;
using CadCartas.View;

namespace Paciente
{
    public partial class FRM_Paciente : Form
    {
        paciente paciente;
        CTR_paciente CTR_paciente;

        public FRM_Paciente()
        {
            InitializeComponent();
            button7.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog abre_arq = new OpenFileDialog();
           // abre_arq.Filter = "*.xls|Microsoft Excel";
           
            abre_arq.Title = "Selecione o Arquivo";

            if(abre_arq.ShowDialog() == DialogResult.OK)
            {
                button1.Enabled = false;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button7.Enabled = true;

                textBox6.Text = abre_arq.FileName;

                paciente = new paciente();
                CTR_paciente = new CTR_paciente(abre_arq.FileName);

            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void button3_Click(object sender, EventArgs e)
        {
            paciente.cpf = Convert.ToInt16(textBox1.Text);
            textBox1.Text = Convert.ToString(paciente.cpf);
            textBox2.Text = Convert.ToString(paciente.rg);
            textBox3.Text = paciente.nome;
            textBox4.Text = paciente.tiposanguineo;
            textBox5.Text = Convert.ToString(paciente.numero);
            textBox7.Text = paciente.sexo;
            textBox8.Text = Convert.ToString(paciente.datanascimento);
            textBox9.Text = paciente.endereco;
            textBox10.Text = paciente.convenio;
            paciente = CTR_paciente.R_buscar(paciente);
            atualiza_textbox();
        }
        private void atualiza_textbox()
        {
            textBox1.Text = Convert.ToString(paciente.cpf);
            textBox2.Text = Convert.ToString(paciente.rg);
            textBox3.Text = paciente.nome;
            textBox4.Text = paciente.tiposanguineo;
            textBox5.Text = Convert.ToString(paciente.numero);
            textBox7.Text = paciente.sexo;
            textBox8.Text = Convert.ToString(paciente.datanascimento);
            textBox9.Text = paciente.endereco;
            textBox10.Text = paciente.convenio;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            paciente.cpf = Convert.ToInt16(textBox1.Text);
            paciente.rg = Convert.ToInt16(textBox2.Text);
            paciente.nome = textBox3.Text;
            paciente.tiposanguineo = textBox4.Text;
            paciente.numero = Convert.ToInt16(textBox5.Text);
            paciente.sexo = textBox7.Text;
            paciente.datanascimento = Convert.ToInt16(textBox8.Text);
            paciente.endereco = textBox9.Text;
            paciente.convenio = textBox10.Text;
            CTR_paciente.C_novo(paciente);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            paciente.cpf = Convert.ToInt16(textBox1.Text);
            paciente.rg = Convert.ToInt16(textBox2.Text);
            paciente.nome = textBox3.Text;
            paciente.tiposanguineo = textBox4.Text;
            paciente.numero = Convert.ToInt16(textBox5.Text);
            paciente.sexo = textBox7.Text;
            paciente.datanascimento = Convert.ToInt16(textBox8.Text);
            paciente.endereco = textBox9.Text;
            paciente.convenio = textBox10.Text;
            CTR_paciente.U_altera(paciente);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            paciente.cpf = Convert.ToInt16(textBox1.Text);
            CTR_paciente.D_exclui(paciente);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FRM_Agendamento FRM_Consulta = new FRM_Agendamento();
            FRM_Consulta.ShowDialog();
        }
    }
}
