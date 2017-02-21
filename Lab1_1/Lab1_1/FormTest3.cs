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
    public partial class FormTest3 : Form
    {
        public FormTest3()
        {
            InitializeComponent();
            this.MouseMove -= new System.Windows.Forms.MouseEventHandler(this.FormTest3_MouseMove);
        }

        DateTime startMoment;
        int x1 = 0, y1 = 0;
        int[] sMas = new int[] { 0, 20, 40, 60, 100, 150, 200, 250, 300, 350 };
        int[] dMas = new int[] { 8, 10, 12, 15, 20, 30, 50, 70, 100 };
        int i = 0;
        int x = 0, y = 0;
        double[] tMas = new double[3];
        String text = "";

        private void drawButton_Click(object sender, EventArgs e)
        {
            Cursor.Position = new Point(0, 23);

            int a = 0;
            Random rnd = new Random();
            a = rnd.Next(0, 90);
            aLabel.Text = a.ToString();
            System.Drawing.Graphics formGraphics;
            System.Drawing.Color color = SystemColors.Control;
            formGraphics = this.CreateGraphics();

            if (x < 10)
            {
                if (y < 9 && i != 3)
                {
                    x1 = (int)(Math.Cos(Math.PI * a / 180) * sMas[x]);
                    y1 = (int)(Math.Sin(Math.PI * a / 180) * sMas[x]);
                    xLabel.Text = x1.ToString();
                    yLabel.Text = y1.ToString();

                    sLabel.Text = sMas[x].ToString();
                    dLabel.Text = dMas[y].ToString();

                    System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
                    formGraphics.Clear(color);
                    formGraphics.FillRectangle(myBrush, new Rectangle(x1, y1, dMas[y], dMas[y]));
                    myBrush.Dispose();
                    formGraphics.Dispose();
                }
                if (y < 9 && i == 3)
                {
                    formGraphics.Clear(color);
                    FormTest3_Click(sender, e);
                    y++;
                }
                if (y == 9)
                {
                    x++;
                    y = 0;
                }
                this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormTest3_MouseMove);
            }
            else
            {
                System.IO.File.WriteAllText(@"C:\Users\Admin\Documents\Visual Studio 2013\Projects\3 курс\2 семестр\Lab1_1\Lab1_1\Test3.txt", text);
                this.Close();
                return;
            }
        }

        private void FormTest3_MouseMove(object sender, MouseEventArgs e)
        {
            startMoment = DateTime.Now;
            this.MouseMove -= new System.Windows.Forms.MouseEventHandler(this.FormTest3_MouseMove);
        }

        private void FormTest3_Click(object sender, EventArgs e)
        {
            int xCursor = Cursor.Position.X;
            int yCursor = Cursor.Position.Y;
            if (x == 10 || y == 9)
                return;
            if (x1 <= xCursor && xCursor <= x1 + dMas[y] && y1 <= yCursor - 23 && yCursor - 23 <= y1 + dMas[y] && i < 3)
            {
                TimeSpan interval = DateTime.Now - startMoment;
                this.MouseMove -= new System.Windows.Forms.MouseEventHandler(this.FormTest3_MouseMove);
                timeLabel.Text = "s: " + interval.Seconds.ToString() + " ms: " + interval.Milliseconds.ToString();
                tMas[i] = interval.TotalSeconds;
                i++;
            }
            else
            {
                timeLabel.Text = "---";
                if (i == 3 && x < 10 && y < 9)
                {
                    double avg = 0, sum = 0;
                    for (int j = 0; j < 3; j++)
                        sum += tMas[j];
                    avg = (sum / 3.0) * 1000;
                    avgTimeLabel.Text = avg.ToString();
                    text += sMas[x].ToString() + " " + dMas[y].ToString() + " " + avg.ToString() + "\r\n";
                    System.IO.File.WriteAllText(@"C:\Users\Admin\Documents\Visual Studio 2013\Projects\3 курс\2 семестр\Lab1_1\Lab1_1\Test3.txt", text);
                    i = 0;
                }
                else
                {
                    return;
                }
            }
        }
    }
}
