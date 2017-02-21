using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_1
{
    public partial class FormTest1 : Form
    {
        public FormTest1()
        {
            InitializeComponent();
            this.MouseMove -= new System.Windows.Forms.MouseEventHandler(this.FormTest1_MouseMove);
        }

        DateTime startMoment;
        int x1 = 0, y1 = 0;
        double[] tMas = new double[5];
        int[] sMas = new int[] { 0, 20, 40, 60, 100, 150, 200, 250, 300, 350 };
        int num = 0, i = 0;
        String text = "";

        private void drawButton_Click(object sender, EventArgs e)
        {
            Cursor.Position = new Point(0, 23);

            int a = 0;
            Random rnd = new Random();
            a = rnd.Next(0, 90);
            aLabel.Text = a.ToString();
            sTextLabel.Text = sMas[i].ToString();
            x1 = (int)(Math.Cos(Math.PI * a / 180) * sMas[i]);
            y1 = (int)(Math.Sin(Math.PI * a / 180) * sMas[i]);
            xLabel.Text = x1.ToString();
            yLabel.Text = y1.ToString();

            System.Drawing.Graphics formGraphics;
            //System.Drawing.Color color = Color.Yellow;
            System.Drawing.Color color = SystemColors.Control;
            formGraphics = this.CreateGraphics();

            if (num != 5)
            {
                System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
                formGraphics.Clear(color);
                formGraphics.FillRectangle(myBrush, new Rectangle(x1, y1, 17, 17));
                myBrush.Dispose();
                formGraphics.Dispose();
            }
            else if (num == 5)
            {
                formGraphics.Clear(color);
                FormTest1_Click(sender, e);
            }
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormTest1_MouseMove);
        }

        private void FormTest1_MouseMove(object sender, MouseEventArgs e)
        {
            startMoment = DateTime.Now;
            this.MouseMove -= new System.Windows.Forms.MouseEventHandler(this.FormTest1_MouseMove);
        }

        private void FormTest1_Click(object sender, EventArgs e)
        {
            int xCursor = Cursor.Position.X;
            int yCursor = Cursor.Position.Y;
            if (x1 <= xCursor && xCursor <= x1 + 17 && y1 <= yCursor - 23 && yCursor - 23 <= y1 + 17 && num < 5)
            {
                TimeSpan interval = DateTime.Now - startMoment;
                this.MouseMove -= new System.Windows.Forms.MouseEventHandler(this.FormTest1_MouseMove);
                timeLabel.Text = "s: " + interval.Seconds.ToString() + " ms: " + interval.Milliseconds.ToString();
                tMas[num] = interval.TotalSeconds;
                num++;
            }
            else
            {
                timeLabel.Text = "---";
                if (num == 5)
                {
                    double avg = 0, sum = 0;
                    for (int j = 0; j < 5; j++)
                        sum += tMas[j];
                    avg = (sum / 5.0) * 1000;
                    avgTimeLabel.Text = avg.ToString();
                    text += sTextLabel.Text + " " + avg.ToString() + "\r\n";
                    System.IO.File.WriteAllText(@"C:\Users\Admin\Documents\Visual Studio 2013\Projects\3 курс\2 семестр\Lab1_1\Lab1_1\Test1.txt", text);
                    num = 0;
                    i++;
                    sTextLabel.Text = "";
                    if (i == 10)
                    {
                        this.Close();
                        return;
                    }
                }
            }
        }
    }
}
