using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tela_de_Login
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {
            string login = txtuser.Text;
            string password = txtsenha.Text;
        }

        private void btnlogar_Click(object sender, EventArgs e)
        {
            if (txtuser.Text == "" || txtsenha.Text == "")
            {
                MessageBox.Show("por favor escolha uma das opçoes ", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else 
            {
                MessageBox.Show("Logado com sucesso!", "sucesseful" );
            }
            
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
