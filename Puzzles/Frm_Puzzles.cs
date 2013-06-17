using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Puzzles
{
    public partial class Frm_Puzzles : Form
    {
        public Frm_Puzzles()
        {
            InitializeComponent();
        }

        private void Frm_Puzzles_Load(object sender, EventArgs e)
        {
            // set initial image on start
            setImage(Reference.startImage);
        }

        public void setImage(Image img)
        {
            if (img == null)
            {
                return;
            }
            Reference.currentImage = img;

            pan_PuzzlePanel.Controls.Clear();

            // create first puzzlepiece
            PuzzlePiece pp = new PuzzlePiece();

            pp.Image = img;
            // reposition image in frame to the middle
            pp.Location = new Point((img.Width * Reference.Ratio - img.Width) / 2, (img.Height * Reference.Ratio - img.Height) / 2);

            // check size of img (SCALE?)
            // resize panel (3 * image size)
            pan_PuzzlePanel.Size = new Size(img.Width * Reference.Ratio, img.Height * Reference.Ratio);
            
            // adjust frame size
            adjustSize();
            
            // add first puzzlepiece
            pan_PuzzlePanel.Controls.Add(pp);

            pan_PuzzlePanel.Refresh();
        }

        private bool stepper = false;

        // adjust frame size
        private void adjustSize()
        {
            int width = pan_PuzzlePanel.Width +  (this.Width - this.ClientRectangle.Width);
            int height = pan_PuzzlePanel.Height + pan_PuzzlePanel.Top + (this.Height - this.ClientRectangle.Height);

            // add single step menu to the bottom of the frame and connect it to the puzzlepanel
            if (stepper)
            {
                height += gbo_StepByStep.Height;
                gbo_StepByStep.Width = pan_PuzzlePanel.Width;
                gbo_StepByStep.Top = pan_PuzzlePanel.Bottom;
                gbo_StepByStep.Left = pan_PuzzlePanel.Left;
            }
            gbo_StepByStep.Visible = stepper;

            // set calculated frame size
            this.Size = new Size(width, height);
        }

        // load a new picture
        private void mni_LoadPicture_Click(object sender, EventArgs e)
        {
            // open file dialog at exe path
            FileDialog fd = this.dia_OpenPicture;
            fd.InitialDirectory = Application.StartupPath;
            DialogResult res = fd.ShowDialog();

            if (res == DialogResult.OK)
            {
                // try to open file as bitmap, catch exceptions
                try
                {
                    Bitmap bmp = new Bitmap(fd.FileName);
                    this.setImage(bmp);
                }
                catch (ArgumentException)
                {
                    MessageBox.Show(String.Format("File {0} is not a Picture.", fd.FileName), "ERROR", MessageBoxButtons.OK);
                    mni_LoadPicture_Click(sender, e);
                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show(String.Format("File {0} not found.", fd.FileName), "ERROR", MessageBoxButtons.OK);
                    mni_LoadPicture_Click(sender, e);
                }
            }
        }

        // exit the game
        private void mni_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // start a new game, choose difficulty
        private void mni_NewGame_Click(object sender, EventArgs e)
        {
            Frm_Difficulty dia_Difficulty = new Frm_Difficulty();
            DialogResult res = dia_Difficulty.ShowDialog();
            if (res == DialogResult.OK)
            {
                Reference.Difficulty = dia_Difficulty.diff;
            }
            else
            {
                return;
            }

            setImage(Reference.currentImage);
            for (int i = 0; i < (int)Reference.Difficulty; i++)
            {
                pan_PuzzlePanel.Split();
            }
            pan_PuzzlePanel.Distribute();
        }

        // load last game from file [WIP]
        private void mni_LoadGame_Click(object sender, EventArgs e)
        {
            //FileStream fs = new FileStream(Reference.SavePath, FileMode.Open);
            //fs.Close();
        }

        // save current game to file [WIP]
        private void mni_SaveGame_Click(object sender, EventArgs e)
        {
            //FileStream fs = new FileStream(Reference.SavePath, FileMode.CreateNew);
            //fs.Close();
        }

        // show about dialog... [WIP]
        private void mni_About_Click(object sender, EventArgs e)
        {
            Frm_About about = new Frm_About();
            about.ShowDialog();
        }

        // display step-by-step window
        private void mni_StepByStep_CheckedChanged(object sender, EventArgs e)
        {
            stepper = !stepper;
            // adjust frame size
            adjustSize();
        }

        // split a puzzlepiece once
        private void btn_Split_Click(object sender, EventArgs e)
        {
            pan_PuzzlePanel.Split();
        }

        // distribute puzzlepieces
        private void btn_Distribute_Click(object sender, EventArgs e)
        {
            pan_PuzzlePanel.Distribute();
        }

        // solve a puzzlepiece at a time
        private void btn_Solve_Click(object sender, EventArgs e)
        {
            pan_PuzzlePanel.Solve();
        }

        // solve the whole puzzle
        private void mni_Solve_Click(object sender, EventArgs e)
        {
            bool ret = false;
            do
            {
                ret = pan_PuzzlePanel.Solve();
            } while (ret);
        }

        // show settings dialog
        private void mni_Settings_Click(object sender, EventArgs e)
        {
            Frm_Settings dia_settings = new Frm_Settings();
            DialogResult res = dia_settings.ShowDialog();
            if (res == DialogResult.OK)
            {
                // set new settings values
                Reference.maxSize = dia_settings.maxSize;
                Reference.minSize = dia_settings.minSize;
                Reference.minArea = dia_settings.minArea;
                Reference.minWidth = dia_settings.minWidth;
                Reference.Ratio = dia_settings.ratio;
                Reference.SplitTries = dia_settings.tries;

                // refresh panel size
                pan_PuzzlePanel.Size = new Size(Reference.currentImage.Width * Reference.Ratio, Reference.currentImage.Height * Reference.Ratio);
                adjustSize();
                this.Refresh();
            }
        }
    }
}
