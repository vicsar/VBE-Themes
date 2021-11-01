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

using System;

/* Here InteropServices is used to import the dll for round corners and to move the main form*/

using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace VBEThemes
{
    public partial class FrmMain : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public FrmMain()
        {
            InitializeComponent();

            // Reducing form flicker
            this.DoubleBuffered = true;

            // Rounded cornes settings
            this.FormBorderStyle = FormBorderStyle.None;
            // Making rounded corners
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
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

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnApplyTheme_Click(object sender, EventArgs e)
        {
            // Begin setting registry keys:
            // Microsoft.Win32.Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\VBA\\7.1\\Common", "key_name", "key_value");
            if (RdoDefault.Checked == true)
            {
                // Default theme
                Microsoft.Win32.Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\VBA\\7.1\\Common", "CodeBackColors", "0 0 0 7 6 0 0 0 0 0 0 0 0 0 0 0 ");
                Microsoft.Win32.Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\VBA\\7.1\\Common", "CodeForeColors", "0 0 5 0 1 10 14 0 0 0 0 0 0 0 0 0 ");

                //MessageBox.Show("Default", "VBE Themes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (RdoDark.Checked == true)
            {
                // Dark theme
                Microsoft.Win32.Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\VBA\\7.1\\Common", "CodeBackColors", "4 0 4 7 6 4 4 4 4 4 0 0 0 0 0 0 ");
                Microsoft.Win32.Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\VBA\\7.1\\Common", "CodeForeColors", "3 0 5 0 1 10 13 12 2 2 0 0 0 0 0 0 ");

                //MessageBox.Show("Dark", "VBE Themes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Rdovicsar.Checked == true)
            {
                // vicsar theme
                Microsoft.Win32.Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\VBA\\7.1\\Common", "CodeBackColors", "4 0 4 7 6 4 4 4 0 0 0 0 0 0 0 0 ");
                Microsoft.Win32.Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\VBA\\7.1\\Common", "CodeForeColors", "10 0 5 0 1 9 13 2 0 0 0 0 0 0 0 0 ");

                //MessageBox.Show("vicsar", "VBE Themes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (RdoDesert.Checked == true)
            {
                // Desert theme
                Microsoft.Win32.Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\VBA\\7.1\\Common", "CodeBackColors", "2 7 1 13 15 2 2 2 11 9 0 0 0 0 0 0 ");
                Microsoft.Win32.Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\VBA\\7.1\\Common", "CodeForeColors", "13 5 12 1 6 15 8 5 1 1 0 0 0 0 0 0 ");

                //MessageBox.Show("Desert", "VBE Themes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (RdoVimDarkBlue.Checked == true)
            {
                // vim dark blue theme
                Microsoft.Win32.Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\VBA\\7.1\\Common", "CodeBackColors", "14 12 0 7 6 14 14 14 0 0 0 0 0 0 0 0 ");
                Microsoft.Win32.Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\VBA\\7.1\\Common", "CodeForeColors", "1 0 5 0 1 9 11 3 0 0 0 0 0 0 0 0 ");

                //MessageBox.Show("vim", "VBE Themes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (RdoVieEnRose.Checked == true)
            {
                // La vie en rose theme
                Microsoft.Win32.Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\VBA\\7.1\\Common", "CodeBackColors", "4 0 4 7 6 4 4 4 4 4 0 0 0 0 0 0 ");
                Microsoft.Win32.Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\VBA\\7.1\\Common", "CodeForeColors", "13 0 5 0 2 12 9 15 1 2 0 0 0 0 0 0 ");

                //MessageBox.Show("Rose", "VBE Themes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (RdoMatrix.Checked == true)
            {
                // What is the Matrix? theme
                Microsoft.Win32.Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\VBA\\7.1\\Common", "CodeBackColors", "4 10 14 4 12 14 4 4 0 0 0 0 0 0 0 0 ");
                Microsoft.Win32.Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\VBA\\7.1\\Common", "CodeForeColors", "10 4 5 9 1 9 9 12 0 0 0 0 0 0 0 0 ");

                //MessageBox.Show("Matrix", "VBE Themes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (RdoNostalgie.Checked == true)
            {
                // L'heure de la nostalgie theme
                Microsoft.Win32.Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\VBA\\7.1\\Common", "CodeBackColors", "4 1 4 12 10 4 4 4 2 3 0 0 0 0 0 0 ");
                Microsoft.Win32.Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\VBA\\7.1\\Common", "CodeForeColors", "9 13 5 1 1 13 9 9 14 11 0 0 0 0 0 0 ");

                //MessageBox.Show("Nostalgie", "VBE Themes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Fail-safe
            else
            {
                MessageBox.Show("No theme selected, please choose one.", "VBE Themes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // Provide feedback to user
            LblCatchPhrase.Text = "Color Scheme Applied. Restart Microsoft Office®.";
        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmAbout Frm = new FrmAbout();
            Frm.Show();
        }

        private void RdoDefault_CheckedChanged(object sender, EventArgs e)
        {
            PicThemePreview.BackgroundImage = Properties.Resources.default_vbe_theme_preview;
        }

        private void RdoDark_CheckedChanged(object sender, EventArgs e)
        {
            PicThemePreview.BackgroundImage = Properties.Resources.dark_vbe_theme_preview;
        }

        private void Rdovicsar_CheckedChanged(object sender, EventArgs e)
        {
            PicThemePreview.BackgroundImage = Properties.Resources.vicsar_vbe_theme_preview;
        }

        private void RdoDesert_CheckedChanged(object sender, EventArgs e)
        {
            PicThemePreview.BackgroundImage = Properties.Resources.desert_vbe_theme_preview;
        }

        private void RdoVimDarkBlue_CheckedChanged(object sender, EventArgs e)
        {
            PicThemePreview.BackgroundImage = Properties.Resources.vim_dark_blue_vbe_theme_preview;
        }

        private void RdoVieEnRose_CheckedChanged(object sender, EventArgs e)
        {
            PicThemePreview.BackgroundImage = Properties.Resources.la_vie_en_rose_vbe_theme_preview;
        }

        private void RdoMatrix_CheckedChanged(object sender, EventArgs e)
        {
            PicThemePreview.BackgroundImage = Properties.Resources.what_is_the_matrix_vbe_theme_preview;
        }

        private void RdoNostalgie_CheckedChanged(object sender, EventArgs e)
        {
            PicThemePreview.BackgroundImage = Properties.Resources.l_heure_de_la_nostalgie_vbe_theme_preview;
        }

        private void TmrTimer_Tick(object sender, EventArgs e)
        {
            // Clean feedback given to user
            LblCatchPhrase.Text = "";
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
        }

        private void FrmMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void PicThemePreview_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void LblCatchPhrase_Move(object sender, EventArgs e)
        {
        }

        private void RdoDefault_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void RdoDark_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Rdovicsar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void RdoDesert_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void RdoVimDarkBlue_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void RdoVieEnRose_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void RdoMatrix_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void RdoNostalgie_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void LblCatchPhrase_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}