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
                where = where + "  forn.nomeForn like '%" + nome + "%' ";
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
                where = where + "  forn.cpf_cnpj like '%" + cpf_cnpj + "%' ";
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
                where = where + " forn.dataCadastro >= '" + data + "'";
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
                where = where + " forn.dataCadastro <= '" + data + " 23:59:59'";
            }
            catch
            {
                // Data não preenchida
            }

            string sql = "Select forn.nomeForn as 'Fornecedor', " +
                " forn.cpf_cnpj as 'CPF/CNPJ', forn.rg as 'RG', forn.nascimento as 'Data nascimento', " +
                " forn.dataCadastro as 'Data cadastro', forn.fisicaJuridica as 'Tipo pessoa', emp.nomeEmpresa as 'Empresa', " +
                " STUFF((select ', ' + tel.telefone from fornecedores_tel tel where tel.idFornecedor = forn.idFornecedor FOR XML PATH ( '' )), 1, 1, '') as 'Telefones'" +
                " From fornecedores forn " +
                " left join empresa emp on (emp.idEmpresa = forn.idEmpresa) ";

            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-JA44IVG8;Initial Catalog=Desafio_Bludata;Integrated Security=True");

            DataTable tabela = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter (sql + where, "Data Source=LAPTOP-JA44IVG8;Initial Catalog=Desafio_Bludata;Integrated Security=True");

            conn.Open();

            dataAdapter.Fill(tabela);

            conn.Close();

            return tabela;
        }

        private void ConsultaFornecedores_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(200, 0, 0, 0);
        }
    }
}
