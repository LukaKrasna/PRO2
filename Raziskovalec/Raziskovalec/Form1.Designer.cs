namespace Raziskovalec
{
    partial class Form1
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
            this.datotekaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trvDrevo = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAtribut = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUstvarjena = new System.Windows.Forms.TextBox();
            this.txtDostop = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCeloIme = new System.Windows.Forms.TextBox();
            this.txtExtension = new System.Windows.Forms.TextBox();
            this.txtSprememba = new System.Windows.Forms.TextBox();
            this.txtRoot = new System.Windows.Forms.TextBox();
            this.txtStars = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtDolžina = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datotekaToolStripMenuItem,
            this.programToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(541, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // datotekaToolStripMenuItem
            // 
            this.datotekaToolStripMenuItem.Name = "datotekaToolStripMenuItem";
            this.datotekaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.datotekaToolStripMenuItem.Text = "Datoteka";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oProgramuToolStripMenuItem});
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.programToolStripMenuItem.Text = "Pomoč";
            this.programToolStripMenuItem.Click += new System.EventHandler(this.programToolStripMenuItem_Click);
            // 
            // oProgramuToolStripMenuItem
            // 
            this.oProgramuToolStripMenuItem.Name = "oProgramuToolStripMenuItem";
            this.oProgramuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.oProgramuToolStripMenuItem.Text = "O programu";
            this.oProgramuToolStripMenuItem.Click += new System.EventHandler(this.oProgramuToolStripMenuItem_Click);
            // 
            // trvDrevo
            // 
            this.trvDrevo.Dock = System.Windows.Forms.DockStyle.Top;
            this.trvDrevo.Location = new System.Drawing.Point(0, 24);
            this.trvDrevo.Name = "trvDrevo";
            this.trvDrevo.Size = new System.Drawing.Size(541, 270);
            this.trvDrevo.TabIndex = 1;
            this.trvDrevo.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.trvDrevo_BeforeExpand);
            this.trvDrevo.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvDrevo_AfterSelect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Atribut";
            // 
            // txtAtribut
            // 
            this.txtAtribut.Location = new System.Drawing.Point(163, 298);
            this.txtAtribut.Name = "txtAtribut";
            this.txtAtribut.ReadOnly = true;
            this.txtAtribut.Size = new System.Drawing.Size(100, 20);
            this.txtAtribut.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ustvarjena";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Datum dostopa";
            // 
            // txtUstvarjena
            // 
            this.txtUstvarjena.Location = new System.Drawing.Point(163, 326);
            this.txtUstvarjena.Name = "txtUstvarjena";
            this.txtUstvarjena.ReadOnly = true;
            this.txtUstvarjena.Size = new System.Drawing.Size(100, 20);
            this.txtUstvarjena.TabIndex = 6;
            // 
            // txtDostop
            // 
            this.txtDostop.Location = new System.Drawing.Point(163, 354);
            this.txtDostop.Name = "txtDostop";
            this.txtDostop.ReadOnly = true;
            this.txtDostop.Size = new System.Drawing.Size(100, 20);
            this.txtDostop.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Datum zadnjega spreminjanja";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(104, 413);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Extension";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(110, 441);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Celo ime";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(133, 469);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Ime";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(126, 497);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Starš";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(127, 525);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Root";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(115, 553);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Dolžina";
            // 
            // txtCeloIme
            // 
            this.txtCeloIme.Location = new System.Drawing.Point(163, 438);
            this.txtCeloIme.Name = "txtCeloIme";
            this.txtCeloIme.ReadOnly = true;
            this.txtCeloIme.Size = new System.Drawing.Size(296, 20);
            this.txtCeloIme.TabIndex = 17;
            // 
            // txtExtension
            // 
            this.txtExtension.Location = new System.Drawing.Point(163, 410);
            this.txtExtension.Name = "txtExtension";
            this.txtExtension.ReadOnly = true;
            this.txtExtension.Size = new System.Drawing.Size(100, 20);
            this.txtExtension.TabIndex = 16;
            // 
            // txtSprememba
            // 
            this.txtSprememba.Location = new System.Drawing.Point(163, 382);
            this.txtSprememba.Name = "txtSprememba";
            this.txtSprememba.ReadOnly = true;
            this.txtSprememba.Size = new System.Drawing.Size(100, 20);
            this.txtSprememba.TabIndex = 15;
            // 
            // txtRoot
            // 
            this.txtRoot.Location = new System.Drawing.Point(163, 522);
            this.txtRoot.Name = "txtRoot";
            this.txtRoot.ReadOnly = true;
            this.txtRoot.Size = new System.Drawing.Size(100, 20);
            this.txtRoot.TabIndex = 20;
            // 
            // txtStars
            // 
            this.txtStars.Location = new System.Drawing.Point(163, 494);
            this.txtStars.Name = "txtStars";
            this.txtStars.ReadOnly = true;
            this.txtStars.Size = new System.Drawing.Size(100, 20);
            this.txtStars.TabIndex = 19;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(163, 466);
            this.txtIme.Name = "txtIme";
            this.txtIme.ReadOnly = true;
            this.txtIme.Size = new System.Drawing.Size(100, 20);
            this.txtIme.TabIndex = 18;
            // 
            // txtDolžina
            // 
            this.txtDolžina.Location = new System.Drawing.Point(163, 550);
            this.txtDolžina.Name = "txtDolžina";
            this.txtDolžina.ReadOnly = true;
            this.txtDolžina.Size = new System.Drawing.Size(100, 20);
            this.txtDolžina.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 608);
            this.Controls.Add(this.txtDolžina);
            this.Controls.Add(this.txtRoot);
            this.Controls.Add(this.txtStars);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.txtCeloIme);
            this.Controls.Add(this.txtExtension);
            this.Controls.Add(this.txtSprememba);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDostop);
            this.Controls.Add(this.txtUstvarjena);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAtribut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trvDrevo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem datotekaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oProgramuToolStripMenuItem;
        private System.Windows.Forms.TreeView trvDrevo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAtribut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUstvarjena;
        private System.Windows.Forms.TextBox txtDostop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCeloIme;
        private System.Windows.Forms.TextBox txtExtension;
        private System.Windows.Forms.TextBox txtSprememba;
        private System.Windows.Forms.TextBox txtRoot;
        private System.Windows.Forms.TextBox txtStars;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtDolžina;
    }
}

