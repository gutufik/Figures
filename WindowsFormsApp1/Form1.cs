using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApp1
{
    public partial class frm : Form
    {
        public Stopwatch stopWatch = new Stopwatch();
        public Random rnd = new Random();

        public frm()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {   
            if (btn.Width == 200)
            {
                stopWatch.Start();
            }
            btn.Location = new Point(rnd.Next(0, this.Size.Width - btn.Width),
                rnd.Next(0, this.Size.Height - btn.Height));
            btn.Width -= 10;
            btn.Height -= 10;

            int red = rnd.Next(0, 256);
            int green = rnd.Next(0, 256);
            int blue = rnd.Next(0, 256);

            btn.BackColor = Color.FromArgb(255, red, green, blue);

            if (btn.Width <= 10)
            {
                MessageBox.Show(stopWatch.Elapsed.ToString());
                this.Close();
            }
        }
    }
}
