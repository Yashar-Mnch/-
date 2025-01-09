namespace C
{
    partial class RecipeDetailsForm
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
            this.lblRecipeName = new System.Windows.Forms.Label();
            this.txtRecipeDetails = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRecipeName
            // 
            this.lblRecipeName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRecipeName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRecipeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecipeName.Location = new System.Drawing.Point(183, 40);
            this.lblRecipeName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecipeName.Name = "lblRecipeName";
            this.lblRecipeName.Size = new System.Drawing.Size(164, 44);
            this.lblRecipeName.TabIndex = 0;
            this.lblRecipeName.Text = "نام غذاها";
            this.lblRecipeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRecipeDetails
            // 
            this.txtRecipeDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRecipeDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecipeDetails.Location = new System.Drawing.Point(1, 86);
            this.txtRecipeDetails.Margin = new System.Windows.Forms.Padding(2);
            this.txtRecipeDetails.Multiline = true;
            this.txtRecipeDetails.Name = "txtRecipeDetails";
            this.txtRecipeDetails.ReadOnly = true;
            this.txtRecipeDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRecipeDetails.Size = new System.Drawing.Size(540, 391);
            this.txtRecipeDetails.TabIndex = 1;
            this.txtRecipeDetails.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(215, 518);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(91, 29);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "بازگشت";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // RecipeDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(541, 558);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtRecipeDetails);
            this.Controls.Add(this.lblRecipeName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RecipeDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RecipeDetailsForm";
            this.Load += new System.EventHandler(this.RecipeDetailsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRecipeName;
        private System.Windows.Forms.TextBox txtRecipeDetails;
        private System.Windows.Forms.Button btnBack;
    }
}