namespace testWorkFinTeh
{
    partial class fMain
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
            butFirst = new Button();
            butSecond = new Button();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // butFirst
            // 
            butFirst.Location = new Point(12, 12);
            butFirst.Name = "butFirst";
            butFirst.Size = new Size(75, 23);
            butFirst.TabIndex = 1;
            butFirst.Text = "1 Задание";
            butFirst.UseVisualStyleBackColor = true;
            butFirst.Click += butFirst_Click;
            // 
            // butSecond
            // 
            butSecond.Location = new Point(12, 41);
            butSecond.Name = "butSecond";
            butSecond.Size = new Size(75, 23);
            butSecond.TabIndex = 2;
            butSecond.Text = "2 Задание";
            butSecond.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Location = new Point(93, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(454, 564);
            panel1.TabIndex = 3;
            // 
            // fMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 566);
            Controls.Add(panel1);
            Controls.Add(butSecond);
            Controls.Add(butFirst);
            Name = "fMain";
            Text = "Тестовое задание для Фин-Тех";
            ResumeLayout(false);
        }

        #endregion
        private Button butFirst;
        private Button butSecond;
        private Panel panel1;
    }
}