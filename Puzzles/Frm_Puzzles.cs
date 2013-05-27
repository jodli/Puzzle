using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puzzles
{
    public partial class Frm_Puzzles : Form
    {
        public Frm_Puzzles()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.UserPaint, true);
        }

        private void Frm_Puzzles_Load(object sender, EventArgs e)
        {
            setImage(Reference.startImage);
        }

        public void setImage(Image img)
        {
            if (img == null)
            {
                return;
            }
            Reference.Image = img;
            pan_PuzzlePanel.Controls.Clear();
            PuzzlePiece pp = new PuzzlePiece();
            // TODO 
            // check size of img (SCALE?)
            // reposition frame on monitor
            pp.Location = new Point(img.Width, img.Height);
            pan_PuzzlePanel.Size = new Size(img.Width * 3, img.Height * 3);
            adjustSize();
            pan_PuzzlePanel.Controls.Add(pp);
            pan_PuzzlePanel.Refresh();
        }

        private bool stepper = false;

        private void adjustSize()
        {
            int width = pan_PuzzlePanel.Width +  (this.Width - this.ClientRectangle.Width);
            int height = pan_PuzzlePanel.Height + pan_PuzzlePanel.Top + (this.Height - this.ClientRectangle.Height);
            if (stepper)
            {
                height += gbo_StepByStep.Height;
                gbo_StepByStep.Width = pan_PuzzlePanel.Width;
                gbo_StepByStep.Top = pan_PuzzlePanel.Bottom;
                gbo_StepByStep.Left = pan_PuzzlePanel.Left;
            }
            gbo_StepByStep.Visible = stepper;
            this.Size = new Size(width, height);
        }

        private void loadPictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileDialog fd = this.dia_openPicture;
            fd.InitialDirectory = Application.StartupPath;
            DialogResult res = fd.ShowDialog();

            if (res == DialogResult.OK)
            {
                try
                {
                    Bitmap bmp = new Bitmap(fd.FileName);
                    this.setImage(bmp);
                }
                catch (ArgumentException ae)
                {
                    MessageBox.Show(String.Format("File {0} is not a Picture.", fd.FileName), "ERROR", MessageBoxButtons.OK);
                    loadPictureToolStripMenuItem_Click(sender, e);
                }
                catch (FileNotFoundException fnfe)
                {
                    MessageBox.Show(String.Format("File {0} not found.", fd.FileName), "ERROR", MessageBoxButtons.OK);
                    loadPictureToolStripMenuItem_Click(sender, e);
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setImage(Reference.Image);
            for (int i = 0; i < Reference.initialSplits; i++)
            {
                pan_PuzzlePanel.Split();
            }
            pan_PuzzlePanel.Distribute();
        }

        private void loadGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // load saved game from file... [WIP]
            //FileStream fs = new FileStream(Reference.SavePath, FileMode.Open);
            //fs.Close();
        }

        private void saveGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // save game to file... serializable? save image only once! [WIP]
            //FileStream fs = new FileStream(Reference.SavePath, FileMode.CreateNew);
            //fs.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // some about dialog... [WIP]
            AboutPuzzles box = new AboutPuzzles();
            box.ShowDialog();
        }

        private void stepbyStepToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            stepper = !stepper;
            adjustSize();
        }

        private void btn_Split_Click(object sender, EventArgs e)
        {
            pan_PuzzlePanel.Split();
        }

        private void btn_Distribute_Click(object sender, EventArgs e)
        {
            pan_PuzzlePanel.Distribute();
        }
    }
}
