namespace Karitas__pisanje_in_branje_iz_datotek_
{
    partial class Glavno_okno
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
            this.vnosiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preglediToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiskanjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zaščitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vnosiToolStripMenuItem,
            this.preglediToolStripMenuItem,
            this.tiskanjeToolStripMenuItem,
            this.zaščitaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(940, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // vnosiToolStripMenuItem
            // 
            this.vnosiToolStripMenuItem.Name = "vnosiToolStripMenuItem";
            this.vnosiToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.vnosiToolStripMenuItem.Text = "Vnosi";
            this.vnosiToolStripMenuItem.Click += new System.EventHandler(this.vnosiToolStripMenuItem_Click);
            // 
            // preglediToolStripMenuItem
            // 
            this.preglediToolStripMenuItem.Name = "preglediToolStripMenuItem";
            this.preglediToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.preglediToolStripMenuItem.Text = "Pregledi";
            this.preglediToolStripMenuItem.Click += new System.EventHandler(this.preglediToolStripMenuItem_Click);
            // 
            // tiskanjeToolStripMenuItem
            // 
            this.tiskanjeToolStripMenuItem.Name = "tiskanjeToolStripMenuItem";
            this.tiskanjeToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.tiskanjeToolStripMenuItem.Text = "Tiskanje";
            // 
            // zaščitaToolStripMenuItem
            // 
            this.zaščitaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backUpToolStripMenuItem,
            this.restoreToolStripMenuItem});
            this.zaščitaToolStripMenuItem.Name = "zaščitaToolStripMenuItem";
            this.zaščitaToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.zaščitaToolStripMenuItem.Text = "Zaščita";
            // 
            // backUpToolStripMenuItem
            // 
            this.backUpToolStripMenuItem.Name = "backUpToolStripMenuItem";
            this.backUpToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.backUpToolStripMenuItem.Text = "Back up";
            // 
            // restoreToolStripMenuItem
            // 
            this.restoreToolStripMenuItem.Name = "restoreToolStripMenuItem";
            this.restoreToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.restoreToolStripMenuItem.Text = "Restore";
            // 
            // Glavno_okno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Karitas__pisanje_in_branje_iz_datotek_.Properties.Resources.Posnetek_zaslona_20230120_125725;
            this.ClientSize = new System.Drawing.Size(940, 692);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Glavno_okno";
            this.Text = "Glavno okno";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vnosiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preglediToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiskanjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zaščitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restoreToolStripMenuItem;
    }
}