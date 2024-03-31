namespace PirateChan
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.username_txt = new System.Windows.Forms.TextBox();
            this.pwd_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.login_btn = new System.Windows.Forms.Button();
            this.registerhere_btn2 = new System.Windows.Forms.Label();
            this.registerhere_btn1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Candara", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(630, 125);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(516, 214);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username:";
            // 
            // username_txt
            // 
            this.username_txt.BackColor = System.Drawing.SystemColors.Control;
            this.username_txt.Location = new System.Drawing.Point(520, 248);
            this.username_txt.Margin = new System.Windows.Forms.Padding(2);
            this.username_txt.Name = "username_txt";
            this.username_txt.Size = new System.Drawing.Size(301, 20);
            this.username_txt.TabIndex = 1;
            // 
            // pwd_txt
            // 
            this.pwd_txt.BackColor = System.Drawing.SystemColors.Control;
            this.pwd_txt.Location = new System.Drawing.Point(520, 325);
            this.pwd_txt.Margin = new System.Windows.Forms.Padding(2);
            this.pwd_txt.Name = "pwd_txt";
            this.pwd_txt.PasswordChar = '*';
            this.pwd_txt.Size = new System.Drawing.Size(301, 20);
            this.pwd_txt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(516, 291);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            // 
            // login_btn
            // 
            this.login_btn.Location = new System.Drawing.Point(627, 374);
            this.login_btn.Margin = new System.Windows.Forms.Padding(2);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(103, 24);
            this.login_btn.TabIndex = 4;
            this.login_btn.Text = "LOGIN";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // registerhere_btn2
            // 
            this.registerhere_btn2.AutoSize = true;
            this.registerhere_btn2.BackColor = System.Drawing.Color.Transparent;
            this.registerhere_btn2.Font = new System.Drawing.Font("Candara Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerhere_btn2.Location = new System.Drawing.Point(534, 438);
            this.registerhere_btn2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.registerhere_btn2.Name = "registerhere_btn2";
            this.registerhere_btn2.Size = new System.Drawing.Size(172, 19);
            this.registerhere_btn2.TabIndex = 5;
            this.registerhere_btn2.Text = "Don\'t have an Account? ";
            this.registerhere_btn2.Click += new System.EventHandler(this.registerhere_btn2_Click);
            // 
            // registerhere_btn1
            // 
            this.registerhere_btn1.AutoSize = true;
            this.registerhere_btn1.BackColor = System.Drawing.Color.Transparent;
            this.registerhere_btn1.Font = new System.Drawing.Font("Candara Light", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerhere_btn1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.registerhere_btn1.Location = new System.Drawing.Point(709, 438);
            this.registerhere_btn1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.registerhere_btn1.Name = "registerhere_btn1";
            this.registerhere_btn1.Size = new System.Drawing.Size(101, 19);
            this.registerhere_btn1.TabIndex = 6;
            this.registerhere_btn1.Text = "Register Here ";
            this.registerhere_btn1.Click += new System.EventHandler(this.registerhere_btn1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(909, 612);
            this.Controls.Add(this.registerhere_btn1);
            this.Controls.Add(this.registerhere_btn2);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.pwd_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.username_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox username_txt;
        private System.Windows.Forms.TextBox pwd_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Label registerhere_btn2;
        private System.Windows.Forms.Label registerhere_btn1;
    }
}

