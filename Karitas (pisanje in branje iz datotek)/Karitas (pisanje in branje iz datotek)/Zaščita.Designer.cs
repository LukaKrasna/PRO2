namespace Karitas__pisanje_in_branje_iz_datotek_
{
    partial class Zaščita
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
            this.btnZaščita = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnZaščita
            // 
            this.btnZaščita.Location = new System.Drawing.Point(143, 61);
            this.btnZaščita.Name = "btnZaščita";
            this.btnZaščita.Size = new System.Drawing.Size(75, 23);
            this.btnZaščita.TabIndex = 0;
            this.btnZaščita.Text = "Zaščita";
            this.btnZaščita.UseVisualStyleBackColor = true;
            this.btnZaščita.Click += new System.EventHandler(this.btnZaščita_Click);
            // 
            // Zaščita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 145);
            this.Controls.Add(this.btnZaščita);
            this.Name = "Zaščita";
            this.Text = "Zaščita";
            this.Load += new System.EventHandler(this.Zaščita_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnZaščita;
    }
}