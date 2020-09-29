namespace desafio_bludata
{
    partial class Empresa
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
            this.btn_gravar_bd = new System.Windows.Forms.Button();
            this.txt_cnpj = new System.Windows.Forms.MaskedTextBox();
            this.cbx_uf = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nome_empresa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btn_gravar_bd);
            this.panel1.Controls.Add(this.txt_cnpj);
            this.panel1.Controls.Add(this.cbx_uf);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_nome_empresa);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel1.Location = new System.Drawing.Point(87, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(526, 406);
            this.panel1.TabIndex = 25;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_gravar_bd
            // 
            this.btn_gravar_bd.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_gravar_bd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_gravar_bd.Location = new System.Drawing.Point(173, 289);
            this.btn_gravar_bd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_gravar_bd.Name = "btn_gravar_bd";
            this.btn_gravar_bd.Size = new System.Drawing.Size(156, 49);
            this.btn_gravar_bd.TabIndex = 3;
            this.btn_gravar_bd.Text = "Gravar";
            this.btn_gravar_bd.UseVisualStyleBackColor = false;
            this.btn_gravar_bd.Click += new System.EventHandler(this.btn_gravar_bd_Click);
            // 
            // txt_cnpj
            // 
            this.txt_cnpj.Location = new System.Drawing.Point(83, 190);
            this.txt_cnpj.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_cnpj.Mask = "99.999.999/9999-99";
            this.txt_cnpj.Name = "txt_cnpj";
            this.txt_cnpj.Size = new System.Drawing.Size(234, 34);
            this.txt_cnpj.TabIndex = 1;
            // 
            // cbx_uf
            // 
            this.cbx_uf.FormattingEnabled = true;
            this.cbx_uf.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cbx_uf.Location = new System.Drawing.Point(363, 190);
            this.cbx_uf.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbx_uf.Name = "cbx_uf";
            this.cbx_uf.Size = new System.Drawing.Size(72, 36);
            this.cbx_uf.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(358, 157);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 28);
            this.label3.TabIndex = 28;
            this.label3.Text = "UF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(78, 157);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 28);
            this.label2.TabIndex = 27;
            this.label2.Text = "CNPJ";
            // 
            // txt_nome_empresa
            // 
            this.txt_nome_empresa.Location = new System.Drawing.Point(78, 102);
            this.txt_nome_empresa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_nome_empresa.Name = "txt_nome_empresa";
            this.txt_nome_empresa.Size = new System.Drawing.Size(357, 34);
            this.txt_nome_empresa.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(73, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 35);
            this.label1.TabIndex = 25;
            this.label1.Text = "Nome Fantasia";
            // 
            // Empresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImage = global::desafio_bludata.Properties.Resources.unnamed1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(698, 546);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Empresa";
            this.Text = "Cadastro Empresa";
            this.Load += new System.EventHandler(this.Empresa_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox txt_cnpj;
        private System.Windows.Forms.ComboBox cbx_uf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nome_empresa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_gravar_bd;
    }
}