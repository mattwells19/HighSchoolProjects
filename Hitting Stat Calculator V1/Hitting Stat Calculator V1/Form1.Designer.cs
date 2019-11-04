namespace Hitting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.battingAverageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onBasePercToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onBasePlusSlgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sluggingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BatA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OnBP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Slug = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OnPS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gainsboro;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(431, 28);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.battingAverageToolStripMenuItem,
            this.onBasePercToolStripMenuItem,
            this.onBasePlusSlgToolStripMenuItem,
            this.sluggingToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.helpToolStripMenuItem.Text = "Info.";
            // 
            // battingAverageToolStripMenuItem
            // 
            this.battingAverageToolStripMenuItem.Name = "battingAverageToolStripMenuItem";
            this.battingAverageToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.battingAverageToolStripMenuItem.Text = "Batting Average";
            this.battingAverageToolStripMenuItem.Click += new System.EventHandler(this.battingAverageToolStripMenuItem_Click);
            // 
            // onBasePercToolStripMenuItem
            // 
            this.onBasePercToolStripMenuItem.Name = "onBasePercToolStripMenuItem";
            this.onBasePercToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.onBasePercToolStripMenuItem.Text = "On Base Perc.";
            this.onBasePercToolStripMenuItem.Click += new System.EventHandler(this.onBasePercToolStripMenuItem_Click);
            // 
            // onBasePlusSlgToolStripMenuItem
            // 
            this.onBasePlusSlgToolStripMenuItem.Name = "onBasePlusSlgToolStripMenuItem";
            this.onBasePlusSlgToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.onBasePlusSlgToolStripMenuItem.Text = "On Base Plus Slg.";
            this.onBasePlusSlgToolStripMenuItem.Click += new System.EventHandler(this.onBasePlusSlgToolStripMenuItem_Click);
            // 
            // sluggingToolStripMenuItem
            // 
            this.sluggingToolStripMenuItem.Name = "sluggingToolStripMenuItem";
            this.sluggingToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.sluggingToolStripMenuItem.Text = "Slugging";
            this.sluggingToolStripMenuItem.Click += new System.EventHandler(this.sluggingToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(117, 53);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 159);
            this.button2.TabIndex = 27;
            this.button2.Text = "Please select your .CSV File here!";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(140, 298);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 60);
            this.button3.TabIndex = 28;
            this.button3.Text = "Go when ready!";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(117, 226);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 22);
            this.textBox1.TabIndex = 29;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.BatA,
            this.OnBP,
            this.Slug,
            this.OnPS});
            this.dataGridView1.Location = new System.Drawing.Point(454, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(549, 505);
            this.dataGridView1.TabIndex = 35;
            this.dataGridView1.Visible = false;
            // 
            // ID
            // 
            this.ID.HeaderText = "Player Name";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // BatA
            // 
            this.BatA.HeaderText = "Batting Average";
            this.BatA.Name = "BatA";
            this.BatA.ReadOnly = true;
            // 
            // OnBP
            // 
            this.OnBP.HeaderText = "OBP";
            this.OnBP.Name = "OnBP";
            this.OnBP.ReadOnly = true;
            // 
            // Slug
            // 
            this.Slug.HeaderText = "Slugging";
            this.Slug.Name = "Slug";
            this.Slug.ReadOnly = true;
            // 
            // OnPS
            // 
            this.OnPS.HeaderText = "OPS";
            this.OnPS.Name = "OnPS";
            this.OnPS.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 54);
            this.button1.TabIndex = 36;
            this.button1.Text = "HELP!!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hitting.Properties.Resources.MC_436_New_Cam_Baseball_Fields_1024x682;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(431, 379);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hitting Calculations";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem battingAverageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onBasePercToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onBasePlusSlgToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sluggingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BatA;
        private System.Windows.Forms.DataGridViewTextBoxColumn OnBP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Slug;
        private System.Windows.Forms.DataGridViewTextBoxColumn OnPS;
        private System.Windows.Forms.Button button1;
    }
}

