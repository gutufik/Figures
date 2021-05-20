
namespace MyDrawing
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCircle = new System.Windows.Forms.Button();
            this.drawPanel = new System.Windows.Forms.Panel();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.clearButton = new System.Windows.Forms.Button();
            this.y1Label = new System.Windows.Forms.Label();
            this.x2LAbel = new System.Windows.Forms.Label();
            this.y2label1 = new System.Windows.Forms.Label();
            this.paramLabel = new System.Windows.Forms.Label();
            this.x1Label = new System.Windows.Forms.Label();
            this.y2Num = new System.Windows.Forms.NumericUpDown();
            this.x1Num = new System.Windows.Forms.NumericUpDown();
            this.x2Num = new System.Windows.Forms.NumericUpDown();
            this.y1Num = new System.Windows.Forms.NumericUpDown();
            this.lbWidth = new System.Windows.Forms.Label();
            this.lbColor = new System.Windows.Forms.Label();
            this.numWidth = new System.Windows.Forms.NumericUpDown();
            this.btnColor = new System.Windows.Forms.Button();
            this.bnnLine = new System.Windows.Forms.Button();
            this.btnTriangle = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnNew = new System.Windows.Forms.ToolStripMenuItem();
            this.sfDialog = new System.Windows.Forms.SaveFileDialog();
            this.ofDialog = new System.Windows.Forms.OpenFileDialog();
            this.clrDialog = new System.Windows.Forms.ColorDialog();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.y2Num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x1Num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x2Num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.y1Num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).BeginInit();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCircle
            // 
            this.btnCircle.Location = new System.Drawing.Point(12, 28);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(56, 38);
            this.btnCircle.TabIndex = 0;
            this.btnCircle.Text = "Circle";
            this.btnCircle.UseVisualStyleBackColor = true;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // drawPanel
            // 
            this.drawPanel.BackColor = System.Drawing.SystemColors.Window;
            this.drawPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawPanel.Location = new System.Drawing.Point(0, 0);
            this.drawPanel.Name = "drawPanel";
            this.drawPanel.Size = new System.Drawing.Size(860, 486);
            this.drawPanel.TabIndex = 1;
            this.drawPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.drawPanel_Paint);
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.clearButton);
            this.panelButtons.Controls.Add(this.y1Label);
            this.panelButtons.Controls.Add(this.x2LAbel);
            this.panelButtons.Controls.Add(this.y2label1);
            this.panelButtons.Controls.Add(this.paramLabel);
            this.panelButtons.Controls.Add(this.x1Label);
            this.panelButtons.Controls.Add(this.y2Num);
            this.panelButtons.Controls.Add(this.x1Num);
            this.panelButtons.Controls.Add(this.x2Num);
            this.panelButtons.Controls.Add(this.y1Num);
            this.panelButtons.Controls.Add(this.lbWidth);
            this.panelButtons.Controls.Add(this.lbColor);
            this.panelButtons.Controls.Add(this.numWidth);
            this.panelButtons.Controls.Add(this.btnColor);
            this.panelButtons.Controls.Add(this.bnnLine);
            this.panelButtons.Controls.Add(this.btnTriangle);
            this.panelButtons.Controls.Add(this.btnRectangle);
            this.panelButtons.Controls.Add(this.btnCircle);
            this.panelButtons.Controls.Add(this.mainMenu);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons.Location = new System.Drawing.Point(0, 0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(860, 157);
            this.panelButtons.TabIndex = 2;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(111, 127);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 21;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.menuBtnClear_Click);
            // 
            // y1Label
            // 
            this.y1Label.AutoSize = true;
            this.y1Label.Location = new System.Drawing.Point(309, 75);
            this.y1Label.Name = "y1Label";
            this.y1Label.Size = new System.Drawing.Size(20, 13);
            this.y1Label.TabIndex = 19;
            this.y1Label.Text = "Y1";
            // 
            // x2LAbel
            // 
            this.x2LAbel.AutoSize = true;
            this.x2LAbel.Location = new System.Drawing.Point(309, 106);
            this.x2LAbel.Name = "x2LAbel";
            this.x2LAbel.Size = new System.Drawing.Size(20, 13);
            this.x2LAbel.TabIndex = 18;
            this.x2LAbel.Text = "X2";
            // 
            // y2label1
            // 
            this.y2label1.AutoSize = true;
            this.y2label1.Location = new System.Drawing.Point(309, 132);
            this.y2label1.Name = "y2label1";
            this.y2label1.Size = new System.Drawing.Size(20, 13);
            this.y2label1.TabIndex = 17;
            this.y2label1.Text = "Y2";
            // 
            // paramLabel
            // 
            this.paramLabel.AutoSize = true;
            this.paramLabel.Location = new System.Drawing.Point(384, 27);
            this.paramLabel.Name = "paramLabel";
            this.paramLabel.Size = new System.Drawing.Size(60, 13);
            this.paramLabel.TabIndex = 16;
            this.paramLabel.Text = "Parameters";
            // 
            // x1Label
            // 
            this.x1Label.AutoSize = true;
            this.x1Label.Location = new System.Drawing.Point(309, 49);
            this.x1Label.Name = "x1Label";
            this.x1Label.Size = new System.Drawing.Size(20, 13);
            this.x1Label.TabIndex = 15;
            this.x1Label.Text = "X1";
            // 
            // y2Num
            // 
            this.y2Num.Location = new System.Drawing.Point(362, 125);
            this.y2Num.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.y2Num.Minimum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.y2Num.Name = "y2Num";
            this.y2Num.Size = new System.Drawing.Size(120, 20);
            this.y2Num.TabIndex = 14;
            this.y2Num.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // x1Num
            // 
            this.x1Num.Location = new System.Drawing.Point(362, 47);
            this.x1Num.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.x1Num.Name = "x1Num";
            this.x1Num.Size = new System.Drawing.Size(120, 20);
            this.x1Num.TabIndex = 13;
            // 
            // x2Num
            // 
            this.x2Num.Location = new System.Drawing.Point(362, 99);
            this.x2Num.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.x2Num.Name = "x2Num";
            this.x2Num.Size = new System.Drawing.Size(120, 20);
            this.x2Num.TabIndex = 12;
            // 
            // y1Num
            // 
            this.y1Num.Location = new System.Drawing.Point(362, 73);
            this.y1Num.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.y1Num.Minimum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.y1Num.Name = "y1Num";
            this.y1Num.Size = new System.Drawing.Size(120, 20);
            this.y1Num.TabIndex = 11;
            this.y1Num.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // lbWidth
            // 
            this.lbWidth.AutoSize = true;
            this.lbWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbWidth.Location = new System.Drawing.Point(668, 28);
            this.lbWidth.Name = "lbWidth";
            this.lbWidth.Size = new System.Drawing.Size(50, 20);
            this.lbWidth.TabIndex = 9;
            this.lbWidth.Text = "Width";
            // 
            // lbColor
            // 
            this.lbColor.AutoSize = true;
            this.lbColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbColor.Location = new System.Drawing.Point(752, 24);
            this.lbColor.Name = "lbColor";
            this.lbColor.Size = new System.Drawing.Size(46, 20);
            this.lbColor.TabIndex = 8;
            this.lbColor.Text = "Color";
            // 
            // numWidth
            // 
            this.numWidth.Location = new System.Drawing.Point(630, 59);
            this.numWidth.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numWidth.Name = "numWidth";
            this.numWidth.Size = new System.Drawing.Size(120, 20);
            this.numWidth.TabIndex = 7;
            this.numWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numWidth.ValueChanged += new System.EventHandler(this.numWidth_ValueChanged);
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.Black;
            this.btnColor.Location = new System.Drawing.Point(756, 51);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(30, 32);
            this.btnColor.TabIndex = 6;
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // bnnLine
            // 
            this.bnnLine.Location = new System.Drawing.Point(206, 28);
            this.bnnLine.Name = "bnnLine";
            this.bnnLine.Size = new System.Drawing.Size(41, 38);
            this.bnnLine.TabIndex = 3;
            this.bnnLine.Text = "Line";
            this.bnnLine.UseVisualStyleBackColor = true;
            this.bnnLine.Click += new System.EventHandler(this.bnnLine_Click);
            // 
            // btnTriangle
            // 
            this.btnTriangle.Location = new System.Drawing.Point(147, 28);
            this.btnTriangle.Name = "btnTriangle";
            this.btnTriangle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnTriangle.Size = new System.Drawing.Size(53, 38);
            this.btnTriangle.TabIndex = 2;
            this.btnTriangle.Text = "Triangle";
            this.btnTriangle.UseVisualStyleBackColor = true;
            this.btnTriangle.Click += new System.EventHandler(this.btnTriangle_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.Location = new System.Drawing.Point(74, 27);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(67, 39);
            this.btnRectangle.TabIndex = 1;
            this.btnRectangle.Text = "Rectangle";
            this.btnRectangle.UseVisualStyleBackColor = true;
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(860, 24);
            this.mainMenu.TabIndex = 5;
            this.mainMenu.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.menuBtnNew});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.menuBtnOpen_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.menuBtnSave_Click);
            // 
            // menuBtnNew
            // 
            this.menuBtnNew.Name = "menuBtnNew";
            this.menuBtnNew.Size = new System.Drawing.Size(103, 22);
            this.menuBtnNew.Text = "New";
            this.menuBtnNew.Click += new System.EventHandler(this.menuBtnClear_Click);
            // 
            // ofDialog
            // 
            this.ofDialog.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 486);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.drawPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelButtons.ResumeLayout(false);
            this.panelButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.y2Num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x1Num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x2Num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.y1Num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).EndInit();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.Panel drawPanel;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button bnnLine;
        private System.Windows.Forms.Button btnTriangle;
        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuBtnNew;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog sfDialog;
        private System.Windows.Forms.OpenFileDialog ofDialog;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.ColorDialog clrDialog;
        private System.Windows.Forms.NumericUpDown numWidth;
        private System.Windows.Forms.Label lbColor;
        private System.Windows.Forms.Label lbWidth;
        private System.Windows.Forms.NumericUpDown y1Num;
        private System.Windows.Forms.Label paramLabel;
        private System.Windows.Forms.Label x1Label;
        private System.Windows.Forms.NumericUpDown y2Num;
        private System.Windows.Forms.NumericUpDown x1Num;
        private System.Windows.Forms.NumericUpDown x2Num;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label y1Label;
        private System.Windows.Forms.Label x2LAbel;
        private System.Windows.Forms.Label y2label1;
    }
}

