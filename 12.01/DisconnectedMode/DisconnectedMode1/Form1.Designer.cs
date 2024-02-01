namespace DisconnectedMode1
{
    partial class DataBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataBase));
            tableLayoutPanel1 = new TableLayoutPanel();
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            saveBtn = new Button();
            deleteBtn = new Button();
            addBtn = new Button();
            getAllDataBtn = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(comboBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(dataGridView1, 0, 1);
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.66666651F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 93.3333359F));
            tableLayoutPanel1.Size = new Size(831, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.Dock = DockStyle.Fill;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(3, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(409, 23);
            comboBox1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel1.SetColumnSpan(dataGridView1, 2);
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 33);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(825, 414);
            dataGridView1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(saveBtn);
            panel1.Controls.Add(deleteBtn);
            panel1.Controls.Add(addBtn);
            panel1.Controls.Add(getAllDataBtn);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(418, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(410, 24);
            panel1.TabIndex = 2;
            // 
            // saveBtn
            // 
            saveBtn.Dock = DockStyle.Left;
            saveBtn.Location = new Point(294, 0);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(75, 24);
            saveBtn.TabIndex = 3;
            saveBtn.Text = "Сохранить";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Dock = DockStyle.Left;
            deleteBtn.Location = new Point(219, 0);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(75, 24);
            deleteBtn.TabIndex = 2;
            deleteBtn.Text = "Удалить";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // addBtn
            // 
            addBtn.Dock = DockStyle.Left;
            addBtn.Location = new Point(144, 0);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(75, 24);
            addBtn.TabIndex = 1;
            addBtn.Text = "Добавить";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // getAllDataBtn
            // 
            getAllDataBtn.Dock = DockStyle.Left;
            getAllDataBtn.Location = new Point(0, 0);
            getAllDataBtn.Name = "getAllDataBtn";
            getAllDataBtn.Size = new Size(144, 24);
            getAllDataBtn.TabIndex = 0;
            getAllDataBtn.Text = "Получить все данные";
            getAllDataBtn.UseVisualStyleBackColor = true;
            getAllDataBtn.Click += getAllDataBtn_Click;
            // 
            // DataBase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 450);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DataBase";
            Text = "База данных";
            Load += DataBase_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Button saveBtn;
        private Button deleteBtn;
        private Button addBtn;
        private Button getAllDataBtn;
    }
}
