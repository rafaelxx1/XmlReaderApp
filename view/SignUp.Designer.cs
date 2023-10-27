namespace XmlReaderApp.model
{
    partial class SignUp
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
            txb_name = new TextBox();
            txb_email = new TextBox();
            txb_password = new TextBox();
            btn_register = new Button();
            lb_name = new Label();
            lb_email = new Label();
            lb_password = new Label();
            lb_info = new Label();
            SuspendLayout();
            // 
            // txb_name
            // 
            txb_name.Location = new Point(102, 82);
            txb_name.Name = "txb_name";
            txb_name.Size = new Size(224, 27);
            txb_name.TabIndex = 0;
            // 
            // txb_email
            // 
            txb_email.Location = new Point(102, 143);
            txb_email.Name = "txb_email";
            txb_email.Size = new Size(224, 27);
            txb_email.TabIndex = 1;
            // 
            // txb_password
            // 
            txb_password.Location = new Point(102, 205);
            txb_password.Name = "txb_password";
            txb_password.PasswordChar = '*';
            txb_password.Size = new Size(224, 27);
            txb_password.TabIndex = 2;
            // 
            // btn_register
            // 
            btn_register.Location = new Point(157, 261);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(118, 34);
            btn_register.TabIndex = 3;
            btn_register.Text = "button1";
            btn_register.UseVisualStyleBackColor = true;
            btn_register.Click += btn_register_Click;
            // 
            // lb_name
            // 
            lb_name.AutoSize = true;
            lb_name.Location = new Point(102, 57);
            lb_name.Name = "lb_name";
            lb_name.Size = new Size(50, 20);
            lb_name.TabIndex = 4;
            lb_name.Text = "label1";
            // 
            // lb_email
            // 
            lb_email.AutoSize = true;
            lb_email.Location = new Point(102, 120);
            lb_email.Name = "lb_email";
            lb_email.Size = new Size(50, 20);
            lb_email.TabIndex = 5;
            lb_email.Text = "label2";
            // 
            // lb_password
            // 
            lb_password.AutoSize = true;
            lb_password.Location = new Point(102, 182);
            lb_password.Name = "lb_password";
            lb_password.Size = new Size(50, 20);
            lb_password.TabIndex = 6;
            lb_password.Text = "label3";
            // 
            // lb_info
            // 
            lb_info.AutoSize = true;
            lb_info.Location = new Point(186, 235);
            lb_info.Name = "lb_info";
            lb_info.Size = new Size(0, 20);
            lb_info.TabIndex = 7;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 374);
            Controls.Add(lb_info);
            Controls.Add(lb_password);
            Controls.Add(lb_email);
            Controls.Add(lb_name);
            Controls.Add(btn_register);
            Controls.Add(txb_password);
            Controls.Add(txb_email);
            Controls.Add(txb_name);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SignUp";
            Text = "SignUp";
            Load += SignUp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txb_name;
        private TextBox txb_email;
        private TextBox txb_password;
        private Button btn_register;
        private Label lb_name;
        private Label lb_email;
        private Label lb_password;
        private Label lb_info;
    }
}