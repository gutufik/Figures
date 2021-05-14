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
        private Bitmap draw;
        private Graphics paper;
        private Pen pen;


        public Form1()
        {
            InitializeComponent();
            draw = new Bitmap(drawPanel.Width, drawPanel.Height);
            paper = Graphics.FromImage(draw);
            pen = new Pen(Color.Black, 1);
        }


        private void btnCircle_Click(object sender, EventArgs e)
        {
            CircleForm newForm = new CircleForm();
            //newForm.ShowDialog();

            if (newForm.ShowDialog(this) == DialogResult.OK)
            {
                paper.DrawEllipse(pen, 150, 150, 100, 100);
                drawPanel.Refresh();
            }
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            TriangleForm newForm = new TriangleForm();

            if (newForm.ShowDialog(this) == DialogResult.OK)
            {
                paper.DrawLine(pen, 150, 200, 200, 250);
                paper.DrawLine(pen, 200, 200, 150, 200);
                paper.DrawLine(pen, 200, 200, 200, 250);
                drawPanel.Refresh();
            }
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            RectangleForm newForm = new RectangleForm();

            if (newForm.ShowDialog(this) == DialogResult.OK)
            {
                paper.DrawRectangle(pen, 150, 150, 100, 100);
                drawPanel.Refresh();
            }
        }

        private void bnnLine_Click(object sender, EventArgs e)
        {
            LineForm newForm = new LineForm();

            if (newForm.ShowDialog(this) == DialogResult.OK)
            {
                paper.DrawLine(pen, 200, 200, 300, 300);
                drawPanel.Refresh();
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

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (clrDialog.ShowDialog(this) == DialogResult.OK)
            {
                btnColor.BackColor = clrDialog.Color;
                pen.Color = clrDialog.Color;
            }
        }

        private void numWidth_ValueChanged(object sender, EventArgs e)
        {
            pen.Width = (int)numWidth.Value;
        }

    }
}
