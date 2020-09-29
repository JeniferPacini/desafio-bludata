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
    public partial class Fornecedor : Form
    {
        public Fornecedor()
        {
            InitializeComponent();
        }

        private void btn_gravar_bd_Click(object sender, EventArgs e)
        {
            if(cbx_seleciona_empresa.SelectedIndex <= 0)
            {
                MessageBox.Show("O campo empresa é obrigatório!");
                return;
            }

            if(txt_nome_fornecedor.Text == "")
            {
                MessageBox.Show(" O campo nome é obrigatório!");
                return;
            }

            if (rb_fisica.Checked)
            {
                if (txt_rg.Text == "")
                {
                    MessageBox.Show("O campo RG é obrigatório!");
                    return;
                }

                try
                {
                    Convert.ToDateTime(txt_nasci.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("A data de nascimento é obrigatória!");
                    return;
                }
            }

            EmpresaDAO empresa = cbx_seleciona_empresa.SelectedItem as EmpresaDAO;

            if (( empresa.uf == "PR") && (rb_fisica.Checked) && (Convert.ToDateTime(txt_nasci.Text).AddYears(18) > DateTime.Now))
            {
                MessageBox.Show("Não é permitido cadastrar fornecedores menores de 18 anos para empresas do Paraná!");
                return;
            }

            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-JA44IVG8;Initial Catalog=Desafio_Bludata;Integrated Security=True");

            string sqlFornecedor = "INSERT INTO dbo.Fornecedores(nomeForn, cpf_cnpj, rg, dataCadastro, idEmpresa, fisicaJuridica";
            
            if (rb_fisica.Checked)
            {
                sqlFornecedor = sqlFornecedor + ", nascimento";
            }

            sqlFornecedor = sqlFornecedor + ") VALUES (@nomeForn, @cpf_cnpj, @rg, @dataCadastro, @idEmpresa, @fisicaJuridica";

            if (rb_fisica.Checked)
            {
                sqlFornecedor = sqlFornecedor + ", @nascimento";
            }
            sqlFornecedor = sqlFornecedor + ')';

            string sqlSelectId = "SELECT MAX(idFornecedor) as id from dbo.Fornecedores";
            string sqlTelefones = "INSERT INTO dbo.Fornecedores_tel(telefone, idFornecedor) VALUES (@telefone, @idFornecedor)";

            try
            {
                SqlCommand c = new SqlCommand(sqlFornecedor, conn);
                SqlCommand select = new SqlCommand(sqlSelectId, conn);
                SqlCommand tel = new SqlCommand(sqlTelefones, conn);

                string fj = "F";
                if (rb_juridica.Checked)
                {
                    fj = "J";
                }

                c.Parameters.Add(new SqlParameter("@nomeForn", txt_nome_fornecedor.Text));
                c.Parameters.Add(new SqlParameter("@cpf_cnpj", txt_cpf.Text));
                c.Parameters.Add(new SqlParameter("@rg", txt_rg.Text));
                
                if (rb_fisica.Checked)
                {
                    c.Parameters.Add(new SqlParameter("@nascimento", Convert.ToDateTime(txt_nasci.Text)));
                }

                c.Parameters.Add(new SqlParameter("@dataCadastro", DateTime.Now));
                c.Parameters.Add(new SqlParameter("@idEmpresa", empresa.idEmpresa));
                c.Parameters.Add(new SqlParameter("@fisicaJuridica", fj));

                conn.Open();

                c.ExecuteNonQuery();

                SqlDataReader reader = select.ExecuteReader();
                reader.Read();
                int idFornecedor = Convert.ToInt32(reader["id"].ToString());
                reader.Close();

                foreach (string telefone in list_tel.Items)
                {
                    tel.Parameters.Clear();

                    tel.Parameters.Add(new SqlParameter("@telefone", telefone));
                    tel.Parameters.Add(new SqlParameter("@idFornecedor", idFornecedor));

                    tel.ExecuteNonQuery();
                }

                conn.Close();

                MessageBox.Show("Fornecedor gravado com sucesso");
                cbx_seleciona_empresa.Text = "";
                txt_nome_fornecedor.Text = "";
                txt_cpf.Text = "";
                txt_nasci.Text = "";
                txt_rg.Text = "";
                txt_tel.Text = "";
                cbx_seleciona_empresa.Focus();

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

        private void rb_fisica_CheckedChanged(object sender, EventArgs e)
        {
            txt_cpf.Text = "";

            if (rb_fisica.Checked)
            {
                txt_cpf.Mask = "999.999.999-99";
                txt_rg.Enabled = true;
                txt_nasci.Enabled = true;
            }
            else
            {
                txt_cpf.Mask = "99.999.999/9999-99";
                txt_rg.Text = "";
                txt_rg.Enabled = false;
                txt_nasci.Text = "";
                txt_nasci.Enabled = false;
            }
        }

        private void Fornecedor_Shown(object sender, EventArgs e)
        {
            cbx_seleciona_empresa.DataSource = Carregar_Lista();
        }

        private List<EmpresaDAO> Carregar_Lista()
        {
            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-JA44IVG8;Initial Catalog=Desafio_Bludata;Integrated Security=True");

            List<EmpresaDAO> empresaList = new List<EmpresaDAO>();
            try
            {
                string cmdText = "SELECT * FROM dbo.Empresa";
                SqlCommand cmd = new SqlCommand(cmdText, conn);
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    EmpresaDAO empresa = new EmpresaDAO();
                    empresa.idEmpresa = Convert.ToInt32(reader["idEmpresa"].ToString());
                    empresa.nomeEmpresa = reader["nomeEmpresa"].ToString();
                    empresa.uf = reader["uf"].ToString();

                    empresaList.Add(empresa);
                }

                return empresaList;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            ConsultaFornecedores consultar = new ConsultaFornecedores();
            consultar.ShowDialog();
        }

        private void Fornecedor_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(200, 0, 0, 0);
        }

        private void btn_add_tel_Click(object sender, EventArgs e)
        {
            if (list_tel.FindString(txt_tel.Text) < 0)
            {
                list_tel.Items.Add(txt_tel.Text);
            }

            txt_tel.Text = "";
            txt_tel.Focus();
        }

        private void btn_apaga_tel_Click(object sender, EventArgs e)
        {
            if (list_tel.SelectedIndex >= 0)
            {
                list_tel.Items.RemoveAt(list_tel.SelectedIndex);
            }
        }
    }
    
}
