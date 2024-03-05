namespace schoolManagementSystem
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
            this.username = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Button();
            this.forget = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(94, 77);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(55, 13);
            this.username.TabIndex = 0;
            this.username.Text = "Username";
            this.username.Click += new System.EventHandler(this.username_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(153, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(94, 106);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(53, 13);
            this.password.TabIndex = 2;
            this.password.Text = "Password";
            this.password.Click += new System.EventHandler(this.password_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(153, 103);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.login.Location = new System.Drawing.Point(97, 138);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(75, 23);
            this.login.TabIndex = 4;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // forget
            // 
            this.forget.AutoSize = true;
            this.forget.Location = new System.Drawing.Point(94, 175);
            this.forget.Name = "forget";
            this.forget.Size = new System.Drawing.Size(86, 13);
            this.forget.TabIndex = 5;
            this.forget.TabStop = true;
            this.forget.Text = "Forget Password";
            this.forget.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forget_LinkClicked);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 325);
            this.Controls.Add(this.forget);
            this.Controls.Add(this.login);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.password);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.username);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.LinkLabel forget;
    }
}