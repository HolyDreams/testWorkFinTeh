namespace testWorkFinTeh.Pages
{
    partial class pWorkers
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
            dataGridView1 = new DataGridView();
            butAdd = new Button();
            butDel = new Button();
            comboDate = new ComboBox();
            labelDate = new Label();
            textSearch = new TextBox();
            labelSearch = new Label();
            butEdit = new Button();
            butRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.Location = new Point(0, 46);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1086, 689);
            dataGridView1.TabIndex = 0;
            // 
            // butAdd
            // 
            butAdd.Location = new Point(13, 17);
            butAdd.Name = "butAdd";
            butAdd.Size = new Size(108, 23);
            butAdd.TabIndex = 1;
            butAdd.Text = "Добавить";
            butAdd.UseVisualStyleBackColor = true;
            butAdd.Click += butAdd_Click;
            // 
            // butDel
            // 
            butDel.Location = new Point(241, 17);
            butDel.Name = "butDel";
            butDel.Size = new Size(108, 23);
            butDel.TabIndex = 4;
            butDel.Text = "Удалить";
            butDel.UseVisualStyleBackColor = true;
            butDel.Click += butDel_Click;
            // 
            // comboDate
            // 
            comboDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboDate.FormattingEnabled = true;
            comboDate.Location = new Point(911, 17);
            comboDate.Name = "comboDate";
            comboDate.Size = new Size(172, 23);
            comboDate.TabIndex = 5;
            comboDate.SelectedIndexChanged += comboDate_SelectedIndexChanged;
            // 
            // labelDate
            // 
            labelDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelDate.AutoSize = true;
            labelDate.Location = new Point(816, 21);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(89, 15);
            labelDate.TabIndex = 6;
            labelDate.Text = "Месяц отпуска";
            // 
            // textSearch
            // 
            textSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textSearch.Location = new Point(568, 17);
            textSearch.Name = "textSearch";
            textSearch.Size = new Size(207, 23);
            textSearch.TabIndex = 7;
            textSearch.TextChanged += textSearch_TextChanged;
            // 
            // labelSearch
            // 
            labelSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelSearch.AutoSize = true;
            labelSearch.Location = new Point(520, 20);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(42, 15);
            labelSearch.TabIndex = 8;
            labelSearch.Text = "Поиск";
            // 
            // butEdit
            // 
            butEdit.Location = new Point(127, 17);
            butEdit.Name = "butEdit";
            butEdit.Size = new Size(108, 23);
            butEdit.TabIndex = 9;
            butEdit.Text = "Редактировать";
            butEdit.UseVisualStyleBackColor = true;
            butEdit.Click += butEdit_Click;
            // 
            // butRefresh
            // 
            butRefresh.Location = new Point(355, 17);
            butRefresh.Name = "butRefresh";
            butRefresh.Size = new Size(108, 23);
            butRefresh.TabIndex = 10;
            butRefresh.Text = "Обновить";
            butRefresh.UseVisualStyleBackColor = true;
            butRefresh.Click += butRefresh_Click;
            // 
            // pWorkers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(butRefresh);
            Controls.Add(butEdit);
            Controls.Add(labelSearch);
            Controls.Add(textSearch);
            Controls.Add(labelDate);
            Controls.Add(comboDate);
            Controls.Add(butDel);
            Controls.Add(butAdd);
            Controls.Add(dataGridView1);
            Name = "pWorkers";
            Size = new Size(1086, 735);
            Load += pWorkers_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button butAdd;
        private Button butDel;
        private ComboBox comboDate;
        private Label labelDate;
        private TextBox textSearch;
        private Label labelSearch;
        private Button butEdit;
        private Button butRefresh;
    }
}
