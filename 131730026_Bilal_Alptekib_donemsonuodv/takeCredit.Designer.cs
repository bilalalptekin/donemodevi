namespace _131730026_Bilal_Alptekib_donemsonuodv
{
    partial class takeCredit
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
            this.btnCek = new System.Windows.Forms.Button();
            this.tbxTutar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCek
            // 
            this.btnCek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCek.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCek.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnCek.Location = new System.Drawing.Point(79, 178);
            this.btnCek.Margin = new System.Windows.Forms.Padding(0);
            this.btnCek.Name = "btnCek";
            this.btnCek.Size = new System.Drawing.Size(284, 82);
            this.btnCek.TabIndex = 23;
            this.btnCek.Text = "Para Çek";
            this.btnCek.UseVisualStyleBackColor = false;
            this.btnCek.Click += new System.EventHandler(this.btnCek_Click);
            // 
            // tbxTutar
            // 
            this.tbxTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tbxTutar.Location = new System.Drawing.Point(123, 85);
            this.tbxTutar.Name = "tbxTutar";
            this.tbxTutar.Size = new System.Drawing.Size(279, 36);
            this.tbxTutar.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(25, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 29);
            this.label1.TabIndex = 19;
            this.label1.Text = "Tutar:";
            // 
            // takeCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 284);
            this.Controls.Add(this.btnCek);
            this.Controls.Add(this.tbxTutar);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "takeCredit";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCek;
        private System.Windows.Forms.TextBox tbxTutar;
        private System.Windows.Forms.Label label1;
    }
}