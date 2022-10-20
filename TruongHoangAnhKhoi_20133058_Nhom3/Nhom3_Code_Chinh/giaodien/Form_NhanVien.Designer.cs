namespace giaodien
{
    partial class Form_NhanVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.data_nv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cb_nhom = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_tentho = new Guna.UI.WinForms.GunaTextBox();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.rd_truong = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rd_tvien = new Guna.UI2.WinForms.Guna2RadioButton();
            this.txt_luong = new Guna.UI.WinForms.GunaTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_matho = new Guna.UI.WinForms.GunaTextBox();
            this.btn_suanv = new Guna.UI.WinForms.GunaButton();
            this.gunaGroupBox2 = new Guna.UI.WinForms.GunaGroupBox();
            this.gunaTextBox4 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox3 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox5 = new Guna.UI.WinForms.GunaTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gunaTextBox6 = new Guna.UI.WinForms.GunaTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_xoanv = new Guna.UI.WinForms.GunaButton();
            this.btn_themnv = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.data_nv)).BeginInit();
            this.gunaGroupBox1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.gunaGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // data_nv
            // 
            this.data_nv.BackgroundColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_nv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.data_nv.ColumnHeadersHeight = 40;
            this.data_nv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.data_nv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.data_nv.Location = new System.Drawing.Point(12, 229);
            this.data_nv.Name = "data_nv";
            this.data_nv.RowHeadersVisible = false;
            this.data_nv.RowHeadersWidth = 40;
            this.data_nv.Size = new System.Drawing.Size(768, 244);
            this.data_nv.TabIndex = 1;
            this.data_nv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_nv_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Mã thợ";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Tên Thợ";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Nhóm";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Nhóm trưởng";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "Lương";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // cb_nhom
            // 
            this.cb_nhom.FormattingEnabled = true;
            this.cb_nhom.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cb_nhom.Location = new System.Drawing.Point(182, 75);
            this.cb_nhom.Name = "cb_nhom";
            this.cb_nhom.Size = new System.Drawing.Size(122, 29);
            this.cb_nhom.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(12, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tên Thợ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(9, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã thợ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(179, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nhóm";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(340, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cấp bậc";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_tentho
            // 
            this.txt_tentho.BaseColor = System.Drawing.Color.White;
            this.txt_tentho.BorderColor = System.Drawing.Color.Silver;
            this.txt_tentho.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tentho.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_tentho.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_tentho.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_tentho.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_tentho.ForeColor = System.Drawing.Color.Black;
            this.txt_tentho.Location = new System.Drawing.Point(10, 157);
            this.txt_tentho.Name = "txt_tentho";
            this.txt_tentho.PasswordChar = '\0';
            this.txt_tentho.SelectedText = "";
            this.txt_tentho.Size = new System.Drawing.Size(297, 30);
            this.txt_tentho.TabIndex = 13;
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.DimGray;
            this.gunaGroupBox1.BorderSize = 1;
            this.gunaGroupBox1.Controls.Add(this.guna2Panel1);
            this.gunaGroupBox1.Controls.Add(this.txt_luong);
            this.gunaGroupBox1.Controls.Add(this.label9);
            this.gunaGroupBox1.Controls.Add(this.txt_matho);
            this.gunaGroupBox1.Controls.Add(this.cb_nhom);
            this.gunaGroupBox1.Controls.Add(this.txt_tentho);
            this.gunaGroupBox1.Controls.Add(this.label1);
            this.gunaGroupBox1.Controls.Add(this.label2);
            this.gunaGroupBox1.Controls.Add(this.label3);
            this.gunaGroupBox1.Controls.Add(this.label4);
            this.gunaGroupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox1.ForeColor = System.Drawing.Color.Black;
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Location = new System.Drawing.Point(12, 12);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(622, 211);
            this.gunaGroupBox1.TabIndex = 14;
            this.gunaGroupBox1.Text = "Thông tin nhân viên";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(230, 4);
            this.gunaGroupBox1.Click += new System.EventHandler(this.gunaGroupBox1_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.rd_truong);
            this.guna2Panel1.Controls.Add(this.rd_tvien);
            this.guna2Panel1.ForeColor = System.Drawing.Color.Gainsboro;
            this.guna2Panel1.Location = new System.Drawing.Point(343, 142);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(267, 64);
            this.guna2Panel1.TabIndex = 25;
            // 
            // rd_truong
            // 
            this.rd_truong.AutoSize = true;
            this.rd_truong.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rd_truong.CheckedState.BorderThickness = 0;
            this.rd_truong.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rd_truong.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rd_truong.CheckedState.InnerOffset = -4;
            this.rd_truong.Location = new System.Drawing.Point(2, 17);
            this.rd_truong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rd_truong.Name = "rd_truong";
            this.rd_truong.Size = new System.Drawing.Size(128, 25);
            this.rd_truong.TabIndex = 23;
            this.rd_truong.Text = "Nhóm trưởng";
            this.rd_truong.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rd_truong.UncheckedState.BorderThickness = 2;
            this.rd_truong.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rd_truong.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rd_tvien
            // 
            this.rd_tvien.AutoSize = true;
            this.rd_tvien.Checked = true;
            this.rd_tvien.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rd_tvien.CheckedState.BorderThickness = 0;
            this.rd_tvien.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rd_tvien.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rd_tvien.CheckedState.InnerOffset = -4;
            this.rd_tvien.Location = new System.Drawing.Point(140, 17);
            this.rd_tvien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rd_tvien.Name = "rd_tvien";
            this.rd_tvien.Size = new System.Drawing.Size(106, 25);
            this.rd_tvien.TabIndex = 24;
            this.rd_tvien.TabStop = true;
            this.rd_tvien.Text = "Thành viên";
            this.rd_tvien.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rd_tvien.UncheckedState.BorderThickness = 2;
            this.rd_tvien.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rd_tvien.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // txt_luong
            // 
            this.txt_luong.BaseColor = System.Drawing.Color.White;
            this.txt_luong.BorderColor = System.Drawing.Color.Silver;
            this.txt_luong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_luong.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_luong.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_luong.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_luong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_luong.ForeColor = System.Drawing.Color.Black;
            this.txt_luong.Location = new System.Drawing.Point(343, 75);
            this.txt_luong.Name = "txt_luong";
            this.txt_luong.PasswordChar = '\0';
            this.txt_luong.SelectedText = "";
            this.txt_luong.Size = new System.Drawing.Size(267, 30);
            this.txt_luong.TabIndex = 20;
            this.txt_luong.Leave += new System.EventHandler(this.txt_luong_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.LightGray;
            this.label9.Location = new System.Drawing.Point(340, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 18);
            this.label9.TabIndex = 19;
            this.label9.Text = "Lương";
            // 
            // txt_matho
            // 
            this.txt_matho.BaseColor = System.Drawing.Color.White;
            this.txt_matho.BorderColor = System.Drawing.Color.Silver;
            this.txt_matho.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_matho.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_matho.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_matho.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_matho.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_matho.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_matho.Location = new System.Drawing.Point(10, 75);
            this.txt_matho.Name = "txt_matho";
            this.txt_matho.PasswordChar = '\0';
            this.txt_matho.SelectedText = "";
            this.txt_matho.Size = new System.Drawing.Size(131, 30);
            this.txt_matho.TabIndex = 17;
            // 
            // btn_suanv
            // 
            this.btn_suanv.AnimationHoverSpeed = 0.07F;
            this.btn_suanv.AnimationSpeed = 0.03F;
            this.btn_suanv.BackColor = System.Drawing.Color.Transparent;
            this.btn_suanv.BaseColor = System.Drawing.Color.Transparent;
            this.btn_suanv.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_suanv.BorderSize = 2;
            this.btn_suanv.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_suanv.FocusedColor = System.Drawing.Color.Empty;
            this.btn_suanv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_suanv.ForeColor = System.Drawing.Color.LightGray;
            this.btn_suanv.Image = null;
            this.btn_suanv.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_suanv.Location = new System.Drawing.Point(644, 94);
            this.btn_suanv.Name = "btn_suanv";
            this.btn_suanv.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_suanv.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_suanv.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_suanv.OnHoverImage = null;
            this.btn_suanv.OnPressedColor = System.Drawing.Color.Black;
            this.btn_suanv.Radius = 20;
            this.btn_suanv.Size = new System.Drawing.Size(138, 51);
            this.btn_suanv.TabIndex = 20;
            this.btn_suanv.Text = "Sửa Thông tin";
            this.btn_suanv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_suanv.Click += new System.EventHandler(this.btn_suanv_Click);
            // 
            // gunaGroupBox2
            // 
            this.gunaGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox2.BaseColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox2.BorderColor = System.Drawing.Color.DimGray;
            this.gunaGroupBox2.BorderSize = 1;
            this.gunaGroupBox2.Controls.Add(this.gunaTextBox4);
            this.gunaGroupBox2.Controls.Add(this.gunaTextBox3);
            this.gunaGroupBox2.Controls.Add(this.gunaTextBox5);
            this.gunaGroupBox2.Controls.Add(this.label5);
            this.gunaGroupBox2.Controls.Add(this.gunaTextBox6);
            this.gunaGroupBox2.Controls.Add(this.label6);
            this.gunaGroupBox2.Controls.Add(this.label7);
            this.gunaGroupBox2.Controls.Add(this.label8);
            this.gunaGroupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gunaGroupBox2.LineColor = System.Drawing.Color.Gray;
            this.gunaGroupBox2.Location = new System.Drawing.Point(12, 12);
            this.gunaGroupBox2.Name = "gunaGroupBox2";
            this.gunaGroupBox2.Size = new System.Drawing.Size(622, 211);
            this.gunaGroupBox2.TabIndex = 19;
            this.gunaGroupBox2.Text = "Thông tin khách hàng";
            this.gunaGroupBox2.TextLocation = new System.Drawing.Point(250, 4);
            // 
            // gunaTextBox4
            // 
            this.gunaTextBox4.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox4.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox4.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox4.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox4.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBox4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gunaTextBox4.Location = new System.Drawing.Point(313, 157);
            this.gunaTextBox4.Name = "gunaTextBox4";
            this.gunaTextBox4.PasswordChar = '\0';
            this.gunaTextBox4.SelectedText = "";
            this.gunaTextBox4.Size = new System.Drawing.Size(205, 30);
            this.gunaTextBox4.TabIndex = 15;
            this.gunaTextBox4.Text = "gunaTextBox4";
            // 
            // gunaTextBox3
            // 
            this.gunaTextBox3.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox3.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox3.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox3.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox3.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gunaTextBox3.Location = new System.Drawing.Point(313, 74);
            this.gunaTextBox3.Name = "gunaTextBox3";
            this.gunaTextBox3.PasswordChar = '\0';
            this.gunaTextBox3.SelectedText = "";
            this.gunaTextBox3.Size = new System.Drawing.Size(205, 30);
            this.gunaTextBox3.TabIndex = 14;
            this.gunaTextBox3.Text = "gunaTextBox3";
            // 
            // gunaTextBox5
            // 
            this.gunaTextBox5.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox5.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox5.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox5.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox5.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBox5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gunaTextBox5.Location = new System.Drawing.Point(10, 157);
            this.gunaTextBox5.Name = "gunaTextBox5";
            this.gunaTextBox5.PasswordChar = '\0';
            this.gunaTextBox5.SelectedText = "";
            this.gunaTextBox5.Size = new System.Drawing.Size(206, 30);
            this.gunaTextBox5.TabIndex = 13;
            this.gunaTextBox5.Text = "gunaTextBox5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(12, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Địa chỉ";
            // 
            // gunaTextBox6
            // 
            this.gunaTextBox6.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox6.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox6.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox6.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox6.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBox6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gunaTextBox6.Location = new System.Drawing.Point(11, 74);
            this.gunaTextBox6.Name = "gunaTextBox6";
            this.gunaTextBox6.PasswordChar = '\0';
            this.gunaTextBox6.SelectedText = "";
            this.gunaTextBox6.Size = new System.Drawing.Size(205, 30);
            this.gunaTextBox6.TabIndex = 12;
            this.gunaTextBox6.Text = "gunaTextBox6";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightGray;
            this.label6.Location = new System.Drawing.Point(9, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Mã khách hàng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.LightGray;
            this.label7.Location = new System.Drawing.Point(310, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "Tên khách hàng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.LightGray;
            this.label8.Location = new System.Drawing.Point(310, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 18);
            this.label8.TabIndex = 8;
            this.label8.Text = "Số điện thoại";
            // 
            // btn_xoanv
            // 
            this.btn_xoanv.AnimationHoverSpeed = 0.07F;
            this.btn_xoanv.AnimationSpeed = 0.03F;
            this.btn_xoanv.BackColor = System.Drawing.Color.Transparent;
            this.btn_xoanv.BaseColor = System.Drawing.Color.Transparent;
            this.btn_xoanv.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_xoanv.BorderSize = 2;
            this.btn_xoanv.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_xoanv.FocusedColor = System.Drawing.Color.Empty;
            this.btn_xoanv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoanv.ForeColor = System.Drawing.Color.LightGray;
            this.btn_xoanv.Image = null;
            this.btn_xoanv.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_xoanv.Location = new System.Drawing.Point(644, 158);
            this.btn_xoanv.Name = "btn_xoanv";
            this.btn_xoanv.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_xoanv.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_xoanv.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_xoanv.OnHoverImage = null;
            this.btn_xoanv.OnPressedColor = System.Drawing.Color.Black;
            this.btn_xoanv.Radius = 20;
            this.btn_xoanv.Size = new System.Drawing.Size(138, 51);
            this.btn_xoanv.TabIndex = 17;
            this.btn_xoanv.Text = "Xoá nhân viên";
            this.btn_xoanv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_xoanv.Click += new System.EventHandler(this.btn_xoanv_Click);
            // 
            // btn_themnv
            // 
            this.btn_themnv.AnimationHoverSpeed = 0.07F;
            this.btn_themnv.AnimationSpeed = 0.03F;
            this.btn_themnv.BackColor = System.Drawing.Color.Transparent;
            this.btn_themnv.BaseColor = System.Drawing.Color.Transparent;
            this.btn_themnv.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_themnv.BorderSize = 2;
            this.btn_themnv.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_themnv.FocusedColor = System.Drawing.Color.Empty;
            this.btn_themnv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themnv.ForeColor = System.Drawing.Color.LightGray;
            this.btn_themnv.Image = null;
            this.btn_themnv.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_themnv.Location = new System.Drawing.Point(644, 24);
            this.btn_themnv.Name = "btn_themnv";
            this.btn_themnv.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_themnv.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_themnv.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_themnv.OnHoverImage = null;
            this.btn_themnv.OnPressedColor = System.Drawing.Color.Black;
            this.btn_themnv.Radius = 20;
            this.btn_themnv.Size = new System.Drawing.Size(138, 51);
            this.btn_themnv.TabIndex = 18;
            this.btn_themnv.Text = "Thêm nhân viên";
            this.btn_themnv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_themnv.Click += new System.EventHandler(this.btn_themnv_Click);
            // 
            // Form_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(792, 485);
            this.Controls.Add(this.btn_suanv);
            this.Controls.Add(this.gunaGroupBox1);
            this.Controls.Add(this.gunaGroupBox2);
            this.Controls.Add(this.data_nv);
            this.Controls.Add(this.btn_xoanv);
            this.Controls.Add(this.btn_themnv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_NhanVien";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form_NhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_nv)).EndInit();
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.gunaGroupBox2.ResumeLayout(false);
            this.gunaGroupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView data_nv;
        private System.Windows.Forms.ComboBox cb_nhom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaTextBox txt_tentho;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Guna.UI.WinForms.GunaButton btn_suanv;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox2;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox4;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox3;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox5;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Guna.UI.WinForms.GunaButton btn_xoanv;
        private Guna.UI.WinForms.GunaButton btn_themnv;
        private Guna.UI.WinForms.GunaTextBox txt_matho;
        private Guna.UI.WinForms.GunaTextBox txt_luong;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2RadioButton rd_truong;
        private Guna.UI2.WinForms.Guna2RadioButton rd_tvien;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn Column3;
        private System.Windows.Forms.DataGridViewButtonColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn Column5;
    }
}