namespace MySql_Crud
{
    partial class FormStudent
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
            panel1 = new Panel();
            lblText = new Label();
            panel2 = new Panel();
            txtSinhalaText = new TextBox();
            lblSinhalaText = new Label();
            btnSave = new Button();
            txtSection = new TextBox();
            label4 = new Label();
            txtClass = new TextBox();
            Class = new Label();
            txtReg = new TextBox();
            label2 = new Label();
            txtName = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(160, 113, 255);
            panel1.Controls.Add(lblText);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(701, 150);
            panel1.TabIndex = 0;
            // 
            // lblText
            // 
            lblText.AutoSize = true;
            lblText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblText.ForeColor = Color.White;
            lblText.Location = new Point(53, 53);
            lblText.Name = "lblText";
            lblText.Size = new Size(122, 28);
            lblText.TabIndex = 0;
            lblText.Text = "Add Student";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(txtSinhalaText);
            panel2.Controls.Add(lblSinhalaText);
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(txtSection);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtClass);
            panel2.Controls.Add(Class);
            panel2.Controls.Add(txtReg);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtName);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(53, 183);
            panel2.Name = "panel2";
            panel2.Size = new Size(565, 525);
            panel2.TabIndex = 0;
            // 
            // txtSinhalaText
            // 
            txtSinhalaText.Location = new Point(50, 147);
            txtSinhalaText.Name = "txtSinhalaText";
            txtSinhalaText.Size = new Size(446, 27);
            txtSinhalaText.TabIndex = 7;
            // 
            // lblSinhalaText
            // 
            lblSinhalaText.AutoSize = true;
            lblSinhalaText.Location = new Point(50, 114);
            lblSinhalaText.Name = "lblSinhalaText";
            lblSinhalaText.Size = new Size(96, 20);
            lblSinhalaText.TabIndex = 6;
            lblSinhalaText.Text = "සිංහල නම  ";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(160, 113, 255);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(49, 449);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(116, 47);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtSection
            // 
            txtSection.Location = new Point(49, 404);
            txtSection.Name = "txtSection";
            txtSection.Size = new Size(446, 27);
            txtSection.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 368);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 0;
            label4.Text = "Section :";
            // 
            // txtClass
            // 
            txtClass.Location = new Point(49, 313);
            txtClass.Name = "txtClass";
            txtClass.Size = new Size(446, 27);
            txtClass.TabIndex = 3;
            // 
            // Class
            // 
            Class.AutoSize = true;
            Class.Location = new Point(50, 273);
            Class.Name = "Class";
            Class.Size = new Size(49, 20);
            Class.TabIndex = 0;
            Class.Text = "Class :";
            // 
            // txtReg
            // 
            txtReg.Location = new Point(49, 229);
            txtReg.Name = "txtReg";
            txtReg.Size = new Size(446, 27);
            txtReg.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 189);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 0;
            label2.Text = "Reg. :";
            // 
            // txtName
            // 
            txtName.Location = new Point(49, 68);
            txtName.Name = "txtName";
            txtName.Size = new Size(446, 27);
            txtName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 35);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 0;
            label1.Text = "Name :";
            // 
            // FormStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(701, 736);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FormStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblText;
        private Panel panel2;
        private TextBox txtName;
        private Label label1;
        private TextBox txtClass;
        private Label Class;
        private TextBox txtReg;
        private Label label2;
        private TextBox txtSection;
        private Label label4;
        private Button btnSave;
        private Label lblSinhalaText;
        private TextBox txtSinhalaText;
    }
}