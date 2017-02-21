namespace Lab1_1
{
    partial class FormTest1
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
            this.avgLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.aLabel = new System.Windows.Forms.Label();
            this.yLabel = new System.Windows.Forms.Label();
            this.xLabel = new System.Windows.Forms.Label();
            this.drawButton = new System.Windows.Forms.Button();
            this.sLabel = new System.Windows.Forms.Label();
            this.sTextLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.avgTimeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // avgLabel
            // 
            this.avgLabel.AutoSize = true;
            this.avgLabel.Location = new System.Drawing.Point(560, 237);
            this.avgLabel.Name = "avgLabel";
            this.avgLabel.Size = new System.Drawing.Size(51, 13);
            this.avgLabel.TabIndex = 25;
            this.avgLabel.Text = "Avg time:";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(595, 212);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(13, 13);
            this.timeLabel.TabIndex = 22;
            this.timeLabel.Text = "0";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.SystemColors.Control;
            this.label.Location = new System.Drawing.Point(560, 212);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(33, 13);
            this.label.TabIndex = 21;
            this.label.Text = "Time:";
            // 
            // aLabel
            // 
            this.aLabel.AutoSize = true;
            this.aLabel.Location = new System.Drawing.Point(613, 187);
            this.aLabel.Name = "aLabel";
            this.aLabel.Size = new System.Drawing.Size(13, 13);
            this.aLabel.TabIndex = 17;
            this.aLabel.Text = "0";
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(585, 187);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(13, 13);
            this.yLabel.TabIndex = 16;
            this.yLabel.Text = "0";
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(560, 187);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(13, 13);
            this.xLabel.TabIndex = 15;
            this.xLabel.Text = "0";
            // 
            // drawButton
            // 
            this.drawButton.Location = new System.Drawing.Point(553, 62);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(125, 55);
            this.drawButton.TabIndex = 13;
            this.drawButton.Text = "Нарисовать";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Click += new System.EventHandler(this.drawButton_Click);
            // 
            // sLabel
            // 
            this.sLabel.AutoSize = true;
            this.sLabel.Location = new System.Drawing.Point(560, 137);
            this.sLabel.Name = "sLabel";
            this.sLabel.Size = new System.Drawing.Size(17, 13);
            this.sLabel.TabIndex = 26;
            this.sLabel.Text = "S:";
            // 
            // sTextLabel
            // 
            this.sTextLabel.AutoSize = true;
            this.sTextLabel.Location = new System.Drawing.Point(579, 137);
            this.sTextLabel.Name = "sTextLabel";
            this.sTextLabel.Size = new System.Drawing.Size(0, 13);
            this.sTextLabel.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(560, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "X1,   Y1,   a:";
            // 
            // avgTimeLabel
            // 
            this.avgTimeLabel.AutoSize = true;
            this.avgTimeLabel.Location = new System.Drawing.Point(610, 237);
            this.avgTimeLabel.Name = "avgTimeLabel";
            this.avgTimeLabel.Size = new System.Drawing.Size(0, 13);
            this.avgTimeLabel.TabIndex = 29;
            // 
            // FormTest1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.avgTimeLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sTextLabel);
            this.Controls.Add(this.sLabel);
            this.Controls.Add(this.avgLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.label);
            this.Controls.Add(this.aLabel);
            this.Controls.Add(this.yLabel);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.drawButton);
            this.Name = "FormTest1";
            this.Text = "Опыт №1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Click += new System.EventHandler(this.FormTest1_Click);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormTest1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label avgLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label aLabel;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.Button drawButton;
        private System.Windows.Forms.Label sLabel;
        private System.Windows.Forms.Label sTextLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label avgTimeLabel;
    }
}