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

namespace CadCartas.View
{
    public partial class FRM_Agendamento : Form
    {
        public FRM_Agendamento()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                textBox1.Text = "Dr. Pietris";
            } 
            else 
            {
                textBox1.Text = "Dra. Patricia";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FRM_Comprovante FRM_Comprovante = new FRM_Comprovante();
            FRM_Comprovante.ShowDialog();
        }

        private void FRM_Consulta_Load(object sender, EventArgs e)
        {

        }
    }
}
