using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_calculo_de_media 
{
    public partial class TxtNota2: Form
    {
        public TxtNota2()
        {
            InitializeComponent();
        }
        private void Btncalcular_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "" || textBox2.Text == "" || textbox3.Text == "" || textbox4.Text == "")
            {
                //mensagem de alerta
                MessageBox.Show("Por Favor,preencha todas as notas!","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);

                     return;
            }
            double nota1 = Convert.ToDouble(textBox1.Text);
            double nota2 = Convert.ToDouble(textBox2.Text);
            double nota3 = Convert.ToDouble(textbox3.Text);
            double nota4 = Convert.ToDouble(textbox4.Text);

            double resultado = (nota1 + nota2 + nota3 + nota4) / 4;

            LblResultadoMedia.Text = resultado.ToString();

            if(resultado >=7) 
            {
            Lblsituacao.Text = "Aprovado :)";
            Lblsituacao.ForeColor = Color.Green;
            
            }
            else
            {
                Lblsituacao.Text = "Reprovado!";
                Lblsituacao.ForeColor= Color.Red;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtNota2_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
