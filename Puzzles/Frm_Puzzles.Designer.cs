namespace Puzzles
{
    partial class Frm_Puzzles
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
            this.ms_Menu = new System.Windows.Forms.MenuStrip();
            this.puzzleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadPictureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stepbyStepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dia_openPicture = new System.Windows.Forms.OpenFileDialog();
            this.gbo_StepByStep = new System.Windows.Forms.GroupBox();
            this.btn_Distribute = new System.Windows.Forms.Button();
            this.btn_Split = new System.Windows.Forms.Button();
            this.pan_PuzzlePanel = new Puzzles.PuzzlePanel();
            this.ms_Menu.SuspendLayout();
            this.gbo_StepByStep.SuspendLayout();
            this.SuspendLayout();
            // 
            // ms_Menu
            // 
            this.ms_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.puzzleToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.ms_Menu.Location = new System.Drawing.Point(0, 0);
            this.ms_Menu.Name = "ms_Menu";
            this.ms_Menu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.ms_Menu.Size = new System.Drawing.Size(284, 24);
            this.ms_Menu.TabIndex = 0;
            this.ms_Menu.Text = "menuStrip1";
            // 
            // puzzleToolStripMenuItem
            // 
            this.puzzleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.loadPictureToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.puzzleToolStripMenuItem.Name = "puzzleToolStripMenuItem";
            this.puzzleToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.puzzleToolStripMenuItem.Text = "Puzzle";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // loadPictureToolStripMenuItem
            // 
            this.loadPictureToolStripMenuItem.Name = "loadPictureToolStripMenuItem";
            this.loadPictureToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.O)));
            this.loadPictureToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.loadPictureToolStripMenuItem.Text = "Load Picture...";
            this.loadPictureToolStripMenuItem.Click += new System.EventHandler(this.loadPictureToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stepbyStepToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // stepbyStepToolStripMenuItem
            // 
            this.stepbyStepToolStripMenuItem.CheckOnClick = true;
            this.stepbyStepToolStripMenuItem.Name = "stepbyStepToolStripMenuItem";
            this.stepbyStepToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.stepbyStepToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.stepbyStepToolStripMenuItem.Text = "Step-by-Step";
            this.stepbyStepToolStripMenuItem.CheckedChanged += new System.EventHandler(this.stepbyStepToolStripMenuItem_CheckedChanged);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // loadGameToolStripMenuItem
            // 
            this.loadGameToolStripMenuItem.Name = "loadGameToolStripMenuItem";
            this.loadGameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.loadGameToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.loadGameToolStripMenuItem.Text = "Load Game";
            this.loadGameToolStripMenuItem.Click += new System.EventHandler(this.loadGameToolStripMenuItem_Click);
            // 
            // saveGameToolStripMenuItem
            // 
            this.saveGameToolStripMenuItem.Name = "saveGameToolStripMenuItem";
            this.saveGameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveGameToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.saveGameToolStripMenuItem.Text = "Save Game";
            this.saveGameToolStripMenuItem.Click += new System.EventHandler(this.saveGameToolStripMenuItem_Click);
            // 
            // dia_openPicture
            // 
            this.dia_openPicture.FileName = "openFileDialog1";
            // 
            // gbo_StepByStep
            // 
            this.gbo_StepByStep.Controls.Add(this.btn_Distribute);
            this.gbo_StepByStep.Controls.Add(this.btn_Split);
            this.gbo_StepByStep.Location = new System.Drawing.Point(12, 266);
            this.gbo_StepByStep.Name = "gbo_StepByStep";
            this.gbo_StepByStep.Size = new System.Drawing.Size(260, 42);
            this.gbo_StepByStep.TabIndex = 2;
            this.gbo_StepByStep.TabStop = false;
            this.gbo_StepByStep.Text = "Step by Step";
            // 
            // btn_Distribute
            // 
            this.btn_Distribute.Location = new System.Drawing.Point(87, 13);
            this.btn_Distribute.Name = "btn_Distribute";
            this.btn_Distribute.Size = new System.Drawing.Size(75, 23);
            this.btn_Distribute.TabIndex = 1;
            this.btn_Distribute.Text = "Distribute";
            this.btn_Distribute.UseVisualStyleBackColor = true;
            this.btn_Distribute.Click += new System.EventHandler(this.btn_Distribute_Click);
            // 
            // btn_Split
            // 
            this.btn_Split.Location = new System.Drawing.Point(6, 13);
            this.btn_Split.Name = "btn_Split";
            this.btn_Split.Size = new System.Drawing.Size(75, 23);
            this.btn_Split.TabIndex = 0;
            this.btn_Split.Text = "Split";
            this.btn_Split.UseVisualStyleBackColor = true;
            this.btn_Split.Click += new System.EventHandler(this.btn_Split_Click);
            // 
            // pan_PuzzlePanel
            // 
            this.pan_PuzzlePanel.BackColor = System.Drawing.Color.Transparent;
            this.pan_PuzzlePanel.Location = new System.Drawing.Point(0, 24);
            this.pan_PuzzlePanel.Margin = new System.Windows.Forms.Padding(2);
            this.pan_PuzzlePanel.Name = "pan_PuzzlePanel";
            this.pan_PuzzlePanel.Size = new System.Drawing.Size(284, 237);
            this.pan_PuzzlePanel.TabIndex = 1;
            // 
            // Frm_Puzzles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 316);
            this.Controls.Add(this.gbo_StepByStep);
            this.Controls.Add(this.pan_PuzzlePanel);
            this.Controls.Add(this.ms_Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.ms_Menu;
            this.Name = "Frm_Puzzles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Puzzle";
            this.Load += new System.EventHandler(this.Frm_Puzzles_Load);
            this.ms_Menu.ResumeLayout(false);
            this.ms_Menu.PerformLayout();
            this.gbo_StepByStep.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ms_Menu;
        private PuzzlePanel pan_PuzzlePanel;
        private System.Windows.Forms.ToolStripMenuItem puzzleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadPictureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stepbyStepToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveGameToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog dia_openPicture;
        private System.Windows.Forms.GroupBox gbo_StepByStep;
        private System.Windows.Forms.Button btn_Distribute;
        private System.Windows.Forms.Button btn_Split;
    }
}

