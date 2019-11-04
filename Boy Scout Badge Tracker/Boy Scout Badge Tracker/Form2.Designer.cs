namespace Boy_Scout_Badge_Tracker
{
    partial class newsc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newsc));
            this.txtscout = new System.Windows.Forms.TextBox();
            this.btngo = new System.Windows.Forms.Button();
            this.btncanc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtscout
            // 
            this.txtscout.Location = new System.Drawing.Point(48, 51);
            this.txtscout.Name = "txtscout";
            this.txtscout.Size = new System.Drawing.Size(250, 20);
            this.txtscout.TabIndex = 0;
            this.txtscout.TextChanged += new System.EventHandler(this.txtscout_TextChanged);
            // 
            // btngo
            // 
            this.btngo.Enabled = false;
            this.btngo.Location = new System.Drawing.Point(328, 23);
            this.btngo.Name = "btngo";
            this.btngo.Size = new System.Drawing.Size(75, 24);
            this.btngo.TabIndex = 1;
            this.btngo.Text = "Okay";
            this.btngo.UseVisualStyleBackColor = true;
            this.btngo.Click += new System.EventHandler(this.btngo_Click);
            // 
            // btncanc
            // 
            this.btncanc.Location = new System.Drawing.Point(328, 51);
            this.btncanc.Name = "btncanc";
            this.btncanc.Size = new System.Drawing.Size(75, 24);
            this.btncanc.TabIndex = 2;
            this.btncanc.Text = "Cancel";
            this.btncanc.UseVisualStyleBackColor = true;
            this.btncanc.Click += new System.EventHandler(this.btncanc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please enter name here. ";
            // 
            // newsc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 94);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncanc);
            this.Controls.Add(this.btngo);
            this.Controls.Add(this.txtscout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "newsc";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Scout";
            this.Load += new System.EventHandler(this.newsc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtscout;
        private System.Windows.Forms.Button btngo;
        private System.Windows.Forms.Button btncanc;
        private System.Windows.Forms.Label label1;
    }
}