namespace Assignment_2
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
            this.searchTxtBx = new System.Windows.Forms.TextBox();
            this.clearTxtBx = new System.Windows.Forms.Button();
            this.totalTxtBx = new System.Windows.Forms.Button();
            this.itemLstBx = new System.Windows.Forms.ListBox();
            this.totalLblBx = new System.Windows.Forms.Label();
            this.errorChkBx = new System.Windows.Forms.CheckBox();
            this.totalGrpBx = new System.Windows.Forms.GroupBox();
            this.companyGrpBx = new System.Windows.Forms.GroupBox();
            this.blizzardRdBtn = new System.Windows.Forms.RadioButton();
            this.eaRdBtn = new System.Windows.Forms.RadioButton();
            this.microsoftRdBtn = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.totalGrpBx.SuspendLayout();
            this.companyGrpBx.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchTxtBx
            // 
            this.searchTxtBx.BackColor = System.Drawing.Color.Black;
            this.searchTxtBx.Font = new System.Drawing.Font("Arial", 8.25F);
            this.searchTxtBx.ForeColor = System.Drawing.Color.Yellow;
            this.searchTxtBx.Location = new System.Drawing.Point(82, 169);
            this.searchTxtBx.Name = "searchTxtBx";
            this.searchTxtBx.Size = new System.Drawing.Size(123, 20);
            this.searchTxtBx.TabIndex = 0;
            // 
            // clearTxtBx
            // 
            this.clearTxtBx.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearTxtBx.Location = new System.Drawing.Point(102, 81);
            this.clearTxtBx.Name = "clearTxtBx";
            this.clearTxtBx.Size = new System.Drawing.Size(84, 48);
            this.clearTxtBx.TabIndex = 1;
            this.clearTxtBx.Text = "Clear\r\nSearch";
            this.clearTxtBx.UseVisualStyleBackColor = true;
            this.clearTxtBx.Click += new System.EventHandler(this.ClearTxtBx_Click);
            // 
            // totalTxtBx
            // 
            this.totalTxtBx.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTxtBx.Location = new System.Drawing.Point(31, 270);
            this.totalTxtBx.Name = "totalTxtBx";
            this.totalTxtBx.Size = new System.Drawing.Size(174, 52);
            this.totalTxtBx.TabIndex = 2;
            this.totalTxtBx.Text = "Total Sales";
            this.totalTxtBx.UseVisualStyleBackColor = true;
            this.totalTxtBx.Click += new System.EventHandler(this.TotalTxtBx_Click);
            // 
            // itemLstBx
            // 
            this.itemLstBx.BackColor = System.Drawing.Color.Beige;
            this.itemLstBx.ForeColor = System.Drawing.Color.Black;
            this.itemLstBx.FormattingEnabled = true;
            this.itemLstBx.Location = new System.Drawing.Point(251, 29);
            this.itemLstBx.Name = "itemLstBx";
            this.itemLstBx.Size = new System.Drawing.Size(331, 160);
            this.itemLstBx.TabIndex = 3;
            // 
            // totalLblBx
            // 
            this.totalLblBx.BackColor = System.Drawing.Color.Yellow;
            this.totalLblBx.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLblBx.ForeColor = System.Drawing.Color.Blue;
            this.totalLblBx.Location = new System.Drawing.Point(16, 23);
            this.totalLblBx.Name = "totalLblBx";
            this.totalLblBx.Size = new System.Drawing.Size(293, 52);
            this.totalLblBx.TabIndex = 4;
            this.totalLblBx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorChkBx
            // 
            this.errorChkBx.AutoSize = true;
            this.errorChkBx.Font = new System.Drawing.Font("Arial", 8.25F);
            this.errorChkBx.Location = new System.Drawing.Point(82, 210);
            this.errorChkBx.Name = "errorChkBx";
            this.errorChkBx.Size = new System.Drawing.Size(88, 18);
            this.errorChkBx.TabIndex = 5;
            this.errorChkBx.Text = "Display Error";
            this.errorChkBx.UseVisualStyleBackColor = true;
            this.errorChkBx.CheckedChanged += new System.EventHandler(this.ErrorChkBx_CheckedChanged);
            // 
            // totalGrpBx
            // 
            this.totalGrpBx.Controls.Add(this.totalLblBx);
            this.totalGrpBx.Font = new System.Drawing.Font("Arial", 8.25F);
            this.totalGrpBx.Location = new System.Drawing.Point(251, 247);
            this.totalGrpBx.Name = "totalGrpBx";
            this.totalGrpBx.Size = new System.Drawing.Size(331, 85);
            this.totalGrpBx.TabIndex = 6;
            this.totalGrpBx.TabStop = false;
            this.totalGrpBx.Text = "Total Sales";
            // 
            // companyGrpBx
            // 
            this.companyGrpBx.Controls.Add(this.blizzardRdBtn);
            this.companyGrpBx.Controls.Add(this.eaRdBtn);
            this.companyGrpBx.Controls.Add(this.microsoftRdBtn);
            this.companyGrpBx.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyGrpBx.Location = new System.Drawing.Point(251, 196);
            this.companyGrpBx.Name = "companyGrpBx";
            this.companyGrpBx.Size = new System.Drawing.Size(331, 45);
            this.companyGrpBx.TabIndex = 7;
            this.companyGrpBx.TabStop = false;
            this.companyGrpBx.Text = "Company";
            // 
            // blizzardRdBtn
            // 
            this.blizzardRdBtn.AutoSize = true;
            this.blizzardRdBtn.Enabled = false;
            this.blizzardRdBtn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blizzardRdBtn.Location = new System.Drawing.Point(201, 19);
            this.blizzardRdBtn.Name = "blizzardRdBtn";
            this.blizzardRdBtn.Size = new System.Drawing.Size(66, 18);
            this.blizzardRdBtn.TabIndex = 9;
            this.blizzardRdBtn.TabStop = true;
            this.blizzardRdBtn.Text = "Blizzard";
            this.blizzardRdBtn.UseVisualStyleBackColor = true;
            // 
            // eaRdBtn
            // 
            this.eaRdBtn.AutoSize = true;
            this.eaRdBtn.Enabled = false;
            this.eaRdBtn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eaRdBtn.Location = new System.Drawing.Point(120, 19);
            this.eaRdBtn.Name = "eaRdBtn";
            this.eaRdBtn.Size = new System.Drawing.Size(39, 18);
            this.eaRdBtn.TabIndex = 8;
            this.eaRdBtn.TabStop = true;
            this.eaRdBtn.Text = "EA";
            this.eaRdBtn.UseVisualStyleBackColor = true;
            // 
            // microsoftRdBtn
            // 
            this.microsoftRdBtn.AutoSize = true;
            this.microsoftRdBtn.Enabled = false;
            this.microsoftRdBtn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.microsoftRdBtn.Location = new System.Drawing.Point(19, 19);
            this.microsoftRdBtn.Name = "microsoftRdBtn";
            this.microsoftRdBtn.Size = new System.Drawing.Size(72, 18);
            this.microsoftRdBtn.TabIndex = 0;
            this.microsoftRdBtn.TabStop = true;
            this.microsoftRdBtn.Text = "MicroSoft";
            this.microsoftRdBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Search";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 356);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.companyGrpBx);
            this.Controls.Add(this.errorChkBx);
            this.Controls.Add(this.itemLstBx);
            this.Controls.Add(this.totalTxtBx);
            this.Controls.Add(this.clearTxtBx);
            this.Controls.Add(this.searchTxtBx);
            this.Controls.Add(this.totalGrpBx);
            this.Name = "Form1";
            this.Text = "Dalveer Game Sales";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.totalGrpBx.ResumeLayout(false);
            this.companyGrpBx.ResumeLayout(false);
            this.companyGrpBx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchTxtBx;
        private System.Windows.Forms.Button clearTxtBx;
        private System.Windows.Forms.Button totalTxtBx;
        private System.Windows.Forms.ListBox itemLstBx;
        private System.Windows.Forms.Label totalLblBx;
        private System.Windows.Forms.CheckBox errorChkBx;
        private System.Windows.Forms.GroupBox totalGrpBx;
        private System.Windows.Forms.GroupBox companyGrpBx;
        private System.Windows.Forms.RadioButton blizzardRdBtn;
        private System.Windows.Forms.RadioButton eaRdBtn;
        private System.Windows.Forms.RadioButton microsoftRdBtn;
        private System.Windows.Forms.Label label2;
    }
}

