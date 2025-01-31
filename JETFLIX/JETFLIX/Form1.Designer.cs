namespace JETFLIX
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchtextBox = new System.Windows.Forms.TextBox();
            this.searchbutton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.genresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.animeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horrorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mysteryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scifiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trillerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.warToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PanMain = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.searchtextBox);
            this.panel1.Controls.Add(this.searchbutton);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1430, 95);
            this.panel1.TabIndex = 0;
            // 
            // searchtextBox
            // 
            this.searchtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchtextBox.Location = new System.Drawing.Point(630, 18);
            this.searchtextBox.Name = "searchtextBox";
            this.searchtextBox.Size = new System.Drawing.Size(332, 35);
            this.searchtextBox.TabIndex = 6;
            this.searchtextBox.TextChanged += new System.EventHandler(this.searchtextBox_TextChanged);
            // 
            // searchbutton
            // 
            this.searchbutton.BackColor = System.Drawing.Color.Teal;
            this.searchbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbutton.ForeColor = System.Drawing.Color.Black;
            this.searchbutton.Location = new System.Drawing.Point(984, 15);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(113, 43);
            this.searchbutton.TabIndex = 5;
            this.searchbutton.Text = " Search";
            this.searchbutton.UseVisualStyleBackColor = false;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.genresToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(277, 21);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(112, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // genresToolStripMenuItem
            // 
            this.genresToolStripMenuItem.BackColor = System.Drawing.Color.Red;
            this.genresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.animeToolStripMenuItem,
            this.crimeToolStripMenuItem,
            this.horrorToolStripMenuItem,
            this.mysteryToolStripMenuItem,
            this.scifiToolStripMenuItem,
            this.trillerToolStripMenuItem,
            this.warToolStripMenuItem});
            this.genresToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.genresToolStripMenuItem.MergeIndex = 0;
            this.genresToolStripMenuItem.Name = "genresToolStripMenuItem";
            this.genresToolStripMenuItem.Size = new System.Drawing.Size(104, 36);
            this.genresToolStripMenuItem.Text = "Genres";
            // 
            // animeToolStripMenuItem
            // 
            this.animeToolStripMenuItem.Name = "animeToolStripMenuItem";
            this.animeToolStripMenuItem.Size = new System.Drawing.Size(203, 40);
            this.animeToolStripMenuItem.Text = "Anime";
            // 
            // crimeToolStripMenuItem
            // 
            this.crimeToolStripMenuItem.Name = "crimeToolStripMenuItem";
            this.crimeToolStripMenuItem.Size = new System.Drawing.Size(203, 40);
            this.crimeToolStripMenuItem.Text = "Crime";
            // 
            // horrorToolStripMenuItem
            // 
            this.horrorToolStripMenuItem.Name = "horrorToolStripMenuItem";
            this.horrorToolStripMenuItem.Size = new System.Drawing.Size(203, 40);
            this.horrorToolStripMenuItem.Text = "Horror";
            // 
            // mysteryToolStripMenuItem
            // 
            this.mysteryToolStripMenuItem.Name = "mysteryToolStripMenuItem";
            this.mysteryToolStripMenuItem.Size = new System.Drawing.Size(203, 40);
            this.mysteryToolStripMenuItem.Text = "Mystery";
            // 
            // scifiToolStripMenuItem
            // 
            this.scifiToolStripMenuItem.Name = "scifiToolStripMenuItem";
            this.scifiToolStripMenuItem.Size = new System.Drawing.Size(203, 40);
            this.scifiToolStripMenuItem.Text = "Sci-fi";
            // 
            // trillerToolStripMenuItem
            // 
            this.trillerToolStripMenuItem.Name = "trillerToolStripMenuItem";
            this.trillerToolStripMenuItem.Size = new System.Drawing.Size(203, 40);
            this.trillerToolStripMenuItem.Text = "Triller";
            // 
            // warToolStripMenuItem
            // 
            this.warToolStripMenuItem.Name = "warToolStripMenuItem";
            this.warToolStripMenuItem.Size = new System.Drawing.Size(203, 40);
            this.warToolStripMenuItem.Text = "War";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(1103, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "SETTING";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(1365, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 58);
            this.label2.TabIndex = 1;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "JETFLIX";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PanMain
            // 
            this.PanMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.PanMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanMain.ForeColor = System.Drawing.Color.Black;
            this.PanMain.Location = new System.Drawing.Point(0, 95);
            this.PanMain.Name = "PanMain";
            this.PanMain.Size = new System.Drawing.Size(1430, 582);
            this.PanMain.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1430, 677);
            this.Controls.Add(this.PanMain);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel PanMain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem genresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem animeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horrorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mysteryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scifiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trillerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem warToolStripMenuItem;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.TextBox searchtextBox;
    }
}

