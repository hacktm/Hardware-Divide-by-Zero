﻿namespace A_Sharp_Bench
{
    partial class A_Sharp_Bench
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
            this.Launch = new System.Windows.Forms.Button();
            this.checkbox_Prime = new System.Windows.Forms.CheckBox();
            this.checkbox_MPrime = new System.Windows.Forms.CheckBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Progress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Launch
            // 
            this.Launch.Location = new System.Drawing.Point(338, 38);
            this.Launch.Name = "Launch";
            this.Launch.Size = new System.Drawing.Size(107, 84);
            this.Launch.TabIndex = 0;
            this.Launch.Text = "Launch";
            this.Launch.UseVisualStyleBackColor = true;
            this.Launch.Click += new System.EventHandler(this.Launch_Click);
            // 
            // checkbox_Prime
            // 
            this.checkbox_Prime.AutoSize = true;
            this.checkbox_Prime.Location = new System.Drawing.Point(24, 38);
            this.checkbox_Prime.Name = "checkbox_Prime";
            this.checkbox_Prime.Size = new System.Drawing.Size(107, 17);
            this.checkbox_Prime.TabIndex = 1;
            this.checkbox_Prime.Text = "Prime Calculation";
            this.checkbox_Prime.UseVisualStyleBackColor = true;
            // 
            // checkbox_MPrime
            // 
            this.checkbox_MPrime.AutoSize = true;
            this.checkbox_MPrime.Location = new System.Drawing.Point(24, 62);
            this.checkbox_MPrime.Name = "checkbox_MPrime";
            this.checkbox_MPrime.Size = new System.Drawing.Size(157, 17);
            this.checkbox_MPrime.TabIndex = 2;
            this.checkbox_MPrime.Text = "Mersenne Prime Calculation";
            this.checkbox_MPrime.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(24, 165);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(315, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // Progress
            // 
            this.Progress.AutoSize = true;
            this.Progress.Location = new System.Drawing.Point(33, 143);
            this.Progress.Name = "Progress";
            this.Progress.Size = new System.Drawing.Size(48, 13);
            this.Progress.TabIndex = 4;
            this.Progress.Text = "Progress";
            // 
            // A_Sharp_Bench
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 415);
            this.Controls.Add(this.Progress);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.checkbox_MPrime);
            this.Controls.Add(this.checkbox_Prime);
            this.Controls.Add(this.Launch);
            this.Name = "A_Sharp_Bench";
            this.Text = "A#Bench";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Launch;
        private System.Windows.Forms.CheckBox checkbox_Prime;
        private System.Windows.Forms.CheckBox checkbox_MPrime;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label Progress;
    }
}

