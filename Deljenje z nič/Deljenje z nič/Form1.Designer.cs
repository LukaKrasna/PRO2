namespace Deljenje_z_nič
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
            this.labDeljenec = new System.Windows.Forms.Label();
            this.labDelitelj = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnDeli = new System.Windows.Forms.Button();
            this.labRezultat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labDeljenec
            // 
            this.labDeljenec.AutoSize = true;
            this.labDeljenec.Location = new System.Drawing.Point(40, 29);
            this.labDeljenec.Name = "labDeljenec";
            this.labDeljenec.Size = new System.Drawing.Size(76, 13);
            this.labDeljenec.TabIndex = 0;
            this.labDeljenec.Text = "Vnesi deljenca";
            // 
            // labDelitelj
            // 
            this.labDelitelj.AutoSize = true;
            this.labDelitelj.Location = new System.Drawing.Point(40, 65);
            this.labDelitelj.Name = "labDelitelj";
            this.labDelitelj.Size = new System.Drawing.Size(71, 13);
            this.labDelitelj.TabIndex = 1;
            this.labDelitelj.Text = "Vnesi delitelja";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(117, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(117, 62);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // btnDeli
            // 
            this.btnDeli.Location = new System.Drawing.Point(43, 123);
            this.btnDeli.Name = "btnDeli";
            this.btnDeli.Size = new System.Drawing.Size(75, 23);
            this.btnDeli.TabIndex = 4;
            this.btnDeli.Text = "Deli";
            this.btnDeli.UseVisualStyleBackColor = true;
            this.btnDeli.Click += new System.EventHandler(this.btnDeli_Click);
            // 
            // labRezultat
            // 
            this.labRezultat.AutoSize = true;
            this.labRezultat.Location = new System.Drawing.Point(134, 128);
            this.labRezultat.Name = "labRezultat";
            this.labRezultat.Size = new System.Drawing.Size(46, 13);
            this.labRezultat.TabIndex = 5;
            this.labRezultat.Text = "Rezultat";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 194);
            this.Controls.Add(this.labRezultat);
            this.Controls.Add(this.btnDeli);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labDelitelj);
            this.Controls.Add(this.labDeljenec);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labDeljenec;
        private System.Windows.Forms.Label labDelitelj;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnDeli;
        private System.Windows.Forms.Label labRezultat;
    }
}

