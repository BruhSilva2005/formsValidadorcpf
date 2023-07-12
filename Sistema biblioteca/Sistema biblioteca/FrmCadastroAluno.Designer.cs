namespace Sistema_biblioteca
{
    partial class FrmCadastroAluno
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Nome = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcPF = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdatanascimento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txttelefone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcelular = new System.Windows.Forms.TextBox();
            this.btnadicioonar = new System.Windows.Forms.Button();
            this.btnatualizar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcodigocliente = new System.Windows.Forms.TextBox();
            this.btnpesquisar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome.Location = new System.Drawing.Point(24, 41);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(44, 16);
            this.Nome.TabIndex = 0;
            this.Nome.Text = "Nome";
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(75, 87);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(240, 26);
            this.txtemail.TabIndex = 1;
            this.txtemail.TextChanged += new System.EventHandler(this.txtemail_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email";
            // 
            // txtnome
            // 
            this.txtnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnome.Location = new System.Drawing.Point(75, 38);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(283, 26);
            this.txtnome.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(399, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "CPF";
            // 
            // txtcPF
            // 
            this.txtcPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcPF.Location = new System.Drawing.Point(450, 35);
            this.txtcPF.Name = "txtcPF";
            this.txtcPF.Size = new System.Drawing.Size(172, 26);
            this.txtcPF.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(347, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data de Nascimento";
            // 
            // txtdatanascimento
            // 
            this.txtdatanascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdatanascimento.Location = new System.Drawing.Point(493, 81);
            this.txtdatanascimento.Name = "txtdatanascimento";
            this.txtdatanascimento.Size = new System.Drawing.Size(129, 26);
            this.txtdatanascimento.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Telefone";
            // 
            // txttelefone
            // 
            this.txttelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelefone.Location = new System.Drawing.Point(75, 132);
            this.txttelefone.Name = "txttelefone";
            this.txttelefone.Size = new System.Drawing.Size(182, 26);
            this.txttelefone.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(295, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Celular";
            // 
            // txtcelular
            // 
            this.txtcelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcelular.Location = new System.Drawing.Point(350, 136);
            this.txtcelular.Name = "txtcelular";
            this.txtcelular.Size = new System.Drawing.Size(172, 26);
            this.txtcelular.TabIndex = 11;
            // 
            // btnadicioonar
            // 
            this.btnadicioonar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadicioonar.Location = new System.Drawing.Point(27, 188);
            this.btnadicioonar.Name = "btnadicioonar";
            this.btnadicioonar.Size = new System.Drawing.Size(75, 23);
            this.btnadicioonar.TabIndex = 12;
            this.btnadicioonar.Text = "Adicionar";
            this.btnadicioonar.UseVisualStyleBackColor = true;
            // 
            // btnatualizar
            // 
            this.btnatualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnatualizar.Location = new System.Drawing.Point(121, 188);
            this.btnatualizar.Name = "btnatualizar";
            this.btnatualizar.Size = new System.Drawing.Size(75, 23);
            this.btnatualizar.TabIndex = 13;
            this.btnatualizar.Text = "Atualizar";
            this.btnatualizar.UseVisualStyleBackColor = true;
            // 
            // btnexcluir
            // 
            this.btnexcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexcluir.Location = new System.Drawing.Point(221, 188);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(75, 23);
            this.btnexcluir.TabIndex = 14;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(365, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Cod. Cliente";
            // 
            // txtcodigocliente
            // 
            this.txtcodigocliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigocliente.Location = new System.Drawing.Point(469, 189);
            this.txtcodigocliente.Name = "txtcodigocliente";
            this.txtcodigocliente.Size = new System.Drawing.Size(138, 26);
            this.txtcodigocliente.TabIndex = 16;
            // 
            // btnpesquisar
            // 
            this.btnpesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpesquisar.Location = new System.Drawing.Point(547, 379);
            this.btnpesquisar.Name = "btnpesquisar";
            this.btnpesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnpesquisar.TabIndex = 17;
            this.btnpesquisar.Text = "Pesquisar";
            this.btnpesquisar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 221);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(610, 152);
            this.dataGridView1.TabIndex = 18;
            // 
            // FrmCadastroAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(629, 404);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnpesquisar);
            this.Controls.Add(this.txtcodigocliente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.btnatualizar);
            this.Controls.Add(this.btnadicioonar);
            this.Controls.Add(this.txtcelular);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txttelefone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtdatanascimento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtcPF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.Nome);
            this.Name = "FrmCadastroAluno";
            this.Text = "Cadastro de Alunos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcPF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdatanascimento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttelefone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtcelular;
        private System.Windows.Forms.Button btnadicioonar;
        private System.Windows.Forms.Button btnatualizar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtcodigocliente;
        private System.Windows.Forms.Button btnpesquisar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

