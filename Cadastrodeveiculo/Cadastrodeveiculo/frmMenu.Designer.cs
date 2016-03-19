namespace Cadastrodeveiculo
{
    partial class frmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.msCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.msCadVeiculo = new System.Windows.Forms.ToolStripMenuItem();
            this.msCadCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.msCadModelo = new System.Windows.Forms.ToolStripMenuItem();
            this.msCadFabricante = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msConVeiculo = new System.Windows.Forms.ToolStripMenuItem();
            this.msConCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.msConModelo = new System.Windows.Forms.ToolStripMenuItem();
            this.msConFabricante = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msCadastro,
            this.consultaToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // msCadastro
            // 
            this.msCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msCadVeiculo,
            this.msCadCliente,
            this.msCadModelo,
            this.msCadFabricante});
            this.msCadastro.Name = "msCadastro";
            this.msCadastro.Size = new System.Drawing.Size(66, 20);
            this.msCadastro.Text = "Cadastro";
            // 
            // msCadVeiculo
            // 
            this.msCadVeiculo.Name = "msCadVeiculo";
            this.msCadVeiculo.Size = new System.Drawing.Size(152, 22);
            this.msCadVeiculo.Text = "Veículo";
            this.msCadVeiculo.Click += new System.EventHandler(this.msCadVeiculo_Click);
            // 
            // msCadCliente
            // 
            this.msCadCliente.Name = "msCadCliente";
            this.msCadCliente.Size = new System.Drawing.Size(152, 22);
            this.msCadCliente.Text = "Cliente";
            this.msCadCliente.Click += new System.EventHandler(this.msCadCliente_Click);
            // 
            // msCadModelo
            // 
            this.msCadModelo.Name = "msCadModelo";
            this.msCadModelo.Size = new System.Drawing.Size(152, 22);
            this.msCadModelo.Text = "Modelo";
            this.msCadModelo.Click += new System.EventHandler(this.msCadModelo_Click);
            // 
            // msCadFabricante
            // 
            this.msCadFabricante.Name = "msCadFabricante";
            this.msCadFabricante.Size = new System.Drawing.Size(152, 22);
            this.msCadFabricante.Text = "Fabricante";
            this.msCadFabricante.Click += new System.EventHandler(this.msCadFabricante_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msConVeiculo,
            this.msConCliente,
            this.msConModelo,
            this.msConFabricante});
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.consultaToolStripMenuItem.Text = "Consulta";
            // 
            // msConVeiculo
            // 
            this.msConVeiculo.Name = "msConVeiculo";
            this.msConVeiculo.Size = new System.Drawing.Size(152, 22);
            this.msConVeiculo.Text = "Veículo";
            this.msConVeiculo.Click += new System.EventHandler(this.msConVeiculo_Click);
            // 
            // msConCliente
            // 
            this.msConCliente.Name = "msConCliente";
            this.msConCliente.Size = new System.Drawing.Size(152, 22);
            this.msConCliente.Text = "Cliente";
            this.msConCliente.Click += new System.EventHandler(this.msConCliente_Click);
            // 
            // msConModelo
            // 
            this.msConModelo.Name = "msConModelo";
            this.msConModelo.Size = new System.Drawing.Size(152, 22);
            this.msConModelo.Text = "Modelo";
            this.msConModelo.Click += new System.EventHandler(this.msConModelo_Click);
            // 
            // msConFabricante
            // 
            this.msConFabricante.Name = "msConFabricante";
            this.msConFabricante.Size = new System.Drawing.Size(152, 22);
            this.msConFabricante.Text = "Fabricante";
            this.msConFabricante.Click += new System.EventHandler(this.msConFabricante_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.Text = "Concessionária Zhokov";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem msCadastro;
        private System.Windows.Forms.ToolStripMenuItem msCadVeiculo;
        private System.Windows.Forms.ToolStripMenuItem msCadCliente;
        private System.Windows.Forms.ToolStripMenuItem msCadModelo;
        private System.Windows.Forms.ToolStripMenuItem msCadFabricante;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msConVeiculo;
        private System.Windows.Forms.ToolStripMenuItem msConCliente;
        private System.Windows.Forms.ToolStripMenuItem msConModelo;
        private System.Windows.Forms.ToolStripMenuItem msConFabricante;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}

