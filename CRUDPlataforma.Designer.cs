namespace MetroCRUD
{
    partial class CRUDPlataforma
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plataformaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxTipo
            // 
            this.cbxTipo.Items.AddRange(new object[] {
            "RPG",
            "FPS",
            "Aventura",
            "Esporte",
            "RPG",
            "FPS",
            "Aventura",
            "Esporte",
            "RPG",
            "FPS",
            "Aventura",
            "Esporte"});
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // txtId
            // 
            // 
            // 
            // 
            this.txtId.CustomButton.Image = null;
            this.txtId.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtId.CustomButton.Name = "";
            this.txtId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtId.CustomButton.TabIndex = 1;
            this.txtId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtId.CustomButton.UseSelectable = true;
            this.txtId.CustomButton.Visible = false;
            this.txtId.Lines = new string[0];
            // 
            // txtNome
            // 
            // 
            // 
            // 
            this.txtNome.CustomButton.Image = null;
            this.txtNome.CustomButton.Location = new System.Drawing.Point(171, 1);
            this.txtNome.CustomButton.Name = "";
            this.txtNome.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNome.CustomButton.TabIndex = 1;
            this.txtNome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNome.CustomButton.UseSelectable = true;
            this.txtNome.CustomButton.Visible = false;
            this.txtNome.Lines = new string[0];
            // 
            // txtDev
            // 
            // 
            // 
            // 
            this.txtDev.CustomButton.Image = null;
            this.txtDev.CustomButton.Location = new System.Drawing.Point(171, 1);
            this.txtDev.CustomButton.Name = "";
            this.txtDev.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDev.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDev.CustomButton.TabIndex = 1;
            this.txtDev.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDev.CustomButton.UseSelectable = true;
            this.txtDev.CustomButton.Visible = false;
            this.txtDev.Lines = new string[0];
            // 
            // txtPreço
            // 
            // 
            // 
            // 
            this.txtPreço.CustomButton.Image = null;
            this.txtPreço.CustomButton.Location = new System.Drawing.Point(78, 1);
            this.txtPreço.CustomButton.Name = "";
            this.txtPreço.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPreço.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPreço.CustomButton.TabIndex = 1;
            this.txtPreço.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPreço.CustomButton.UseSelectable = true;
            this.txtPreço.CustomButton.Visible = false;
            this.txtPreço.Lines = new string[0];
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 539);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(551, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plataformaToolStripMenuItem,
            this.jogosToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // jogosToolStripMenuItem
            // 
            this.jogosToolStripMenuItem.Name = "jogosToolStripMenuItem";
            this.jogosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.jogosToolStripMenuItem.Text = "Jogos";
            // 
            // plataformaToolStripMenuItem
            // 
            this.plataformaToolStripMenuItem.Name = "plataformaToolStripMenuItem";
            this.plataformaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.plataformaToolStripMenuItem.Text = "Plataforma";
            this.plataformaToolStripMenuItem.Click += new System.EventHandler(this.plataformaToolStripMenuItem_Click);
            // 
            // CRUDPlataforma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(591, 583);
            this.Controls.Add(this.menuStrip1);
            this.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CRUDPlataforma";
            this.Load += new System.EventHandler(this.CRUDPlataforma_Load);
            this.Controls.SetChildIndex(this.menuStrip1, 0);
            this.Controls.SetChildIndex(this.metroLabel1, 0);
            this.Controls.SetChildIndex(this.metroLabel2, 0);
            this.Controls.SetChildIndex(this.metroLabel3, 0);
            this.Controls.SetChildIndex(this.metroLabel4, 0);
            this.Controls.SetChildIndex(this.metroLabel5, 0);
            this.Controls.SetChildIndex(this.txtId, 0);
            this.Controls.SetChildIndex(this.txtNome, 0);
            this.Controls.SetChildIndex(this.txtDev, 0);
            this.Controls.SetChildIndex(this.txtPreço, 0);
            this.Controls.SetChildIndex(this.cbxTipo, 0);
            this.Controls.SetChildIndex(this.btnLocalizar, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnCadastrar, 0);
            this.Controls.SetChildIndex(this.btnEditar, 0);
            this.Controls.SetChildIndex(this.btnExcluir, 0);
            this.Controls.SetChildIndex(this.Logo, 0);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plataformaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jogosToolStripMenuItem;
    }
}
