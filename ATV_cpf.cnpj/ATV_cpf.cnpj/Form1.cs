using System;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ATV_cpf.cnpj
{
    public partial class Form1 : Form
    {

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                //mensagem de alerta
                MessageBox.Show("Por Favor,preencha todas as notas!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
        }
    }
}



