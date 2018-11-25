﻿using System.Windows.Media;

namespace HandyControl.Tools
{
    public class ColorHelper
    {
        private const int Win32RedShift = 0;
        private const int Win32GreenShift = 8;
        private const int Win32BlueShift = 16;

        public static int ToWin32(Color c) => c.R << Win32RedShift | c.G << Win32GreenShift | c.B << Win32BlueShift;
    }
}