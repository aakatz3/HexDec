namespace HexDec
{
    partial class RootForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RootForm));
            this.b2 = new System.Windows.Forms.CheckBox();
            this.b3 = new System.Windows.Forms.CheckBox();
            this.b4 = new System.Windows.Forms.CheckBox();
            this.b5 = new System.Windows.Forms.CheckBox();
            this.b6 = new System.Windows.Forms.CheckBox();
            this.b7 = new System.Windows.Forms.CheckBox();
            this.b1 = new System.Windows.Forms.CheckBox();
            this.b0 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hexval = new System.Windows.Forms.NumericUpDown();
            this.binbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.invert = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.format = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decBox = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.hexval)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.decBox)).BeginInit();
            this.SuspendLayout();
            // 
            // b2
            // 
            this.b2.AutoSize = true;
            this.b2.Location = new System.Drawing.Point(130, 14);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(15, 14);
            this.b2.TabIndex = 7;
            this.toolTip1.SetToolTip(this.b2, "Bit 2");
            this.b2.UseVisualStyleBackColor = true;
            this.b2.CheckedChanged += new System.EventHandler(this.b2_CheckedChanged);
            // 
            // b3
            // 
            this.b3.AutoSize = true;
            this.b3.Location = new System.Drawing.Point(109, 14);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(15, 14);
            this.b3.TabIndex = 6;
            this.toolTip1.SetToolTip(this.b3, "Bit 3");
            this.b3.UseVisualStyleBackColor = true;
            this.b3.CheckedChanged += new System.EventHandler(this.b3_CheckedChanged);
            // 
            // b4
            // 
            this.b4.AutoSize = true;
            this.b4.Location = new System.Drawing.Point(88, 14);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(15, 14);
            this.b4.TabIndex = 5;
            this.toolTip1.SetToolTip(this.b4, "Bit 4");
            this.b4.UseVisualStyleBackColor = true;
            this.b4.CheckedChanged += new System.EventHandler(this.b4_CheckedChanged);
            // 
            // b5
            // 
            this.b5.AutoSize = true;
            this.b5.Location = new System.Drawing.Point(67, 14);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(15, 14);
            this.b5.TabIndex = 4;
            this.toolTip1.SetToolTip(this.b5, "Bit 5");
            this.b5.UseVisualStyleBackColor = true;
            this.b5.CheckedChanged += new System.EventHandler(this.b5_CheckedChanged);
            // 
            // b6
            // 
            this.b6.AutoSize = true;
            this.b6.Location = new System.Drawing.Point(46, 14);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(15, 14);
            this.b6.TabIndex = 3;
            this.toolTip1.SetToolTip(this.b6, "Bit 6");
            this.b6.UseVisualStyleBackColor = true;
            this.b6.CheckedChanged += new System.EventHandler(this.b6_CheckedChanged);
            // 
            // b7
            // 
            this.b7.AutoSize = true;
            this.b7.Location = new System.Drawing.Point(25, 14);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(15, 14);
            this.b7.TabIndex = 2;
            this.toolTip1.SetToolTip(this.b7, "Bit 7");
            this.b7.UseVisualStyleBackColor = true;
            this.b7.CheckedChanged += new System.EventHandler(this.b7_CheckedChanged);
            // 
            // b1
            // 
            this.b1.AutoSize = true;
            this.b1.Location = new System.Drawing.Point(151, 14);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(15, 14);
            this.b1.TabIndex = 8;
            this.toolTip1.SetToolTip(this.b1, "Bit 1");
            this.b1.UseVisualStyleBackColor = true;
            this.b1.CheckedChanged += new System.EventHandler(this.b1_CheckedChanged);
            // 
            // b0
            // 
            this.b0.AutoSize = true;
            this.b0.Location = new System.Drawing.Point(172, 14);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(15, 14);
            this.b0.TabIndex = 9;
            this.toolTip1.SetToolTip(this.b0, "Bit 0");
            this.b0.UseVisualStyleBackColor = true;
            this.b0.CheckedChanged += new System.EventHandler(this.b0_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "7";
            // 
            // hexval
            // 
            this.hexval.Hexadecimal = true;
            this.hexval.Location = new System.Drawing.Point(212, 11);
            this.hexval.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.hexval.Name = "hexval";
            this.hexval.Size = new System.Drawing.Size(48, 20);
            this.hexval.TabIndex = 1;
            this.toolTip1.SetToolTip(this.hexval, "Hexadecimal Value (Double-click to copy)");
            this.hexval.ValueChanged += new System.EventHandler(this.hexval_ValueChanged);
            this.hexval.Validated += new System.EventHandler(this.hexval_Validated);
            this.hexval.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.copy_hex);
            this.hexval.Leave += new System.EventHandler(this.hexval_Leave);
            this.hexval.KeyUp += new System.Windows.Forms.KeyEventHandler(this.hexval_KeyUp);
            this.hexval.KeyDown += new System.Windows.Forms.KeyEventHandler(this.hexval_KeyDown);
            // 
            // binbox
            // 
            this.binbox.Location = new System.Drawing.Point(46, 36);
            this.binbox.Name = "binbox";
            this.binbox.ReadOnly = true;
            this.binbox.Size = new System.Drawing.Size(71, 20);
            this.binbox.TabIndex = 12;
            this.binbox.Text = "0b00000000";
            this.toolTip1.SetToolTip(this.binbox, "Binary Value (Double-click to copy)");
            this.binbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.binbox_KeyDown);
            this.binbox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.copy_bin);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Binary:";
            // 
            // invert
            // 
            this.invert.Location = new System.Drawing.Point(170, 35);
            this.invert.Name = "invert";
            this.invert.Size = new System.Drawing.Size(46, 23);
            this.invert.TabIndex = 10;
            this.invert.Text = "Invert";
            this.toolTip1.SetToolTip(this.invert, "Invert Value");
            this.invert.UseVisualStyleBackColor = true;
            this.invert.Click += new System.EventHandler(this.invert_Click);
            // 
            // exit
            // 
            this.exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exit.Location = new System.Drawing.Point(222, 35);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(38, 23);
            this.exit.TabIndex = 11;
            this.exit.Text = "Hide";
            this.toolTip1.SetToolTip(this.exit, "Exit Application");
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // format
            // 
            this.format.Location = new System.Drawing.Point(121, 35);
            this.format.Name = "format";
            this.format.Size = new System.Drawing.Size(43, 23);
            this.format.TabIndex = 19;
            this.format.Text = "FMT";
            this.toolTip1.SetToolTip(this.format, "Change format of Binary field");
            this.format.UseVisualStyleBackColor = true;
            this.format.Click += new System.EventHandler(this.format_Click);
            this.format.MouseHover += new System.EventHandler(this.format_MouseHover);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(266, 35);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(52, 23);
            this.clear.TabIndex = 20;
            this.clear.Text = "Clear";
            this.toolTip1.SetToolTip(this.clear, "Clear Number");
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // trayIcon
            // 
            this.trayIcon.ContextMenuStrip = this.contextMenuStrip1;
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "1";
            this.trayIcon.Visible = true;
            this.trayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.trayIcon_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.hideToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(115, 70);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exit_Click);
            // 
            // hideToolStripMenuItem
            // 
            this.hideToolStripMenuItem.Name = "hideToolStripMenuItem";
            this.hideToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.hideToolStripMenuItem.Text = "Hide";
            this.hideToolStripMenuItem.Click += new System.EventHandler(this.hideToolStripMenuItem_Click);
            // 
            // decBox
            // 
            this.decBox.Enabled = false;
            this.decBox.Location = new System.Drawing.Point(266, 11);
            this.decBox.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.decBox.Name = "decBox";
            this.decBox.Size = new System.Drawing.Size(52, 20);
            this.decBox.TabIndex = 21;
            // 
            // RootForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 65);
            this.Controls.Add(this.decBox);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.format);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.invert);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.binbox);
            this.Controls.Add(this.hexval);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(336, 97);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(336, 97);
            this.Name = "RootForm";
            this.ShowInTaskbar = false;
            this.Text = "Binary Hex Converter";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RootForm_FormClosing);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.RootForm_HelpRequested);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RootForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.hexval)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.decBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox b2;
        private System.Windows.Forms.CheckBox b3;
        private System.Windows.Forms.CheckBox b4;
        private System.Windows.Forms.CheckBox b5;
        private System.Windows.Forms.CheckBox b6;
        private System.Windows.Forms.CheckBox b7;
        private System.Windows.Forms.CheckBox b1;
        private System.Windows.Forms.CheckBox b0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown hexval;
        private System.Windows.Forms.TextBox binbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button invert;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button format;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideToolStripMenuItem;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.NumericUpDown decBox;
    }
}

