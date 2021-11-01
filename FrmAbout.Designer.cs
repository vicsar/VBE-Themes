/*
	VBE Theme Switcher | A simple app designed to quickly change the VBE Theme.
    Copyright (C) 2020  vicsar https://www.vicsar.win/

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

namespace VBEThemes
{
    partial class FrmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAbout));
            this.LblCopyRight = new System.Windows.Forms.Label();
            this.LblVersion = new System.Windows.Forms.Label();
            this.LblDescription = new System.Windows.Forms.Label();
            this.LblVBEThemesTitle = new System.Windows.Forms.Label();
            this.BtnDonate = new System.Windows.Forms.Button();
            this.LblHorizontalSeparator = new System.Windows.Forms.Label();
            this.LnkvicsarURL = new System.Windows.Forms.LinkLabel();
            this.LblNoWarranty = new System.Windows.Forms.Label();
            this.TxtLicense = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblCopyRight
            // 
            this.LblCopyRight.AutoSize = true;
            this.LblCopyRight.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCopyRight.Location = new System.Drawing.Point(12, 63);
            this.LblCopyRight.Name = "LblCopyRight";
            this.LblCopyRight.Size = new System.Drawing.Size(75, 13);
            this.LblCopyRight.TabIndex = 3;
            this.LblCopyRight.Text = "© vicsar 2021";
            this.LblCopyRight.Click += new System.EventHandler(this.LblCopyRight_Click);
            // 
            // LblVersion
            // 
            this.LblVersion.AutoSize = true;
            this.LblVersion.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVersion.Location = new System.Drawing.Point(12, 48);
            this.LblVersion.Name = "LblVersion";
            this.LblVersion.Size = new System.Drawing.Size(55, 13);
            this.LblVersion.TabIndex = 2;
            this.LblVersion.Text = "Version: 1";
            this.LblVersion.Click += new System.EventHandler(this.LblVersion_Click);
            // 
            // LblDescription
            // 
            this.LblDescription.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescription.Location = new System.Drawing.Point(12, 104);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(557, 21);
            this.LblDescription.TabIndex = 5;
            this.LblDescription.Text = "An easy to use program to set the Visual Basic for Applications Editor theme (the" +
    " one used by Microsoft Office®).";
            this.LblDescription.Click += new System.EventHandler(this.LblDescription_Click);
            // 
            // LblVBEThemesTitle
            // 
            this.LblVBEThemesTitle.AutoSize = true;
            this.LblVBEThemesTitle.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVBEThemesTitle.Location = new System.Drawing.Point(12, 9);
            this.LblVBEThemesTitle.Name = "LblVBEThemesTitle";
            this.LblVBEThemesTitle.Size = new System.Drawing.Size(140, 25);
            this.LblVBEThemesTitle.TabIndex = 0;
            this.LblVBEThemesTitle.Text = "VBE Themes";
            this.LblVBEThemesTitle.Click += new System.EventHandler(this.LblVBEThemesTitle_Click);
            // 
            // BtnDonate
            // 
            this.BtnDonate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.BtnDonate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDonate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDonate.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BtnDonate.Location = new System.Drawing.Point(12, 208);
            this.BtnDonate.Name = "BtnDonate";
            this.BtnDonate.Size = new System.Drawing.Size(557, 30);
            this.BtnDonate.TabIndex = 7;
            this.BtnDonate.Text = "Click to &DONATE. Thanks.";
            this.BtnDonate.UseVisualStyleBackColor = true;
            this.BtnDonate.Click += new System.EventHandler(this.BtnDonate_Click);
            // 
            // LblHorizontalSeparator
            // 
            this.LblHorizontalSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblHorizontalSeparator.Location = new System.Drawing.Point(12, 36);
            this.LblHorizontalSeparator.Name = "LblHorizontalSeparator";
            this.LblHorizontalSeparator.Size = new System.Drawing.Size(554, 2);
            this.LblHorizontalSeparator.TabIndex = 1;
            this.LblHorizontalSeparator.Text = " ";
            // 
            // LnkvicsarURL
            // 
            this.LnkvicsarURL.AutoSize = true;
            this.LnkvicsarURL.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnkvicsarURL.Location = new System.Drawing.Point(12, 79);
            this.LnkvicsarURL.Name = "LnkvicsarURL";
            this.LnkvicsarURL.Size = new System.Drawing.Size(83, 13);
            this.LnkvicsarURL.TabIndex = 4;
            this.LnkvicsarURL.TabStop = true;
            this.LnkvicsarURL.Text = "www.vicsar.win";
            this.LnkvicsarURL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkvicsarURL_LinkClicked);
            // 
            // LblNoWarranty
            // 
            this.LblNoWarranty.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNoWarranty.Location = new System.Drawing.Point(12, 139);
            this.LblNoWarranty.Name = "LblNoWarranty";
            this.LblNoWarranty.Size = new System.Drawing.Size(557, 54);
            this.LblNoWarranty.TabIndex = 6;
            this.LblNoWarranty.Text = "This program comes with ABSOLUTELY NO WARRANTY. This is free software, and you ar" +
    "e welcome to redistribute it under certain conditions; for details check the sof" +
    "tware license included below.";
            this.LblNoWarranty.Click += new System.EventHandler(this.LblNoWarranty_Click);
            // 
            // TxtLicense
            // 
            this.TxtLicense.Location = new System.Drawing.Point(12, 266);
            this.TxtLicense.Multiline = true;
            this.TxtLicense.Name = "TxtLicense";
            this.TxtLicense.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtLicense.Size = new System.Drawing.Size(557, 258);
            this.TxtLicense.TabIndex = 8;
            this.TxtLicense.Text = resources.GetString("TxtLicense.Text");
            // 
            // FrmAbout
            // 
            this.AcceptButton = this.BtnDonate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(581, 581);
            this.ControlBox = false;
            this.Controls.Add(this.TxtLicense);
            this.Controls.Add(this.LblNoWarranty);
            this.Controls.Add(this.LnkvicsarURL);
            this.Controls.Add(this.LblHorizontalSeparator);
            this.Controls.Add(this.BtnDonate);
            this.Controls.Add(this.LblVBEThemesTitle);
            this.Controls.Add(this.LblDescription);
            this.Controls.Add(this.LblVersion);
            this.Controls.Add(this.LblCopyRight);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About VBE Themes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAbout_FormClosing);
            this.Load += new System.EventHandler(this.FrmAbout_Load);
            this.Click += new System.EventHandler(this.FrmAbout_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCopyRight;
        private System.Windows.Forms.Label LblVersion;
        private System.Windows.Forms.Label LblDescription;
        private System.Windows.Forms.Label LblVBEThemesTitle;
        private System.Windows.Forms.Button BtnDonate;
        private System.Windows.Forms.Label LblHorizontalSeparator;
        private System.Windows.Forms.LinkLabel LnkvicsarURL;
        private System.Windows.Forms.Label LblNoWarranty;
        private System.Windows.Forms.TextBox TxtLicense;
    }
}