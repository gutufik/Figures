using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;

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

                panel.DrawLine(new Pen(Color.Green, 5), 150, 200, 200, 250);
                panel.DrawLine(new Pen(Color.Green, 5), 200, 200, 150, 200);
                panel.DrawLine(new Pen(Color.Green, 5), 200, 200, 200, 250);
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

        private void bnnLine_Click(object sender, EventArgs e)
        {
            LineForm newForm = new LineForm();
            //newForm.ShowDialog();

            if (newForm.ShowDialog(this) == DialogResult.OK)
            {
                var panel = drawPanel.CreateGraphics();
                panel.DrawLine(new Pen(Color.Red, 5), 200, 200, 300, 300);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sfDialog.ShowDialog() == DialogResult.OK)
            {
                int width = Convert.ToInt32(drawPanel.Width);
                int height = Convert.ToInt32(drawPanel.Height);
                Bitmap bmp = new Bitmap(width, height);
                drawPanel.DrawToBitmap(bmp, new Rectangle(0, 0, width, height));
                bmp.Save($"{sfDialog.FileName}.jpeg", ImageFormat.Jpeg);
            }
        }
    }
}
