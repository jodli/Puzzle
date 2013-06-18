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
        Easy = 3,
        Medium = 5,
        Hard = 8,
        VeryHard = 15
    }

    static class Reference
    {
        // default path for save game
        public static string SavePath = Application.StartupPath + "save.dat";

        // default starting image
        public static System.Drawing.Image startImage = Properties.Resources.MERLIN;

        // puzzlepanel ratio (default: 3 x image)
        private static int _ratio = 3;
        public static int Ratio
        {
            get { return _ratio; }
            set
            {
                if (value < 3)
                {
                    _ratio = 3;
                }
                else
                {
                    _ratio = value;
                }
            }
        }

        // game difficulty
        public static Difficulty Difficulty = Difficulty.Medium;

        // try to split puzzlepieces (default: 10) times 
        private static int _tries = 10;
        public static int SplitTries
        {
            get { return _tries; }
            set
            {
                if (value < 2)
                {
                    _tries = 2;
                }
                else
                {
                    _tries = value;
                }
            }
        }

        // minimum area of new puzzlepiece (default: 20)
        private static float _minArea = 20f;
        public static float minArea
        {
            get { return _minArea; }
            set
            {
                if (value < 5f)
                {
                    _minArea = 5f;
                }
                else
                {
                    _minArea = value;
                }
            }
        }

        // minimum size of new puzzlepiece in relation to original puzzlepiece (default: 30%)
        private static float _minSize = .3f;
        public static float minSize
        {
            get { return _minSize; }
            set
            {
                if (value < .05f)
                {
                    _minSize = .05f;
                }
                else
                {
                    _minSize = value;
                }
            }
        }

        // maximum size of new puzzlepiece in relation to original puzzlepiece (default: 70%)
        private static float _maxSize = .7f;
        public static float maxSize
        {
            get { return _maxSize; }
            set
            {
                if (value < .05f)
                {
                    _maxSize = .7f;
                }
                else
                {
                    _maxSize = value;
                }
            }
        }

        // minimum width of new puzzlepiece (default: 8)
        private static float _minWidth = 8f;
        public static float minWidth
        {
            get { return _minWidth; }
            set
            {
                if (value < 3f)
                {
                    _minWidth = 3f;
                }
                else
                {
                    _minWidth = value;
                }
            }
        }

        // store image for puzzlepiece paint
        public static System.Drawing.Image currentImage = startImage;
    }
}
