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
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.GrpThemes = new System.Windows.Forms.GroupBox();
            this.BtnAbout = new System.Windows.Forms.Button();
            this.LblCatchPhrase = new System.Windows.Forms.Label();
            this.BtnApplyTheme = new System.Windows.Forms.Button();
            this.BtnQuit = new System.Windows.Forms.Button();
            this.Rdovicsar = new System.Windows.Forms.RadioButton();
            this.RdoNostalgie = new System.Windows.Forms.RadioButton();
            this.RdoMatrix = new System.Windows.Forms.RadioButton();
            this.RdoVimDarkBlue = new System.Windows.Forms.RadioButton();
            this.RdoDesert = new System.Windows.Forms.RadioButton();
            this.RdoVieEnRose = new System.Windows.Forms.RadioButton();
            this.RdoDark = new System.Windows.Forms.RadioButton();
            this.RdoDefault = new System.Windows.Forms.RadioButton();
            this.GrpPreviewTheme = new System.Windows.Forms.GroupBox();
            this.PicThemePreview = new System.Windows.Forms.PictureBox();
            this.TmrTimer = new System.Windows.Forms.Timer(this.components);
            this.GrpThemes.SuspendLayout();
            this.GrpPreviewTheme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicThemePreview)).BeginInit();
            this.SuspendLayout();
            // 
            // GrpThemes
            // 
            this.GrpThemes.Controls.Add(this.BtnAbout);
            this.GrpThemes.Controls.Add(this.LblCatchPhrase);
            this.GrpThemes.Controls.Add(this.BtnApplyTheme);
            this.GrpThemes.Controls.Add(this.BtnQuit);
            this.GrpThemes.Controls.Add(this.Rdovicsar);
            this.GrpThemes.Controls.Add(this.RdoNostalgie);
            this.GrpThemes.Controls.Add(this.RdoMatrix);
            this.GrpThemes.Controls.Add(this.RdoVimDarkBlue);
            this.GrpThemes.Controls.Add(this.RdoDesert);
            this.GrpThemes.Controls.Add(this.RdoVieEnRose);
            this.GrpThemes.Controls.Add(this.RdoDark);
            this.GrpThemes.Controls.Add(this.RdoDefault);
            this.GrpThemes.Location = new System.Drawing.Point(12, 12);
            this.GrpThemes.Name = "GrpThemes";
            this.GrpThemes.Size = new System.Drawing.Size(163, 340);
            this.GrpThemes.TabIndex = 0;
            this.GrpThemes.TabStop = false;
            // 
            // BtnAbout
            // 
            this.BtnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAbout.Location = new System.Drawing.Point(0, 294);
            this.BtnAbout.Name = "BtnAbout";
            this.BtnAbout.Size = new System.Drawing.Size(163, 23);
            this.BtnAbout.TabIndex = 10;
            this.BtnAbout.Text = "A&bout";
            this.BtnAbout.UseVisualStyleBackColor = true;
            this.BtnAbout.Click += new System.EventHandler(this.BtnAbout_Click);
            // 
            // LblCatchPhrase
            // 
            this.LblCatchPhrase.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblCatchPhrase.Location = new System.Drawing.Point(6, 225);
            this.LblCatchPhrase.Name = "LblCatchPhrase";
            this.LblCatchPhrase.Size = new System.Drawing.Size(150, 36);
            this.LblCatchPhrase.TabIndex = 8;
            this.LblCatchPhrase.Text = " ";
            this.LblCatchPhrase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblCatchPhrase.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LblCatchPhrase_MouseMove);
            this.LblCatchPhrase.Move += new System.EventHandler(this.LblCatchPhrase_Move);
            // 
            // BtnApplyTheme
            // 
            this.BtnApplyTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnApplyTheme.Location = new System.Drawing.Point(0, 272);
            this.BtnApplyTheme.Name = "BtnApplyTheme";
            this.BtnApplyTheme.Size = new System.Drawing.Size(163, 23);
            this.BtnApplyTheme.TabIndex = 9;
            this.BtnApplyTheme.Text = "&Apply Theme";
            this.BtnApplyTheme.UseVisualStyleBackColor = true;
            this.BtnApplyTheme.Click += new System.EventHandler(this.BtnApplyTheme_Click);
            // 
            // BtnQuit
            // 
            this.BtnQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnQuit.Location = new System.Drawing.Point(0, 316);
            this.BtnQuit.Name = "BtnQuit";
            this.BtnQuit.Size = new System.Drawing.Size(163, 23);
            this.BtnQuit.TabIndex = 11;
            this.BtnQuit.Text = "&Quit";
            this.BtnQuit.UseVisualStyleBackColor = true;
            this.BtnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // 
            // Rdovicsar
            // 
            this.Rdovicsar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Rdovicsar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rdovicsar.Location = new System.Drawing.Point(6, 69);
            this.Rdovicsar.Name = "Rdovicsar";
            this.Rdovicsar.Size = new System.Drawing.Size(157, 19);
            this.Rdovicsar.TabIndex = 2;
            this.Rdovicsar.TabStop = true;
            this.Rdovicsar.Text = "&vicsar";
            this.Rdovicsar.UseVisualStyleBackColor = true;
            this.Rdovicsar.CheckedChanged += new System.EventHandler(this.Rdovicsar_CheckedChanged);
            this.Rdovicsar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Rdovicsar_MouseMove);
            // 
            // RdoNostalgie
            // 
            this.RdoNostalgie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RdoNostalgie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdoNostalgie.Location = new System.Drawing.Point(7, 194);
            this.RdoNostalgie.Name = "RdoNostalgie";
            this.RdoNostalgie.Size = new System.Drawing.Size(156, 19);
            this.RdoNostalgie.TabIndex = 7;
            this.RdoNostalgie.TabStop = true;
            this.RdoNostalgie.Text = "L\'heure de la &nostalgie";
            this.RdoNostalgie.UseVisualStyleBackColor = true;
            this.RdoNostalgie.CheckedChanged += new System.EventHandler(this.RdoNostalgie_CheckedChanged);
            this.RdoNostalgie.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RdoNostalgie_MouseMove);
            // 
            // RdoMatrix
            // 
            this.RdoMatrix.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RdoMatrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdoMatrix.Location = new System.Drawing.Point(6, 169);
            this.RdoMatrix.Name = "RdoMatrix";
            this.RdoMatrix.Size = new System.Drawing.Size(157, 19);
            this.RdoMatrix.TabIndex = 6;
            this.RdoMatrix.TabStop = true;
            this.RdoMatrix.Text = "&What is the Matrix?";
            this.RdoMatrix.UseVisualStyleBackColor = true;
            this.RdoMatrix.CheckedChanged += new System.EventHandler(this.RdoMatrix_CheckedChanged);
            this.RdoMatrix.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RdoMatrix_MouseMove);
            // 
            // RdoVimDarkBlue
            // 
            this.RdoVimDarkBlue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RdoVimDarkBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdoVimDarkBlue.Location = new System.Drawing.Point(6, 119);
            this.RdoVimDarkBlue.Name = "RdoVimDarkBlue";
            this.RdoVimDarkBlue.Size = new System.Drawing.Size(157, 19);
            this.RdoVimDarkBlue.TabIndex = 4;
            this.RdoVimDarkBlue.TabStop = true;
            this.RdoVimDarkBlue.Text = "vim dark b&lue";
            this.RdoVimDarkBlue.UseVisualStyleBackColor = true;
            this.RdoVimDarkBlue.CheckedChanged += new System.EventHandler(this.RdoVimDarkBlue_CheckedChanged);
            this.RdoVimDarkBlue.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RdoVimDarkBlue_MouseMove);
            // 
            // RdoDesert
            // 
            this.RdoDesert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RdoDesert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdoDesert.Location = new System.Drawing.Point(6, 94);
            this.RdoDesert.Name = "RdoDesert";
            this.RdoDesert.Size = new System.Drawing.Size(157, 19);
            this.RdoDesert.TabIndex = 3;
            this.RdoDesert.TabStop = true;
            this.RdoDesert.Text = "D&esert";
            this.RdoDesert.UseVisualStyleBackColor = true;
            this.RdoDesert.CheckedChanged += new System.EventHandler(this.RdoDesert_CheckedChanged);
            this.RdoDesert.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RdoDesert_MouseMove);
            // 
            // RdoVieEnRose
            // 
            this.RdoVieEnRose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RdoVieEnRose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdoVieEnRose.Location = new System.Drawing.Point(6, 144);
            this.RdoVieEnRose.Name = "RdoVieEnRose";
            this.RdoVieEnRose.Size = new System.Drawing.Size(157, 19);
            this.RdoVieEnRose.TabIndex = 5;
            this.RdoVieEnRose.TabStop = true;
            this.RdoVieEnRose.Text = "La vie en &rose";
            this.RdoVieEnRose.UseVisualStyleBackColor = true;
            this.RdoVieEnRose.CheckedChanged += new System.EventHandler(this.RdoVieEnRose_CheckedChanged);
            this.RdoVieEnRose.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RdoVieEnRose_MouseMove);
            // 
            // RdoDark
            // 
            this.RdoDark.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RdoDark.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdoDark.Location = new System.Drawing.Point(6, 44);
            this.RdoDark.Name = "RdoDark";
            this.RdoDark.Size = new System.Drawing.Size(157, 19);
            this.RdoDark.TabIndex = 1;
            this.RdoDark.TabStop = true;
            this.RdoDark.Text = "Dar&k";
            this.RdoDark.UseVisualStyleBackColor = true;
            this.RdoDark.CheckedChanged += new System.EventHandler(this.RdoDark_CheckedChanged);
            this.RdoDark.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RdoDark_MouseMove);
            // 
            // RdoDefault
            // 
            this.RdoDefault.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RdoDefault.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdoDefault.Location = new System.Drawing.Point(6, 19);
            this.RdoDefault.Name = "RdoDefault";
            this.RdoDefault.Size = new System.Drawing.Size(157, 19);
            this.RdoDefault.TabIndex = 0;
            this.RdoDefault.TabStop = true;
            this.RdoDefault.Text = "&Default";
            this.RdoDefault.UseVisualStyleBackColor = true;
            this.RdoDefault.CheckedChanged += new System.EventHandler(this.RdoDefault_CheckedChanged);
            this.RdoDefault.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RdoDefault_MouseMove);
            // 
            // GrpPreviewTheme
            // 
            this.GrpPreviewTheme.Controls.Add(this.PicThemePreview);
            this.GrpPreviewTheme.Location = new System.Drawing.Point(174, 12);
            this.GrpPreviewTheme.Name = "GrpPreviewTheme";
            this.GrpPreviewTheme.Size = new System.Drawing.Size(836, 340);
            this.GrpPreviewTheme.TabIndex = 1;
            this.GrpPreviewTheme.TabStop = false;
            // 
            // PicThemePreview
            // 
            this.PicThemePreview.BackgroundImage = global::VBEThemes.Properties.Resources.default_vbe_theme_preview;
            this.PicThemePreview.Location = new System.Drawing.Point(7, 17);
            this.PicThemePreview.Name = "PicThemePreview";
            this.PicThemePreview.Size = new System.Drawing.Size(821, 312);
            this.PicThemePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicThemePreview.TabIndex = 0;
            this.PicThemePreview.TabStop = false;
            this.PicThemePreview.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PicThemePreview_MouseMove);
            // 
            // TmrTimer
            // 
            this.TmrTimer.Enabled = true;
            this.TmrTimer.Interval = 7000;
            this.TmrTimer.Tick += new System.EventHandler(this.TmrTimer_Tick);
            // 
            // FrmMain
            // 
            this.AcceptButton = this.BtnApplyTheme;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(76)))));
            this.CancelButton = this.BtnQuit;
            this.ClientSize = new System.Drawing.Size(1020, 369);
            this.ControlBox = false;
            this.Controls.Add(this.GrpPreviewTheme);
            this.Controls.Add(this.GrpThemes);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VBE Themes";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseMove);
            this.GrpThemes.ResumeLayout(false);
            this.GrpPreviewTheme.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicThemePreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpThemes;
        private System.Windows.Forms.RadioButton RdoDefault;
        private System.Windows.Forms.RadioButton Rdovicsar;
        private System.Windows.Forms.RadioButton RdoNostalgie;
        private System.Windows.Forms.RadioButton RdoMatrix;
        private System.Windows.Forms.RadioButton RdoVimDarkBlue;
        private System.Windows.Forms.RadioButton RdoDesert;
        private System.Windows.Forms.RadioButton RdoVieEnRose;
        private System.Windows.Forms.RadioButton RdoDark;
        private System.Windows.Forms.GroupBox GrpPreviewTheme;
        private System.Windows.Forms.PictureBox PicThemePreview;
        private System.Windows.Forms.Button BtnApplyTheme;
        private System.Windows.Forms.Button BtnQuit;
        private System.Windows.Forms.Label LblCatchPhrase;
        private System.Windows.Forms.Button BtnAbout;
        private System.Windows.Forms.Timer TmrTimer;
    }
}