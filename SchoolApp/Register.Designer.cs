namespace SchoolApp
{
    partial class FormRegister
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
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            btnSubmitRegister = new Button();
            btnNavToLogin = new Button();
            label1 = new Label();
            txtFullName = new TextBox();
            SuspendLayout();
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUserName.Location = new Point(219, 130);
            txtUserName.Name = "txtUserName";
            txtUserName.PlaceholderText = "Username...";
            txtUserName.Size = new Size(409, 45);
            txtUserName.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(219, 203);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password...";
            txtPassword.Size = new Size(409, 45);
            txtPassword.TabIndex = 1;
            // 
            // btnSubmitRegister
            // 
            btnSubmitRegister.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmitRegister.Location = new Point(219, 265);
            btnSubmitRegister.Name = "btnSubmitRegister";
            btnSubmitRegister.Size = new Size(409, 49);
            btnSubmitRegister.TabIndex = 2;
            btnSubmitRegister.Text = "Register";
            btnSubmitRegister.UseVisualStyleBackColor = true;
            btnSubmitRegister.Click += btnSubmitRegister_Click;
            // 
            // btnNavToLogin
            // 
            btnNavToLogin.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNavToLogin.Location = new Point(219, 331);
            btnNavToLogin.Name = "btnNavToLogin";
            btnNavToLogin.Size = new Size(409, 50);
            btnNavToLogin.TabIndex = 3;
            btnNavToLogin.Text = "To Login";
            btnNavToLogin.UseVisualStyleBackColor = true;
            btnNavToLogin.Click += btnNavToLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(298, 9);
            label1.Name = "label1";
            label1.Size = new Size(250, 40);
            label1.TabIndex = 4;
            label1.Text = "Form Register";
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFullName.Location = new Point(219, 63);
            txtFullName.Name = "txtFullName";
            txtFullName.PlaceholderText = "Full Name...";
            txtFullName.Size = new Size(409, 45);
            txtFullName.TabIndex = 5;
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtFullName);
            Controls.Add(label1);
            Controls.Add(btnNavToLogin);
            Controls.Add(btnSubmitRegister);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Name = "FormRegister";
            Text = "FormRegister";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUserName;
        private TextBox txtPassword;
        private Button btnSubmitRegister;
        private Button btnNavToLogin;
        private Label label1;
        private TextBox txtFullName;
    }
}