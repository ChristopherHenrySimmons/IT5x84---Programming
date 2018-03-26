namespace Accessing_Text_File___GUI
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
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.txtFileContent = new System.Windows.Forms.TextBox();
            this.dlg_OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.lblSelectedFile = new System.Windows.Forms.Label();
            this.btnReload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(41, 61);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(130, 23);
            this.btnSelectFile.TabIndex = 0;
            this.btnSelectFile.Text = "Click to Select File";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // txtFileContent
            // 
            this.txtFileContent.Location = new System.Drawing.Point(41, 107);
            this.txtFileContent.Multiline = true;
            this.txtFileContent.Name = "txtFileContent";
            this.txtFileContent.Size = new System.Drawing.Size(485, 264);
            this.txtFileContent.TabIndex = 2;
            // 
            // dlg_OpenFile
            // 
            this.dlg_OpenFile.Filter = "School of IT (*.soi)|*.soi";
            // 
            // lblSelectedFile
            // 
            this.lblSelectedFile.AutoSize = true;
            this.lblSelectedFile.Location = new System.Drawing.Point(38, 27);
            this.lblSelectedFile.Name = "lblSelectedFile";
            this.lblSelectedFile.Size = new System.Drawing.Size(68, 13);
            this.lblSelectedFile.TabIndex = 3;
            this.lblSelectedFile.Text = "Choose file...";
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(408, 61);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(118, 23);
            this.btnReload.TabIndex = 4;
            this.btnReload.Text = "Reload File";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 400);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.lblSelectedFile);
            this.Controls.Add(this.txtFileContent);
            this.Controls.Add(this.btnSelectFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.TextBox txtFileContent;
        private System.Windows.Forms.OpenFileDialog dlg_OpenFile;
        private System.Windows.Forms.Label lblSelectedFile;
        private System.Windows.Forms.Button btnReload;
    }
}

