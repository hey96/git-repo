namespace Lab1_1
{
    partial class FormTest2
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
            this.avgTimeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dTextLabel = new System.Windows.Forms.Label();
            this.dLabel = new System.Windows.Forms.Label();
            this.avgLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.aLabel = new System.Windows.Forms.Label();
            this.yLabel = new System.Windows.Forms.Label();
            this.xLabel = new System.Windows.Forms.Label();
            this.drawButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // avgTimeLabel
            // 
            this.avgTimeLabel.AutoSize = true;
            this.avgTimeLabel.Location = new System.Drawing.Point(609, 235);
            this.avgTimeLabel.Name = "avgTimeLabel";
            this.avgTimeLabel.Size = new System.Drawing.Size(0, 13);
            this.avgTimeLabel.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(559, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "X1,   Y1,   a:";
            // 
            // dTextLabel
            // 
            this.dTextLabel.AutoSize = true;
            this.dTextLabel.Location = new System.Drawing.Point(578, 135);
            this.dTextLabel.Name = "dTextLabel";
            this.dTextLabel.Size = new System.Drawing.Size(0, 13);
            this.dTextLabel.TabIndex = 38;
            // 
            // dLabel
            // 
            this.dLabel.AutoSize = true;
            this.dLabel.Location = new System.Drawing.Point(559, 135);
            this.dLabel.Name = "dLabel";
            this.dLabel.Size = new System.Drawing.Size(18, 13);
            this.dLabel.TabIndex = 37;
            this.dLabel.Text = "D:";
            // 
            // avgLabel
            // 
            this.avgLabel.AutoSize = true;
            this.avgLabel.Location = new System.Drawing.Point(559, 235);
            this.avgLabel.Name = "avgLabel";
            this.avgLabel.Size = new System.Drawing.Size(51, 13);
            this.avgLabel.TabIndex = 36;
            this.avgLabel.Text = "Avg time:";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(594, 210);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(13, 13);
            this.timeLabel.TabIndex = 35;
            this.timeLabel.Text = "0";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.SystemColors.Control;
            this.label.Location = new System.Drawing.Point(559, 210);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(33, 13);
            this.label.TabIndex = 34;
            this.label.Text = "Time:";
            // 
            // aLabel
            // 
            this.aLabel.AutoSize = true;
            this.aLabel.Location = new System.Drawing.Point(612, 185);
            this.aLabel.Name = "aLabel";
            this.aLabel.Size = new System.Drawing.Size(13, 13);
            this.aLabel.TabIndex = 33;
            this.aLabel.Text = "0";
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(584, 185);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(13, 13);
            this.yLabel.TabIndex = 32;
            this.yLabel.Text = "0";
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(559, 185);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(13, 13);
            this.xLabel.TabIndex = 31;
            this.xLabel.Text = "0";
            // 
            // drawButton
            // 
            this.drawButton.Location = new System.Drawing.Point(550, 62);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(125, 55);
            this.drawButton.TabIndex = 30;
            this.drawButton.Text = "Нарисовать";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Click += new System.EventHandler(this.drawButton_Click);
            // 
            // FormTest2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.avgTimeLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dTextLabel);
            this.Controls.Add(this.dLabel);
            this.Controls.Add(this.avgLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.label);
            this.Controls.Add(this.aLabel);
            this.Controls.Add(this.yLabel);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.drawButton);
            this.Name = "FormTest2";
            this.Text = "Опыт №2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Click += new System.EventHandler(this.FormTest2_Click);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormTest2_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label avgTimeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dTextLabel;
        private System.Windows.Forms.Label dLabel;
        private System.Windows.Forms.Label avgLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label aLabel;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.Button drawButton;

    }
}