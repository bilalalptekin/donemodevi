namespace _131730026_Bilal_Alptekib_donemsonuodv
{
    partial class sendMoney
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
            this.btnGonder = new System.Windows.Forms.Button();
            this.tbxAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxIban = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGonder
            // 
            this.btnGonder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGonder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGonder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnGonder.Location = new System.Drawing.Point(76, 178);
            this.btnGonder.Margin = new System.Windows.Forms.Padding(0);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(284, 82);
            this.btnGonder.TabIndex = 18;
            this.btnGonder.Text = "Para Gönder";
            this.btnGonder.UseVisualStyleBackColor = false;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // tbxAmount
            // 
            this.tbxAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tbxAmount.Location = new System.Drawing.Point(121, 80);
            this.tbxAmount.Name = "tbxAmount";
            this.tbxAmount.Size = new System.Drawing.Size(279, 36);
            this.tbxAmount.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(23, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 29);
            this.label2.TabIndex = 16;
            this.label2.Text = "Miktar:";
            // 
            // tbxIban
            // 
            this.tbxIban.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tbxIban.Location = new System.Drawing.Point(121, 24);
            this.tbxIban.Name = "tbxIban";
            this.tbxIban.Size = new System.Drawing.Size(279, 36);
            this.tbxIban.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "IBAN:";
            // 
            // sendMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 284);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.tbxAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxIban);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "sendMoney";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.TextBox tbxAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxIban;
        private System.Windows.Forms.Label label1;
    }
}