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
            CircleForm newForm = new CircleForm();
            //newForm.ShowDialog();

            if (newForm.ShowDialog(this) == DialogResult.OK)
            {
                var panel = drawPanel.CreateGraphics();
                panel.DrawEllipse(new Pen(Color.Red, 5), 150, 150, 100, 100);
            }
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            TriangleForm newForm = new TriangleForm();
            //newForm.ShowDialog();

            if (newForm.ShowDialog(this) == DialogResult.OK)
            {
                var panel = drawPanel.CreateGraphics();
                panel.DrawRectangle(new Pen(Color.Red, 5), 150, 150, 100, 100);
            }
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            RectangleForm newForm = new RectangleForm();
            //newForm.ShowDialog();

            if (newForm.ShowDialog(this) == DialogResult.OK)
            {
                var panel = drawPanel.CreateGraphics();
                panel.DrawRectangle(new Pen(Color.Red, 5), 150, 150, 100, 100);
            }
        }
    }
}
