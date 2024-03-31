namespace PirateChan
{
    partial class CustomerLanding
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerLanding));
            this.label2 = new System.Windows.Forms.Label();
            this.Leftpanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Logout = new System.Windows.Forms.Label();
            this.figurine_btn = new System.Windows.Forms.Button();
            this.plushy_btn = new System.Windows.Forms.Button();
            this.Leftpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 23);
            this.label2.TabIndex = 8;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Leftpanel
            // 
            this.Leftpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.Leftpanel.Controls.Add(this.panel1);
            this.Leftpanel.Controls.Add(this.Logout);
            this.Leftpanel.Controls.Add(this.figurine_btn);
            this.Leftpanel.Controls.Add(this.plushy_btn);
            this.Leftpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Leftpanel.Location = new System.Drawing.Point(0, 0);
            this.Leftpanel.Margin = new System.Windows.Forms.Padding(2);
            this.Leftpanel.Name = "Leftpanel";
            this.Leftpanel.Size = new System.Drawing.Size(151, 612);
            this.Leftpanel.TabIndex = 39;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(148, 207);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(871, 114);
            this.panel1.TabIndex = 37;
            // 
            // Logout
            // 
            this.Logout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Logout.AutoSize = true;
            this.Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Logout.Location = new System.Drawing.Point(48, 518);
            this.Logout.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(49, 15);
            this.Logout.TabIndex = 38;
            this.Logout.Text = "Log-out";
            // 
            // figurine_btn
            // 
            this.figurine_btn.BackColor = System.Drawing.Color.Transparent;
            this.figurine_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.figurine_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.figurine_btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.figurine_btn.Location = new System.Drawing.Point(-4, -8);
            this.figurine_btn.Margin = new System.Windows.Forms.Padding(2);
            this.figurine_btn.Name = "figurine_btn";
            this.figurine_btn.Size = new System.Drawing.Size(154, 76);
            this.figurine_btn.TabIndex = 31;
            this.figurine_btn.Text = "Figurines";
            this.figurine_btn.UseVisualStyleBackColor = false;
            this.figurine_btn.Click += new System.EventHandler(this.figurine_btn_Click);
            // 
            // plushy_btn
            // 
            this.plushy_btn.BackColor = System.Drawing.Color.Transparent;
            this.plushy_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.plushy_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plushy_btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.plushy_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.plushy_btn.Location = new System.Drawing.Point(-4, 67);
            this.plushy_btn.Margin = new System.Windows.Forms.Padding(2);
            this.plushy_btn.Name = "plushy_btn";
            this.plushy_btn.Size = new System.Drawing.Size(154, 69);
            this.plushy_btn.TabIndex = 37;
            this.plushy_btn.Text = "Plushy";
            this.plushy_btn.UseVisualStyleBackColor = false;
            this.plushy_btn.Click += new System.EventHandler(this.plushy_btn_Click);
            // 
            // CustomerLanding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(909, 612);
            this.Controls.Add(this.Leftpanel);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CustomerLanding";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerLanding";
            this.Leftpanel.ResumeLayout(false);
            this.Leftpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel Leftpanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Logout;
        private System.Windows.Forms.Button figurine_btn;
        private System.Windows.Forms.Button plushy_btn;
    }
}