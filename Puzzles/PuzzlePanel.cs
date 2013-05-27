using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puzzles
{
    class PuzzlePanel : Panel
    {
        public PuzzlePanel() : base()
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
                if (pp.Split(out pp1, out pp2))
                {
                    this.Controls.Remove(pp);
                    this.Controls.Add(pp1);
                    this.Controls.Add(pp2);

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
                this.movePuzzlePiece(mea.Location);
            }
        }

        private void movePuzzlePiece(Point pt)
        {
            if (activePuzzlePiece == null)
            {
                return;
            }

            activePuzzlePiece.Left += pt.X - MouseDownLocation.X;
            activePuzzlePiece.Top += pt.Y - MouseDownLocation.Y;

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
                    PuzzlePiece pp = (PuzzlePiece)sender;
                    if (pp.isInside(mea.Location))
                    {
                        MouseDownLocation = mea.Location;
                        clicked = true;
                        activePuzzlePiece = pp;
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
            PuzzlePiece pp = this.getNearPP();
            if (pp != null)
            {
                activePuzzlePiece.Location = pp.Location;

                // recombine puzzlepieces to get rid of borders [WIP]
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
            foreach (PuzzlePiece pp in this.Controls)
            {
                if (pp != activePuzzlePiece && pp.Distance(activePuzzlePiece) < 6f)
                {
                    return pp;
                }
            }
            return null;
        }

        public void Distribute ()
        {
            Random rnd = new Random(DateTime.Now.Millisecond);
            foreach (PuzzlePiece pp in this.Controls)
            {
                int width = this.Width / pp.Width;
                int height = this.Height / pp.Height;
                pp.Location = new Point(rnd.Next((width - 1) * this.Width / width), rnd.Next((height - 1) * this.Height / height));
            }
            this.Refresh();
        }

    }
}
