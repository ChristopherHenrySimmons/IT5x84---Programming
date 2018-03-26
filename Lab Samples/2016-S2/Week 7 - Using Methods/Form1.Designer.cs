namespace Week_4___Loop___Exercise
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
            this.txtAddName = new System.Windows.Forms.TextBox();
            this.btnAddName = new System.Windows.Forms.Button();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.btnSearchName = new System.Windows.Forms.Button();
            this.btnCompare = new System.Windows.Forms.Button();
            this.lstLeft = new System.Windows.Forms.ListBox();
            this.lstRight = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtAddName
            // 
            this.txtAddName.Location = new System.Drawing.Point(52, 34);
            this.txtAddName.Name = "txtAddName";
            this.txtAddName.Size = new System.Drawing.Size(100, 20);
            this.txtAddName.TabIndex = 0;
            // 
            // btnAddName
            // 
            this.btnAddName.Location = new System.Drawing.Point(182, 34);
            this.btnAddName.Name = "btnAddName";
            this.btnAddName.Size = new System.Drawing.Size(75, 23);
            this.btnAddName.TabIndex = 1;
            this.btnAddName.Text = "Add";
            this.btnAddName.UseVisualStyleBackColor = true;
            this.btnAddName.Click += new System.EventHandler(this.btnAddName_Click);
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(52, 197);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(100, 20);
            this.txtSearchName.TabIndex = 2;
            // 
            // btnSearchName
            // 
            this.btnSearchName.Location = new System.Drawing.Point(52, 223);
            this.btnSearchName.Name = "btnSearchName";
            this.btnSearchName.Size = new System.Drawing.Size(75, 23);
            this.btnSearchName.TabIndex = 3;
            this.btnSearchName.Text = "Search";
            this.btnSearchName.UseVisualStyleBackColor = true;
            this.btnSearchName.Click += new System.EventHandler(this.btnSearchName_Click);
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(219, 201);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(75, 23);
            this.btnCompare.TabIndex = 4;
            this.btnCompare.Text = "Compare";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // lstLeft
            // 
            this.lstLeft.FormattingEnabled = true;
            this.lstLeft.Location = new System.Drawing.Point(52, 87);
            this.lstLeft.Name = "lstLeft";
            this.lstLeft.Size = new System.Drawing.Size(120, 95);
            this.lstLeft.TabIndex = 5;
            // 
            // lstRight
            // 
            this.lstRight.FormattingEnabled = true;
            this.lstRight.Location = new System.Drawing.Point(209, 87);
            this.lstRight.Name = "lstRight";
            this.lstRight.Size = new System.Drawing.Size(120, 95);
            this.lstRight.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 266);
            this.Controls.Add(this.lstRight);
            this.Controls.Add(this.lstLeft);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.btnSearchName);
            this.Controls.Add(this.txtSearchName);
            this.Controls.Add(this.btnAddName);
            this.Controls.Add(this.txtAddName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAddName;
        private System.Windows.Forms.Button btnAddName;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Button btnSearchName;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.ListBox lstLeft;
        private System.Windows.Forms.ListBox lstRight;
    }
}

