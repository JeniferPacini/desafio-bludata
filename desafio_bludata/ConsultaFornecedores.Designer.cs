namespace desafio_bludata
{
    partial class ConsultaFornecedores
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
            this.dg_dados = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_cpf_cnpj = new System.Windows.Forms.TextBox();
            this.txt_dataDe = new System.Windows.Forms.MaskedTextBox();
            this.txt_dataAte = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dg_dados)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dg_dados
            // 
            this.dg_dados.AllowUserToAddRows = false;
            this.dg_dados.AllowUserToDeleteRows = false;
            this.dg_dados.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dg_dados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dg_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_dados.Location = new System.Drawing.Point(73, 222);
            this.dg_dados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dg_dados.Name = "dg_dados";
            this.dg_dados.ReadOnly = true;
            this.dg_dados.RowHeadersWidth = 51;
            this.dg_dados.RowTemplate.Height = 24;
            this.dg_dados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_dados.Size = new System.Drawing.Size(962, 390);
            this.dg_dados.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(18, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome ";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(145, 24);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(783, 34);
            this.txt_nome.TabIndex = 2;
            // 
            // btn_consultar
            // 
            this.btn_consultar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_consultar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_consultar.Location = new System.Drawing.Point(769, 120);
            this.btn_consultar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(159, 50);
            this.btn_consultar.TabIndex = 34;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.UseVisualStyleBackColor = false;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(18, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 28);
            this.label2.TabIndex = 35;
            this.label2.Text = "CPF/CNPJ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(412, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 28);
            this.label3.TabIndex = 37;
            this.label3.Text = "Data Cadastro de";
            // 
            // txt_cpf_cnpj
            // 
            this.txt_cpf_cnpj.Location = new System.Drawing.Point(145, 72);
            this.txt_cpf_cnpj.Name = "txt_cpf_cnpj";
            this.txt_cpf_cnpj.Size = new System.Drawing.Size(242, 34);
            this.txt_cpf_cnpj.TabIndex = 36;
            // 
            // txt_dataDe
            // 
            this.txt_dataDe.Location = new System.Drawing.Point(578, 72);
            this.txt_dataDe.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.txt_dataDe.Mask = "99/99/9999";
            this.txt_dataDe.Name = "txt_dataDe";
            this.txt_dataDe.Size = new System.Drawing.Size(124, 34);
            this.txt_dataDe.TabIndex = 40;
            // 
            // txt_dataAte
            // 
            this.txt_dataAte.Location = new System.Drawing.Point(804, 72);
            this.txt_dataAte.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.txt_dataAte.Mask = "99/99/9999";
            this.txt_dataAte.Name = "txt_dataAte";
            this.txt_dataAte.Size = new System.Drawing.Size(124, 34);
            this.txt_dataAte.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(764, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 28);
            this.label4.TabIndex = 41;
            this.label4.Text = "Até";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txt_dataDe);
            this.panel1.Controls.Add(this.txt_dataAte);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_nome);
            this.panel1.Controls.Add(this.btn_consultar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_cpf_cnpj);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel1.Location = new System.Drawing.Point(73, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(962, 188);
            this.panel1.TabIndex = 43;
            // 
            // ConsultaFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::desafio_bludata.Properties.Resources.unnamed1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1108, 650);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dg_dados);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConsultaFornecedores";
            this.Text = "Consulta de Fornecedores";
            this.Load += new System.EventHandler(this.ConsultaFornecedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_dados)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_dados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_cpf_cnpj;
        private System.Windows.Forms.MaskedTextBox txt_dataDe;
        private System.Windows.Forms.MaskedTextBox txt_dataAte;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
    }
}