namespace InterestCalculator
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
            this.principalText = new System.Windows.Forms.TextBox();
            this.lblPrincipal = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.timeText = new System.Windows.Forms.TextBox();
            this.lblRate = new System.Windows.Forms.Label();
            this.rateText = new System.Windows.Forms.TextBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // principalText
            // 
            this.principalText.Location = new System.Drawing.Point(148, 30);
            this.principalText.Name = "principalText";
            this.principalText.Size = new System.Drawing.Size(100, 20);
            this.principalText.TabIndex = 0;
            this.principalText.TextChanged += new System.EventHandler(this.principalText_TextChanged);
            // 
            // lblPrincipal
            // 
            this.lblPrincipal.AutoSize = true;
            this.lblPrincipal.Location = new System.Drawing.Point(51, 37);
            this.lblPrincipal.Name = "lblPrincipal";
            this.lblPrincipal.Size = new System.Drawing.Size(47, 13);
            this.lblPrincipal.TabIndex = 1;
            this.lblPrincipal.Text = "Principal";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(54, 86);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(30, 13);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "Time";
            // 
            // timeText
            // 
            this.timeText.Location = new System.Drawing.Point(148, 86);
            this.timeText.Name = "timeText";
            this.timeText.Size = new System.Drawing.Size(100, 20);
            this.timeText.TabIndex = 3;
            this.timeText.TextChanged += new System.EventHandler(this.timeText_TextChanged);
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(54, 137);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(30, 13);
            this.lblRate.TabIndex = 4;
            this.lblRate.Text = "Rate";
            this.lblRate.Click += new System.EventHandler(this.lblRate_Click);
            // 
            // rateText
            // 
            this.rateText.Location = new System.Drawing.Point(148, 137);
            this.rateText.Name = "rateText";
            this.rateText.Size = new System.Drawing.Size(100, 20);
            this.rateText.TabIndex = 5;
            this.rateText.TextChanged += new System.EventHandler(this.rateText_TextChanged);
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(54, 200);
            this.submitBtn.Margin = new System.Windows.Forms.Padding(3, 3, 3, 4);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(114, 25);
            this.submitBtn.TabIndex = 6;
            this.submitBtn.Text = "Calculate-Interest";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 7;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(344, 93);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 261);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.rateText);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.timeText);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblPrincipal);
            this.Controls.Add(this.principalText);
            this.Name = "Form1";
            this.Text = "<<Interest   Calculator>>";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox principalText;
        private System.Windows.Forms.Label lblPrincipal;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox timeText;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.TextBox rateText;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResult;
    }
}

