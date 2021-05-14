using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private Bitmap draw;
        private Graphics paper;

        public Form1()
        {
            InitializeComponent();
            draw = new Bitmap(drawPanel.Width, drawPanel.Height);
            paper = Graphics.FromImage(draw);
        }


        private void btnCircle_Click(object sender, EventArgs e)
        {
            CircleForm newForm = new CircleForm();
            //newForm.ShowDialog();

            if (newForm.ShowDialog(this) == DialogResult.OK)
            {
                paper.DrawEllipse(new Pen(Color.Red, 5), 150, 150, 100, 100);
                drawPanel.Refresh();
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
            sfDialog.Filter = "PNG Image | *.png";
            if (sfDialog.ShowDialog(this) == DialogResult.OK)
            {
                draw.Save(sfDialog.FileName);
            }
        }

        private void drawPanel_MouseClick(object sender, MouseEventArgs e)
        {
            var pen = new Pen(Color.DarkOliveGreen, 5);
            paper.DrawEllipse(pen, e.X, e.Y, 50, 50);
            drawPanel.Refresh();
        }

        private void drawPanel_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(draw, new Point(0, 0));
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ofDialog.Filter = "PNG Image | *.png";

            if (ofDialog.ShowDialog(this) == DialogResult.OK)
            {
                var img = new Bitmap(ofDialog.FileName);
                draw.Dispose();
                draw = new Bitmap(img);
                paper = Graphics.FromImage(draw);
                drawPanel.Refresh();
                img.Dispose();
            }
        }
    }
}
