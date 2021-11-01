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
using System.Runtime.InteropServices;

namespace Animation
{
    internal class WinAPI
    {
        public const int HOR_Positive = 0X1;
        public const int HOR_NEGATIVE = 0X2;
        public const int VER_POSITIVE = 0X4;
        public const int VER_NEGATIVE = 0X8;
        public const int CENTER = 0X10;
        public const int BLEND = 0X80000;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int AnimateWindow(IntPtr hwand, int dwTime, int dwFlag);
    }
}