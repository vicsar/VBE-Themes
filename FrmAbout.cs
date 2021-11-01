/*
	VBE Theme Switcher | A simple app designed to quickly change the VBE Theme.
    Copyright (C) 2021  vicsar https://www.vicsar.win/

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

using Animation;
using System;

/* InteropServices is used to import the dll for round corners */

using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace VBEThemes
{
    public partial class FrmAbout : Form
    {
        public FrmAbout()
        {
            InitializeComponent();

            // Reducing form flicker
            this.DoubleBuffered = true;

            // Rounded cornes settings
            this.FormBorderStyle = FormBorderStyle.None;
            // Making rounded corners
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void BtnDonate_Click(object sender, EventArgs e)
        {
            // Launch browser to PayPal...
            System.Diagnostics.Process.Start("https://www.paypal.com/donate?hosted_button_id=GD7GJH8ALP5W4");
        }

        // Making rounded corners
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        private void FrmAbout_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmAbout_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Set the transparency of the parent window
            FrmMain Frm = (FrmMain)Application.OpenForms["FrmMain"];
            Frm.Opacity = 1;

            Frm.Show();
        }

        private void FrmAbout_Load(object sender, EventArgs e)
        {
            // Set the transparency of the parent window
            //FrmMain Frm = (FrmMain)Application.OpenForms["FrmMain"];
            //Frm.Opacity = 0.85;

            // Animating the window, just for fun, c'mon guys, enjoy what you do!
            Animation.WinAPI.AnimateWindow(this.Handle, 200, WinAPI.HOR_Positive);
        }

        private void LblNoWarranty_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LnkLegalURL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.vbetheme.com/legal");
        }

        private void LnkvicsarURL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.vicsar.win/");
        }

        // Close on Escape
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Escape))
            {
                Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void LblVBEThemesTitle_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LblVersion_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LblCopyRight_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LblDescription_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}