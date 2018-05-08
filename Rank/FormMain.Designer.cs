namespace Rank
{
    partial class FormMain
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
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarRankToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pokémonLeagueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pokémonMyBoy3raGeneraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.batallaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarBatallaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.batallaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportarRankToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // exportarRankToolStripMenuItem
            // 
            this.exportarRankToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pokémonLeagueToolStripMenuItem,
            this.pokémonMyBoy3raGeneraciónToolStripMenuItem});
            this.exportarRankToolStripMenuItem.Name = "exportarRankToolStripMenuItem";
            this.exportarRankToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.exportarRankToolStripMenuItem.Text = "Exportar rank";
            // 
            // pokémonLeagueToolStripMenuItem
            // 
            this.pokémonLeagueToolStripMenuItem.Name = "pokémonLeagueToolStripMenuItem";
            this.pokémonLeagueToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.pokémonLeagueToolStripMenuItem.Text = "Pokémon League";
            this.pokémonLeagueToolStripMenuItem.Click += new System.EventHandler(this.LeagueToolStripMenuItem_Click);
            // 
            // pokémonMyBoy3raGeneraciónToolStripMenuItem
            // 
            this.pokémonMyBoy3raGeneraciónToolStripMenuItem.Name = "pokémonMyBoy3raGeneraciónToolStripMenuItem";
            this.pokémonMyBoy3raGeneraciónToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.pokémonMyBoy3raGeneraciónToolStripMenuItem.Text = "Pokémon MyBoy 3ra Generación";
            // 
            // batallaToolStripMenuItem
            // 
            this.batallaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarBatallaToolStripMenuItem});
            this.batallaToolStripMenuItem.Name = "batallaToolStripMenuItem";
            this.batallaToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.batallaToolStripMenuItem.Text = "Batalla";
            // 
            // agregarBatallaToolStripMenuItem
            // 
            this.agregarBatallaToolStripMenuItem.Name = "agregarBatallaToolStripMenuItem";
            this.agregarBatallaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.agregarBatallaToolStripMenuItem.Text = "Agregar Batalla";
            this.agregarBatallaToolStripMenuItem.Click += new System.EventHandler(this.AddBattleToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Rank de Batallas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarRankToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pokémonLeagueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pokémonMyBoy3raGeneraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem batallaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarBatallaToolStripMenuItem;
    }
}

