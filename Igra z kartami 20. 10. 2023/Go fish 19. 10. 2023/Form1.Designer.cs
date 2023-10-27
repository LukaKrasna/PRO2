namespace Go_fish_19._10._2023
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
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPonastaviKupDva = new System.Windows.Forms.Button();
            this.btnMešajKupEna = new System.Windows.Forms.Button();
            this.btnMešajKupDva = new System.Windows.Forms.Button();
            this.OdDesneKLevi = new System.Windows.Forms.Button();
            this.OdLeveKDesni = new System.Windows.Forms.Button();
            this.btnPonastaviKupEna = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(239, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(51, 46);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(171, 355);
            this.listBox1.TabIndex = 1;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(326, 46);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(178, 355);
            this.listBox2.TabIndex = 2;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kup #1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kup #2 (52 kart)";
            // 
            // btnPonastaviKupDva
            // 
            this.btnPonastaviKupDva.Location = new System.Drawing.Point(326, 420);
            this.btnPonastaviKupDva.Name = "btnPonastaviKupDva";
            this.btnPonastaviKupDva.Size = new System.Drawing.Size(178, 23);
            this.btnPonastaviKupDva.TabIndex = 5;
            this.btnPonastaviKupDva.Text = "Ponastavi kup #2";
            this.btnPonastaviKupDva.UseVisualStyleBackColor = true;
            this.btnPonastaviKupDva.Click += new System.EventHandler(this.btnPonastaviKupDva_Click);
            // 
            // btnMešajKupEna
            // 
            this.btnMešajKupEna.Location = new System.Drawing.Point(54, 464);
            this.btnMešajKupEna.Name = "btnMešajKupEna";
            this.btnMešajKupEna.Size = new System.Drawing.Size(168, 23);
            this.btnMešajKupEna.TabIndex = 6;
            this.btnMešajKupEna.Text = "Mešaj kup #1";
            this.btnMešajKupEna.UseVisualStyleBackColor = true;
            this.btnMešajKupEna.Click += new System.EventHandler(this.btnMešajKupEna_Click);
            // 
            // btnMešajKupDva
            // 
            this.btnMešajKupDva.Location = new System.Drawing.Point(326, 464);
            this.btnMešajKupDva.Name = "btnMešajKupDva";
            this.btnMešajKupDva.Size = new System.Drawing.Size(178, 23);
            this.btnMešajKupDva.TabIndex = 7;
            this.btnMešajKupDva.Text = "Mešaj kup #2";
            this.btnMešajKupDva.UseVisualStyleBackColor = true;
            this.btnMešajKupDva.Click += new System.EventHandler(this.btnMešajKupDva_Click);
            // 
            // OdDesneKLevi
            // 
            this.OdDesneKLevi.Location = new System.Drawing.Point(245, 156);
            this.OdDesneKLevi.Name = "OdDesneKLevi";
            this.OdDesneKLevi.Size = new System.Drawing.Size(54, 23);
            this.OdDesneKLevi.TabIndex = 8;
            this.OdDesneKLevi.Text = "<<";
            this.OdDesneKLevi.UseVisualStyleBackColor = true;
            this.OdDesneKLevi.Click += new System.EventHandler(this.OdDesneKLevi_Click);
            // 
            // OdLeveKDesni
            // 
            this.OdLeveKDesni.Location = new System.Drawing.Point(245, 108);
            this.OdLeveKDesni.Name = "OdLeveKDesni";
            this.OdLeveKDesni.Size = new System.Drawing.Size(54, 23);
            this.OdLeveKDesni.TabIndex = 9;
            this.OdLeveKDesni.Text = ">>";
            this.OdLeveKDesni.UseVisualStyleBackColor = true;
            this.OdLeveKDesni.Click += new System.EventHandler(this.OdLeveKDesni_Click);
            // 
            // btnPonastaviKupEna
            // 
            this.btnPonastaviKupEna.Location = new System.Drawing.Point(54, 419);
            this.btnPonastaviKupEna.Name = "btnPonastaviKupEna";
            this.btnPonastaviKupEna.Size = new System.Drawing.Size(168, 23);
            this.btnPonastaviKupEna.TabIndex = 10;
            this.btnPonastaviKupEna.Text = "Ponastavki kup #1";
            this.btnPonastaviKupEna.UseVisualStyleBackColor = true;
            this.btnPonastaviKupEna.Click += new System.EventHandler(this.btnPonastaviKupEna_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 507);
            this.Controls.Add(this.btnPonastaviKupEna);
            this.Controls.Add(this.OdLeveKDesni);
            this.Controls.Add(this.OdDesneKLevi);
            this.Controls.Add(this.btnMešajKupDva);
            this.Controls.Add(this.btnMešajKupEna);
            this.Controls.Add(this.btnPonastaviKupDva);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPonastaviKupDva;
        private System.Windows.Forms.Button btnMešajKupEna;
        private System.Windows.Forms.Button btnMešajKupDva;
        private System.Windows.Forms.Button OdDesneKLevi;
        private System.Windows.Forms.Button OdLeveKDesni;
        private System.Windows.Forms.Button btnPonastaviKupEna;
    }
}

