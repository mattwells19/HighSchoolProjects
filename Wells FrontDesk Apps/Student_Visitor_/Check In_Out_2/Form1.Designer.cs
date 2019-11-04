namespace Check_In_Out_2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtReason = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.grpInOut = new System.Windows.Forms.GroupBox();
            this.radOut = new System.Windows.Forms.RadioButton();
            this.radIn = new System.Windows.Forms.RadioButton();
            this.grpStuVis = new System.Windows.Forms.GroupBox();
            this.radVis = new System.Windows.Forms.RadioButton();
            this.radStu = new System.Windows.Forms.RadioButton();
            this.btnHelp = new System.Windows.Forms.Button();
            this.grpAll = new System.Windows.Forms.GroupBox();
            this.btnTime = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.pBLogo = new System.Windows.Forms.PictureBox();
            this.pictureBoxVideo = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chkPrint = new System.Windows.Forms.CheckBox();
            this.chkSpanish = new System.Windows.Forms.CheckBox();
            this.grpInOut.SuspendLayout();
            this.grpStuVis.SuspendLayout();
            this.grpAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(44, 294);
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(385, 20);
            this.txtReason.TabIndex = 26;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(46, 235);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(385, 20);
            this.txtName.TabIndex = 25;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 29);
            this.label2.TabIndex = 29;
            this.label2.Text = "Name of Student/Visitor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 29);
            this.label1.TabIndex = 28;
            this.label1.Text = "Reason";
            // 
            // btnGo
            // 
            this.btnGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.Location = new System.Drawing.Point(45, 324);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(385, 70);
            this.btnGo.TabIndex = 27;
            this.btnGo.Text = "Save";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // grpInOut
            // 
            this.grpInOut.Controls.Add(this.radOut);
            this.grpInOut.Controls.Add(this.radIn);
            this.grpInOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInOut.Location = new System.Drawing.Point(45, 111);
            this.grpInOut.Name = "grpInOut";
            this.grpInOut.Size = new System.Drawing.Size(385, 89);
            this.grpInOut.TabIndex = 32;
            this.grpInOut.TabStop = false;
            this.grpInOut.Text = "In/Out";
            // 
            // radOut
            // 
            this.radOut.AutoSize = true;
            this.radOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radOut.Location = new System.Drawing.Point(208, 39);
            this.radOut.Name = "radOut";
            this.radOut.Size = new System.Drawing.Size(131, 29);
            this.radOut.TabIndex = 3;
            this.radOut.TabStop = true;
            this.radOut.Text = "Check Out";
            this.radOut.UseVisualStyleBackColor = true;
            // 
            // radIn
            // 
            this.radIn.AutoSize = true;
            this.radIn.Checked = true;
            this.radIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radIn.Location = new System.Drawing.Point(51, 39);
            this.radIn.Name = "radIn";
            this.radIn.Size = new System.Drawing.Size(114, 29);
            this.radIn.TabIndex = 2;
            this.radIn.TabStop = true;
            this.radIn.Text = "Check In";
            this.radIn.UseVisualStyleBackColor = true;
            // 
            // grpStuVis
            // 
            this.grpStuVis.Controls.Add(this.radVis);
            this.grpStuVis.Controls.Add(this.radStu);
            this.grpStuVis.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpStuVis.Location = new System.Drawing.Point(46, 29);
            this.grpStuVis.Name = "grpStuVis";
            this.grpStuVis.Size = new System.Drawing.Size(384, 76);
            this.grpStuVis.TabIndex = 31;
            this.grpStuVis.TabStop = false;
            this.grpStuVis.Text = "Student/Visitor";
            // 
            // radVis
            // 
            this.radVis.AutoSize = true;
            this.radVis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radVis.Location = new System.Drawing.Point(207, 30);
            this.radVis.Name = "radVis";
            this.radVis.Size = new System.Drawing.Size(90, 29);
            this.radVis.TabIndex = 1;
            this.radVis.Text = "Visitor";
            this.radVis.UseVisualStyleBackColor = true;
            this.radVis.CheckedChanged += new System.EventHandler(this.radVis_CheckedChanged_1);
            // 
            // radStu
            // 
            this.radStu.AutoSize = true;
            this.radStu.Checked = true;
            this.radStu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radStu.Location = new System.Drawing.Point(50, 30);
            this.radStu.Name = "radStu";
            this.radStu.Size = new System.Drawing.Size(104, 29);
            this.radStu.TabIndex = 0;
            this.radStu.TabStop = true;
            this.radStu.Text = "Student";
            this.radStu.UseVisualStyleBackColor = true;
            this.radStu.CheckedChanged += new System.EventHandler(this.radStu_CheckedChanged_1);
            // 
            // btnHelp
            // 
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Location = new System.Drawing.Point(333, 12);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(109, 55);
            this.btnHelp.TabIndex = 33;
            this.btnHelp.Text = "Turn Camera Off";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Visible = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // grpAll
            // 
            this.grpAll.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpAll.Controls.Add(this.btnTime);
            this.grpAll.Controls.Add(this.btnSub);
            this.grpAll.Controls.Add(this.txtReason);
            this.grpAll.Controls.Add(this.txtName);
            this.grpAll.Controls.Add(this.label2);
            this.grpAll.Controls.Add(this.label1);
            this.grpAll.Controls.Add(this.btnGo);
            this.grpAll.Controls.Add(this.grpInOut);
            this.grpAll.Controls.Add(this.grpStuVis);
            this.grpAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpAll.Location = new System.Drawing.Point(388, 144);
            this.grpAll.Name = "grpAll";
            this.grpAll.Size = new System.Drawing.Size(559, 436);
            this.grpAll.TabIndex = 34;
            this.grpAll.TabStop = false;
            // 
            // btnTime
            // 
            this.btnTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTime.Location = new System.Drawing.Point(446, 222);
            this.btnTime.Name = "btnTime";
            this.btnTime.Size = new System.Drawing.Size(95, 157);
            this.btnTime.TabIndex = 36;
            this.btnTime.Text = "Time Keeper";
            this.btnTime.UseVisualStyleBackColor = true;
            this.btnTime.Click += new System.EventHandler(this.btnTime_Click);
            // 
            // btnSub
            // 
            this.btnSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSub.Location = new System.Drawing.Point(446, 59);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(95, 157);
            this.btnSub.TabIndex = 35;
            this.btnSub.Text = "Substitute";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // pBLogo
            // 
            this.pBLogo.Image = ((System.Drawing.Image)(resources.GetObject("pBLogo.Image")));
            this.pBLogo.Location = new System.Drawing.Point(688, 12);
            this.pBLogo.Name = "pBLogo";
            this.pBLogo.Size = new System.Drawing.Size(132, 126);
            this.pBLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBLogo.TabIndex = 35;
            this.pBLogo.TabStop = false;
            // 
            // pictureBoxVideo
            // 
            this.pictureBoxVideo.Location = new System.Drawing.Point(225, -131);
            this.pictureBoxVideo.Name = "pictureBoxVideo";
            this.pictureBoxVideo.Size = new System.Drawing.Size(126, 81);
            this.pictureBoxVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxVideo.TabIndex = 30;
            this.pictureBoxVideo.TabStop = false;
            this.pictureBoxVideo.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chkPrint
            // 
            this.chkPrint.AutoSize = true;
            this.chkPrint.Location = new System.Drawing.Point(1157, 12);
            this.chkPrint.Name = "chkPrint";
            this.chkPrint.Size = new System.Drawing.Size(81, 17);
            this.chkPrint.TabIndex = 36;
            this.chkPrint.Text = "Print Labels";
            this.chkPrint.UseVisualStyleBackColor = true;
            this.chkPrint.Visible = false;
            this.chkPrint.CheckedChanged += new System.EventHandler(this.chkPrint_CheckedChanged);
            // 
            // chkSpanish
            // 
            this.chkSpanish.AutoSize = true;
            this.chkSpanish.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSpanish.Location = new System.Drawing.Point(388, 121);
            this.chkSpanish.Name = "chkSpanish";
            this.chkSpanish.Size = new System.Drawing.Size(81, 22);
            this.chkSpanish.TabIndex = 37;
            this.chkSpanish.Text = "Español";
            this.chkSpanish.UseVisualStyleBackColor = true;
            this.chkSpanish.CheckedChanged += new System.EventHandler(this.chkSpanish_CheckedChanged);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnGo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 672);
            this.Controls.Add(this.chkSpanish);
            this.Controls.Add(this.chkPrint);
            this.Controls.Add(this.pBLogo);
            this.Controls.Add(this.grpAll);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.pictureBoxVideo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Check In/Out";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.Form1_HelpButtonClicked);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDoubleClick);
            this.grpInOut.ResumeLayout(false);
            this.grpInOut.PerformLayout();
            this.grpStuVis.ResumeLayout(false);
            this.grpStuVis.PerformLayout();
            this.grpAll.ResumeLayout(false);
            this.grpAll.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVideo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.GroupBox grpInOut;
        private System.Windows.Forms.RadioButton radOut;
        private System.Windows.Forms.RadioButton radIn;
        private System.Windows.Forms.GroupBox grpStuVis;
        private System.Windows.Forms.RadioButton radVis;
        private System.Windows.Forms.RadioButton radStu;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.GroupBox grpAll;
        private System.Windows.Forms.Button btnSub;
        public System.Windows.Forms.PictureBox pictureBoxVideo;
        private System.Windows.Forms.PictureBox pBLogo;
        private System.Windows.Forms.Button btnTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox chkPrint;
        private System.Windows.Forms.CheckBox chkSpanish;
    }
}

