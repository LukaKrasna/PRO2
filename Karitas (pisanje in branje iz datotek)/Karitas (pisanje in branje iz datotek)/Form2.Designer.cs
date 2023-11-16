namespace Karitas__pisanje_in_branje_iz_datotek_
{
    partial class Pregledi
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
            this.dgvPregledi = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregledi)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPregledi
            // 
            this.dgvPregledi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPregledi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPregledi.Location = new System.Drawing.Point(0, 0);
            this.dgvPregledi.Name = "dgvPregledi";
            this.dgvPregledi.Size = new System.Drawing.Size(888, 599);
            this.dgvPregledi.TabIndex = 1;
            this.dgvPregledi.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPregledi_CellValueChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(888, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 22);
            // 
            // Pregledi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 599);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvPregledi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Pregledi";
            this.Text = "Pregledi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Pregledi_FormClosing);
            this.Load += new System.EventHandler(this.Pregledi_Load);
            this.Shown += new System.EventHandler(this.Pregledi_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregledi)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvPregledi;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
    }
}