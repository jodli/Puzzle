namespace Puzzles
{
    partial class Frm_Difficulty
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
            this.rdb_VeryEasy = new System.Windows.Forms.RadioButton();
            this.btn_Diff_OK = new System.Windows.Forms.Button();
            this.btn_Diff_Cancel = new System.Windows.Forms.Button();
            this.rdb_Medium = new System.Windows.Forms.RadioButton();
            this.rdb_Easy = new System.Windows.Forms.RadioButton();
            this.rdb_Hard = new System.Windows.Forms.RadioButton();
            this.rdb_VeryHard = new System.Windows.Forms.RadioButton();
            this.pan_Difficulties = new System.Windows.Forms.Panel();
            this.pan_Difficulties.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdb_VeryEasy
            // 
            this.rdb_VeryEasy.AutoSize = true;
            this.rdb_VeryEasy.Location = new System.Drawing.Point(57, -1);
            this.rdb_VeryEasy.Name = "rdb_VeryEasy";
            this.rdb_VeryEasy.Size = new System.Drawing.Size(72, 17);
            this.rdb_VeryEasy.TabIndex = 0;
            this.rdb_VeryEasy.Text = "Very Easy";
            this.rdb_VeryEasy.UseVisualStyleBackColor = true;
            this.rdb_VeryEasy.CheckedChanged += new System.EventHandler(this.rdb_CheckedChanged);
            // 
            // btn_Diff_OK
            // 
            this.btn_Diff_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Diff_OK.Location = new System.Drawing.Point(11, 81);
            this.btn_Diff_OK.Name = "btn_Diff_OK";
            this.btn_Diff_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_Diff_OK.TabIndex = 1;
            this.btn_Diff_OK.Text = "OK";
            this.btn_Diff_OK.UseVisualStyleBackColor = true;
            // 
            // btn_Diff_Cancel
            // 
            this.btn_Diff_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Diff_Cancel.Location = new System.Drawing.Point(106, 81);
            this.btn_Diff_Cancel.Name = "btn_Diff_Cancel";
            this.btn_Diff_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Diff_Cancel.TabIndex = 2;
            this.btn_Diff_Cancel.Text = "Cancel";
            this.btn_Diff_Cancel.UseVisualStyleBackColor = true;
            // 
            // rdb_Medium
            // 
            this.rdb_Medium.AutoSize = true;
            this.rdb_Medium.Checked = true;
            this.rdb_Medium.Location = new System.Drawing.Point(57, 22);
            this.rdb_Medium.Name = "rdb_Medium";
            this.rdb_Medium.Size = new System.Drawing.Size(62, 17);
            this.rdb_Medium.TabIndex = 3;
            this.rdb_Medium.TabStop = true;
            this.rdb_Medium.Text = "Medium";
            this.rdb_Medium.UseVisualStyleBackColor = true;
            this.rdb_Medium.CheckedChanged += new System.EventHandler(this.rdb_CheckedChanged);
            // 
            // rdb_Easy
            // 
            this.rdb_Easy.AutoSize = true;
            this.rdb_Easy.Location = new System.Drawing.Point(3, 22);
            this.rdb_Easy.Name = "rdb_Easy";
            this.rdb_Easy.Size = new System.Drawing.Size(48, 17);
            this.rdb_Easy.TabIndex = 4;
            this.rdb_Easy.Text = "Easy";
            this.rdb_Easy.UseVisualStyleBackColor = true;
            this.rdb_Easy.CheckedChanged += new System.EventHandler(this.rdb_CheckedChanged);
            // 
            // rdb_Hard
            // 
            this.rdb_Hard.AutoSize = true;
            this.rdb_Hard.Location = new System.Drawing.Point(125, 22);
            this.rdb_Hard.Name = "rdb_Hard";
            this.rdb_Hard.Size = new System.Drawing.Size(48, 17);
            this.rdb_Hard.TabIndex = 5;
            this.rdb_Hard.Text = "Hard";
            this.rdb_Hard.UseVisualStyleBackColor = true;
            this.rdb_Hard.CheckedChanged += new System.EventHandler(this.rdb_CheckedChanged);
            // 
            // rdb_VeryHard
            // 
            this.rdb_VeryHard.AutoSize = true;
            this.rdb_VeryHard.Location = new System.Drawing.Point(57, 45);
            this.rdb_VeryHard.Name = "rdb_VeryHard";
            this.rdb_VeryHard.Size = new System.Drawing.Size(72, 17);
            this.rdb_VeryHard.TabIndex = 6;
            this.rdb_VeryHard.Text = "Very Hard";
            this.rdb_VeryHard.UseVisualStyleBackColor = true;
            this.rdb_VeryHard.CheckedChanged += new System.EventHandler(this.rdb_CheckedChanged);
            // 
            // pan_Difficulties
            // 
            this.pan_Difficulties.AutoSize = true;
            this.pan_Difficulties.Controls.Add(this.rdb_VeryHard);
            this.pan_Difficulties.Controls.Add(this.rdb_Medium);
            this.pan_Difficulties.Controls.Add(this.rdb_Hard);
            this.pan_Difficulties.Controls.Add(this.rdb_VeryEasy);
            this.pan_Difficulties.Controls.Add(this.rdb_Easy);
            this.pan_Difficulties.Location = new System.Drawing.Point(10, 12);
            this.pan_Difficulties.Name = "pan_Difficulties";
            this.pan_Difficulties.Size = new System.Drawing.Size(176, 65);
            this.pan_Difficulties.TabIndex = 7;
            // 
            // Frm_Difficulty
            // 
            this.AcceptButton = this.btn_Diff_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Diff_Cancel;
            this.ClientSize = new System.Drawing.Size(191, 119);
            this.Controls.Add(this.btn_Diff_Cancel);
            this.Controls.Add(this.btn_Diff_OK);
            this.Controls.Add(this.pan_Difficulties);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Difficulty";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Choose your difficulty";
            this.pan_Difficulties.ResumeLayout(false);
            this.pan_Difficulties.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdb_VeryEasy;
        private System.Windows.Forms.Button btn_Diff_OK;
        private System.Windows.Forms.Button btn_Diff_Cancel;
        private System.Windows.Forms.RadioButton rdb_Medium;
        private System.Windows.Forms.RadioButton rdb_Easy;
        private System.Windows.Forms.RadioButton rdb_Hard;
        private System.Windows.Forms.RadioButton rdb_VeryHard;
        private System.Windows.Forms.Panel pan_Difficulties;
    }
}