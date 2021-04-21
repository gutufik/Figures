
namespace WindowsFormsApp2
{
    partial class CircleForm
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
            this.btnOK = new System.Windows.Forms.Button();
            this.xTextbox = new System.Windows.Forms.TextBox();
            this.yTextbox = new System.Windows.Forms.TextBox();
            this.rTextbox = new System.Windows.Forms.TextBox();
            this.XLabel = new System.Windows.Forms.Label();
            this.YLabel = new System.Windows.Forms.Label();
            this.RLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(158, 190);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // xTextbox
            // 
            this.xTextbox.Location = new System.Drawing.Point(133, 28);
            this.xTextbox.Name = "xTextbox";
            this.xTextbox.Size = new System.Drawing.Size(100, 20);
            this.xTextbox.TabIndex = 1;
            // 
            // yTextbox
            // 
            this.yTextbox.Location = new System.Drawing.Point(133, 78);
            this.yTextbox.Name = "yTextbox";
            this.yTextbox.Size = new System.Drawing.Size(100, 20);
            this.yTextbox.TabIndex = 2;
            // 
            // rTextbox
            // 
            this.rTextbox.Location = new System.Drawing.Point(133, 126);
            this.rTextbox.Name = "rTextbox";
            this.rTextbox.Size = new System.Drawing.Size(100, 20);
            this.rTextbox.TabIndex = 3;
            // 
            // XLabel
            // 
            this.XLabel.AutoSize = true;
            this.XLabel.Location = new System.Drawing.Point(89, 35);
            this.XLabel.Name = "XLabel";
            this.XLabel.Size = new System.Drawing.Size(14, 13);
            this.XLabel.TabIndex = 4;
            this.XLabel.Text = "X";
            this.XLabel.Click += new System.EventHandler(this.XLabel_Click);
            // 
            // YLabel
            // 
            this.YLabel.AutoSize = true;
            this.YLabel.Location = new System.Drawing.Point(89, 85);
            this.YLabel.Name = "YLabel";
            this.YLabel.Size = new System.Drawing.Size(14, 13);
            this.YLabel.TabIndex = 5;
            this.YLabel.Text = "Y";
            this.YLabel.Click += new System.EventHandler(this.YLabel_Click);
            // 
            // RLabel
            // 
            this.RLabel.AutoSize = true;
            this.RLabel.Location = new System.Drawing.Point(73, 133);
            this.RLabel.Name = "RLabel";
            this.RLabel.Size = new System.Drawing.Size(40, 13);
            this.RLabel.TabIndex = 6;
            this.RLabel.Text = "Radius";
            // 
            // CircleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(413, 246);
            this.Controls.Add(this.RLabel);
            this.Controls.Add(this.YLabel);
            this.Controls.Add(this.XLabel);
            this.Controls.Add(this.rTextbox);
            this.Controls.Add(this.yTextbox);
            this.Controls.Add(this.xTextbox);
            this.Controls.Add(this.btnOK);
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name = "CircleForm";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox xTextbox;
        private System.Windows.Forms.TextBox yTextbox;
        private System.Windows.Forms.TextBox rTextbox;
        private System.Windows.Forms.Label XLabel;
        private System.Windows.Forms.Label YLabel;
        private System.Windows.Forms.Label RLabel;
    }
}