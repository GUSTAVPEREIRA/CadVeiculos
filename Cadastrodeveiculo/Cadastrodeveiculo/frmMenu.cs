using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastrodeveiculo
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void msCadVeiculo_Click(object sender, EventArgs e)
        {
            frmCadVeiculo frmcadVeiculo= new frmCadVeiculo();
            frmcadVeiculo.Show();
        }

        private void msCadCliente_Click(object sender, EventArgs e)
        {
            frmCadCliente frmcadCliente = new frmCadCliente();
            frmcadCliente.Show();
        }

        private void msCadModelo_Click(object sender, EventArgs e)
        {
            frmCadModelo frmcadModelo = new frmCadModelo();
            frmcadModelo.Show();
        }

        private void msCadFabricante_Click(object sender, EventArgs e)
        {
            frmCadFabricante frmcadFabricante = new frmCadFabricante();
            frmcadFabricante.Show();
        }

        private void msConVeiculo_Click(object sender, EventArgs e)
        {
            frmLocVeiculo frmlocVeiculo = new frmLocVeiculo();
            frmlocVeiculo.Show();
        }

        private void msConCliente_Click(object sender, EventArgs e)
        {
            frmLocCliente frmlocCliente = new frmLocCliente();
            frmlocCliente.Show();
        }

        private void msConModelo_Click(object sender, EventArgs e)
        {
            frmLocModelo frmlocModelo = new frmLocModelo();
            frmlocModelo.Show();
        }

        private void msConFabricante_Click(object sender, EventArgs e)
        {
            frmLocFabricante frmlocFabricante = new frmLocFabricante();
            frmlocFabricante.Show();
        }
    }
}
