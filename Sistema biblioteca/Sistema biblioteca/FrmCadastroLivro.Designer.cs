namespace Sistema_biblioteca
{
    partial class FrmCadastroLivro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbltitulo = new System.Windows.Forms.Label();
            this.txttitulo = new System.Windows.Forms.TextBox();
            this.lblautor = new System.Windows.Forms.Label();
            this.txtautor = new System.Windows.Forms.TextBox();
            this.lblnpaginas = new System.Windows.Forms.Label();
            this.lblpreço = new System.Windows.Forms.Label();
            this.lblano = new System.Windows.Forms.Label();
            this.txtnumerodepaginas = new System.Windows.Forms.TextBox();
            this.txtpreco = new System.Windows.Forms.TextBox();
            this.txtano = new System.Windows.Forms.TextBox();
            this.txtisbn = new System.Windows.Forms.TextBox();
            this.lblISBN = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.btnpesquisa = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(26, 28);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(40, 16);
            this.lbltitulo.TabIndex = 2;
            this.lbltitulo.Text = "Titulo";
            // 
            // txttitulo
            // 
            this.txttitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttitulo.Location = new System.Drawing.Point(72, 22);
            this.txttitulo.Name = "txttitulo";
            this.txttitulo.Size = new System.Drawing.Size(189, 26);
            this.txttitulo.TabIndex = 3;
            // 
            // lblautor
            // 
            this.lblautor.AutoSize = true;
            this.lblautor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblautor.Location = new System.Drawing.Point(26, 76);
            this.lblautor.Name = "lblautor";
            this.lblautor.Size = new System.Drawing.Size(38, 16);
            this.lblautor.TabIndex = 4;
            this.lblautor.Text = "Autor";
            // 
            // txtautor
            // 
            this.txtautor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtautor.Location = new System.Drawing.Point(72, 76);
            this.txtautor.Name = "txtautor";
            this.txtautor.Size = new System.Drawing.Size(257, 26);
            this.txtautor.TabIndex = 5;
            // 
            // lblnpaginas
            // 
            this.lblnpaginas.AutoSize = true;
            this.lblnpaginas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnpaginas.Location = new System.Drawing.Point(26, 126);
            this.lblnpaginas.Name = "lblnpaginas";
            this.lblnpaginas.Size = new System.Drawing.Size(132, 16);
            this.lblnpaginas.TabIndex = 6;
            this.lblnpaginas.Text = "Numero de paginas  ";
            // 
            // lblpreço
            // 
            this.lblpreço.AutoSize = true;
            this.lblpreço.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpreço.Location = new System.Drawing.Point(447, 31);
            this.lblpreço.Name = "lblpreço";
            this.lblpreço.Size = new System.Drawing.Size(43, 16);
            this.lblpreço.TabIndex = 7;
            this.lblpreço.Text = "Preço";
            // 
            // lblano
            // 
            this.lblano.AutoSize = true;
            this.lblano.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblano.Location = new System.Drawing.Point(380, 82);
            this.lblano.Name = "lblano";
            this.lblano.Size = new System.Drawing.Size(121, 16);
            this.lblano.TabIndex = 8;
            this.lblano.Text = "Ano de Publicação";
            // 
            // txtnumerodepaginas
            // 
            this.txtnumerodepaginas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumerodepaginas.Location = new System.Drawing.Point(164, 126);
            this.txtnumerodepaginas.Name = "txtnumerodepaginas";
            this.txtnumerodepaginas.Size = new System.Drawing.Size(165, 26);
            this.txtnumerodepaginas.TabIndex = 9;
            // 
            // txtpreco
            // 
            this.txtpreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpreco.Location = new System.Drawing.Point(507, 25);
            this.txtpreco.Name = "txtpreco";
            this.txtpreco.Size = new System.Drawing.Size(160, 26);
            this.txtpreco.TabIndex = 10;
            // 
            // txtano
            // 
            this.txtano.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtano.Location = new System.Drawing.Point(507, 76);
            this.txtano.Name = "txtano";
            this.txtano.Size = new System.Drawing.Size(160, 26);
            this.txtano.TabIndex = 11;
            // 
            // txtisbn
            // 
            this.txtisbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtisbn.Location = new System.Drawing.Point(507, 134);
            this.txtisbn.Name = "txtisbn";
            this.txtisbn.Size = new System.Drawing.Size(160, 26);
            this.txtisbn.TabIndex = 12;
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISBN.Location = new System.Drawing.Point(463, 140);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(38, 16);
            this.lblISBN.TabIndex = 13;
            this.lblISBN.Text = "ISBN";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(52, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(149, 194);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Atualizar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(254, 194);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Excluir";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodigo.Location = new System.Drawing.Point(401, 187);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(79, 16);
            this.lblcodigo.TabIndex = 17;
            this.lblcodigo.Text = "Cod. Cliente";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.Location = new System.Drawing.Point(492, 177);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(175, 26);
            this.txtcodigo.TabIndex = 18;
            this.txtcodigo.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // btnpesquisa
            // 
            this.btnpesquisa.Location = new System.Drawing.Point(592, 397);
            this.btnpesquisa.Name = "btnpesquisa";
            this.btnpesquisa.Size = new System.Drawing.Size(75, 23);
            this.btnpesquisa.TabIndex = 19;
            this.btnpesquisa.Text = "Pesquisa";
            this.btnpesquisa.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 241);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(666, 150);
            this.dataGridView1.TabIndex = 20;
            // 
            // FrmCadastroLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 430);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnpesquisa);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.lblcodigo);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.txtisbn);
            this.Controls.Add(this.txtano);
            this.Controls.Add(this.txtpreco);
            this.Controls.Add(this.txtnumerodepaginas);
            this.Controls.Add(this.lblano);
            this.Controls.Add(this.lblpreço);
            this.Controls.Add(this.lblnpaginas);
            this.Controls.Add(this.txtautor);
            this.Controls.Add(this.lblautor);
            this.Controls.Add(this.txttitulo);
            this.Controls.Add(this.lbltitulo);
            this.Name = "FrmCadastroLivro";
            this.Text = "TxtCadastroLivro";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.TextBox txttitulo;
        private System.Windows.Forms.Label lblautor;
        private System.Windows.Forms.TextBox txtautor;
        private System.Windows.Forms.Label lblnpaginas;
        private System.Windows.Forms.Label lblpreço;
        private System.Windows.Forms.Label lblano;
        private System.Windows.Forms.TextBox txtnumerodepaginas;
        private System.Windows.Forms.TextBox txtpreco;
        private System.Windows.Forms.TextBox txtano;
        private System.Windows.Forms.TextBox txtisbn;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Button btnpesquisa;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}