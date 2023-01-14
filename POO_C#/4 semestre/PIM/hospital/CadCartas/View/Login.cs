using Paciente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Medico.View;

namespace CadCartas.View
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRM_Paciente FRM_Paciente = new FRM_Paciente();
            FRM_Paciente.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FRM_Medico FRM_Medico = new FRM_Medico();
            FRM_Medico.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
