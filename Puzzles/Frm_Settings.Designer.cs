namespace Puzzles
{
    partial class Frm_Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Sett_Cancel = new System.Windows.Forms.Button();
            this.btn_Sett_OK = new System.Windows.Forms.Button();
            this.cb_Diff = new System.Windows.Forms.ComboBox();
            this.lbl_Diff = new System.Windows.Forms.Label();
            this.lbl_Ratio = new System.Windows.Forms.Label();
            this.lbl_Tries = new System.Windows.Forms.Label();
            this.lbl_minWidth = new System.Windows.Forms.Label();
            this.nup_Ratio = new System.Windows.Forms.NumericUpDown();
            this.nup_Tries = new System.Windows.Forms.NumericUpDown();
            this.nup_minWidth = new System.Windows.Forms.NumericUpDown();
            this.nup_maxSize = new System.Windows.Forms.NumericUpDown();
            this.nup_minSize = new System.Windows.Forms.NumericUpDown();
            this.nup_minArea = new System.Windows.Forms.NumericUpDown();
            this.lbl_maxSize = new System.Windows.Forms.Label();
            this.lbl_minSize = new System.Windows.Forms.Label();
            this.lbl_minArea = new System.Windows.Forms.Label();
            this.gb_General = new System.Windows.Forms.GroupBox();
            this.gb_Gameplay = new System.Windows.Forms.GroupBox();
            this.lbl_percent2 = new System.Windows.Forms.Label();
            this.lbl_percent = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nup_Ratio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_Tries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_minWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_maxSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_minSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_minArea)).BeginInit();
            this.gb_General.SuspendLayout();
            this.gb_Gameplay.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Sett_Cancel
            // 
            this.btn_Sett_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Sett_Cancel.Location = new System.Drawing.Point(166, 136);
            this.btn_Sett_Cancel.Name = "btn_Sett_Cancel";
            this.btn_Sett_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Sett_Cancel.TabIndex = 4;
            this.btn_Sett_Cancel.Text = "Cancel";
            this.btn_Sett_Cancel.UseVisualStyleBackColor = true;
            this.btn_Sett_Cancel.Click += new System.EventHandler(this.btn_Sett_Cancel_Click);
            // 
            // btn_Sett_OK
            // 
            this.btn_Sett_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Sett_OK.Location = new System.Drawing.Point(71, 136);
            this.btn_Sett_OK.Name = "btn_Sett_OK";
            this.btn_Sett_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_Sett_OK.TabIndex = 3;
            this.btn_Sett_OK.Text = "OK";
            this.btn_Sett_OK.UseVisualStyleBackColor = true;
            this.btn_Sett_OK.Click += new System.EventHandler(this.btn_Sett_OK_Click);
            // 
            // cb_Diff
            // 
            this.cb_Diff.FormattingEnabled = true;
            this.cb_Diff.Location = new System.Drawing.Point(60, 20);
            this.cb_Diff.Name = "cb_Diff";
            this.cb_Diff.Size = new System.Drawing.Size(70, 21);
            this.cb_Diff.TabIndex = 5;
            // 
            // lbl_Diff
            // 
            this.lbl_Diff.AutoSize = true;
            this.lbl_Diff.Location = new System.Drawing.Point(7, 23);
            this.lbl_Diff.Name = "lbl_Diff";
            this.lbl_Diff.Size = new System.Drawing.Size(47, 13);
            this.lbl_Diff.TabIndex = 6;
            this.lbl_Diff.Text = "Difficulty";
            // 
            // lbl_Ratio
            // 
            this.lbl_Ratio.AutoSize = true;
            this.lbl_Ratio.Location = new System.Drawing.Point(19, 49);
            this.lbl_Ratio.Name = "lbl_Ratio";
            this.lbl_Ratio.Size = new System.Drawing.Size(32, 13);
            this.lbl_Ratio.TabIndex = 7;
            this.lbl_Ratio.Text = "Ratio";
            // 
            // lbl_Tries
            // 
            this.lbl_Tries.AutoSize = true;
            this.lbl_Tries.Location = new System.Drawing.Point(19, 75);
            this.lbl_Tries.Name = "lbl_Tries";
            this.lbl_Tries.Size = new System.Drawing.Size(30, 13);
            this.lbl_Tries.TabIndex = 8;
            this.lbl_Tries.Text = "Tries";
            // 
            // lbl_minWidth
            // 
            this.lbl_minWidth.AutoSize = true;
            this.lbl_minWidth.Location = new System.Drawing.Point(4, 92);
            this.lbl_minWidth.Name = "lbl_minWidth";
            this.lbl_minWidth.Size = new System.Drawing.Size(79, 13);
            this.lbl_minWidth.TabIndex = 9;
            this.lbl_minWidth.Text = "Minimum Width";
            // 
            // nup_Ratio
            // 
            this.nup_Ratio.Location = new System.Drawing.Point(60, 47);
            this.nup_Ratio.Name = "nup_Ratio";
            this.nup_Ratio.Size = new System.Drawing.Size(36, 20);
            this.nup_Ratio.TabIndex = 10;
            // 
            // nup_Tries
            // 
            this.nup_Tries.Location = new System.Drawing.Point(60, 73);
            this.nup_Tries.Name = "nup_Tries";
            this.nup_Tries.Size = new System.Drawing.Size(36, 20);
            this.nup_Tries.TabIndex = 11;
            // 
            // nup_minWidth
            // 
            this.nup_minWidth.Location = new System.Drawing.Point(83, 90);
            this.nup_minWidth.Name = "nup_minWidth";
            this.nup_minWidth.Size = new System.Drawing.Size(46, 20);
            this.nup_minWidth.TabIndex = 12;
            // 
            // nup_maxSize
            // 
            this.nup_maxSize.DecimalPlaces = 2;
            this.nup_maxSize.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nup_maxSize.Location = new System.Drawing.Point(83, 64);
            this.nup_maxSize.Name = "nup_maxSize";
            this.nup_maxSize.Size = new System.Drawing.Size(46, 20);
            this.nup_maxSize.TabIndex = 18;
            // 
            // nup_minSize
            // 
            this.nup_minSize.DecimalPlaces = 2;
            this.nup_minSize.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nup_minSize.Location = new System.Drawing.Point(83, 38);
            this.nup_minSize.Name = "nup_minSize";
            this.nup_minSize.Size = new System.Drawing.Size(46, 20);
            this.nup_minSize.TabIndex = 17;
            // 
            // nup_minArea
            // 
            this.nup_minArea.Location = new System.Drawing.Point(83, 12);
            this.nup_minArea.Name = "nup_minArea";
            this.nup_minArea.Size = new System.Drawing.Size(46, 20);
            this.nup_minArea.TabIndex = 16;
            // 
            // lbl_maxSize
            // 
            this.lbl_maxSize.AutoSize = true;
            this.lbl_maxSize.Location = new System.Drawing.Point(4, 66);
            this.lbl_maxSize.Name = "lbl_maxSize";
            this.lbl_maxSize.Size = new System.Drawing.Size(74, 13);
            this.lbl_maxSize.TabIndex = 15;
            this.lbl_maxSize.Text = "Maximum Size";
            // 
            // lbl_minSize
            // 
            this.lbl_minSize.AutoSize = true;
            this.lbl_minSize.Location = new System.Drawing.Point(4, 40);
            this.lbl_minSize.Name = "lbl_minSize";
            this.lbl_minSize.Size = new System.Drawing.Size(71, 13);
            this.lbl_minSize.TabIndex = 14;
            this.lbl_minSize.Text = "Minimum Size";
            // 
            // lbl_minArea
            // 
            this.lbl_minArea.AutoSize = true;
            this.lbl_minArea.Location = new System.Drawing.Point(4, 14);
            this.lbl_minArea.Name = "lbl_minArea";
            this.lbl_minArea.Size = new System.Drawing.Size(73, 13);
            this.lbl_minArea.TabIndex = 13;
            this.lbl_minArea.Text = "Minimum Area";
            // 
            // gb_General
            // 
            this.gb_General.Controls.Add(this.nup_Tries);
            this.gb_General.Controls.Add(this.nup_Ratio);
            this.gb_General.Controls.Add(this.lbl_Tries);
            this.gb_General.Controls.Add(this.lbl_Ratio);
            this.gb_General.Controls.Add(this.lbl_Diff);
            this.gb_General.Controls.Add(this.cb_Diff);
            this.gb_General.Location = new System.Drawing.Point(12, 12);
            this.gb_General.Name = "gb_General";
            this.gb_General.Size = new System.Drawing.Size(139, 102);
            this.gb_General.TabIndex = 19;
            this.gb_General.TabStop = false;
            this.gb_General.Text = "General";
            // 
            // gb_Gameplay
            // 
            this.gb_Gameplay.Controls.Add(this.lbl_percent2);
            this.gb_Gameplay.Controls.Add(this.lbl_percent);
            this.gb_Gameplay.Controls.Add(this.nup_maxSize);
            this.gb_Gameplay.Controls.Add(this.nup_minSize);
            this.gb_Gameplay.Controls.Add(this.nup_minArea);
            this.gb_Gameplay.Controls.Add(this.lbl_maxSize);
            this.gb_Gameplay.Controls.Add(this.lbl_minSize);
            this.gb_Gameplay.Controls.Add(this.lbl_minArea);
            this.gb_Gameplay.Controls.Add(this.nup_minWidth);
            this.gb_Gameplay.Controls.Add(this.lbl_minWidth);
            this.gb_Gameplay.Location = new System.Drawing.Point(157, 12);
            this.gb_Gameplay.Name = "gb_Gameplay";
            this.gb_Gameplay.Size = new System.Drawing.Size(148, 117);
            this.gb_Gameplay.TabIndex = 20;
            this.gb_Gameplay.TabStop = false;
            this.gb_Gameplay.Text = "Gameplay";
            // 
            // lbl_percent2
            // 
            this.lbl_percent2.AutoSize = true;
            this.lbl_percent2.Location = new System.Drawing.Point(130, 42);
            this.lbl_percent2.Name = "lbl_percent2";
            this.lbl_percent2.Size = new System.Drawing.Size(15, 13);
            this.lbl_percent2.TabIndex = 20;
            this.lbl_percent2.Text = "%";
            // 
            // lbl_percent
            // 
            this.lbl_percent.AutoSize = true;
            this.lbl_percent.Location = new System.Drawing.Point(130, 68);
            this.lbl_percent.Name = "lbl_percent";
            this.lbl_percent.Size = new System.Drawing.Size(15, 13);
            this.lbl_percent.TabIndex = 19;
            this.lbl_percent.Text = "%";
            // 
            // Frm_Settings
            // 
            this.AcceptButton = this.btn_Sett_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Sett_Cancel;
            this.ClientSize = new System.Drawing.Size(315, 171);
            this.Controls.Add(this.gb_Gameplay);
            this.Controls.Add(this.gb_General);
            this.Controls.Add(this.btn_Sett_Cancel);
            this.Controls.Add(this.btn_Sett_OK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Frm_Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.nup_Ratio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_Tries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_minWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_maxSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_minSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_minArea)).EndInit();
            this.gb_General.ResumeLayout(false);
            this.gb_General.PerformLayout();
            this.gb_Gameplay.ResumeLayout(false);
            this.gb_Gameplay.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Sett_Cancel;
        private System.Windows.Forms.Button btn_Sett_OK;
        private System.Windows.Forms.ComboBox cb_Diff;
        private System.Windows.Forms.Label lbl_Diff;
        private System.Windows.Forms.Label lbl_Ratio;
        private System.Windows.Forms.Label lbl_Tries;
        private System.Windows.Forms.Label lbl_minWidth;
        private System.Windows.Forms.NumericUpDown nup_Ratio;
        private System.Windows.Forms.NumericUpDown nup_Tries;
        private System.Windows.Forms.NumericUpDown nup_minWidth;
        private System.Windows.Forms.NumericUpDown nup_maxSize;
        private System.Windows.Forms.NumericUpDown nup_minSize;
        private System.Windows.Forms.NumericUpDown nup_minArea;
        private System.Windows.Forms.Label lbl_maxSize;
        private System.Windows.Forms.Label lbl_minSize;
        private System.Windows.Forms.Label lbl_minArea;
        private System.Windows.Forms.GroupBox gb_General;
        private System.Windows.Forms.GroupBox gb_Gameplay;
        private System.Windows.Forms.Label lbl_percent2;
        private System.Windows.Forms.Label lbl_percent;
    }
}