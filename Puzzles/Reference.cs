using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puzzles
{
    public enum Difficulty
    {
        VeryEasy = 1,
        Easy = 2,
        Medium = 3,
        Hard = 4,
        VeryHard = 5
    }

    static class Reference
    {
        //public static string SavePath = Application.StartupPath + "save.dat";
        public static System.Drawing.Image startImage = Properties.Resources.MERLIN;
        public static int Ratio = 3;
        public static Difficulty Difficulty = Difficulty.Medium;

        // store image for puzzlepiece paint
        private static System.Drawing.Image currentImage = startImage;
        public static System.Drawing.Image Image { get { return Reference.currentImage; } set { Reference.currentImage = value; } }
    }
}
