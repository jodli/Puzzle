using System;
using System.Windows.Forms;

namespace Puzzles
{
    public partial class Frm_Difficulty : Form
    {
        public Frm_Difficulty()
        {
            InitializeComponent();
        }

        public Difficulty diff = Difficulty.Medium;

        private void rdb_CheckedChanged(object sender, EventArgs e)
        {
            switch (((RadioButton)sender).Name)
            {
                case "rdb_VeryEasy":
                    diff = Difficulty.VeryEasy;
                    break;
                case "rdb_Easy":
                    diff = Difficulty.Easy;
                    break;
                case "rdb_Medium":
                    diff = Difficulty.Medium;
                    break;
                case "rdb_Hard":
                    diff = Difficulty.Hard;
                    break;
                case "rdb_VeryHard":
                    diff = Difficulty.VeryHard;
                    break;
            }
        }
    }
}
