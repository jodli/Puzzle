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
            this.mni_Puzzle = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_NewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_LoadPicture = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_Options = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_StepByStep = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_Solve = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_About = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_LoadGame = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_SaveGame = new System.Windows.Forms.ToolStripMenuItem();
            this.dia_OpenPicture = new System.Windows.Forms.OpenFileDialog();
            this.gbo_StepByStep = new System.Windows.Forms.GroupBox();
            this.btn_Solve = new System.Windows.Forms.Button();
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
            this.mni_Puzzle,
            this.mni_Options,
            this.mni_Help});
            this.ms_Menu.Location = new System.Drawing.Point(0, 0);
            this.ms_Menu.Name = "ms_Menu";
            this.ms_Menu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.ms_Menu.Size = new System.Drawing.Size(284, 24);
            this.ms_Menu.TabIndex = 0;
            this.ms_Menu.Text = "menuStrip1";
            // 
            // mni_Puzzle
            // 
            this.mni_Puzzle.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mni_NewGame,
            this.mni_LoadPicture,
            this.mni_Exit});
            this.mni_Puzzle.Name = "mni_Puzzle";
            this.mni_Puzzle.Size = new System.Drawing.Size(52, 20);
            this.mni_Puzzle.Text = "&Puzzle";
            // 
            // mni_NewGame
            // 
            this.mni_NewGame.Name = "mni_NewGame";
            this.mni_NewGame.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mni_NewGame.Size = new System.Drawing.Size(224, 22);
            this.mni_NewGame.Text = "&New Game";
            this.mni_NewGame.Click += new System.EventHandler(this.mni_NewGame_Click);
            // 
            // mni_LoadPicture
            // 
            this.mni_LoadPicture.Name = "mni_LoadPicture";
            this.mni_LoadPicture.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.O)));
            this.mni_LoadPicture.Size = new System.Drawing.Size(224, 22);
            this.mni_LoadPicture.Text = "L&oad Picture...";
            this.mni_LoadPicture.Click += new System.EventHandler(this.mni_LoadPicture_Click);
            // 
            // mni_Exit
            // 
            this.mni_Exit.Name = "mni_Exit";
            this.mni_Exit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mni_Exit.Size = new System.Drawing.Size(224, 22);
            this.mni_Exit.Text = "E&xit";
            this.mni_Exit.Click += new System.EventHandler(this.mni_Exit_Click);
            // 
            // mni_Options
            // 
            this.mni_Options.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mni_StepByStep,
            this.mni_Solve});
            this.mni_Options.Name = "mni_Options";
            this.mni_Options.Size = new System.Drawing.Size(61, 20);
            this.mni_Options.Text = "Op&tions";
            // 
            // mni_StepByStep
            // 
            this.mni_StepByStep.CheckOnClick = true;
            this.mni_StepByStep.Name = "mni_StepByStep";
            this.mni_StepByStep.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.mni_StepByStep.Size = new System.Drawing.Size(162, 22);
            this.mni_StepByStep.Text = "St&ep-by-Step";
            this.mni_StepByStep.CheckedChanged += new System.EventHandler(this.mni_StepByStep_CheckedChanged);
            // 
            // mni_Solve
            // 
            this.mni_Solve.Name = "mni_Solve";
            this.mni_Solve.ShortcutKeys = System.Windows.Forms.Keys.F9;
            this.mni_Solve.Size = new System.Drawing.Size(162, 22);
            this.mni_Solve.Text = "Sol&ve";
            this.mni_Solve.Click += new System.EventHandler(this.mni_Solve_Click);
            // 
            // mni_Help
            // 
            this.mni_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mni_About});
            this.mni_Help.Name = "mni_Help";
            this.mni_Help.Size = new System.Drawing.Size(44, 20);
            this.mni_Help.Text = "&Help";
            // 
            // mni_About
            // 
            this.mni_About.Name = "mni_About";
            this.mni_About.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.mni_About.Size = new System.Drawing.Size(126, 22);
            this.mni_About.Text = "A&bout";
            this.mni_About.Click += new System.EventHandler(this.mni_About_Click);
            // 
            // mni_LoadGame
            // 
            this.mni_LoadGame.Name = "mni_LoadGame";
            this.mni_LoadGame.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mni_LoadGame.Size = new System.Drawing.Size(215, 22);
            this.mni_LoadGame.Text = "Load Game";
            this.mni_LoadGame.Click += new System.EventHandler(this.mni_LoadGame_Click);
            // 
            // mni_SaveGame
            // 
            this.mni_SaveGame.Name = "mni_SaveGame";
            this.mni_SaveGame.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mni_SaveGame.Size = new System.Drawing.Size(215, 22);
            this.mni_SaveGame.Text = "Save Game";
            this.mni_SaveGame.Click += new System.EventHandler(this.mni_SaveGame_Click);
            // 
            // dia_OpenPicture
            // 
            this.dia_OpenPicture.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF";
            // 
            // gbo_StepByStep
            // 
            this.gbo_StepByStep.Controls.Add(this.btn_Solve);
            this.gbo_StepByStep.Controls.Add(this.btn_Distribute);
            this.gbo_StepByStep.Controls.Add(this.btn_Split);
            this.gbo_StepByStep.Location = new System.Drawing.Point(12, 266);
            this.gbo_StepByStep.Name = "gbo_StepByStep";
            this.gbo_StepByStep.Size = new System.Drawing.Size(260, 42);
            this.gbo_StepByStep.TabIndex = 2;
            this.gbo_StepByStep.TabStop = false;
            this.gbo_StepByStep.Text = "Step by Step";
            // 
            // btn_Solve
            // 
            this.btn_Solve.Location = new System.Drawing.Point(168, 13);
            this.btn_Solve.Name = "btn_Solve";
            this.btn_Solve.Size = new System.Drawing.Size(75, 23);
            this.btn_Solve.TabIndex = 2;
            this.btn_Solve.Text = "Solve";
            this.btn_Solve.UseVisualStyleBackColor = true;
            this.btn_Solve.Click += new System.EventHandler(this.btn_Solve_Click);
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
        private System.Windows.Forms.ToolStripMenuItem mni_Puzzle;
        private System.Windows.Forms.ToolStripMenuItem mni_NewGame;
        private System.Windows.Forms.ToolStripMenuItem mni_LoadPicture;
        private System.Windows.Forms.ToolStripMenuItem mni_Exit;
        private System.Windows.Forms.ToolStripMenuItem mni_Options;
        private System.Windows.Forms.ToolStripMenuItem mni_StepByStep;
        private System.Windows.Forms.ToolStripMenuItem mni_Help;
        private System.Windows.Forms.ToolStripMenuItem mni_About;
        private System.Windows.Forms.ToolStripMenuItem mni_LoadGame;
        private System.Windows.Forms.ToolStripMenuItem mni_SaveGame;
        private System.Windows.Forms.OpenFileDialog dia_OpenPicture;
        private System.Windows.Forms.GroupBox gbo_StepByStep;
        private System.Windows.Forms.Button btn_Distribute;
        private System.Windows.Forms.Button btn_Split;
        private System.Windows.Forms.ToolStripMenuItem mni_Solve;
        private System.Windows.Forms.Button btn_Solve;
    }
}

