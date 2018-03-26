namespace SampleForm
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
            this.btnShowMessage = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtTwo = new System.Windows.Forms.TextBox();
            this.txtOne = new System.Windows.Forms.TextBox();
            this.lblOne = new System.Windows.Forms.Label();
            this.lblTwo = new System.Windows.Forms.Label();
            this.lblListOne = new System.Windows.Forms.Label();
            this.lblListTwo = new System.Windows.Forms.Label();
            this.lblListThree = new System.Windows.Forms.Label();
            this.cboTwo = new System.Windows.Forms.ComboBox();
            this.lstFour = new System.Windows.Forms.ListBox();
            this.cboOne = new System.Windows.Forms.ComboBox();
            this.cboThree = new System.Windows.Forms.ComboBox();
            this.lblListFour = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnShowMessage
            // 
            this.btnShowMessage.Location = new System.Drawing.Point(250, 35);
            this.btnShowMessage.Name = "btnShowMessage";
            this.btnShowMessage.Size = new System.Drawing.Size(100, 43);
            this.btnShowMessage.TabIndex = 0;
            this.btnShowMessage.Text = "Show Message";
            this.btnShowMessage.UseVisualStyleBackColor = true;
            this.btnShowMessage.Click += new System.EventHandler(this.btnShowMessage_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(387, 43);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 27);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtTwo
            // 
            this.txtTwo.Location = new System.Drawing.Point(103, 66);
            this.txtTwo.Name = "txtTwo";
            this.txtTwo.Size = new System.Drawing.Size(117, 20);
            this.txtTwo.TabIndex = 2;
            // 
            // txtOne
            // 
            this.txtOne.Location = new System.Drawing.Point(103, 27);
            this.txtOne.Name = "txtOne";
            this.txtOne.Size = new System.Drawing.Size(117, 20);
            this.txtOne.TabIndex = 3;
            this.txtOne.Text = "Iwan";
            // 
            // lblOne
            // 
            this.lblOne.AutoSize = true;
            this.lblOne.Location = new System.Drawing.Point(29, 33);
            this.lblOne.Name = "lblOne";
            this.lblOne.Size = new System.Drawing.Size(49, 13);
            this.lblOne.TabIndex = 4;
            this.lblOne.Text = "First One";
            // 
            // lblTwo
            // 
            this.lblTwo.AutoSize = true;
            this.lblTwo.ForeColor = System.Drawing.Color.Red;
            this.lblTwo.Location = new System.Drawing.Point(29, 69);
            this.lblTwo.Name = "lblTwo";
            this.lblTwo.Size = new System.Drawing.Size(67, 13);
            this.lblTwo.TabIndex = 5;
            this.lblTwo.Text = "Second One";
            // 
            // lblListOne
            // 
            this.lblListOne.AutoSize = true;
            this.lblListOne.Location = new System.Drawing.Point(27, 130);
            this.lblListOne.Name = "lblListOne";
            this.lblListOne.Size = new System.Drawing.Size(35, 13);
            this.lblListOne.TabIndex = 6;
            this.lblListOne.Text = "label1";
            // 
            // lblListTwo
            // 
            this.lblListTwo.AutoSize = true;
            this.lblListTwo.Location = new System.Drawing.Point(28, 162);
            this.lblListTwo.Name = "lblListTwo";
            this.lblListTwo.Size = new System.Drawing.Size(35, 13);
            this.lblListTwo.TabIndex = 7;
            this.lblListTwo.Text = "label2";
            // 
            // lblListThree
            // 
            this.lblListThree.AutoSize = true;
            this.lblListThree.Location = new System.Drawing.Point(29, 193);
            this.lblListThree.Name = "lblListThree";
            this.lblListThree.Size = new System.Drawing.Size(35, 13);
            this.lblListThree.TabIndex = 8;
            this.lblListThree.Text = "label3";
            // 
            // cboTwo
            // 
            this.cboTwo.FormattingEnabled = true;
            this.cboTwo.Items.AddRange(new object[] {
            "Porirua",
            "Tawa",
            "Ranui Height",
            "Cannot Creek",
            "Whitby",
            "Paremata",
            "Kenepuru",
            "Titahi bay"});
            this.cboTwo.Location = new System.Drawing.Point(299, 122);
            this.cboTwo.Name = "cboTwo";
            this.cboTwo.Size = new System.Drawing.Size(121, 21);
            this.cboTwo.TabIndex = 9;
            // 
            // lstFour
            // 
            this.lstFour.FormattingEnabled = true;
            this.lstFour.Items.AddRange(new object[] {
            "Wellington",
            "Paraparaumu",
            "Waikanae",
            "Foxton",
            "Levin"});
            this.lstFour.Location = new System.Drawing.Point(488, 12);
            this.lstFour.Name = "lstFour";
            this.lstFour.Size = new System.Drawing.Size(120, 95);
            this.lstFour.TabIndex = 10;
            // 
            // cboOne
            // 
            this.cboOne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboOne.FormattingEnabled = true;
            this.cboOne.Items.AddRange(new object[] {
            "Porirua",
            "Tawa",
            "Ranui Height",
            "Cannot Creek",
            "Whitby",
            "Paremata",
            "Kenepuru",
            "Titahi bay"});
            this.cboOne.Location = new System.Drawing.Point(160, 122);
            this.cboOne.Name = "cboOne";
            this.cboOne.Size = new System.Drawing.Size(121, 150);
            this.cboOne.TabIndex = 11;
            // 
            // cboThree
            // 
            this.cboThree.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboThree.FormattingEnabled = true;
            this.cboThree.Items.AddRange(new object[] {
            "Porirua",
            "Tawa",
            "Ranui Height",
            "Cannot Creek",
            "Whitby",
            "Paremata",
            "Kenepuru",
            "Titahi bay"});
            this.cboThree.Location = new System.Drawing.Point(440, 123);
            this.cboThree.Name = "cboThree";
            this.cboThree.Size = new System.Drawing.Size(121, 21);
            this.cboThree.TabIndex = 12;
            // 
            // lblListFour
            // 
            this.lblListFour.AutoSize = true;
            this.lblListFour.Location = new System.Drawing.Point(27, 227);
            this.lblListFour.Name = "lblListFour";
            this.lblListFour.Size = new System.Drawing.Size(35, 13);
            this.lblListFour.TabIndex = 13;
            this.lblListFour.Text = "label3";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(440, 162);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(440, 186);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 17);
            this.checkBox2.TabIndex = 15;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(440, 210);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(80, 17);
            this.checkBox3.TabIndex = 16;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 275);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lblListFour);
            this.Controls.Add(this.cboThree);
            this.Controls.Add(this.cboOne);
            this.Controls.Add(this.lstFour);
            this.Controls.Add(this.cboTwo);
            this.Controls.Add(this.lblListThree);
            this.Controls.Add(this.lblListTwo);
            this.Controls.Add(this.lblListOne);
            this.Controls.Add(this.lblTwo);
            this.Controls.Add(this.lblOne);
            this.Controls.Add(this.txtOne);
            this.Controls.Add(this.txtTwo);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnShowMessage);
            this.Name = "Form1";
            this.Text = "Sample Program";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowMessage;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtTwo;
        private System.Windows.Forms.TextBox txtOne;
        private System.Windows.Forms.Label lblOne;
        private System.Windows.Forms.Label lblTwo;
        private System.Windows.Forms.Label lblListOne;
        private System.Windows.Forms.Label lblListTwo;
        private System.Windows.Forms.Label lblListThree;
        private System.Windows.Forms.ComboBox cboTwo;
        private System.Windows.Forms.ListBox lstFour;
        private System.Windows.Forms.ComboBox cboOne;
        private System.Windows.Forms.ComboBox cboThree;
        private System.Windows.Forms.Label lblListFour;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
    }
}

