namespace testWorkFinTeh
{
    partial class pPrint
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            textX1 = new TextBox();
            labelX1 = new Label();
            labelY1 = new Label();
            textY1 = new TextBox();
            labelX2 = new Label();
            textX2 = new TextBox();
            labelY2 = new Label();
            textY2 = new TextBox();
            labelR = new Label();
            textR = new TextBox();
            labelCount = new Label();
            textCount = new TextBox();
            butSide = new Button();
            butPrint = new Button();
            labelSide = new Label();
            panelMain = new Panel();
            SuspendLayout();
            // 
            // textX1
            // 
            textX1.BorderStyle = BorderStyle.FixedSingle;
            textX1.Location = new Point(24, 38);
            textX1.Name = "textX1";
            textX1.Size = new Size(57, 23);
            textX1.TabIndex = 0;
            textX1.KeyPress += textX1_KeyPress;
            // 
            // labelX1
            // 
            labelX1.AutoSize = true;
            labelX1.Location = new Point(42, 20);
            labelX1.Name = "labelX1";
            labelX1.Size = new Size(20, 15);
            labelX1.TabIndex = 1;
            labelX1.Text = "X1";
            // 
            // labelY1
            // 
            labelY1.AutoSize = true;
            labelY1.Location = new Point(105, 20);
            labelY1.Name = "labelY1";
            labelY1.Size = new Size(20, 15);
            labelY1.TabIndex = 3;
            labelY1.Text = "Y1";
            // 
            // textY1
            // 
            textY1.BorderStyle = BorderStyle.FixedSingle;
            textY1.Location = new Point(87, 38);
            textY1.Name = "textY1";
            textY1.Size = new Size(57, 23);
            textY1.TabIndex = 2;
            textY1.KeyPress += textX1_KeyPress;
            // 
            // labelX2
            // 
            labelX2.AutoSize = true;
            labelX2.Location = new Point(168, 20);
            labelX2.Name = "labelX2";
            labelX2.Size = new Size(20, 15);
            labelX2.TabIndex = 5;
            labelX2.Text = "X2";
            // 
            // textX2
            // 
            textX2.BorderStyle = BorderStyle.FixedSingle;
            textX2.Location = new Point(150, 38);
            textX2.Name = "textX2";
            textX2.Size = new Size(57, 23);
            textX2.TabIndex = 4;
            textX2.KeyPress += textX1_KeyPress;
            // 
            // labelY2
            // 
            labelY2.AutoSize = true;
            labelY2.Location = new Point(231, 20);
            labelY2.Name = "labelY2";
            labelY2.Size = new Size(20, 15);
            labelY2.TabIndex = 7;
            labelY2.Text = "Y2";
            // 
            // textY2
            // 
            textY2.BorderStyle = BorderStyle.FixedSingle;
            textY2.Location = new Point(213, 38);
            textY2.Name = "textY2";
            textY2.Size = new Size(57, 23);
            textY2.TabIndex = 6;
            textY2.KeyPress += textX1_KeyPress;
            // 
            // labelR
            // 
            labelR.AutoSize = true;
            labelR.Location = new Point(298, 20);
            labelR.Name = "labelR";
            labelR.Size = new Size(14, 15);
            labelR.TabIndex = 9;
            labelR.Text = "R";
            // 
            // textR
            // 
            textR.BorderStyle = BorderStyle.FixedSingle;
            textR.Location = new Point(276, 38);
            textR.Name = "textR";
            textR.Size = new Size(57, 23);
            textR.TabIndex = 8;
            textR.KeyPress += textX1_KeyPress;
            // 
            // labelCount
            // 
            labelCount.AutoSize = true;
            labelCount.Location = new Point(32, 75);
            labelCount.Name = "labelCount";
            labelCount.Size = new Size(80, 15);
            labelCount.TabIndex = 11;
            labelCount.Text = "Кол-во точек";
            // 
            // textCount
            // 
            textCount.BorderStyle = BorderStyle.FixedSingle;
            textCount.Location = new Point(42, 93);
            textCount.Name = "textCount";
            textCount.Size = new Size(57, 23);
            textCount.TabIndex = 10;
            textCount.KeyPress += textX1_KeyPress;
            // 
            // butSide
            // 
            butSide.Location = new Point(132, 93);
            butSide.Name = "butSide";
            butSide.Size = new Size(75, 23);
            butSide.TabIndex = 12;
            butSide.Text = "Left";
            butSide.UseVisualStyleBackColor = true;
            butSide.Click += butSide_Click;
            // 
            // butPrint
            // 
            butPrint.Location = new Point(331, 91);
            butPrint.Name = "butPrint";
            butPrint.Size = new Size(93, 23);
            butPrint.TabIndex = 13;
            butPrint.Text = "Нарисовать";
            butPrint.UseVisualStyleBackColor = true;
            butPrint.Click += butPrint_Click;
            // 
            // labelSide
            // 
            labelSide.AutoSize = true;
            labelSide.Location = new Point(143, 75);
            labelSide.Name = "labelSide";
            labelSide.Size = new Size(54, 15);
            labelSide.TabIndex = 14;
            labelSide.Text = "Сторона";
            // 
            // panelMain
            // 
            panelMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelMain.BorderStyle = BorderStyle.FixedSingle;
            panelMain.Location = new Point(24, 133);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(400, 400);
            panelMain.TabIndex = 15;
            panelMain.Paint += panelMain_Paint;
            // 
            // pPrint
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelMain);
            Controls.Add(labelSide);
            Controls.Add(butPrint);
            Controls.Add(butSide);
            Controls.Add(labelCount);
            Controls.Add(textCount);
            Controls.Add(labelR);
            Controls.Add(textR);
            Controls.Add(labelY2);
            Controls.Add(textY2);
            Controls.Add(labelX2);
            Controls.Add(textX2);
            Controls.Add(labelY1);
            Controls.Add(textY1);
            Controls.Add(labelX1);
            Controls.Add(textX1);
            Name = "pPrint";
            Size = new Size(454, 564);
            Resize += pPrint_Resize;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textX1;
        private Label labelX1;
        private Label labelY1;
        private TextBox textY1;
        private Label labelX2;
        private TextBox textX2;
        private Label labelY2;
        private TextBox textY2;
        private Label labelR;
        private TextBox textR;
        private Label labelCount;
        private TextBox textCount;
        private Button butSide;
        private Button butPrint;
        private Label labelSide;
        private Panel panelMain;
    }
}
