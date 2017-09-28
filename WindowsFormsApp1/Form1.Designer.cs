namespace WindowsFormsApp1
{
    partial class Form1
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
            this.calculation_Box = new System.Windows.Forms.ListBox();
            this.equalbutton = new System.Windows.Forms.Button();
            this.fourbutton = new System.Windows.Forms.Button();
            this.onebutton = new System.Windows.Forms.Button();
            this.twobutton = new System.Windows.Forms.Button();
            this.threebutton = new System.Windows.Forms.Button();
            this.fivebutton = new System.Windows.Forms.Button();
            this.sixbutton = new System.Windows.Forms.Button();
            this.sevenbutton = new System.Windows.Forms.Button();
            this.eightbutton = new System.Windows.Forms.Button();
            this.ninebutton = new System.Windows.Forms.Button();
            this.zerobutton = new System.Windows.Forms.Button();
            this.dotbutton = new System.Windows.Forms.Button();
            this.changesignbutton = new System.Windows.Forms.Button();
            this.multiplybutton = new System.Windows.Forms.Button();
            this.minusbutton = new System.Windows.Forms.Button();
            this.plusbutton = new System.Windows.Forms.Button();
            this.backspacebutton = new System.Windows.Forms.Button();
            this.Cbutton = new System.Windows.Forms.Button();
            this.CEbutton = new System.Windows.Forms.Button();
            this.dividebutton = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.TextBox();
            this.clear_button = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // calculation_Box
            // 
            this.calculation_Box.FormattingEnabled = true;
            this.calculation_Box.Location = new System.Drawing.Point(11, 36);
            this.calculation_Box.Name = "calculation_Box";
            this.calculation_Box.ScrollAlwaysVisible = true;
            this.calculation_Box.Size = new System.Drawing.Size(120, 251);
            this.calculation_Box.TabIndex = 23;
            // 
            // equalbutton
            // 
            this.equalbutton.Location = new System.Drawing.Point(318, 286);
            this.equalbutton.Name = "equalbutton";
            this.equalbutton.Size = new System.Drawing.Size(38, 36);
            this.equalbutton.TabIndex = 2;
            this.equalbutton.Text = "=";
            this.equalbutton.UseVisualStyleBackColor = true;
            this.equalbutton.Click += new System.EventHandler(this.performTask);
            // 
            // fourbutton
            // 
            this.fourbutton.Location = new System.Drawing.Point(150, 202);
            this.fourbutton.Name = "fourbutton";
            this.fourbutton.Size = new System.Drawing.Size(38, 36);
            this.fourbutton.TabIndex = 3;
            this.fourbutton.Text = "4";
            this.fourbutton.UseVisualStyleBackColor = true;
            this.fourbutton.Click += new System.EventHandler(this.performTask);
            // 
            // onebutton
            // 
            this.onebutton.Location = new System.Drawing.Point(150, 244);
            this.onebutton.Name = "onebutton";
            this.onebutton.Size = new System.Drawing.Size(38, 36);
            this.onebutton.TabIndex = 4;
            this.onebutton.Text = "1";
            this.onebutton.UseVisualStyleBackColor = true;
            this.onebutton.Click += new System.EventHandler(this.performTask);
            // 
            // twobutton
            // 
            this.twobutton.Location = new System.Drawing.Point(199, 244);
            this.twobutton.Name = "twobutton";
            this.twobutton.Size = new System.Drawing.Size(38, 36);
            this.twobutton.TabIndex = 5;
            this.twobutton.Text = "2";
            this.twobutton.UseVisualStyleBackColor = true;
            this.twobutton.Click += new System.EventHandler(this.performTask);
            // 
            // threebutton
            // 
            this.threebutton.Location = new System.Drawing.Point(244, 244);
            this.threebutton.Name = "threebutton";
            this.threebutton.Size = new System.Drawing.Size(38, 36);
            this.threebutton.TabIndex = 6;
            this.threebutton.Text = "3";
            this.threebutton.UseVisualStyleBackColor = true;
            this.threebutton.Click += new System.EventHandler(this.performTask);
            // 
            // fivebutton
            // 
            this.fivebutton.Location = new System.Drawing.Point(199, 202);
            this.fivebutton.Name = "fivebutton";
            this.fivebutton.Size = new System.Drawing.Size(38, 36);
            this.fivebutton.TabIndex = 7;
            this.fivebutton.Text = "5";
            this.fivebutton.UseVisualStyleBackColor = true;
            this.fivebutton.Click += new System.EventHandler(this.performTask);
            // 
            // sixbutton
            // 
            this.sixbutton.Location = new System.Drawing.Point(244, 202);
            this.sixbutton.Name = "sixbutton";
            this.sixbutton.Size = new System.Drawing.Size(38, 36);
            this.sixbutton.TabIndex = 8;
            this.sixbutton.Text = "6";
            this.sixbutton.UseVisualStyleBackColor = true;
            this.sixbutton.Click += new System.EventHandler(this.performTask);
            // 
            // sevenbutton
            // 
            this.sevenbutton.Location = new System.Drawing.Point(150, 160);
            this.sevenbutton.Name = "sevenbutton";
            this.sevenbutton.Size = new System.Drawing.Size(38, 36);
            this.sevenbutton.TabIndex = 9;
            this.sevenbutton.Text = "7";
            this.sevenbutton.UseVisualStyleBackColor = true;
            this.sevenbutton.Click += new System.EventHandler(this.performTask);
            // 
            // eightbutton
            // 
            this.eightbutton.Location = new System.Drawing.Point(199, 160);
            this.eightbutton.Name = "eightbutton";
            this.eightbutton.Size = new System.Drawing.Size(38, 36);
            this.eightbutton.TabIndex = 10;
            this.eightbutton.Text = "8";
            this.eightbutton.UseVisualStyleBackColor = true;
            this.eightbutton.Click += new System.EventHandler(this.performTask);
            // 
            // ninebutton
            // 
            this.ninebutton.Location = new System.Drawing.Point(244, 160);
            this.ninebutton.Name = "ninebutton";
            this.ninebutton.Size = new System.Drawing.Size(38, 36);
            this.ninebutton.TabIndex = 11;
            this.ninebutton.Text = "9";
            this.ninebutton.UseVisualStyleBackColor = true;
            this.ninebutton.Click += new System.EventHandler(this.performTask);
            // 
            // zerobutton
            // 
            this.zerobutton.Location = new System.Drawing.Point(199, 286);
            this.zerobutton.Name = "zerobutton";
            this.zerobutton.Size = new System.Drawing.Size(38, 36);
            this.zerobutton.TabIndex = 12;
            this.zerobutton.Text = "0";
            this.zerobutton.UseVisualStyleBackColor = true;
            this.zerobutton.Click += new System.EventHandler(this.performTask);
            // 
            // dotbutton
            // 
            this.dotbutton.Location = new System.Drawing.Point(244, 286);
            this.dotbutton.Name = "dotbutton";
            this.dotbutton.Size = new System.Drawing.Size(38, 36);
            this.dotbutton.TabIndex = 13;
            this.dotbutton.Text = ".";
            this.dotbutton.UseVisualStyleBackColor = true;
            this.dotbutton.Click += new System.EventHandler(this.performTask);
            // 
            // changesignbutton
            // 
            this.changesignbutton.Location = new System.Drawing.Point(150, 286);
            this.changesignbutton.Name = "changesignbutton";
            this.changesignbutton.Size = new System.Drawing.Size(38, 36);
            this.changesignbutton.TabIndex = 14;
            this.changesignbutton.Text = "-/+";
            this.changesignbutton.UseVisualStyleBackColor = true;
            this.changesignbutton.Click += new System.EventHandler(this.performTask);
            // 
            // multiplybutton
            // 
            this.multiplybutton.Location = new System.Drawing.Point(318, 160);
            this.multiplybutton.Name = "multiplybutton";
            this.multiplybutton.Size = new System.Drawing.Size(38, 36);
            this.multiplybutton.TabIndex = 15;
            this.multiplybutton.Text = "*";
            this.multiplybutton.UseVisualStyleBackColor = true;
            this.multiplybutton.Click += new System.EventHandler(this.performTask);
            // 
            // minusbutton
            // 
            this.minusbutton.Location = new System.Drawing.Point(318, 202);
            this.minusbutton.Name = "minusbutton";
            this.minusbutton.Size = new System.Drawing.Size(38, 36);
            this.minusbutton.TabIndex = 16;
            this.minusbutton.Text = "-";
            this.minusbutton.UseVisualStyleBackColor = true;
            this.minusbutton.Click += new System.EventHandler(this.performTask);
            // 
            // plusbutton
            // 
            this.plusbutton.Location = new System.Drawing.Point(318, 244);
            this.plusbutton.Name = "plusbutton";
            this.plusbutton.Size = new System.Drawing.Size(38, 36);
            this.plusbutton.TabIndex = 17;
            this.plusbutton.Text = "+";
            this.plusbutton.UseVisualStyleBackColor = true;
            this.plusbutton.Click += new System.EventHandler(this.performTask);
            // 
            // backspacebutton
            // 
            this.backspacebutton.Location = new System.Drawing.Point(243, 118);
            this.backspacebutton.Name = "backspacebutton";
            this.backspacebutton.Size = new System.Drawing.Size(38, 36);
            this.backspacebutton.TabIndex = 18;
            this.backspacebutton.Text = "<<";
            this.backspacebutton.UseVisualStyleBackColor = true;
            this.backspacebutton.Click += new System.EventHandler(this.performTask);
            // 
            // Cbutton
            // 
            this.Cbutton.Location = new System.Drawing.Point(199, 118);
            this.Cbutton.Name = "Cbutton";
            this.Cbutton.Size = new System.Drawing.Size(38, 36);
            this.Cbutton.TabIndex = 19;
            this.Cbutton.Text = "C";
            this.Cbutton.UseVisualStyleBackColor = true;
            this.Cbutton.Click += new System.EventHandler(this.performTask);
            // 
            // CEbutton
            // 
            this.CEbutton.Location = new System.Drawing.Point(150, 118);
            this.CEbutton.Name = "CEbutton";
            this.CEbutton.Size = new System.Drawing.Size(38, 36);
            this.CEbutton.TabIndex = 20;
            this.CEbutton.Text = "CE";
            this.CEbutton.UseVisualStyleBackColor = true;
            this.CEbutton.Click += new System.EventHandler(this.performTask);
            // 
            // dividebutton
            // 
            this.dividebutton.Location = new System.Drawing.Point(318, 118);
            this.dividebutton.Name = "dividebutton";
            this.dividebutton.Size = new System.Drawing.Size(38, 36);
            this.dividebutton.TabIndex = 21;
            this.dividebutton.Text = "/";
            this.dividebutton.UseVisualStyleBackColor = true;
            this.dividebutton.Click += new System.EventHandler(this.performTask);
            // 
            // display
            // 
            this.display.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.display.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.display.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.display.Location = new System.Drawing.Point(150, 37);
            this.display.Multiline = true;
            this.display.Name = "display";
            this.display.ReadOnly = true;
            this.display.Size = new System.Drawing.Size(201, 68);
            this.display.TabIndex = 22;
            this.display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(12, 294);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(119, 28);
            this.clear_button.TabIndex = 24;
            this.clear_button.Text = "Clear";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.performTask);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(367, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem1});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.saveToolStripMenuItem.Text = "Menu";
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem1.Text = "Save";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.saveToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 333);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.calculation_Box);
            this.Controls.Add(this.display);
            this.Controls.Add(this.dividebutton);
            this.Controls.Add(this.CEbutton);
            this.Controls.Add(this.Cbutton);
            this.Controls.Add(this.backspacebutton);
            this.Controls.Add(this.plusbutton);
            this.Controls.Add(this.minusbutton);
            this.Controls.Add(this.multiplybutton);
            this.Controls.Add(this.changesignbutton);
            this.Controls.Add(this.dotbutton);
            this.Controls.Add(this.zerobutton);
            this.Controls.Add(this.ninebutton);
            this.Controls.Add(this.eightbutton);
            this.Controls.Add(this.sevenbutton);
            this.Controls.Add(this.sixbutton);
            this.Controls.Add(this.fivebutton);
            this.Controls.Add(this.threebutton);
            this.Controls.Add(this.twobutton);
            this.Controls.Add(this.onebutton);
            this.Controls.Add(this.fourbutton);
            this.Controls.Add(this.equalbutton);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox calculation_Box;
        private System.Windows.Forms.Button equalbutton;
        private System.Windows.Forms.Button fourbutton;
        private System.Windows.Forms.Button onebutton;
        private System.Windows.Forms.Button twobutton;
        private System.Windows.Forms.Button threebutton;
        private System.Windows.Forms.Button fivebutton;
        private System.Windows.Forms.Button sixbutton;
        private System.Windows.Forms.Button sevenbutton;
        private System.Windows.Forms.Button eightbutton;
        private System.Windows.Forms.Button ninebutton;
        private System.Windows.Forms.Button zerobutton;
        private System.Windows.Forms.Button dotbutton;
        private System.Windows.Forms.Button changesignbutton;
        private System.Windows.Forms.Button multiplybutton;
        private System.Windows.Forms.Button minusbutton;
        private System.Windows.Forms.Button plusbutton;
        private System.Windows.Forms.Button backspacebutton;
        private System.Windows.Forms.Button Cbutton;
        private System.Windows.Forms.Button CEbutton;
        private System.Windows.Forms.Button dividebutton;
        private System.Windows.Forms.TextBox display;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
    }
}

