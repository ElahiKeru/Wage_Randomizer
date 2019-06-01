namespace WageRandomizer
{
    partial class FRMWageRandomizer
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
            this.CLBWageRecipients = new System.Windows.Forms.CheckedListBox();
            this.BTNGenerate = new System.Windows.Forms.Button();
            this.NUDWeeks = new System.Windows.Forms.NumericUpDown();
            this.LBLWeeks = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NUDWeeks)).BeginInit();
            this.SuspendLayout();
            // 
            // CLBWageRecipients
            // 
            this.CLBWageRecipients.FormattingEnabled = true;
            this.CLBWageRecipients.Location = new System.Drawing.Point(13, 13);
            this.CLBWageRecipients.Name = "CLBWageRecipients";
            this.CLBWageRecipients.Size = new System.Drawing.Size(179, 139);
            this.CLBWageRecipients.TabIndex = 0;
            this.CLBWageRecipients.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CLBWageRecipients_ItemCheck);
            // 
            // BTNGenerate
            // 
            this.BTNGenerate.Location = new System.Drawing.Point(13, 184);
            this.BTNGenerate.Name = "BTNGenerate";
            this.BTNGenerate.Size = new System.Drawing.Size(179, 23);
            this.BTNGenerate.TabIndex = 2;
            this.BTNGenerate.Text = "Generate";
            this.BTNGenerate.UseVisualStyleBackColor = true;
            this.BTNGenerate.Click += new System.EventHandler(this.BTNGenerate_Click);
            // 
            // NUDWeeks
            // 
            this.NUDWeeks.Location = new System.Drawing.Point(98, 158);
            this.NUDWeeks.Name = "NUDWeeks";
            this.NUDWeeks.Size = new System.Drawing.Size(94, 20);
            this.NUDWeeks.TabIndex = 3;
            // 
            // LBLWeeks
            // 
            this.LBLWeeks.AutoSize = true;
            this.LBLWeeks.Location = new System.Drawing.Point(12, 160);
            this.LBLWeeks.Name = "LBLWeeks";
            this.LBLWeeks.Size = new System.Drawing.Size(44, 13);
            this.LBLWeeks.TabIndex = 4;
            this.LBLWeeks.Text = "Weeks:";
            // 
            // FRMWageRandomizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 217);
            this.Controls.Add(this.LBLWeeks);
            this.Controls.Add(this.NUDWeeks);
            this.Controls.Add(this.BTNGenerate);
            this.Controls.Add(this.CLBWageRecipients);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FRMWageRandomizer";
            this.Text = "Wage Gen";
            this.Load += new System.EventHandler(this.FRMWageRandomizer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUDWeeks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox CLBWageRecipients;
        private System.Windows.Forms.Button BTNGenerate;
        private System.Windows.Forms.NumericUpDown NUDWeeks;
        private System.Windows.Forms.Label LBLWeeks;
    }
}

