using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using Microsoft.Win32;
using System.Windows;

namespace HexDec
{
    public partial class RootForm : Form
    {
        static byte value;
        static CheckBox[] bitbox;
        //static RegistryKey key;
        static bool updating = false;
        static bool asmFormat = false;
        static bool hidden = false;
        public RootForm()
        {
            Hide();
            asmFormat = HexDec.Properties.Settings.Default.asmFmt;
            value = HexDec.Properties.Settings.Default.value;
            InitializeComponent();
            toolTip1.IsBalloon = true;
            CheckBox [] tmp = { b0, b1, b2, b3, b4, b5, b6, b7};
            bitbox = tmp;
            
            this.TopMost = true;
            /*key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\HexBinDecoder");
            value = Convert.ToByte(Registry.GetValue(@"SOFTWARE\HexBinDecoder","LastValue", (byte)0xFC));*/
            updateFormatButton();
            updateControls();
            Show();
        }

        private void hexval_ValueChanged(object sender, EventArgs e)
        {
            hexval.Validate();

            value = (byte)hexval.Value;

            updateControls(true);
            
 
        }

        private void updateControls()
        {
            updateControls(true);
            updateControls(false);
        }

        private void updateDec()
        {
            decBox.Value = value;
        }

        private void updateBinbox()
        {
            string prefix = asmFormat ? "#%" : "0b";
            binbox.Text = String.Concat(prefix, Convert.ToString(value, 2).PadLeft(8, '0'));
        }

        private void updateControls(bool checkChanged)
        {
            if (!updating)
            {
                updating = true;
                updateBinbox();
                updateDec();
                if (checkChanged)
                {
                    for (int i = 0; i < bitbox.Length; i++)
                    {
                        bitbox[i].Checked = Convert.ToBoolean(((byte)value) & ((byte)(1 << i)));
                    }
                }
                else
                {
                    hexval.Value = value;
                }
                updating = false;
            }
        }

        private void switchBit(int bitToSwap)
        {
            if(!updating)
                value ^= (byte)(1 << bitToSwap);
        }

        private void b0_CheckedChanged(object sender, EventArgs e)
        {
            switchBit(0);
            updateControls(false);
        }
        private void b1_CheckedChanged(object sender, EventArgs e)
        {
            switchBit(1);
            updateControls(false);
        }
        private void b2_CheckedChanged(object sender, EventArgs e)
        {
            switchBit(2);
            updateControls(false);
        }
        private void b3_CheckedChanged(object sender, EventArgs e)
        {
            switchBit(3);
            updateControls(false);
        }
        private void b4_CheckedChanged(object sender, EventArgs e)
        {
            switchBit(4);
            updateControls(false);
        }
        private void b5_CheckedChanged(object sender, EventArgs e)
        {
            switchBit(5);
            updateControls(false);
        }
        private void b6_CheckedChanged(object sender, EventArgs e)
        {
            switchBit(6);
            updateControls(false);
        }
        private void b7_CheckedChanged(object sender, EventArgs e)
        {
            switchBit(7);
            updateControls(false);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            //key.SetValue("ScheduledInstallTime", 0x0000000c, RegistryValueKind.DWord);
            //key.Flush();
            //key.Close();            
            Close();
        }

        private void invert_Click(object sender, EventArgs e)
        {
            value =  (byte)~value;
            updateControls();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            //Close();
            hidden = true;
            hideToolStripMenuItem.Text = "Show";
            Hide();
        }

        private int hex2int(char ch)
        {
            if (ch >= '0' && ch <= '9')
                return ch - '0';
            if (ch >= 'A' && ch <= 'F')
                return ch - 'A' + 10;
            if (ch >= 'a' && ch <= 'f')
                return ch - 'a' + 10;
            return -1;
        }

