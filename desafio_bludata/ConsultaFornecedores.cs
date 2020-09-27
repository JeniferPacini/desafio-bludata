using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desafio_bludata
{
    public partial class ConsultaFornecedores : Form
    {
        public ConsultaFornecedores()
        {
            InitializeComponent();
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            dg_dados.DataSource = Consultar(txt_nome.Text, txt_cpf_cnpj.Text, txt_dataDe.Text, txt_dataAte.Text);            
        }

        public DataTable Consultar(string nome, string cpf_cnpj, string dataDe, string dataAte)
        {
            string where = "";
            
            if(nome != "")
            {
                if(where == "")
                {
                    where = "where ";
                }
                else
                {
                    where = where + " and ";
                }
                where = where + "  nomeForn like '%" + nome + "%' ";
            }

            if (cpf_cnpj != "")
            {
                if (where == "")
                {
                    where = "where ";
                }
                else
                {
                    where = where + " and ";
                }
                where = where + "  cpf_cnpj like '%" + cpf_cnpj + "%' ";
            }

            try
            {
                string data = System.String.Format("{0:yyyy-dd-MM}", Convert.ToDateTime(dataDe));

                if (where == "")
                {
                    where = "where ";
                }
                else
                {
                    where = where + " and ";
                }
                where = where + " dataCadastro >= '" + data + "'";
            }
            catch
            {
                // Data não preenchida
            }

            try
            {
                string data = System.String.Format("{0:yyyy-dd-MM}", Convert.ToDateTime(dataAte));

                if (where == "")
                {
                    where = "where ";
                }
                else
                {
                    where = where + " and ";
                }
                where = where + " dataCadastro <= '" + data + " 23:59:59'";
            }
            catch
            {
                // Data não preenchida
            }

            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-JA44IVG8;Initial Catalog=Desafio_Bludata;Integrated Security=True");

            DataTable tabela = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter ("Select * From fornecedores " + where, "Data Source=LAPTOP-JA44IVG8;Initial Catalog=Desafio_Bludata;Integrated Security=True");

            conn.Open();

            dataAdapter.Fill(tabela);

            conn.Close();

            return tabela;
        }
    }
}
