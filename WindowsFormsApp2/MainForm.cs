using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinDraw;

namespace MyDrawing
{
    public partial class MainForm : Form
    {
        private Bitmap draw;
        private Graphics paper;
        private Pen pen;
        private List<Figure> figures;

        public MainForm()
        {
            InitializeComponent();
            draw = new Bitmap(drawPanel.Width, drawPanel.Height);
            paper = Graphics.FromImage(draw);
            pen = new Pen(Color.Black, 1);
            figures = new List<Figure>();
        }


        private void btnCircle_Click(object sender, EventArgs e)
        {
            var circle = new Circle((int)x1Num.Value, (int)y1Num.Value,
                                (int)x2Num.Value);
            circle.Draw(paper, pen);
            figures.Add(circle);
            drawPanel.Refresh();
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            var triangle = new Triangle((int)x1Num.Value, (int)y1Num.Value,
                                (int)x2Num.Value, (int)y2Num.Value);
            triangle.Draw(paper, pen);
            figures.Add(triangle);
            drawPanel.Refresh();
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            var rectangle = new MyRectangle((int)x1Num.Value, (int)y1Num.Value,
                                (int)x2Num.Value - (int)x1Num.Value,
                                (int)y2Num.Value - (int)y1Num.Value);
            rectangle.Draw(paper, pen);
            figures.Add(rectangle);
            drawPanel.Refresh();
        }

        private void bnnLine_Click(object sender, EventArgs e)
        {
            var line = new Line((int)x1Num.Value, (int)y1Num.Value, 
                                (int)x2Num.Value, (int)y2Num.Value);
            line.Draw(paper, pen);
            figures.Add(line);
            drawPanel.Refresh();
        }

        private void menuBtnSave_Click(object sender, EventArgs e)
        {
            sfDialog.Filter = "PNG Image | *.png";
            if (sfDialog.ShowDialog(this) == DialogResult.OK)
            {
                draw.Save(sfDialog.FileName);
            }
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
            figures.Clear();

            drawPanel.Refresh();
        }
    }
}
