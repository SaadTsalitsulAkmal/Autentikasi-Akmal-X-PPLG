namespace SchoolApp
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
            lblName = new Label();
            textBoxName = new TextBox();
            label1 = new Label();
            txtInstitution = new TextBox();
            btnSave = new Button();
            dgvData = new DataGridView();
            btnUpdate = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Stencil", 19.8000011F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.Lime;
            lblName.Location = new Point(32, 112);
            lblName.Name = "lblName";
            lblName.Size = new Size(156, 40);
            lblName.TabIndex = 0;
            lblName.Text = "Visitor";
            lblName.Click += label1_Click;
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Segoe UI", 20F);
            textBoxName.ForeColor = Color.FromArgb(192, 255, 192);
            textBoxName.Location = new Point(308, 112);
            textBoxName.Name = "textBoxName";
            textBoxName.PlaceholderText = "Input Your Name";
            textBoxName.Size = new Size(555, 52);
            textBoxName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(32, 185);
            label1.Name = "label1";
            label1.Size = new Size(245, 43);
            label1.TabIndex = 2;
            label1.Text = "Institution";
            // 
            // txtInstitution
            // 
            txtInstitution.Font = new Font("Segoe UI", 20F);
            txtInstitution.ForeColor = Color.FromArgb(192, 192, 255);
            txtInstitution.Location = new Point(308, 181);
            txtInstitution.Name = "txtInstitution";
            txtInstitution.PlaceholderText = "Input Institution";
            txtInstitution.Size = new Size(555, 52);
            txtInstitution.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("SimSun-ExtG", 20F, FontStyle.Bold);
            btnSave.ForeColor = Color.DarkRed;
            btnSave.Location = new Point(891, 104);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(97, 52);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(32, 256);
            dgvData.Name = "dgvData";
            dgvData.RowHeadersWidth = 51;
            dgvData.Size = new Size(768, 258);
            dgvData.TabIndex = 6;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(894, 181);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 52);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(891, 256);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 45);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1023, 557);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(dgvData);
            Controls.Add(btnSave);
            Controls.Add(txtInstitution);
            Controls.Add(label1);
            Controls.Add(textBoxName);
            Controls.Add(lblName);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private TextBox textBoxName;
        private Label label1;
        private TextBox txtInstitution;
        private Button btnSave;
        private DataGridView dgvData;
        private Button btnUpdate;
        private Button btnDelete;
    }
}
