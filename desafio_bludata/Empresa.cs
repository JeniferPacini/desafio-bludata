using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace desafio_bludata
{
    public partial class Empresa : Form
    {

        public Empresa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Empresa_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(200, 0, 0, 0);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_gravar_bd_Click(object sender, EventArgs e)
        {

            if (txt_nome_empresa.Text == "")
            {
                MessageBox.Show("O nome da empresa é obrigatório");
                return;
            }

            if(txt_cnpj.Text == "")
            {
                MessageBox.Show("O CNPJ é obrigatório");
                return;

            }

            if (cbx_uf.SelectedIndex <= 0 )
            {
                MessageBox.Show("A UF é obrigatória");
                return;

            }

            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-JA44IVG8;Initial Catalog=Desafio_Bludata;Integrated Security=True");

            string sqlEmpresa = "INSERT INTO dbo.Empresa(nomeEmpresa, cnpj, uf) VALUES (@nomeEmpresa, @cnpj, @uf)";

            try
            {
                SqlCommand c = new SqlCommand(sqlEmpresa, conn);

                c.Parameters.Add(new SqlParameter("@nomeEmpresa", this.txt_nome_empresa.Text));
                c.Parameters.Add(new SqlParameter("@cnpj", this.txt_cnpj.Text));
                c.Parameters.Add(new SqlParameter("@uf", this.cbx_uf.Text));

                conn.Open();

                c.ExecuteNonQuery();
                
                conn.Close();

                txt_nome_empresa.Clear();
                txt_cnpj.Clear();
                cbx_uf.Text = "";
                txt_nome_empresa.Focus();

                MessageBox.Show("Empresa gravada com sucesso!");
            }
            catch (SqlException ex)
            {
               MessageBox.Show("Ocorreu o erro:" + ex);
            }
            finally
            {
                conn.Close();
            }

        }
    }
}
