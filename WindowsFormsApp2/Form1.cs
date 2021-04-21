using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void drawPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            //newForm.ShowDialog();

            if (newForm.ShowDialog(this) == DialogResult.OK)
            {
                var panel = drawPanel.CreateGraphics();
                panel.DrawEllipse(new Pen(Color.Red, 5), 100, 100, 50, 50);

            }
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {

        }
    }
}
