namespace A_Sharp_Bench
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(A_Sharp_Bench));
            this.Launch = new System.Windows.Forms.Button();
            this.checkbox_Prime = new System.Windows.Forms.CheckBox();
            this.checkbox_MPrime = new System.Windows.Forms.CheckBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.Progress = new System.Windows.Forms.Label();
            this.Open_Chart_Button = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Launch
            // 
            this.Launch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Launch.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Launch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Launch.BackgroundImage")));
            this.Launch.ForeColor = System.Drawing.SystemColors.Window;
            this.Launch.Location = new System.Drawing.Point(371, 38);
            this.Launch.Name = "Launch";
            this.Launch.Size = new System.Drawing.Size(107, 84);
            this.Launch.TabIndex = 0;
            this.Launch.Text = "Launch Benchmark";
            this.Launch.UseVisualStyleBackColor = false;
            this.Launch.Click += new System.EventHandler(this.Launch_Click);
            // 
            // checkbox_Prime
            // 
            this.checkbox_Prime.AutoSize = true;
            this.checkbox_Prime.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkbox_Prime.BackgroundImage")));
            this.checkbox_Prime.Checked = true;
            this.checkbox_Prime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkbox_Prime.Enabled = false;
            this.checkbox_Prime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbox_Prime.ForeColor = System.Drawing.SystemColors.Window;
            this.checkbox_Prime.Location = new System.Drawing.Point(24, 38);
            this.checkbox_Prime.Name = "checkbox_Prime";
            this.checkbox_Prime.Size = new System.Drawing.Size(124, 17);
            this.checkbox_Prime.TabIndex = 1;
            this.checkbox_Prime.Text = "Prime Calculation";
            this.checkbox_Prime.UseVisualStyleBackColor = true;
            // 
            // checkbox_MPrime
            // 
            this.checkbox_MPrime.AutoSize = true;
            this.checkbox_MPrime.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkbox_MPrime.BackgroundImage")));
            this.checkbox_MPrime.Checked = true;
            this.checkbox_MPrime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkbox_MPrime.Enabled = false;
            this.checkbox_MPrime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbox_MPrime.ForeColor = System.Drawing.SystemColors.Window;
            this.checkbox_MPrime.Location = new System.Drawing.Point(24, 62);
            this.checkbox_MPrime.Name = "checkbox_MPrime";
            this.checkbox_MPrime.Size = new System.Drawing.Size(183, 17);
            this.checkbox_MPrime.TabIndex = 2;
            this.checkbox_MPrime.Text = "Mersenne Prime Calculation";
            this.checkbox_MPrime.UseVisualStyleBackColor = true;
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.progressBar.Location = new System.Drawing.Point(24, 178);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(315, 23);
            this.progressBar.TabIndex = 3;
            // 
            // Progress
            // 
            this.Progress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Progress.AutoSize = true;
            this.Progress.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Progress.ForeColor = System.Drawing.SystemColors.Window;
            this.Progress.ImageKey = "(none)";
            this.Progress.Location = new System.Drawing.Point(33, 156);
            this.Progress.Name = "Progress";
            this.Progress.Size = new System.Drawing.Size(48, 13);
            this.Progress.TabIndex = 4;
            this.Progress.Text = "Progress";
            // 
            // Open_Chart_Button
            // 
            this.Open_Chart_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Open_Chart_Button.ForeColor = System.Drawing.SystemColors.Window;
            this.Open_Chart_Button.Image = ((System.Drawing.Image)(resources.GetObject("Open_Chart_Button.Image")));
            this.Open_Chart_Button.Location = new System.Drawing.Point(41, 240);
            this.Open_Chart_Button.Name = "Open_Chart_Button";
            this.Open_Chart_Button.Size = new System.Drawing.Size(121, 42);
            this.Open_Chart_Button.TabIndex = 5;
            this.Open_Chart_Button.Text = "Open Chart";
            this.Open_Chart_Button.UseVisualStyleBackColor = true;
            this.Open_Chart_Button.Click += new System.EventHandler(this.Open_Chart_Button_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(511, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // A_Sharp_Bench
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(511, 428);
            this.Controls.Add(this.Open_Chart_Button);
            this.Controls.Add(this.Progress);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.checkbox_MPrime);
            this.Controls.Add(this.checkbox_Prime);
            this.Controls.Add(this.Launch);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "A_Sharp_Bench";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Launch;
        private System.Windows.Forms.CheckBox checkbox_Prime;
        private System.Windows.Forms.CheckBox checkbox_MPrime;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label Progress;
        private System.Windows.Forms.Button Open_Chart_Button;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

