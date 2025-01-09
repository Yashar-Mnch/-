namespace C
{
    partial class FORm
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.textBoxx = new System.Windows.Forms.TextBox();
            this.buttonn = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.labell = new System.Windows.Forms.Label();
            this.linkLabelLogin = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(88, 50);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(200, 48);
            this.textBox.TabIndex = 0;
            this.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxx
            // 
            this.textBoxx.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxx.Location = new System.Drawing.Point(88, 172);
            this.textBoxx.Multiline = true;
            this.textBoxx.Name = "textBoxx";
            this.textBoxx.Size = new System.Drawing.Size(200, 48);
            this.textBoxx.TabIndex = 1;
            this.textBoxx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonn
            // 
            this.buttonn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonn.Location = new System.Drawing.Point(311, 289);
            this.buttonn.Name = "buttonn";
            this.buttonn.Size = new System.Drawing.Size(75, 29);
            this.buttonn.TabIndex = 2;
            this.buttonn.Text = "ثبت نام\r\n";
            this.buttonn.UseVisualStyleBackColor = true;
            this.buttonn.Click += new System.EventHandler(this.buttonn_Click);
            // 
            // label
            // 
            this.label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(441, 54);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(180, 44);
            this.label.TabIndex = 3;
            this.label.Text = "نام کاربری";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labell
            // 
            this.labell.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labell.BackColor = System.Drawing.SystemColors.Control;
            this.labell.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labell.Location = new System.Drawing.Point(441, 175);
            this.labell.Name = "labell";
            this.labell.Size = new System.Drawing.Size(180, 44);
            this.labell.TabIndex = 4;
            this.labell.Text = "رمز عبور";
            this.labell.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabelLogin
            // 
            this.linkLabelLogin.BackColor = System.Drawing.Color.Yellow;
            this.linkLabelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelLogin.LinkColor = System.Drawing.Color.Black;
            this.linkLabelLogin.Location = new System.Drawing.Point(50, 316);
            this.linkLabelLogin.Name = "linkLabelLogin";
            this.linkLabelLogin.Size = new System.Drawing.Size(163, 24);
            this.linkLabelLogin.TabIndex = 5;
            this.linkLabelLogin.TabStop = true;
            this.linkLabelLogin.Text = "اگر قبلا ثبت نام کرده اید، وارد شوید";
            this.linkLabelLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLogin_LinkClicked);
            // 
            // FORm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(671, 367);
            this.Controls.Add(this.linkLabelLogin);
            this.Controls.Add(this.labell);
            this.Controls.Add(this.label);
            this.Controls.Add(this.buttonn);
            this.Controls.Add(this.textBoxx);
            this.Controls.Add(this.textBox);
            this.Name = "FORm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FORm";
            this.Load += new System.EventHandler(this.FORm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.TextBox textBoxx;
        private System.Windows.Forms.Button buttonn;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label labell;
        private System.Windows.Forms.LinkLabel linkLabelLogin;
    }
}