        private void hexval_KeyUp(object sender, KeyEventArgs e)
        {
            if (!e.KeyCode.Equals(Keys.Left) && !e.KeyCode.Equals(Keys.Right))
            {
                hexval.ValueChanged -= hexval_ValueChanged;
                hexval.Maximum = 99999999;

                if (hexval.Value > 255)
                {
                    //Console.WriteLine(((int)hexval.Value) << 16);
                    //hexval.Value = ((int)hexval.Value) << ;
                    //hexval.Value = hex2int((char)e.KeyValue);
                    hexval.Value /= 16;


                }

                hexval.Maximum = 255;
                hexval.ValueChanged += hexval_ValueChanged;
                value = (byte)hexval.Value;

                updateControls(true);

                    

                Console.Write(hexval.Controls.ContainsKey("TextBox"));
                
                hexval.Select(2, 0);
                
            }

        }

        private void hexval_Validated(object sender, EventArgs e)
        {
            
            value = (byte)hexval.Value;

            updateControls(true);
        }


        private void hexval_KeyPress(object sender, KeyEventArgs e)
        {
            

        }

        private void hexval_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter) || e.KeyCode.Equals(Keys.Return))
            {
                e.SuppressKeyPress = true;
                hexval.Select(2, 0);
                label1.Focus();
            }
            else if (e.KeyCode.Equals(Keys.Escape))
            {
                label1.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void hexval_Leave(object sender, EventArgs e)
        {
            Console.WriteLine(sender.ToString());
            Console.WriteLine(e.GetType().ToString());
            Console.WriteLine(e.ToString());
        }


        private void format_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(format, asmFormat ? "Change to C format" : "Change to HCS12 Assembly format");
        }

        private void format_Click(object sender, EventArgs e)
        {
            asmFormat = !asmFormat;
            updateFormatButton();
            updateBinbox();
        }

        private void updateFormatButton()
        {
            format.Text = asmFormat ? "C" : "ASM";
        }


        private void copy_bin(object sender, MouseEventArgs e)
        {
            this.Cursor = new Cursor(Cursor.Current.Handle);
            System.Windows.Forms.Clipboard.SetText(binbox.Text);
            trayIcon.ShowBalloonTip(1000, "HexDec", "The Binary value was copied to your clipboard!", ToolTipIcon.Info);
        }

        private void copy_hex(object sender, MouseEventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(String.Concat("0x", hexval.Value.ToString().PadLeft(2, '0')));
            trayIcon.ShowBalloonTip(1000, "HexDec", "The Hexadecimal value was copied to your clipboard!", ToolTipIcon.Info);
        }

        private void RootForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode.Equals(Keys.Escape)){
                if (!hexval.Focused && !binbox.Focused)
                {
                    DialogResult exitres = MessageBox.Show("Exit HexDec?",
                        "Are you sure you want to exit?", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    if (exitres.Equals(DialogResult.Yes))
                        Close();
                }
                else
                {
                    if (binbox.Focused || hexval.Focused)
                    {
                        label1.Focus();
                        e.Handled = true;
                        e.SuppressKeyPress = true;
                    }
                }
            }
        }



        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form about = new AboutBox();
            about.ShowInTaskbar = true;
            about.ShowDialog();
        }

        private void RootForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            HexDec.Properties.Settings.Default.asmFmt = asmFormat;
            HexDec.Properties.Settings.Default.value = value;
            HexDec.Properties.Settings.Default.Save();
        }

        private void RootForm_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Form about = new AboutBox();
            about.ShowInTaskbar = false;
            about.ShowDialog();
        }

        private void hideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hidden = !hidden;
            if (hidden)
            {
                hideToolStripMenuItem.Text = "Show";
                Hide();
            }
            else
            {
                hideToolStripMenuItem.Text = "Hide";
                Show();
            }
        }

        private void binbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Escape))
            {
                label1.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            value = 0;
            updateControls();
        }

        private void trayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (hidden)
            {
                hidden = false;
                hideToolStripMenuItem.Text = "Show";
                Show();
            }
        }
    }
}