namespace WindowsFormsApplication1
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
            this.lstYear = new System.Windows.Forms.ListBox();
            this.cbbDay = new System.Windows.Forms.ComboBox();
            this.txtStartYear = new System.Windows.Forms.TextBox();
            this.btnSetYearToListBox = new System.Windows.Forms.Button();
            this.btnGetItem = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstYear
            // 
            this.lstYear.FormattingEnabled = true;
            this.lstYear.Location = new System.Drawing.Point(35, 66);
            this.lstYear.Name = "lstYear";
            this.lstYear.Size = new System.Drawing.Size(120, 121);
            this.lstYear.TabIndex = 0;
            // 
            // cbbDay
            // 
            this.cbbDay.FormattingEnabled = true;
            this.cbbDay.Location = new System.Drawing.Point(354, 12);
            this.cbbDay.Name = "cbbDay";
            this.cbbDay.Size = new System.Drawing.Size(121, 21);
            this.cbbDay.TabIndex = 1;
            // 
            // txtStartYear
            // 
            this.txtStartYear.Location = new System.Drawing.Point(35, 27);
            this.txtStartYear.Name = "txtStartYear";
            this.txtStartYear.Size = new System.Drawing.Size(100, 20);
            this.txtStartYear.TabIndex = 2;
            // 
            // btnSetYearToListBox
            // 
            this.btnSetYearToListBox.Location = new System.Drawing.Point(150, 24);
            this.btnSetYearToListBox.Name = "btnSetYearToListBox";
            this.btnSetYearToListBox.Size = new System.Drawing.Size(75, 23);
            this.btnSetYearToListBox.TabIndex = 3;
            this.btnSetYearToListBox.Text = "Set Year";
            this.btnSetYearToListBox.UseVisualStyleBackColor = true;
            this.btnSetYearToListBox.Click += new System.EventHandler(this.btnSetYearToListBox_Click);
            // 
            // btnGetItem
            // 
            this.btnGetItem.Location = new System.Drawing.Point(188, 82);
            this.btnGetItem.Name = "btnGetItem";
            this.btnGetItem.Size = new System.Drawing.Size(75, 23);
            this.btnGetItem.TabIndex = 4;
            this.btnGetItem.Text = "Get Item";
            this.btnGetItem.UseVisualStyleBackColor = true;
            this.btnGetItem.Click += new System.EventHandler(this.btnGetItem_Click);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Location = new System.Drawing.Point(188, 125);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveItem.TabIndex = 5;
            this.btnRemoveItem.Text = "Remove Item";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 260);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.btnGetItem);
            this.Controls.Add(this.btnSetYearToListBox);
            this.Controls.Add(this.txtStartYear);
            this.Controls.Add(this.cbbDay);
            this.Controls.Add(this.lstYear);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstYear;
        private System.Windows.Forms.ComboBox cbbDay;
        private System.Windows.Forms.TextBox txtStartYear;
        private System.Windows.Forms.Button btnSetYearToListBox;
        private System.Windows.Forms.Button btnGetItem;
        private System.Windows.Forms.Button btnRemoveItem;
    }
}

