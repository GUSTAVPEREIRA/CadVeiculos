using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Cadastrodeveiculo
{
    public partial class frmCadFabricante : Form
    {
        private String Nomefabricante;
        private String strcon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Academico\LP II\projeto\Cadastrodeveiculo\Cadastrodeveiculo\Database1.mdf;Integrated Security = True";
        public frmCadFabricante()
        {
            InitializeComponent();
            inicializador();
        }

        public void inicializador()
        {
            btAlterar.Enabled = false;
            btInserir.Enabled = true;
            btGravar.Enabled  = false;
            btPesquisar.Enabled = true;
            btSair.Enabled = true;
            txtNomeFabr.Enabled = false;

            
            
        }
        private void txtNomeFabr_TextChanged(object sender, EventArgs e)
        {
            Nomefabricante = txtNomeFabr.Text;
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            btAlterar.Enabled = true;
            btInserir.Enabled = false;
            btGravar.Enabled = true;
            btPesquisar.Enabled = true;
            btSair.Enabled = true;
            txtNomeFabr.Enabled = true;
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            try
            {
                String sql = @"INSERT INTO fabrica(nome) values (@nome)";
                SqlConnection con = new SqlConnection(strcon);
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@nome", Nomefabricante);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                

            }
            catch
            {
                
            }
            inicializador();
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {

        }
    }
}
