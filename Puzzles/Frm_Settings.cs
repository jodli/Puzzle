using System;
using System.Windows.Forms;

namespace Puzzles
{
    public partial class Frm_Settings : Form
    {
        public Frm_Settings()
        {
            InitializeComponent();

            // set current values on controls
            cb_Diff.DataSource = Enum.GetValues(typeof(Difficulty));

            nup_maxSize.Value = (decimal)Reference.maxSize;
            nup_minSize.Value = (decimal)Reference.minSize;
            nup_minArea.Value = (decimal)Reference.minArea;
            nup_minWidth.Value = (decimal)Reference.minWidth;
            nup_Ratio.Value = (decimal)Reference.Ratio;
            nup_Tries.Value = (decimal)Reference.SplitTries;
        }

        // access from outside after closing the dialog
        public float maxSize = Reference.maxSize;
        public float minSize = Reference.minSize;
        public float minArea = Reference.minArea;
        public float minWidth = Reference.minWidth;
        public int ratio = Reference.Ratio;
        public int tries = Reference.SplitTries;

        private void btn_Sett_OK_Click(object sender, EventArgs e)
        {
            this.ratio = (int)nup_Ratio.Value;
            this.tries = (int)nup_Tries.Value;
            this.minArea = (float)nup_minArea.Value;
            this.minSize = (float)nup_minSize.Value;
            this.maxSize = (float)nup_maxSize.Value;
            this.minWidth = (float)nup_minWidth.Value;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btn_Sett_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
