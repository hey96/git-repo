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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void testButton1_Click(object sender, EventArgs e)
        {
            FormTest1 FT1 = new FormTest1();
            FT1.ShowDialog();
        }

        private void testButton2_Click(object sender, EventArgs e)
        {
            FormTest2 FT2 = new FormTest2();
            FT2.ShowDialog();
        }

        private void testButton3_Click(object sender, EventArgs e)
        {
            FormTest3 FT3 = new FormTest3();
            FT3.ShowDialog();
        }
    }
}
