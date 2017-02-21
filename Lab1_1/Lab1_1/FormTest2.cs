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
    public partial class FormTest2 : Form
    {
        public FormTest2()
        {
            InitializeComponent();
            this.MouseMove -= new System.Windows.Forms.MouseEventHandler(this.FormTest2_MouseMove);
        }

        DateTime startMoment;
        int x1 = 0, y1 = 0;
        double[] tMas = new double[5];
        int[] dMas = new int[] { 8, 10, 12, 15, 20, 30, 50, 70, 100 };
        int num = 0, i = 0;
        String text = "";

        private void drawButton_Click(object sender, EventArgs e)
        {
            Cursor.Position = new Point(0, 23);

            int a = 0;
            Random rnd = new Random();
            a = rnd.Next(0, 90);
            aLabel.Text = a.ToString();
            dTextLabel.Text = dMas[i].ToString();
            x1 = (int)(Math.Cos(Math.PI * a / 180) * 400);
            y1 = (int)(Math.Sin(Math.PI * a / 180) * 400);
            xLabel.Text = x1.ToString();
            yLabel.Text = y1.ToString();

            System.Drawing.Graphics formGraphics;
            System.Drawing.Color color = SystemColors.Control;
            formGraphics = this.CreateGraphics();

            if (num != 5)
            {
                System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
                formGraphics.Clear(color);
                formGraphics.FillRectangle(myBrush, new Rectangle(x1, y1, dMas[i], dMas[i]));
                myBrush.Dispose();
                formGraphics.Dispose();
            }
            else if (num == 5)
            {
                formGraphics.Clear(color);
                FormTest2_Click(sender, e);
            }
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormTest2_MouseMove);
        }

        private void FormTest2_MouseMove(object sender, MouseEventArgs e)
        {
            startMoment = DateTime.Now;
            this.MouseMove -= new System.Windows.Forms.MouseEventHandler(this.FormTest2_MouseMove);
        }

        private void FormTest2_Click(object sender, EventArgs e)
        {
            int xCursor = Cursor.Position.X;
            int yCursor = Cursor.Position.Y;
            if (x1 <= xCursor && xCursor <= x1 + dMas[i] && y1 <= yCursor - 23 && yCursor - 23 <= y1 + dMas[i] && num < 5)
            {
                TimeSpan interval = DateTime.Now - startMoment;
                this.MouseMove -= new System.Windows.Forms.MouseEventHandler(this.FormTest2_MouseMove);
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
                    text += dTextLabel.Text + " " + avg.ToString() + "\r\n";
                    System.IO.File.WriteAllText(@"C:\Users\Admin\Documents\Visual Studio 2013\Projects\3 курс\2 семестр\Lab1_1\Lab1_1\Test2.txt", text);
                    num = 0;
                    i++;
                    dTextLabel.Text = "";
                    if (i == 9)
                    {
                        this.Close();
                        return;
                    }
                }
            }
        }
    }
}
