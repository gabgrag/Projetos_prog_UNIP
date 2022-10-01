using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FRM_Endereco : Form
    {
        Endereco end;

        public FRM_Endereco()
        {  
            end = new Endereco();
            InitializeComponent();
        }

        private void BTN_Sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BTN_Gravar_Click(object sender, EventArgs e)
        {
            end.rua = TXT_Rua.Text;
            end.cep = Convert.ToInt16(TXT_CEP.Text);
        }

        private void BTN_Limpar_Click(object sender, EventArgs e)
        {
            TXT_Rua.Text = "";
            TXT_Rua.Text = "0";
        }

        private void BTN_Ler_Click(object sender, EventArgs e)
        {
            TXT_Rua.Text = end.rua;
            TXT_CEP.Text = Convert.ToString(end.cep); // end.cep + ""; tbm converte em string
        }

        private void BTN_Verificar_CEP_Click(object sender, EventArgs e)
        {
            int aux;
            CTR_Endereco CTR_Endereco = new CTR_Endereco();
            aux = CTR_Endereco.verifica_cep(end);
            if (aux == 0)
                MessageBox.Show(" Endereco OK ");
            else
                MessageBox.Show(" Endereco ERRO ");
        
        }
    }
}
