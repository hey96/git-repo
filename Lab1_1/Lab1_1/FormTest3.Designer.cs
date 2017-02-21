namespace Lab1_1
{
    partial class FormTest3
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
            this.d = new System.Windows.Forms.Label();
            this.s = new System.Windows.Forms.Label();
            this.dLabel = new System.Windows.Forms.Label();
            this.sLabel = new System.Windows.Forms.Label();
            this.drawButton = new System.Windows.Forms.Button();
            this.avgTimeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.avgLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.aLabel = new System.Windows.Forms.Label();
            this.yLabel = new System.Windows.Forms.Label();
            this.xLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // d
            // 
            this.d.AutoSize = true;
            this.d.Location = new System.Drawing.Point(607, 149);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(18, 13);
            this.d.TabIndex = 58;
            this.d.Text = "D:";
            // 
            // s
            // 
            this.s.AutoSize = true;
            this.s.Location = new System.Drawing.Point(562, 149);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(17, 13);
            this.s.TabIndex = 57;
            this.s.Text = "S:";
            // 
            // dLabel
            // 
            this.dLabel.AutoSize = true;
            this.dLabel.Location = new System.Drawing.Point(623, 149);
            this.dLabel.Name = "dLabel";
            this.dLabel.Size = new System.Drawing.Size(0, 13);
            this.dLabel.TabIndex = 56;
            // 
            // sLabel
            // 
            this.sLabel.AutoSize = true;
            this.sLabel.Location = new System.Drawing.Point(578, 149);
            this.sLabel.Name = "sLabel";
            this.sLabel.Size = new System.Drawing.Size(0, 13);
            this.sLabel.TabIndex = 55;
            // 
            // drawButton
            // 
            this.drawButton.Location = new System.Drawing.Point(551, 70);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(125, 55);
            this.drawButton.TabIndex = 43;
            this.drawButton.Text = "Нарисовать";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Click += new System.EventHandler(this.drawButton_Click);
            // 
            // avgTimeLabel
            // 
            this.avgTimeLabel.AutoSize = true;
            this.avgTimeLabel.Location = new System.Drawing.Point(612, 249);
            this.avgTimeLabel.Name = "avgTimeLabel";
            this.avgTimeLabel.Size = new System.Drawing.Size(0, 13);
            this.avgTimeLabel.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(562, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 65;
            this.label1.Text = "X1,   Y1,   a:";
            // 
            // avgLabel
            // 
            this.avgLabel.AutoSize = true;
            this.avgLabel.Location = new System.Drawing.Point(562, 249);
            this.avgLabel.Name = "avgLabel";
            this.avgLabel.Size = new System.Drawing.Size(51, 13);
            this.avgLabel.TabIndex = 64;
            this.avgLabel.Text = "Avg time:";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(597, 224);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(13, 13);
            this.timeLabel.TabIndex = 63;
            this.timeLabel.Text = "0";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.SystemColors.Control;
            this.label.Location = new System.Drawing.Point(562, 224);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(33, 13);
            this.label.TabIndex = 62;
            this.label.Text = "Time:";
            // 
            // aLabel
            // 
            this.aLabel.AutoSize = true;
            this.aLabel.Location = new System.Drawing.Point(615, 199);
            this.aLabel.Name = "aLabel";
            this.aLabel.Size = new System.Drawing.Size(13, 13);
            this.aLabel.TabIndex = 61;
            this.aLabel.Text = "0";
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(587, 199);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(13, 13);
            this.yLabel.TabIndex = 60;
            this.yLabel.Text = "0";
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(562, 199);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(13, 13);
            this.xLabel.TabIndex = 59;
            this.xLabel.Text = "0";
            // 
            // FormTest3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.avgTimeLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.avgLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.label);
            this.Controls.Add(this.aLabel);
            this.Controls.Add(this.yLabel);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.d);
            this.Controls.Add(this.s);
            this.Controls.Add(this.dLabel);
            this.Controls.Add(this.sLabel);
            this.Controls.Add(this.drawButton);
            this.Name = "FormTest3";
            this.Text = "Опыт №3";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Click += new System.EventHandler(this.FormTest3_Click);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormTest3_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label d;
        private System.Windows.Forms.Label s;
        private System.Windows.Forms.Label dLabel;
        private System.Windows.Forms.Label sLabel;
        private System.Windows.Forms.Button drawButton;
        private System.Windows.Forms.Label avgTimeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label avgLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label aLabel;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.Label xLabel;
    }
}