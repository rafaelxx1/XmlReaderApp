using XmlReaderApp.connection;

namespace XmlReaderApp
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            account_txt = new TextBox();
            password_txt = new TextBox();
            lb1 = new Label();
            lb2 = new Label();
            btn_login = new Button();
            link_signup = new LinkLabel();
            SuspendLayout();
            // 
            // account_txt
            // 
            account_txt.Location = new Point(292, 144);
            account_txt.Name = "account_txt";
            account_txt.Size = new Size(203, 27);
            account_txt.TabIndex = 0;
            // 
            // password_txt
            // 
            password_txt.Location = new Point(292, 197);
            password_txt.Name = "password_txt";
            password_txt.Size = new Size(203, 27);
            password_txt.TabIndex = 1;
            // 
            // lb1
            // 
            lb1.AutoSize = true;
            lb1.Location = new Point(292, 121);
            lb1.Name = "lb1";
            lb1.Size = new Size(50, 20);
            lb1.TabIndex = 2;
            lb1.Text = "label1";
            // 
            // lb2
            // 
            lb2.AutoSize = true;
            lb2.Location = new Point(292, 174);
            lb2.Name = "lb2";
            lb2.Size = new Size(50, 20);
            lb2.TabIndex = 3;
            lb2.Text = "label2";
            // 
            // btn_login
            // 
            btn_login.Location = new Point(292, 247);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(203, 29);
            btn_login.TabIndex = 4;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // link_signup
            // 
            link_signup.AutoSize = true;
            link_signup.Location = new Point(292, 224);
            link_signup.Name = "link_signup";
            link_signup.Size = new Size(57, 20);
            link_signup.TabIndex = 6;
            link_signup.TabStop = true;
            link_signup.Text = "sign up";
            link_signup.LinkClicked += link_signup_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(link_signup);
            Controls.Add(btn_login);
            Controls.Add(lb2);
            Controls.Add(lb1);
            Controls.Add(password_txt);
            Controls.Add(account_txt);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox account_txt;
        private TextBox password_txt;
        private Label lb1;
        private Label lb2;
        private Button btn_login;
        private LinkLabel link_signup;
    }
}