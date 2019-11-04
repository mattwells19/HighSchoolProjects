namespace Boy_Scout_Badge_Tracker
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.chkchef = new System.Windows.Forms.CheckBox();
            this.chkgod = new System.Windows.Forms.CheckBox();
            this.chkfirstresp = new System.Windows.Forms.CheckBox();
            this.chksfh = new System.Windows.Forms.CheckBox();
            this.chkwebwalk = new System.Windows.Forms.CheckBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteScoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAoL = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "\'Add Scout"});
            this.comboBox1.Location = new System.Drawing.Point(114, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(158, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // chkchef
            // 
            this.chkchef.AutoSize = true;
            this.chkchef.Location = new System.Drawing.Point(22, 88);
            this.chkchef.Name = "chkchef";
            this.chkchef.Size = new System.Drawing.Size(93, 17);
            this.chkchef.TabIndex = 1;
            this.chkchef.Text = "Cast Iron Chef";
            this.chkchef.UseVisualStyleBackColor = true;
            // 
            // chkgod
            // 
            this.chkgod.AutoSize = true;
            this.chkgod.Location = new System.Drawing.Point(22, 144);
            this.chkgod.Name = "chkgod";
            this.chkgod.Size = new System.Drawing.Size(126, 17);
            this.chkgod.TabIndex = 2;
            this.chkgod.Text = "Duty to God and You";
            this.chkgod.UseVisualStyleBackColor = true;
            // 
            // chkfirstresp
            // 
            this.chkfirstresp.AutoSize = true;
            this.chkfirstresp.Location = new System.Drawing.Point(172, 88);
            this.chkfirstresp.Name = "chkfirstresp";
            this.chkfirstresp.Size = new System.Drawing.Size(100, 17);
            this.chkfirstresp.TabIndex = 3;
            this.chkfirstresp.Text = "First Responder";
            this.chkfirstresp.UseVisualStyleBackColor = true;
            // 
            // chksfh
            // 
            this.chksfh.AutoSize = true;
            this.chksfh.Location = new System.Drawing.Point(172, 144);
            this.chksfh.Name = "chksfh";
            this.chksfh.Size = new System.Drawing.Size(138, 17);
            this.chksfh.TabIndex = 4;
            this.chksfh.Text = "Stronger, Faster, Higher";
            this.chksfh.UseVisualStyleBackColor = true;
            // 
            // chkwebwalk
            // 
            this.chkwebwalk.AutoSize = true;
            this.chkwebwalk.Location = new System.Drawing.Point(97, 200);
            this.chkwebwalk.Name = "chkwebwalk";
            this.chkwebwalk.Size = new System.Drawing.Size(123, 17);
            this.chkwebwalk.TabIndex = 5;
            this.chkwebwalk.Text = "Webelos Walkabout";
            this.chkwebwalk.UseVisualStyleBackColor = true;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(114, 243);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(87, 33);
            this.btnsave.TabIndex = 6;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(321, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteDataToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // deleteDataToolStripMenuItem
            // 
            this.deleteDataToolStripMenuItem.Name = "deleteDataToolStripMenuItem";
            this.deleteDataToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.deleteDataToolStripMenuItem.Text = "Delete All Data";
            this.deleteDataToolStripMenuItem.Click += new System.EventHandler(this.deleteDataToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeNameToolStripMenuItem,
            this.deleteScoutToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // changeNameToolStripMenuItem
            // 
            this.changeNameToolStripMenuItem.Name = "changeNameToolStripMenuItem";
            this.changeNameToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.changeNameToolStripMenuItem.Text = "Change Name";
            this.changeNameToolStripMenuItem.Click += new System.EventHandler(this.changeNameToolStripMenuItem_Click);
            // 
            // deleteScoutToolStripMenuItem
            // 
            this.deleteScoutToolStripMenuItem.Name = "deleteScoutToolStripMenuItem";
            this.deleteScoutToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.deleteScoutToolStripMenuItem.Text = "Delete Scout";
            this.deleteScoutToolStripMenuItem.Click += new System.EventHandler(this.deleteScoutToolStripMenuItem_Click);
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
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Scout Name: ";
            // 
            // btnAoL
            // 
            this.btnAoL.Location = new System.Drawing.Point(35, 291);
            this.btnAoL.Name = "btnAoL";
            this.btnAoL.Size = new System.Drawing.Size(237, 23);
            this.btnAoL.TabIndex = 9;
            this.btnAoL.Text = "Level 2: Arrow of Light";
            this.btnAoL.UseVisualStyleBackColor = true;
            this.btnAoL.Click += new System.EventHandler(this.btnAoL_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Level 3: Electives";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(321, 357);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAoL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.chkwebwalk);
            this.Controls.Add(this.chksfh);
            this.Controls.Add(this.chkfirstresp);
            this.Controls.Add(this.chkgod);
            this.Controls.Add(this.chkchef);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Badge Tracker";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox chkchef;
        private System.Windows.Forms.CheckBox chkgod;
        private System.Windows.Forms.CheckBox chkfirstresp;
        private System.Windows.Forms.CheckBox chksfh;
        private System.Windows.Forms.CheckBox chkwebwalk;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAoL;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteScoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteDataToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}

