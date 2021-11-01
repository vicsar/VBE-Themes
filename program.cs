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

using System;
using System.Windows.Forms;

namespace VBEThemes
{
    internal static class Program
    {
        /*
        <summary>
        An easy to use program to set the Visual Basic for Applications Editor theme (used by Microsoft Office®).
        </summary>
        */

        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());
        }
    }
}