namespace TesterSMT
{
    partial class ПерваяФорма
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Label4 = new System.Windows.Forms.Label();
            this.Update = new System.Windows.Forms.Label();
            this.DG_Packing = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Дата = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Инфо = new System.Windows.Forms.GroupBox();
            this.Label21 = new System.Windows.Forms.Label();
            this.NickLabel = new System.Windows.Forms.Label();
            this.ЛоггинКнопка = new System.Windows.Forms.Button();
            this.SNTbox = new System.Windows.Forms.TextBox();
            this.ВводНомера = new System.Windows.Forms.GroupBox();
            this.CloseSN = new System.Windows.Forms.Button();
            this.LogGrid = new System.Windows.Forms.DataGridView();
            this.RFIDTB = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Вход = new System.Windows.Forms.GroupBox();
            this.Pass = new System.Windows.Forms.Button();
            this.Fail = new System.Windows.Forms.Button();
            this.FailPass = new System.Windows.Forms.GroupBox();
            this.FAILBT = new System.Windows.Forms.RadioButton();
            this.PASSBT = new System.Windows.Forms.RadioButton();
            this.FAILGROUP = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Description = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboError = new System.Windows.Forms.ComboBox();
            this.ErrorGrid = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.UnitCheck = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Packing)).BeginInit();
            this.Инфо.SuspendLayout();
            this.ВводНомера.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogGrid)).BeginInit();
            this.Вход.SuspendLayout();
            this.FailPass.SuspendLayout();
            this.FAILGROUP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label4.Location = new System.Drawing.Point(12, 189);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(0, 29);
            this.Label4.TabIndex = 57;
            // 
            // Update
            // 
            this.Update.AutoSize = true;
            this.Update.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.Update.Location = new System.Drawing.Point(12, 264);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(53, 20);
            this.Update.TabIndex = 61;
            this.Update.Text = "Label";
            // 
            // DG_Packing
            // 
            this.DG_Packing.AllowUserToAddRows = false;
            this.DG_Packing.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.DG_Packing.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DG_Packing.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DG_Packing.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DG_Packing.BackgroundColor = System.Drawing.Color.Goldenrod;
            this.DG_Packing.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_Packing.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DG_Packing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Packing.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Status,
            this.Дата,
            this.Column2,
            this.Column3,
            this.DE});
            this.DG_Packing.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DG_Packing.DefaultCellStyle = dataGridViewCellStyle3;
            this.DG_Packing.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DG_Packing.Location = new System.Drawing.Point(12, 287);
            this.DG_Packing.Name = "DG_Packing";
            this.DG_Packing.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_Packing.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DG_Packing.Size = new System.Drawing.Size(987, 405);
            this.DG_Packing.TabIndex = 60;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "TRID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 74;
            // 
            // Status
            // 
            this.Status.HeaderText = "Статус";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 87;
            // 
            // Дата
            // 
            this.Дата.HeaderText = "Дата";
            this.Дата.Name = "Дата";
            this.Дата.ReadOnly = true;
            this.Дата.Width = 73;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Пользователь";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "ErrorCode";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 113;
            // 
            // DE
            // 
            this.DE.HeaderText = "Description";
            this.DE.Name = "DE";
            this.DE.ReadOnly = true;
            this.DE.Width = 126;
            // 
            // Инфо
            // 
            this.Инфо.Controls.Add(this.Label21);
            this.Инфо.Controls.Add(this.NickLabel);
            this.Инфо.Controls.Add(this.ЛоггинКнопка);
            this.Инфо.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.Инфо.Location = new System.Drawing.Point(363, 12);
            this.Инфо.Name = "Инфо";
            this.Инфо.Size = new System.Drawing.Size(333, 54);
            this.Инфо.TabIndex = 59;
            this.Инфо.TabStop = false;
            this.Инфо.Text = "Информация";
            // 
            // Label21
            // 
            this.Label21.AutoSize = true;
            this.Label21.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label21.Location = new System.Drawing.Point(6, 22);
            this.Label21.Name = "Label21";
            this.Label21.Size = new System.Drawing.Size(170, 20);
            this.Label21.TabIndex = 19;
            this.Label21.Text = "Имя пользователя:";
            // 
            // NickLabel
            // 
            this.NickLabel.AutoSize = true;
            this.NickLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NickLabel.Location = new System.Drawing.Point(173, 24);
            this.NickLabel.Name = "NickLabel";
            this.NickLabel.Size = new System.Drawing.Size(57, 19);
            this.NickLabel.TabIndex = 5;
            this.NickLabel.Text = "Label1";
            // 
            // ЛоггинКнопка
            // 
            this.ЛоггинКнопка.BackColor = System.Drawing.Color.Transparent;
            this.ЛоггинКнопка.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.ЛоггинКнопка.FlatAppearance.BorderSize = 0;
            this.ЛоггинКнопка.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.ЛоггинКнопка.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.ЛоггинКнопка.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ЛоггинКнопка.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.ЛоггинКнопка.Image = global::TesterSMT.Properties.Resources.cancel_96921;
            this.ЛоггинКнопка.Location = new System.Drawing.Point(284, 11);
            this.ЛоггинКнопка.Name = "ЛоггинКнопка";
            this.ЛоггинКнопка.Size = new System.Drawing.Size(44, 38);
            this.ЛоггинКнопка.TabIndex = 64;
            this.ЛоггинКнопка.UseVisualStyleBackColor = false;
            this.ЛоггинКнопка.Click += new System.EventHandler(this.ЛоггинКнопка_Click);
            // 
            // SNTbox
            // 
            this.SNTbox.Location = new System.Drawing.Point(6, 29);
            this.SNTbox.MaxLength = 300;
            this.SNTbox.Name = "SNTbox";
            this.SNTbox.Size = new System.Drawing.Size(642, 23);
            this.SNTbox.TabIndex = 3;
            this.SNTbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SNTbox_KeyDown);
            // 
            // ВводНомера
            // 
            this.ВводНомера.Controls.Add(this.CloseSN);
            this.ВводНомера.Controls.Add(this.SNTbox);
            this.ВводНомера.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ВводНомера.Location = new System.Drawing.Point(12, 64);
            this.ВводНомера.Name = "ВводНомера";
            this.ВводНомера.Size = new System.Drawing.Size(708, 62);
            this.ВводНомера.TabIndex = 58;
            this.ВводНомера.TabStop = false;
            this.ВводНомера.Text = "Введите Серийный номер";
            // 
            // CloseSN
            // 
            this.CloseSN.BackColor = System.Drawing.Color.Transparent;
            this.CloseSN.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CloseSN.FlatAppearance.BorderSize = 0;
            this.CloseSN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.CloseSN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.CloseSN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseSN.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.CloseSN.Image = global::TesterSMT.Properties.Resources.cancel_96921;
            this.CloseSN.Location = new System.Drawing.Point(654, 18);
            this.CloseSN.Name = "CloseSN";
            this.CloseSN.Size = new System.Drawing.Size(44, 38);
            this.CloseSN.TabIndex = 67;
            this.CloseSN.UseVisualStyleBackColor = false;
            this.CloseSN.Click += new System.EventHandler(this.button2_Click);
            // 
            // LogGrid
            // 
            this.LogGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LogGrid.Location = new System.Drawing.Point(1166, 533);
            this.LogGrid.Name = "LogGrid";
            this.LogGrid.Size = new System.Drawing.Size(128, 46);
            this.LogGrid.TabIndex = 56;
            this.LogGrid.Visible = false;
            // 
            // RFIDTB
            // 
            this.RFIDTB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.RFIDTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RFIDTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RFIDTB.Location = new System.Drawing.Point(84, 16);
            this.RFIDTB.Name = "RFIDTB";
            this.RFIDTB.PasswordChar = '*';
            this.RFIDTB.Size = new System.Drawing.Size(233, 21);
            this.RFIDTB.TabIndex = 1;
            this.RFIDTB.Tag = "1";
            this.RFIDTB.UseSystemPasswordChar = true;
            this.RFIDTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RFIDTB_KeyDown);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label2.Location = new System.Drawing.Point(6, 17);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(72, 20);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Логин :";
            // 
            // Вход
            // 
            this.Вход.Controls.Add(this.RFIDTB);
            this.Вход.Controls.Add(this.Label2);
            this.Вход.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.Вход.Location = new System.Drawing.Point(12, 9);
            this.Вход.Name = "Вход";
            this.Вход.Size = new System.Drawing.Size(345, 49);
            this.Вход.TabIndex = 55;
            this.Вход.TabStop = false;
            this.Вход.Text = "Войти";
            // 
            // Pass
            // 
            this.Pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Pass.FlatAppearance.BorderSize = 0;
            this.Pass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Pass.Location = new System.Drawing.Point(832, 12);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(91, 30);
            this.Pass.TabIndex = 65;
            this.Pass.Text = "PASS Кнопка \"Y\"";
            this.Pass.UseVisualStyleBackColor = false;
            this.Pass.Visible = false;
            this.Pass.Click += new System.EventHandler(this.Pass_Click);
            // 
            // Fail
            // 
            this.Fail.BackColor = System.Drawing.Color.Red;
            this.Fail.FlatAppearance.BorderSize = 0;
            this.Fail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Fail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Fail.Location = new System.Drawing.Point(929, 12);
            this.Fail.Name = "Fail";
            this.Fail.Size = new System.Drawing.Size(70, 30);
            this.Fail.TabIndex = 65;
            this.Fail.Text = "FAIL Кнопка \"N\"";
            this.Fail.UseVisualStyleBackColor = false;
            this.Fail.Visible = false;
            this.Fail.Click += new System.EventHandler(this.Fail_Click);
            // 
            // FailPass
            // 
            this.FailPass.BackColor = System.Drawing.SystemColors.ControlLight;
            this.FailPass.Controls.Add(this.FAILBT);
            this.FailPass.Controls.Add(this.PASSBT);
            this.FailPass.Enabled = false;
            this.FailPass.Location = new System.Drawing.Point(12, 132);
            this.FailPass.Name = "FailPass";
            this.FailPass.Size = new System.Drawing.Size(234, 120);
            this.FailPass.TabIndex = 66;
            this.FailPass.TabStop = false;
            // 
            // FAILBT
            // 
            this.FAILBT.AutoSize = true;
            this.FAILBT.BackColor = System.Drawing.Color.Red;
            this.FAILBT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.FAILBT.FlatAppearance.BorderSize = 5;
            this.FAILBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FAILBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FAILBT.ForeColor = System.Drawing.Color.Black;
            this.FAILBT.Location = new System.Drawing.Point(124, 38);
            this.FAILBT.Name = "FAILBT";
            this.FAILBT.Size = new System.Drawing.Size(93, 37);
            this.FAILBT.TabIndex = 0;
            this.FAILBT.TabStop = true;
            this.FAILBT.Text = "FAIL";
            this.FAILBT.UseVisualStyleBackColor = false;
            this.FAILBT.CheckedChanged += new System.EventHandler(this.FAILBT_CheckedChanged);
            // 
            // PASSBT
            // 
            this.PASSBT.AutoSize = true;
            this.PASSBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.PASSBT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.PASSBT.FlatAppearance.BorderSize = 5;
            this.PASSBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PASSBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PASSBT.ForeColor = System.Drawing.Color.Black;
            this.PASSBT.Location = new System.Drawing.Point(10, 38);
            this.PASSBT.Name = "PASSBT";
            this.PASSBT.Size = new System.Drawing.Size(108, 37);
            this.PASSBT.TabIndex = 0;
            this.PASSBT.TabStop = true;
            this.PASSBT.Text = "PASS";
            this.PASSBT.UseVisualStyleBackColor = false;
            // 
            // FAILGROUP
            // 
            this.FAILGROUP.BackColor = System.Drawing.Color.Gainsboro;
            this.FAILGROUP.Controls.Add(this.button2);
            this.FAILGROUP.Controls.Add(this.Description);
            this.FAILGROUP.Controls.Add(this.label3);
            this.FAILGROUP.Controls.Add(this.label1);
            this.FAILGROUP.Controls.Add(this.ComboError);
            this.FAILGROUP.Location = new System.Drawing.Point(252, 132);
            this.FAILGROUP.Name = "FAILGROUP";
            this.FAILGROUP.Size = new System.Drawing.Size(381, 120);
            this.FAILGROUP.TabIndex = 67;
            this.FAILGROUP.TabStop = false;
            this.FAILGROUP.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.OldLace;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(231, 91);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "OK - Кнопка \"ctrl + Enter\"";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(132, 24);
            this.Description.MaxLength = 1200;
            this.Description.Multiline = true;
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(243, 62);
            this.Description.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F);
            this.label3.Location = new System.Drawing.Point(128, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Описание";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F);
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Код Ошибки";
            // 
            // ComboError
            // 
            this.ComboError.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComboError.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComboError.FormattingEnabled = true;
            this.ComboError.Location = new System.Drawing.Point(7, 25);
            this.ComboError.Name = "ComboError";
            this.ComboError.Size = new System.Drawing.Size(121, 24);
            this.ComboError.TabIndex = 0;
            this.ComboError.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ComboError_KeyDown);
            this.ComboError.Leave += new System.EventHandler(this.ComboError_Leave);
            // 
            // ErrorGrid
            // 
            this.ErrorGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ErrorGrid.Location = new System.Drawing.Point(839, 93);
            this.ErrorGrid.Name = "ErrorGrid";
            this.ErrorGrid.Size = new System.Drawing.Size(240, 150);
            this.ErrorGrid.TabIndex = 68;
            this.ErrorGrid.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F);
            this.label5.Location = new System.Drawing.Point(725, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 19);
            this.label5.TabIndex = 70;
            this.label5.Text = "Отчёт";
            this.label5.Visible = false;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::TesterSMT.Properties.Resources.icons8_questions_50;
            this.button3.Location = new System.Drawing.Point(726, 64);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(51, 58);
            this.button3.TabIndex = 69;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Button1
            // 
            this.Button1.FlatAppearance.BorderSize = 0;
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button1.Image = global::TesterSMT.Properties.Resources.exit_closethesession_close_6317;
            this.Button1.Location = new System.Drawing.Point(953, 698);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(46, 38);
            this.Button1.TabIndex = 63;
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // UnitCheck
            // 
            this.UnitCheck.AutoSize = true;
            this.UnitCheck.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UnitCheck.Location = new System.Drawing.Point(639, 132);
            this.UnitCheck.Name = "UnitCheck";
            this.UnitCheck.Size = new System.Drawing.Size(178, 20);
            this.UnitCheck.TabIndex = 71;
            this.UnitCheck.Text = "Проверка в базе UNIT";
            this.UnitCheck.UseVisualStyleBackColor = true;
            // 
            // ПерваяФорма
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1011, 741);
            this.Controls.Add(this.UnitCheck);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Fail);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ErrorGrid);
            this.Controls.Add(this.FAILGROUP);
            this.Controls.Add(this.FailPass);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.DG_Packing);
            this.Controls.Add(this.Инфо);
            this.Controls.Add(this.ВводНомера);
            this.Controls.Add(this.LogGrid);
            this.Controls.Add(this.Вход);
            this.KeyPreview = true;
            this.Name = "ПерваяФорма";
            this.Text = "TesterCaden";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.DG_Packing)).EndInit();
            this.Инфо.ResumeLayout(false);
            this.Инфо.PerformLayout();
            this.ВводНомера.ResumeLayout(false);
            this.ВводНомера.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogGrid)).EndInit();
            this.Вход.ResumeLayout(false);
            this.Вход.PerformLayout();
            this.FailPass.ResumeLayout(false);
            this.FailPass.PerformLayout();
            this.FAILGROUP.ResumeLayout(false);
            this.FAILGROUP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Button ЛоггинКнопка;
        internal System.Windows.Forms.Label Update;
        internal System.Windows.Forms.DataGridView DG_Packing;
        internal System.Windows.Forms.GroupBox Инфо;
        internal System.Windows.Forms.Label Label21;
        internal System.Windows.Forms.Label NickLabel;
        internal System.Windows.Forms.TextBox SNTbox;
        internal System.Windows.Forms.GroupBox ВводНомера;
        internal System.Windows.Forms.DataGridView LogGrid;
        internal System.Windows.Forms.TextBox RFIDTB;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.GroupBox Вход;
        private System.Windows.Forms.Button Pass;
        private System.Windows.Forms.Button Fail;
        private System.Windows.Forms.GroupBox FailPass;
        internal System.Windows.Forms.Button CloseSN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Дата;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn DE;
        private System.Windows.Forms.GroupBox FAILGROUP;
        private System.Windows.Forms.TextBox Description;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboError;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView ErrorGrid;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton FAILBT;
        private System.Windows.Forms.RadioButton PASSBT;
        private System.Windows.Forms.CheckBox UnitCheck;
    }
}

