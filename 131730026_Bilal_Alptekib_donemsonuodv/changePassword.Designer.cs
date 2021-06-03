namespace _131730026_Bilal_Alptekib_donemsonuodv
{
    partial class changePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(changePassword));
            this.btnGonder = new System.Windows.Forms.Button();
            this.tbxSıfre2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxSıfre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGonder
            // 
            this.btnGonder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGonder.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnGonder, "btnGonder");
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.UseVisualStyleBackColor = false;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // tbxSıfre2
            // 
            resources.ApplyResources(this.tbxSıfre2, "tbxSıfre2");
            this.tbxSıfre2.Name = "tbxSıfre2";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // tbxSıfre
            // 
            resources.ApplyResources(this.tbxSıfre, "tbxSıfre");
            this.tbxSıfre.Name = "tbxSıfre";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // changePassword
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.tbxSıfre2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxSıfre);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "changePassword";
            this.ShowIcon = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.TextBox tbxSıfre2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxSıfre;
        private System.Windows.Forms.Label label1;
    }
}