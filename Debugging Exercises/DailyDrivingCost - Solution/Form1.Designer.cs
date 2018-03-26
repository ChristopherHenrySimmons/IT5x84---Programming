namespace DailyDrivingCostForm
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtTolls = new System.Windows.Forms.TextBox();
            this.txtParkingFees = new System.Windows.Forms.TextBox();
            this.txtAverageKMsPerLitre = new System.Windows.Forms.TextBox();
            this.txtCostPerLitre = new System.Windows.Forms.TextBox();
            this.txtKMsDriven = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(278, 250);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTolls
            // 
            this.txtTolls.Location = new System.Drawing.Point(47, 213);
            this.txtTolls.Name = "txtTolls";
            this.txtTolls.Size = new System.Drawing.Size(100, 20);
            this.txtTolls.TabIndex = 5;
            // 
            // txtParkingFees
            // 
            this.txtParkingFees.Location = new System.Drawing.Point(47, 173);
            this.txtParkingFees.Name = "txtParkingFees";
            this.txtParkingFees.Size = new System.Drawing.Size(100, 20);
            this.txtParkingFees.TabIndex = 4;
            // 
            // txtAverageKMsPerLitre
            // 
            this.txtAverageKMsPerLitre.Location = new System.Drawing.Point(47, 125);
            this.txtAverageKMsPerLitre.Name = "txtAverageKMsPerLitre";
            this.txtAverageKMsPerLitre.Size = new System.Drawing.Size(100, 20);
            this.txtAverageKMsPerLitre.TabIndex = 3;
            // 
            // txtCostPerLitre
            // 
            this.txtCostPerLitre.Location = new System.Drawing.Point(47, 86);
            this.txtCostPerLitre.Name = "txtCostPerLitre";
            this.txtCostPerLitre.Size = new System.Drawing.Size(100, 20);
            this.txtCostPerLitre.TabIndex = 2;
            // 
            // txtKMsDriven
            // 
            this.txtKMsDriven.Location = new System.Drawing.Point(47, 36);
            this.txtKMsDriven.Name = "txtKMsDriven";
            this.txtKMsDriven.Size = new System.Drawing.Size(100, 20);
            this.txtKMsDriven.TabIndex = 1;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 346);
            this.Controls.Add(this.txtKMsDriven);
            this.Controls.Add(this.txtCostPerLitre);
            this.Controls.Add(this.txtAverageKMsPerLitre);
            this.Controls.Add(this.txtParkingFees);
            this.Controls.Add(this.txtTolls);
            this.Controls.Add(this.btnCalculate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtTolls;
        private System.Windows.Forms.TextBox txtParkingFees;
        private System.Windows.Forms.TextBox txtAverageKMsPerLitre;
        private System.Windows.Forms.TextBox txtCostPerLitre;
        private System.Windows.Forms.TextBox txtKMsDriven;
    }
}