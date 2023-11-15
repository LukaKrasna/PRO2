namespace Karitas__pisanje_in_branje_iz_datotek_
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtZapŠt = new System.Windows.Forms.TextBox();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.txtNamen = new System.Windows.Forms.TextBox();
            this.txtZnesek = new System.Windows.Forms.TextBox();
            this.txtOpombe = new System.Windows.Forms.TextBox();
            this.btnVnesi = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labStanje = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zap. številka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Datum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Namen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Znesek";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Opombe";
            // 
            // txtZapŠt
            // 
            this.txtZapŠt.Location = new System.Drawing.Point(141, 23);
            this.txtZapŠt.Name = "txtZapŠt";
            this.txtZapŠt.Size = new System.Drawing.Size(100, 26);
            this.txtZapŠt.TabIndex = 5;
            this.txtZapŠt.Leave += new System.EventHandler(this.txtZapŠt_Leave);
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(141, 55);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(200, 26);
            this.dtpDatum.TabIndex = 6;
            // 
            // txtNamen
            // 
            this.txtNamen.Location = new System.Drawing.Point(141, 91);
            this.txtNamen.Name = "txtNamen";
            this.txtNamen.Size = new System.Drawing.Size(200, 26);
            this.txtNamen.TabIndex = 7;
            // 
            // txtZnesek
            // 
            this.txtZnesek.Location = new System.Drawing.Point(141, 125);
            this.txtZnesek.Name = "txtZnesek";
            this.txtZnesek.Size = new System.Drawing.Size(200, 26);
            this.txtZnesek.TabIndex = 8;
            // 
            // txtOpombe
            // 
            this.txtOpombe.Location = new System.Drawing.Point(141, 159);
            this.txtOpombe.Multiline = true;
            this.txtOpombe.Name = "txtOpombe";
            this.txtOpombe.Size = new System.Drawing.Size(200, 164);
            this.txtOpombe.TabIndex = 9;
            // 
            // btnVnesi
            // 
            this.btnVnesi.Location = new System.Drawing.Point(38, 333);
            this.btnVnesi.Name = "btnVnesi";
            this.btnVnesi.Size = new System.Drawing.Size(75, 29);
            this.btnVnesi.TabIndex = 10;
            this.btnVnesi.Text = "Vnesi";
            this.btnVnesi.UseVisualStyleBackColor = true;
            this.btnVnesi.Click += new System.EventHandler(this.btnVnesi_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labStanje});
            this.statusStrip1.Location = new System.Drawing.Point(0, 366);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(436, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // labStanje
            // 
            this.labStanje.Name = "labStanje";
            this.labStanje.Size = new System.Drawing.Size(63, 17);
            this.labStanje.Text = "Pripravljen";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 388);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnVnesi);
            this.Controls.Add(this.txtOpombe);
            this.Controls.Add(this.txtZnesek);
            this.Controls.Add(this.txtNamen);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.txtZapŠt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Vnos";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtZapŠt;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.TextBox txtNamen;
        private System.Windows.Forms.TextBox txtZnesek;
        private System.Windows.Forms.TextBox txtOpombe;
        private System.Windows.Forms.Button btnVnesi;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel labStanje;
    }
}

