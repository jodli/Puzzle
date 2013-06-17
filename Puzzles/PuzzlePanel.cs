using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace Puzzles
{
    class PuzzlePanel : Panel
    {
        public PuzzlePanel()
            : base()
        {
            base.Paint += PuzzlePanel_Paint;
            this.MouseMove += PuzzlePanel_MouseMove;
        }

        private bool clicked = false;
        private Point MouseDownLocation = Point.Empty;
        private PuzzlePiece activePuzzlePiece = null;

        public bool Split()
        {
            bool flag = false;
            ArrayList puzzlepieces = new ArrayList();

            // save only puzzlepieces in arraylist
            foreach (Control control in this.Controls)
            {
                if (control is PuzzlePiece)
                {
                    puzzlepieces.Add(control);
                }
            }

            foreach (PuzzlePiece pp in puzzlepieces)
            {
                PuzzlePiece pp1, pp2;
                // split puzzlepiece into two
                if (pp.Split(out pp1, out pp2))
                {
                    // remove single puzzlepiece and add two splitted
                    this.Controls.Remove(pp);
                    this.Controls.Add(pp1);
                    this.Controls.Add(pp2);

                    // add eventhandlers
                    pp1.MouseDown += new MouseEventHandler(this.PuzzlePiece_MouseDown);
                    pp1.MouseMove += new MouseEventHandler(this.PuzzlePiece_MouseMove);
                    pp1.MouseUp += new MouseEventHandler(this.PuzzlePiece_MouseUp);

                    pp2.MouseDown += new MouseEventHandler(this.PuzzlePiece_MouseDown);
                    pp2.MouseMove += new MouseEventHandler(this.PuzzlePiece_MouseMove);
                    pp2.MouseUp += new MouseEventHandler(this.PuzzlePiece_MouseUp);

                    flag = true;
                }
            }
            return flag;
        }

        void PuzzlePanel_Paint(object sender, PaintEventArgs pea)
        {
            // draw border around puzzlepanel
            pea.Graphics.DrawRectangle(Pens.Black, 0, 0, base.Width - 1, base.Height - 1);
        }

        private void PuzzlePanel_MouseMove(object sender, MouseEventArgs mea)
        {
            if (mea == null)
            {
                return;
            }
            this.movePuzzlePiece(mea.Location);
        }

        private void PuzzlePiece_MouseMove(object sender, MouseEventArgs mea)
        {
            if (mea == null || activePuzzlePiece == null)
            {
                return;
            }

            if (clicked && sender == activePuzzlePiece)
            {
                // move puzzlepiece -> not in position anymore
                this.movePuzzlePiece(mea.Location);
                activePuzzlePiece.inPosition = false;
            }
        }

        private void movePuzzlePiece(Point pt)
        {
            if (activePuzzlePiece == null)
            {
                return;
            }

            // move puzzlepiece accordingly
            activePuzzlePiece.Left += pt.X - MouseDownLocation.X;
            activePuzzlePiece.Top += pt.Y - MouseDownLocation.Y;

            // change bodercolor when approaching matching puzzlepiece
            if (this.getNearPP() != null)
            {
                activePuzzlePiece.BorderColor = Color.Green;
            }
            else
            {
                activePuzzlePiece.BorderColor = Color.Red;
            }
        }

        private void PuzzlePiece_MouseDown(object sender, MouseEventArgs mea)
        {
            if (mea == null)
            {
                return;
            }

            if (mea.Button == MouseButtons.Left)
            {
                if (sender is PuzzlePiece)
                {
                    // is click location inside puzzlepiece?
                    if (((PuzzlePiece)sender).isInside(mea.Location))
                    {
                        // save this position for moving
                        MouseDownLocation = mea.Location;
                        // save mouse down
                        clicked = true;
                        // set active puzzlepiece
                        activePuzzlePiece = (PuzzlePiece)sender;
                        movePuzzlePiece(mea.Location);
                    }
                }
            }
        }

        private void PuzzlePiece_MouseUp(object sender, MouseEventArgs mea)
        {
            if (mea == null || sender != activePuzzlePiece)
            {
                return;
            }

            // move active (currently moved) puzzlepiece to final position next to second puzzlepiece
            PuzzlePiece pp = this.getNearPP();
            if (pp != null)
            {
                activePuzzlePiece.Location = pp.Location;
                activePuzzlePiece.inPosition = true;
                findLocation();

                // recombine puzzlepieces
                //this.Controls.Remove(activePuzzlePiece);
                //this.Controls.Remove(pp);
                //PuzzlePiece newPp = activePuzzlePiece.Combine(pp);
                //newPp.MouseDown += new MouseEventHandler(this.PuzzlePiece_MouseDown);
                //newPp.MouseMove += new MouseEventHandler(this.PuzzlePiece_MouseMove);
                //newPp.MouseUp += new MouseEventHandler(this.PuzzlePiece_MouseUp);
                //this.Controls.Add(newPp); 
            }
            clicked = false;

            activePuzzlePiece.BorderColor = Color.Black;
            activePuzzlePiece = null;
        }

        public PuzzlePiece getNearPP()
        {
            // iterate through puzzlepieces
            foreach (PuzzlePiece pp in this.Controls)
            {
                // distance between active (currently moved) puzzlepiece and control < 6 pixels
                if (pp != activePuzzlePiece && pp.Distance(activePuzzlePiece) < 6f)
                {
                    return pp;
                }
            }
            return null;
        }

        public void Distribute()
        {
            Random rnd = new Random(DateTime.Now.Millisecond);
            foreach (PuzzlePiece pp in this.Controls)
            {
                pp.inPosition = false;
                // calculate new random position inside puzzlepanel for puzzlepiece location (top left corner of image)
                pp.Location = new Point(rnd.Next((Reference.Ratio - 1) * this.Width / Reference.Ratio), rnd.Next((Reference.Ratio - 1) * this.Height / Reference.Ratio));
            }
            this.Refresh();
        }

        // initial location for puzzlepieces if none is already in position
        private Point loc = new Point(Reference.currentImage.Width, Reference.currentImage.Height);

        public bool Solve()
        {
            // iterate over puzzlepiece controls
            foreach (PuzzlePiece pp in this.Controls)
            {
                foreach (PuzzlePiece pp2 in this.Controls)
                {
                    if (pp == pp2 || pp.inPosition)
                    {
                        continue;
                    }
                    // pp has line in common with pp2
                    if (pp.Distance(pp2) != double.MaxValue)
                    {
                        // set location of puzzlepiece
                        pp.Location = loc;
                        // pp is now in end position
                        pp.inPosition = true;

                        // puzzlepiece moved
                        return true;
                    }
                }
            }
            // no puzzlepiece moved
            return false;
        }

        public void findLocation()
        {
            bool flag = false;

            // save location of puzzlepiece if one is already in position
            foreach (PuzzlePiece pp in this.Controls)
            {
                if (flag)
                {
                    // reset position of puzzlepieces not in saved location
                    pp.inPosition = false;
                }
                if (pp.inPosition)
                {
                    // save location of first puzzlepiece in position
                    loc = pp.Location;
                    flag = true;
                }
            }
        }
    }
}
