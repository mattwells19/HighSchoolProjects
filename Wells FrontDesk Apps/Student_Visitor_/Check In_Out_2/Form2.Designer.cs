namespace Check_In_Out_2
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.txtName = new System.Windows.Forms.TextBox();
            this.radHalf = new System.Windows.Forms.RadioButton();
            this.radAll = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.grpLong = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtTeach = new System.Windows.Forms.ComboBox();
            this.pBSub = new System.Windows.Forms.PictureBox();
            this.grpLong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBSub)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(180, 35);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(119, 20);
            this.txtName.TabIndex = 1;
            // 
            // radHalf
            // 
            this.radHalf.AutoSize = true;
            this.radHalf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radHalf.Location = new System.Drawing.Point(34, 17);
            this.radHalf.Name = "radHalf";
            this.radHalf.Size = new System.Drawing.Size(79, 20);
            this.radHalf.TabIndex = 1;
            this.radHalf.TabStop = true;
            this.radHalf.Text = "Half-Day";
            this.radHalf.UseVisualStyleBackColor = true;
            // 
            // radAll
            // 
            this.radAll.AutoSize = true;
            this.radAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radAll.Location = new System.Drawing.Point(157, 17);
            this.radAll.Name = "radAll";
            this.radAll.Size = new System.Drawing.Size(69, 20);
            this.radAll.TabIndex = 2;
            this.radAll.TabStop = true;
            this.radAll.Text = "All Day";
            this.radAll.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // grpLong
            // 
            this.grpLong.Controls.Add(this.radAll);
            this.grpLong.Controls.Add(this.radHalf);
            this.grpLong.Location = new System.Drawing.Point(40, 108);
            this.grpLong.Name = "grpLong";
            this.grpLong.Size = new System.Drawing.Size(259, 51);
            this.grpLong.TabIndex = 3;
            this.grpLong.TabStop = false;
            this.grpLong.Text = "How Long";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Teacher Subbing For";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(40, 165);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(259, 59);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtTeach
            // 
            this.txtTeach.FormattingEnabled = true;
            this.txtTeach.Location = new System.Drawing.Point(180, 67);
            this.txtTeach.Name = "txtTeach";
            this.txtTeach.Size = new System.Drawing.Size(119, 21);
            this.txtTeach.TabIndex = 2;
            // 
            // pBSub
            // 
            this.pBSub.Location = new System.Drawing.Point(305, 109);
            this.pBSub.Name = "pBSub";
            this.pBSub.Size = new System.Drawing.Size(100, 50);
            this.pBSub.TabIndex = 7;
            this.pBSub.TabStop = false;
            this.pBSub.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 254);
            this.Controls.Add(this.pBSub);
            this.Controls.Add(this.txtTeach);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grpLong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Substitute";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.grpLong.ResumeLayout(false);
            this.grpLong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBSub)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.RadioButton radHalf;
        private System.Windows.Forms.RadioButton radAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpLong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox txtTeach;
        private System.Windows.Forms.PictureBox pBSub;
    }
}