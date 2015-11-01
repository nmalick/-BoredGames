namespace BoredGames
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnSudoku = new System.Windows.Forms.Button();
            this.btnCheckers = new System.Windows.Forms.Button();
            this.btnChess = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadGameToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSudoku
            // 
            this.btnSudoku.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSudoku.BackgroundImage")));
            this.btnSudoku.Location = new System.Drawing.Point(142, 39);
            this.btnSudoku.Name = "btnSudoku";
            this.btnSudoku.Size = new System.Drawing.Size(303, 94);
            this.btnSudoku.TabIndex = 3;
            this.btnSudoku.UseVisualStyleBackColor = true;
            this.btnSudoku.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCheckers
            // 
            this.btnCheckers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCheckers.BackgroundImage")));
            this.btnCheckers.Location = new System.Drawing.Point(142, 248);
            this.btnCheckers.Name = "btnCheckers";
            this.btnCheckers.Size = new System.Drawing.Size(303, 94);
            this.btnCheckers.TabIndex = 5;
            this.btnCheckers.UseVisualStyleBackColor = true;
            this.btnCheckers.Click += new System.EventHandler(this.btnCheckers_Click);
            // 
            // btnChess
            // 
            this.btnChess.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnChess.BackgroundImage")));
            this.btnChess.Location = new System.Drawing.Point(142, 148);
            this.btnChess.Name = "btnChess";
            this.btnChess.Size = new System.Drawing.Size(303, 94);
            this.btnChess.TabIndex = 6;
            this.btnChess.UseVisualStyleBackColor = true;
            this.btnChess.Click += new System.EventHandler(this.btnChess_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(568, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPlayerToolStripMenuItem,
            this.loadGameToolStripMenuItem,
            this.loadGameToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newPlayerToolStripMenuItem
            // 
            this.newPlayerToolStripMenuItem.Name = "newPlayerToolStripMenuItem";
            this.newPlayerToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.newPlayerToolStripMenuItem.Text = "New Player";
            // 
            // loadGameToolStripMenuItem
            // 
            this.loadGameToolStripMenuItem.Name = "loadGameToolStripMenuItem";
            this.loadGameToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.loadGameToolStripMenuItem.Text = "Save  Game";
            this.loadGameToolStripMenuItem.Click += new System.EventHandler(this.loadGameToolStripMenuItem_Click);
            // 
            // loadGameToolStripMenuItem1
            // 
            this.loadGameToolStripMenuItem1.Name = "loadGameToolStripMenuItem1";
            this.loadGameToolStripMenuItem1.Size = new System.Drawing.Size(135, 22);
            this.loadGameToolStripMenuItem1.Text = "Load Game";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.Location = new System.Drawing.Point(142, 348);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(303, 94);
            this.btnExit.TabIndex = 8;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(568, 467);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnChess);
            this.Controls.Add(this.btnCheckers);
            this.Controls.Add(this.btnSudoku);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "#BoredGames";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSudoku;
        private System.Windows.Forms.Button btnCheckers;
        private System.Windows.Forms.Button btnChess;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newPlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadGameToolStripMenuItem1;
        private System.Windows.Forms.Button btnExit;
    }
}

