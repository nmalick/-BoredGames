namespace BoredGames
{
    partial class frmCheckers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCheckers));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCheckersGenerate = new System.Windows.Forms.Button();
            this.btnCheckers2_2 = new System.Windows.Forms.Button();
            this.btnCheckers2_4 = new System.Windows.Forms.Button();
            this.btnCheckers4_2 = new System.Windows.Forms.Button();
            this.btnCheckers4_4 = new System.Windows.Forms.Button();
            this.btnCheckersClear = new System.Windows.Forms.Button();
            this.btnCheckersExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnCheckers4_4);
            this.panel1.Controls.Add(this.btnCheckers4_2);
            this.panel1.Controls.Add(this.btnCheckers2_4);
            this.panel1.Controls.Add(this.btnCheckers2_2);
            this.panel1.Location = new System.Drawing.Point(118, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(598, 379);
            this.panel1.TabIndex = 0;
            // 
            // btnCheckersGenerate
            // 
            this.btnCheckersGenerate.Location = new System.Drawing.Point(383, 459);
            this.btnCheckersGenerate.Name = "btnCheckersGenerate";
            this.btnCheckersGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnCheckersGenerate.TabIndex = 31;
            this.btnCheckersGenerate.Text = "Generate!";
            this.btnCheckersGenerate.UseVisualStyleBackColor = true;
            this.btnCheckersGenerate.Click += new System.EventHandler(this.btn_SudokuGenerate_Click);
            // 
            // btnCheckers2_2
            // 
            this.btnCheckers2_2.BackColor = System.Drawing.Color.DarkRed;
            this.btnCheckers2_2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCheckers2_2.BackgroundImage")));
            this.btnCheckers2_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCheckers2_2.Location = new System.Drawing.Point(75, 47);
            this.btnCheckers2_2.Name = "btnCheckers2_2";
            this.btnCheckers2_2.Size = new System.Drawing.Size(75, 48);
            this.btnCheckers2_2.TabIndex = 0;
            this.btnCheckers2_2.UseVisualStyleBackColor = false;
            this.btnCheckers2_2.Visible = false;
            this.btnCheckers2_2.Click += new System.EventHandler(this.btnCheckers2_2_Click);
            // 
            // btnCheckers2_4
            // 
            this.btnCheckers2_4.BackColor = System.Drawing.Color.DarkRed;
            this.btnCheckers2_4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCheckers2_4.BackgroundImage")));
            this.btnCheckers2_4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCheckers2_4.Location = new System.Drawing.Point(224, 47);
            this.btnCheckers2_4.Name = "btnCheckers2_4";
            this.btnCheckers2_4.Size = new System.Drawing.Size(75, 48);
            this.btnCheckers2_4.TabIndex = 1;
            this.btnCheckers2_4.UseVisualStyleBackColor = false;
            this.btnCheckers2_4.Visible = false;
            this.btnCheckers2_4.Click += new System.EventHandler(this.btnCheckers2_4_Click);
            // 
            // btnCheckers4_2
            // 
            this.btnCheckers4_2.BackColor = System.Drawing.Color.DarkRed;
            this.btnCheckers4_2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCheckers4_2.BackgroundImage")));
            this.btnCheckers4_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCheckers4_2.Location = new System.Drawing.Point(75, 138);
            this.btnCheckers4_2.Name = "btnCheckers4_2";
            this.btnCheckers4_2.Size = new System.Drawing.Size(75, 48);
            this.btnCheckers4_2.TabIndex = 2;
            this.btnCheckers4_2.UseVisualStyleBackColor = false;
            this.btnCheckers4_2.Visible = false;
            this.btnCheckers4_2.Click += new System.EventHandler(this.btnCheckers4_2_Click);
            // 
            // btnCheckers4_4
            // 
            this.btnCheckers4_4.BackColor = System.Drawing.Color.DarkRed;
            this.btnCheckers4_4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCheckers4_4.BackgroundImage")));
            this.btnCheckers4_4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCheckers4_4.Location = new System.Drawing.Point(224, 138);
            this.btnCheckers4_4.Name = "btnCheckers4_4";
            this.btnCheckers4_4.Size = new System.Drawing.Size(75, 48);
            this.btnCheckers4_4.TabIndex = 3;
            this.btnCheckers4_4.UseVisualStyleBackColor = false;
            this.btnCheckers4_4.Visible = false;
            this.btnCheckers4_4.Click += new System.EventHandler(this.btnCheckers4_4_Click);
            // 
            // btnCheckersClear
            // 
            this.btnCheckersClear.Location = new System.Drawing.Point(580, 459);
            this.btnCheckersClear.Name = "btnCheckersClear";
            this.btnCheckersClear.Size = new System.Drawing.Size(75, 23);
            this.btnCheckersClear.TabIndex = 32;
            this.btnCheckersClear.Text = "Clear";
            this.btnCheckersClear.UseVisualStyleBackColor = true;
            this.btnCheckersClear.Click += new System.EventHandler(this.btnCheckersClear_Click);
            // 
            // btnCheckersExit
            // 
            this.btnCheckersExit.Location = new System.Drawing.Point(178, 459);
            this.btnCheckersExit.Name = "btnCheckersExit";
            this.btnCheckersExit.Size = new System.Drawing.Size(75, 23);
            this.btnCheckersExit.TabIndex = 33;
            this.btnCheckersExit.Text = "Exit";
            this.btnCheckersExit.UseVisualStyleBackColor = true;
            this.btnCheckersExit.Click += new System.EventHandler(this.btnCheckersExit_Click);
            // 
            // frmCheckers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(832, 529);
            this.Controls.Add(this.btnCheckersExit);
            this.Controls.Add(this.btnCheckersClear);
            this.Controls.Add(this.btnCheckersGenerate);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCheckers";
            this.Text = "Checkers";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCheckersGenerate;
        private System.Windows.Forms.Button btnCheckers4_4;
        private System.Windows.Forms.Button btnCheckers4_2;
        private System.Windows.Forms.Button btnCheckers2_4;
        private System.Windows.Forms.Button btnCheckers2_2;
        private System.Windows.Forms.Button btnCheckersClear;
        private System.Windows.Forms.Button btnCheckersExit;
    }
}