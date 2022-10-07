namespace PBL
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        private void CustomInitialize()
        {
            
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.IndexLabel = new System.Windows.Forms.Label();
            this.LineLabel = new System.Windows.Forms.Label();
            this.LdLabel = new System.Windows.Forms.Label();
            this.CLabel = new System.Windows.Forms.Label();
            this.mCLabel = new System.Windows.Forms.Label();
            this.TLabel = new System.Windows.Forms.Label();
            this.TrongSoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.IndexLabel.AutoSize = true;
            this.IndexLabel.Location = new System.Drawing.Point(46, 40);
            this.IndexLabel.Name = "label1";
            this.IndexLabel.Size = new System.Drawing.Size(13, 20);
            this.IndexLabel.TabIndex = 0;
            this.IndexLabel.Text = "i";
            // 
            // label2
            // 
            this.LineLabel.AutoSize = true;
            this.LineLabel.Location = new System.Drawing.Point(82, 40);
            this.LineLabel.Name = "label2";
            this.LineLabel.Size = new System.Drawing.Size(36, 20);
            this.LineLabel.TabIndex = 1;
            this.LineLabel.Text = "Line";
            // 
            // label3
            // 
            this.LdLabel.AutoSize = true;
            this.LdLabel.Location = new System.Drawing.Point(163, 40);
            this.LdLabel.Name = "label3";
            this.LdLabel.Size = new System.Drawing.Size(84, 20);
            this.LdLabel.TabIndex = 2;
            this.LdLabel.Text = "Ld(pkts/sec";
            // 
            // label4
            // 
            this.CLabel.AutoSize = true;
            this.CLabel.Location = new System.Drawing.Point(313, 40);
            this.CLabel.Name = "label4";
            this.CLabel.Size = new System.Drawing.Size(61, 20);
            this.CLabel.TabIndex = 3;
            this.CLabel.Text = "C(Kbps)";
            // 
            // label5
            // 
            this.mCLabel.AutoSize = true;
            this.mCLabel.Location = new System.Drawing.Point(430, 40);
            this.mCLabel.Name = "label5";
            this.mCLabel.Size = new System.Drawing.Size(95, 20);
            this.mCLabel.TabIndex = 4;
            this.mCLabel.Text = "mC(pkts/sec)";
            // 
            // label6
            // 
            this.TLabel.AutoSize = true;
            this.TLabel.Location = new System.Drawing.Point(587, 40);
            this.TLabel.Name = "label6";
            this.TLabel.Size = new System.Drawing.Size(61, 20);
            this.TLabel.TabIndex = 5;
            this.TLabel.Text = "T(msec)";
            // 
            // label7
            // 
            this.TrongSoLabel.AutoSize = true;
            this.TrongSoLabel.Location = new System.Drawing.Point(699, 40);
            this.TrongSoLabel.Name = "label7";
            this.TrongSoLabel.Size = new System.Drawing.Size(66, 20);
            this.TrongSoLabel.TabIndex = 6;
            this.TrongSoLabel.Text = "Trọng số";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TrongSoLabel);
            this.Controls.Add(this.TLabel);
            this.Controls.Add(this.mCLabel);
            this.Controls.Add(this.CLabel);
            this.Controls.Add(this.LdLabel);
            this.Controls.Add(this.LineLabel);
            this.Controls.Add(this.IndexLabel);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label IndexLabel;
        private Label LineLabel;
        private Label LdLabel;
        private Label CLabel;
        private Label mCLabel;
        private Label TLabel;
        private Label TrongSoLabel;
    }
}