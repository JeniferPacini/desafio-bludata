﻿namespace desafio_bludata
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_cadastra_fornecedor = new System.Windows.Forms.Button();
            this.btn_cadastra_empresa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_cadastra_fornecedor);
            this.panel1.Controls.Add(this.btn_cadastra_empresa);
            this.panel1.Location = new System.Drawing.Point(171, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(526, 310);
            this.panel1.TabIndex = 26;
            // 
            // btn_cadastra_fornecedor
            // 
            this.btn_cadastra_fornecedor.BackColor = System.Drawing.Color.Green;
            this.btn_cadastra_fornecedor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_cadastra_fornecedor.Location = new System.Drawing.Point(295, 177);
            this.btn_cadastra_fornecedor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_cadastra_fornecedor.Name = "btn_cadastra_fornecedor";
            this.btn_cadastra_fornecedor.Size = new System.Drawing.Size(156, 49);
            this.btn_cadastra_fornecedor.TabIndex = 32;
            this.btn_cadastra_fornecedor.Text = "FORNECEDOR";
            this.btn_cadastra_fornecedor.UseVisualStyleBackColor = false;
            this.btn_cadastra_fornecedor.Click += new System.EventHandler(this.btn_cadastra_fornecedor_Click);
            // 
            // btn_cadastra_empresa
            // 
            this.btn_cadastra_empresa.BackColor = System.Drawing.Color.Green;
            this.btn_cadastra_empresa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_cadastra_empresa.Location = new System.Drawing.Point(81, 176);
            this.btn_cadastra_empresa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_cadastra_empresa.Name = "btn_cadastra_empresa";
            this.btn_cadastra_empresa.Size = new System.Drawing.Size(156, 50);
            this.btn_cadastra_empresa.TabIndex = 31;
            this.btn_cadastra_empresa.Text = "EMPRESA";
            this.btn_cadastra_empresa.UseVisualStyleBackColor = false;
            this.btn_cadastra_empresa.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 38);
            this.label1.TabIndex = 33;
            this.label1.Text = "CADASTRAR";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 649);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Tela de Cadastro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_cadastra_fornecedor;
        private System.Windows.Forms.Button btn_cadastra_empresa;
        private System.Windows.Forms.Label label1;
    }
}

