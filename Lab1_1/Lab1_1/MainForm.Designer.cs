namespace Lab1_1
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.testButton1 = new System.Windows.Forms.Button();
            this.testButton2 = new System.Windows.Forms.Button();
            this.testButton3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // testButton1
            // 
            this.testButton1.Location = new System.Drawing.Point(71, 56);
            this.testButton1.Name = "testButton1";
            this.testButton1.Size = new System.Drawing.Size(200, 40);
            this.testButton1.TabIndex = 0;
            this.testButton1.Text = "Опыт №1. D=const";
            this.testButton1.UseVisualStyleBackColor = true;
            this.testButton1.Click += new System.EventHandler(this.testButton1_Click);
            // 
            // testButton2
            // 
            this.testButton2.Location = new System.Drawing.Point(71, 124);
            this.testButton2.Name = "testButton2";
            this.testButton2.Size = new System.Drawing.Size(200, 40);
            this.testButton2.TabIndex = 1;
            this.testButton2.Text = "Опыт №2. S=const";
            this.testButton2.UseVisualStyleBackColor = true;
            this.testButton2.Click += new System.EventHandler(this.testButton2_Click);
            // 
            // testButton3
            // 
            this.testButton3.Location = new System.Drawing.Point(71, 193);
            this.testButton3.Name = "testButton3";
            this.testButton3.Size = new System.Drawing.Size(200, 40);
            this.testButton3.TabIndex = 2;
            this.testButton3.Text = "Опыт №3";
            this.testButton3.UseVisualStyleBackColor = true;
            this.testButton3.Click += new System.EventHandler(this.testButton3_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.testButton3);
            this.Controls.Add(this.testButton2);
            this.Controls.Add(this.testButton1);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Первая группа опытов";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button testButton1;
        private System.Windows.Forms.Button testButton2;
        private System.Windows.Forms.Button testButton3;
    }
}

