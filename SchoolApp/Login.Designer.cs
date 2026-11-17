namespace SchoolApp
{
    partial class FormLogin
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
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnSubmitLogin = new Button();
            btnNavToRegister = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(203, 71);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username...";
            txtUsername.Size = new Size(380, 45);
            txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(203, 134);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password...";
            txtPassword.Size = new Size(380, 45);
            txtPassword.TabIndex = 1;
            // 
            // btnSubmitLogin
            // 
            btnSubmitLogin.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmitLogin.Location = new Point(203, 209);
            btnSubmitLogin.Name = "btnSubmitLogin";
            btnSubmitLogin.Size = new Size(380, 48);
            btnSubmitLogin.TabIndex = 2;
            btnSubmitLogin.Text = "Login";
            btnSubmitLogin.UseVisualStyleBackColor = true;
            btnSubmitLogin.Click += btnSubmitLogin_Click;
            // 
            // btnNavToRegister
            // 
            btnNavToRegister.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNavToRegister.Location = new Point(203, 287);
            btnNavToRegister.Name = "btnNavToRegister";
            btnNavToRegister.Size = new Size(380, 49);
            btnNavToRegister.TabIndex = 3;
            btnNavToRegister.Text = "To Register";
            btnNavToRegister.UseVisualStyleBackColor = true;
            btnNavToRegister.Click += btnNavToRegister_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(294, 9);
            label1.Name = "label1";
            label1.Size = new Size(205, 40);
            label1.TabIndex = 4;
            label1.Text = "Form Login";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnNavToRegister);
            Controls.Add(btnSubmitLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Name = "FormLogin";
            Text = "FormLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnSubmitLogin;
        private Button btnNavToRegister;
        private Label label1;
    }
}