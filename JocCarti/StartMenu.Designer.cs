namespace JocCarti
{
    partial class StartMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartMenu));
            this.Clasament = new System.Windows.Forms.Button();
            this.StartGame = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Clasament
            // 
            this.Clasament.BackColor = System.Drawing.Color.Gray;
            this.Clasament.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Clasament.Dock = System.Windows.Forms.DockStyle.Left;
            this.Clasament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clasament.Font = new System.Drawing.Font("Microsoft JhengHei UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clasament.ForeColor = System.Drawing.Color.Transparent;
            this.Clasament.Location = new System.Drawing.Point(0, 0);
            this.Clasament.Margin = new System.Windows.Forms.Padding(0);
            this.Clasament.Name = "Clasament";
            this.Clasament.Size = new System.Drawing.Size(300, 661);
            this.Clasament.TabIndex = 0;
            this.Clasament.Text = "Clasament";
            this.Clasament.UseVisualStyleBackColor = false;
            this.Clasament.Click += new System.EventHandler(this.LoadClasament);
            this.Clasament.Paint += new System.Windows.Forms.PaintEventHandler(this.ClasamentP);
            // 
            // StartGame
            // 
            this.StartGame.BackColor = System.Drawing.Color.Gray;
            this.StartGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartGame.Dock = System.Windows.Forms.DockStyle.Right;
            this.StartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartGame.Font = new System.Drawing.Font("Microsoft JhengHei UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartGame.ForeColor = System.Drawing.Color.Transparent;
            this.StartGame.Location = new System.Drawing.Point(384, 0);
            this.StartGame.Name = "StartGame";
            this.StartGame.Size = new System.Drawing.Size(300, 661);
            this.StartGame.TabIndex = 1;
            this.StartGame.Text = "Start Game";
            this.StartGame.UseVisualStyleBackColor = false;
            this.StartGame.Click += new System.EventHandler(this.LoadGame);
            this.StartGame.Paint += new System.Windows.Forms.PaintEventHandler(this.StartP);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(321, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(44, 616);
            this.label1.TabIndex = 2;
            this.label1.Text = "Card Game";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Red;
            this.Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(0, 611);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(50, 50);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // StartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StartGame);
            this.Controls.Add(this.Clasament);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StartMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Gradient);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Clasament;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button StartGame;
        private System.Windows.Forms.Button Exit;
    }
}

