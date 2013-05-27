﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puzzles
{
    static class Reference
    {
        public static string SavePath = Application.StartupPath + "save.dat";
        public static int initialSplits = 4;
        public static System.Drawing.Image startImage = Properties.Resources.MERLIN;
        private static System.Drawing.Image currentImage = null;
        public static System.Drawing.Image Image { get { return Reference.currentImage; } set { Reference.currentImage = value; } }
    }
}
