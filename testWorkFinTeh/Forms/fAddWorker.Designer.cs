namespace testWorkFinTeh.Forms
{
    partial class fAddWorker
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
            labelFirstName = new Label();
            textFirstName = new TextBox();
            textMidName = new TextBox();
            labelMidName = new Label();
            textLastName = new TextBox();
            labelLastName = new Label();
            butSave = new Button();
            comboRole = new ComboBox();
            labelRole = new Label();
            labelDepart = new Label();
            comboDepart = new ComboBox();
            SuspendLayout();
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            labelFirstName.Location = new Point(16, 16);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(105, 28);
            labelFirstName.TabIndex = 0;
            labelFirstName.Text = "Фамилия";
            // 
            // textFirstName
            // 
            textFirstName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textFirstName.Location = new Point(16, 49);
            textFirstName.Name = "textFirstName";
            textFirstName.Size = new Size(330, 32);
            textFirstName.TabIndex = 1;
            // 
            // textMidName
            // 
            textMidName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textMidName.Location = new Point(16, 126);
            textMidName.Name = "textMidName";
            textMidName.Size = new Size(330, 32);
            textMidName.TabIndex = 3;
            // 
            // labelMidName
            // 
            labelMidName.AutoSize = true;
            labelMidName.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            labelMidName.Location = new Point(16, 93);
            labelMidName.Name = "labelMidName";
            labelMidName.Size = new Size(55, 28);
            labelMidName.TabIndex = 2;
            labelMidName.Text = "Имя";
            // 
            // textLastName
            // 
            textLastName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textLastName.Location = new Point(16, 205);
            textLastName.Name = "textLastName";
            textLastName.Size = new Size(330, 32);
            textLastName.TabIndex = 5;
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            labelLastName.Location = new Point(16, 172);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(102, 28);
            labelLastName.TabIndex = 4;
            labelLastName.Text = "Отчество";
            // 
            // butSave
            // 
            butSave.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            butSave.Location = new Point(114, 439);
            butSave.Name = "butSave";
            butSave.Size = new Size(128, 41);
            butSave.TabIndex = 6;
            butSave.Text = "Сохранить";
            butSave.UseVisualStyleBackColor = true;
            butSave.Click += butSave_Click;
            // 
            // comboRole
            // 
            comboRole.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboRole.FormattingEnabled = true;
            comboRole.Location = new Point(16, 298);
            comboRole.Name = "comboRole";
            comboRole.Size = new Size(330, 33);
            comboRole.TabIndex = 7;
            comboRole.KeyPress += comboRole_KeyPress;
            // 
            // labelRole
            // 
            labelRole.AutoSize = true;
            labelRole.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            labelRole.Location = new Point(16, 257);
            labelRole.Name = "labelRole";
            labelRole.Size = new Size(123, 28);
            labelRole.TabIndex = 8;
            labelRole.Text = "Должность";
            // 
            // labelDepart
            // 
            labelDepart.AutoSize = true;
            labelDepart.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            labelDepart.Location = new Point(16, 344);
            labelDepart.Name = "labelDepart";
            labelDepart.Size = new Size(71, 28);
            labelDepart.TabIndex = 10;
            labelDepart.Text = "Отдел";
            // 
            // comboDepart
            // 
            comboDepart.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboDepart.FormattingEnabled = true;
            comboDepart.Location = new Point(16, 385);
            comboDepart.Name = "comboDepart";
            comboDepart.Size = new Size(330, 33);
            comboDepart.TabIndex = 9;
            comboDepart.KeyPress += comboDepart_KeyPress;
            // 
            // fAddWorker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 492);
            Controls.Add(labelDepart);
            Controls.Add(comboDepart);
            Controls.Add(labelRole);
            Controls.Add(comboRole);
            Controls.Add(butSave);
            Controls.Add(textLastName);
            Controls.Add(labelLastName);
            Controls.Add(textMidName);
            Controls.Add(labelMidName);
            Controls.Add(textFirstName);
            Controls.Add(labelFirstName);
            Name = "fAddWorker";
            Text = "fAddWorker";
            Load += fAddWorker_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelFirstName;
        private TextBox textFirstName;
        private TextBox textMidName;
        private Label labelMidName;
        private TextBox textLastName;
        private Label labelLastName;
        private Button butSave;
        private ComboBox comboRole;
        private Label labelRole;
        private Label labelDepart;
        private ComboBox comboDepart;
    }
}