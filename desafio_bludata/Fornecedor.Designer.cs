namespace desafio_bludata
{
    partial class Fornecedor
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_tel = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_rg = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nasci = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_nome_fornecedor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbx_seleciona_empresa = new System.Windows.Forms.ComboBox();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.btn_gravar_bd = new System.Windows.Forms.Button();
            this.txt_cpf = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rb_fisica = new System.Windows.Forms.RadioButton();
            this.rb_juridica = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.rb_juridica);
            this.panel1.Controls.Add(this.rb_fisica);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txt_tel);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_rg);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_nasci);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_nome_fornecedor);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbx_seleciona_empresa);
            this.panel1.Controls.Add(this.btn_consultar);
            this.panel1.Controls.Add(this.btn_gravar_bd);
            this.panel1.Controls.Add(this.txt_cpf);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(107, 44);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(722, 561);
            this.panel1.TabIndex = 26;
            // 
            // txt_tel
            // 
            this.txt_tel.Location = new System.Drawing.Point(374, 395);
            this.txt_tel.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.txt_tel.Mask = "(99)99999-9999";
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(223, 34);
            this.txt_tel.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(369, 358);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 28);
            this.label6.TabIndex = 42;
            this.label6.Text = "Telefone";
            // 
            // txt_rg
            // 
            this.txt_rg.Location = new System.Drawing.Point(107, 395);
            this.txt_rg.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.txt_rg.Name = "txt_rg";
            this.txt_rg.Size = new System.Drawing.Size(215, 34);
            this.txt_rg.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 358);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 28);
            this.label3.TabIndex = 40;
            this.label3.Text = "RG";
            // 
            // txt_nasci
            // 
            this.txt_nasci.Location = new System.Drawing.Point(374, 306);
            this.txt_nasci.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.txt_nasci.Mask = "99/99/9999";
            this.txt_nasci.Name = "txt_nasci";
            this.txt_nasci.Size = new System.Drawing.Size(223, 34);
            this.txt_nasci.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(369, 269);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 28);
            this.label5.TabIndex = 38;
            this.label5.Text = "Data Nascimento";
            // 
            // txt_nome_fornecedor
            // 
            this.txt_nome_fornecedor.Location = new System.Drawing.Point(107, 144);
            this.txt_nome_fornecedor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_nome_fornecedor.Name = "txt_nome_fornecedor";
            this.txt_nome_fornecedor.Size = new System.Drawing.Size(490, 34);
            this.txt_nome_fornecedor.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 102);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 28);
            this.label4.TabIndex = 36;
            this.label4.Text = "Nome ";
            // 
            // cbx_seleciona_empresa
            // 
            this.cbx_seleciona_empresa.FormattingEnabled = true;
            this.cbx_seleciona_empresa.Location = new System.Drawing.Point(107, 57);
            this.cbx_seleciona_empresa.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.cbx_seleciona_empresa.Name = "cbx_seleciona_empresa";
            this.cbx_seleciona_empresa.Size = new System.Drawing.Size(490, 36);
            this.cbx_seleciona_empresa.TabIndex = 0;
            // 
            // btn_consultar
            // 
            this.btn_consultar.BackColor = System.Drawing.Color.Green;
            this.btn_consultar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_consultar.Location = new System.Drawing.Point(402, 475);
            this.btn_consultar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(136, 40);
            this.btn_consultar.TabIndex = 34;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.UseVisualStyleBackColor = false;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // btn_gravar_bd
            // 
            this.btn_gravar_bd.BackColor = System.Drawing.Color.Green;
            this.btn_gravar_bd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_gravar_bd.Location = new System.Drawing.Point(168, 475);
            this.btn_gravar_bd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_gravar_bd.Name = "btn_gravar_bd";
            this.btn_gravar_bd.Size = new System.Drawing.Size(136, 40);
            this.btn_gravar_bd.TabIndex = 8;
            this.btn_gravar_bd.Text = "Gravar";
            this.btn_gravar_bd.UseVisualStyleBackColor = false;
            this.btn_gravar_bd.Click += new System.EventHandler(this.btn_gravar_bd_Click);
            // 
            // txt_cpf
            // 
            this.txt_cpf.Location = new System.Drawing.Point(107, 306);
            this.txt_cpf.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.txt_cpf.Mask = "999.999.999-99";
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Size = new System.Drawing.Size(215, 34);
            this.txt_cpf.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 269);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 28);
            this.label2.TabIndex = 27;
            this.label2.Text = "CPF/CNPJ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 28);
            this.label1.TabIndex = 25;
            this.label1.Text = "Empresa";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(102, 193);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 35);
            this.label7.TabIndex = 44;
            this.label7.Text = "Tipo de Pessoa";
            // 
            // rb_fisica
            // 
            this.rb_fisica.AutoSize = true;
            this.rb_fisica.Checked = true;
            this.rb_fisica.Location = new System.Drawing.Point(107, 224);
            this.rb_fisica.Name = "rb_fisica";
            this.rb_fisica.Size = new System.Drawing.Size(81, 32);
            this.rb_fisica.TabIndex = 2;
            this.rb_fisica.TabStop = true;
            this.rb_fisica.Text = "Fisíca";
            this.rb_fisica.UseVisualStyleBackColor = true;
            this.rb_fisica.CheckedChanged += new System.EventHandler(this.rb_fisica_CheckedChanged);
            // 
            // rb_juridica
            // 
            this.rb_juridica.AutoSize = true;
            this.rb_juridica.Location = new System.Drawing.Point(374, 224);
            this.rb_juridica.Name = "rb_juridica";
            this.rb_juridica.Size = new System.Drawing.Size(101, 32);
            this.rb_juridica.TabIndex = 3;
            this.rb_juridica.Text = "Jurídica";
            this.rb_juridica.UseVisualStyleBackColor = true;
            this.rb_juridica.CheckedChanged += new System.EventHandler(this.rb_fisica_CheckedChanged);
            // 
            // Fornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 652);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Fornecedor";
            this.Text = "Fornecedor";
            this.Shown += new System.EventHandler(this.Fornecedor_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox txt_cpf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_seleciona_empresa;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.Button btn_gravar_bd;
        private System.Windows.Forms.MaskedTextBox txt_tel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txt_rg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txt_nasci;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_nome_fornecedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rb_juridica;
        private System.Windows.Forms.RadioButton rb_fisica;
        private System.Windows.Forms.Label label7;
    }
}