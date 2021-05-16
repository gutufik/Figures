using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDrawing
{
    public partial class Form1 : Form
    {
        private Bitmap draw;
        private Graphics paper;
        private Pen pen;
        private string figure;

        private bool drawWithPen;
        private Point lastPoint;
        private bool isMouseDown;

        public Form1()
        {
            InitializeComponent();
            draw = new Bitmap(drawPanel.Width, drawPanel.Height);
            paper = Graphics.FromImage(draw);
            pen = new Pen(Color.Black, 1);
            lastPoint = Point.Empty;
            isMouseDown = new Boolean();
            drawWithPen = false;
        }


        private void btnCircle_Click(object sender, EventArgs e)
        {
            figure = "Circle";
            drawWithPen = false;
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            figure = "Triangle";
            drawWithPen = false;
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            figure = "Rectangle";
            drawWithPen = false;
        }

        private void bnnLine_Click(object sender, EventArgs e)
        {
            figure = "Line";
            drawWithPen = false;
        }

        private void menuBtnSave_Click(object sender, EventArgs e)
        {
            sfDialog.Filter = "PNG Image | *.png";
            if (sfDialog.ShowDialog(this) == DialogResult.OK)
            {
                draw.Save(sfDialog.FileName);
            }
        }

        private void drawPanel_MouseClick(object sender, MouseEventArgs e)
        {
            switch (figure)
            {
                case "Circle":
                    paper.DrawEllipse(pen, e.X, e.Y, 50, 50);
                    break;
                case "Line":
                    paper.DrawLine(pen, e.X, e.Y, e.X + 50, e.Y + 50);
                    break;
                case "Rectangle":
                    paper.DrawRectangle(pen, e.X, e.Y, 50, 50);
                    break;
                case "Triangle":
                    paper.DrawLine(pen, e.X, e.Y + 100, e.X + 50, e.Y);
                    paper.DrawLine(pen, e.X + 50, e.Y, e.X + 100, e.Y + 100);
                    paper.DrawLine(pen, e.X + 100, e.Y + 100, e.X, e.Y + 100);
                    break;
            }
            drawPanel.Refresh();
        }

        private void drawPanel_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(draw, new Point(0, 0));
        }

        private void menuBtnOpen_Click(object sender, EventArgs e)
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

        private void menuBtnClear_Click(object sender, EventArgs e)
        {
            draw = new Bitmap(drawPanel.Width, drawPanel.Height);
            paper = Graphics.FromImage(draw);
            drawPanel.Refresh();
        }

        private void drawPanel_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            lastPoint = e.Location;
        }

        private void drawPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }

        private void drawPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown && drawWithPen)
            {
                paper.DrawLine(pen, lastPoint.X, lastPoint.Y, e.X, e.Y);
                lastPoint = e.Location;
                drawPanel.Refresh();
            }
        }

        private void btnPen_Click(object sender, EventArgs e)
        {
            drawWithPen = true;
        }
    }
}
