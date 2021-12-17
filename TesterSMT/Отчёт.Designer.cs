namespace TesterSMT
{
    partial class Counter
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
            this.GridPos = new System.Windows.Forms.DataGridView();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.BtOK = new System.Windows.Forms.Button();
            this.До = new System.Windows.Forms.DateTimePicker();
            this.От = new System.Windows.Forms.DateTimePicker();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.UserCombo = new System.Windows.Forms.ComboBox();
            this.GridRem = new System.Windows.Forms.DataGridView();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.СписокИмён = new System.Windows.Forms.DataGridView();
            this.Counters = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridPos)).BeginInit();
            this.GroupBox3.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridRem)).BeginInit();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.СписокИмён)).BeginInit();
            this.SuspendLayout();
            // 
            // GridPos
            // 
            this.GridPos.AllowUserToAddRows = false;
            this.GridPos.AllowUserToDeleteRows = false;
            this.GridPos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridPos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.GridPos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridPos.EnableHeadersVisualStyles = false;
            this.GridPos.Location = new System.Drawing.Point(6, 36);
            this.GridPos.Name = "GridPos";
            this.GridPos.ReadOnly = true;
            this.GridPos.RowHeadersVisible = false;
            this.GridPos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridPos.Size = new System.Drawing.Size(187, 194);
            this.GridPos.TabIndex = 4;
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.GridPos);
            this.GroupBox3.Controls.Add(this.Label6);
            this.GroupBox3.Location = new System.Drawing.Point(5, 207);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(200, 242);
            this.GroupBox3.TabIndex = 14;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Visible = false;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(4, 15);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(70, 13);
            this.Label6.TabIndex = 1;
            this.Label6.Text = "Топ отказов";
            // 
            // GroupBox2
            // 
            this.GroupBox2.BackColor = System.Drawing.Color.White;
            this.GroupBox2.Controls.Add(this.BtOK);
            this.GroupBox2.Controls.Add(this.До);
            this.GroupBox2.Controls.Add(this.От);
            this.GroupBox2.Controls.Add(this.Label3);
            this.GroupBox2.Controls.Add(this.Label4);
            this.GroupBox2.Controls.Add(this.Label5);
            this.GroupBox2.Location = new System.Drawing.Point(12, 12);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(193, 141);
            this.GroupBox2.TabIndex = 13;
            this.GroupBox2.TabStop = false;
            // 
            // BtOK
            // 
            this.BtOK.BackColor = System.Drawing.Color.LightSalmon;
            this.BtOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtOK.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtOK.Location = new System.Drawing.Point(46, 104);
            this.BtOK.Name = "BtOK";
            this.BtOK.Size = new System.Drawing.Size(141, 31);
            this.BtOK.TabIndex = 4;
            this.BtOK.Text = "Сформировать";
            this.BtOK.UseVisualStyleBackColor = false;
            this.BtOK.Click += new System.EventHandler(this.BtOK_Click);
            // 
            // До
            // 
            this.До.CustomFormat = "dd.MM.yyyy";
            this.До.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.До.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.До.Location = new System.Drawing.Point(46, 69);
            this.До.Name = "До";
            this.До.Size = new System.Drawing.Size(139, 29);
            this.До.TabIndex = 3;
            this.До.Value = new System.DateTime(2019, 7, 12, 0, 0, 0, 0);
            // 
            // От
            // 
            this.От.CustomFormat = "dd.MM.yyyy";
            this.От.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.От.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.От.Location = new System.Drawing.Point(46, 34);
            this.От.Name = "От";
            this.От.Size = new System.Drawing.Size(139, 29);
            this.От.TabIndex = 3;
            this.От.Value = new System.DateTime(2019, 7, 12, 0, 0, 0, 0);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label3.Location = new System.Drawing.Point(8, 71);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(32, 20);
            this.Label3.TabIndex = 2;
            this.Label3.Text = "До";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label4.Location = new System.Drawing.Point(8, 41);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(32, 20);
            this.Label4.TabIndex = 2;
            this.Label4.Text = "От";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label5.Location = new System.Drawing.Point(6, 13);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(160, 20);
            this.Label5.TabIndex = 2;
            this.Label5.Text = "Выберите период";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label2.Location = new System.Drawing.Point(213, 12);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(186, 20);
            this.Label2.TabIndex = 11;
            this.Label2.Text = "Отсканировано плат";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(9, 156);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(114, 13);
            this.Label1.TabIndex = 9;
            this.Label1.Text = "Выбор пользователя";
            // 
            // UserCombo
            // 
            this.UserCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserCombo.FormattingEnabled = true;
            this.UserCombo.Location = new System.Drawing.Point(10, 175);
            this.UserCombo.Name = "UserCombo";
            this.UserCombo.Size = new System.Drawing.Size(195, 26);
            this.UserCombo.TabIndex = 10;
            this.UserCombo.TabStop = false;
            // 
            // GridRem
            // 
            this.GridRem.AllowUserToAddRows = false;
            this.GridRem.AllowUserToDeleteRows = false;
            this.GridRem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GridRem.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.GridRem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridRem.EnableHeadersVisualStyles = false;
            this.GridRem.Location = new System.Drawing.Point(6, 19);
            this.GridRem.Name = "GridRem";
            this.GridRem.ReadOnly = true;
            this.GridRem.RowHeadersVisible = false;
            this.GridRem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridRem.Size = new System.Drawing.Size(671, 440);
            this.GridRem.TabIndex = 4;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.GridRem);
            this.GroupBox1.Location = new System.Drawing.Point(211, 35);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(683, 465);
            this.GroupBox1.TabIndex = 8;
            this.GroupBox1.TabStop = false;
            // 
            // СписокИмён
            // 
            this.СписокИмён.AllowUserToAddRows = false;
            this.СписокИмён.AllowUserToDeleteRows = false;
            this.СписокИмён.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.СписокИмён.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.СписокИмён.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.СписокИмён.EnableHeadersVisualStyles = false;
            this.СписокИмён.Location = new System.Drawing.Point(1028, 133);
            this.СписокИмён.Name = "СписокИмён";
            this.СписокИмён.ReadOnly = true;
            this.СписокИмён.RowHeadersVisible = false;
            this.СписокИмён.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.СписокИмён.Size = new System.Drawing.Size(187, 194);
            this.СписокИмён.TabIndex = 4;
            this.СписокИмён.Visible = false;
            // 
            // Counters
            // 
            this.Counters.AutoSize = true;
            this.Counters.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Counters.Location = new System.Drawing.Point(396, 12);
            this.Counters.Name = "Counters";
            this.Counters.Size = new System.Drawing.Size(38, 20);
            this.Counters.TabIndex = 11;
            this.Counters.Text = "N/A";
            // 
            // Counter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 516);
            this.Controls.Add(this.СписокИмён);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.Counters);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.UserCombo);
            this.Controls.Add(this.GroupBox1);
            this.Name = "Counter";
            this.Text = "Отчёт";
            this.Load += new System.EventHandler(this.Отчёт_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridPos)).EndInit();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridRem)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.СписокИмён)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView GridPos;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Button BtOK;
        internal System.Windows.Forms.DateTimePicker До;
        internal System.Windows.Forms.DateTimePicker От;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ComboBox UserCombo;
        internal System.Windows.Forms.DataGridView GridRem;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.DataGridView СписокИмён;
        internal System.Windows.Forms.Label Counters;
    }
}