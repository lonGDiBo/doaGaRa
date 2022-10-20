namespace giaodien
{
    partial class Form_KhachHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.data_KHang = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_themKH = new Guna.UI.WinForms.GunaButton();
            this.btn_xoaKH = new Guna.UI.WinForms.GunaButton();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.txt_sdt = new Guna.UI.WinForms.GunaTextBox();
            this.txt_diachi = new Guna.UI.WinForms.GunaTextBox();
            this.txt_makh = new Guna.UI.WinForms.GunaTextBox();
            this.txt_tenkh = new Guna.UI.WinForms.GunaTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_suaKH = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.data_KHang)).BeginInit();
            this.gunaGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // data_KHang
            // 
            this.data_KHang.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_KHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.data_KHang.ColumnHeadersHeight = 35;
            this.data_KHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.data_KHang.Location = new System.Drawing.Point(12, 229);
            this.data_KHang.Name = "data_KHang";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_KHang.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.data_KHang.RowHeadersVisible = false;
            this.data_KHang.RowHeadersWidth = 51;
            this.data_KHang.Size = new System.Drawing.Size(768, 244);
            this.data_KHang.TabIndex = 2;
            this.data_KHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_KHang_CellClick);
            this.data_KHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Mã khách hàng";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Tên khách hàng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Địa chỉ";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Số điện thoại";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btn_themKH
            // 
            this.btn_themKH.AnimationHoverSpeed = 0.07F;
            this.btn_themKH.AnimationSpeed = 0.03F;
            this.btn_themKH.BackColor = System.Drawing.Color.Transparent;
            this.btn_themKH.BaseColor = System.Drawing.Color.Transparent;
            this.btn_themKH.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_themKH.BorderSize = 2;
            this.btn_themKH.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_themKH.FocusedColor = System.Drawing.Color.Empty;
            this.btn_themKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themKH.ForeColor = System.Drawing.Color.LightGray;
            this.btn_themKH.Image = null;
            this.btn_themKH.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_themKH.Location = new System.Drawing.Point(643, 24);
            this.btn_themKH.Name = "btn_themKH";
            this.btn_themKH.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_themKH.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_themKH.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_themKH.OnHoverImage = null;
            this.btn_themKH.OnPressedColor = System.Drawing.Color.Black;
            this.btn_themKH.Radius = 20;
            this.btn_themKH.Size = new System.Drawing.Size(138, 51);
            this.btn_themKH.TabIndex = 13;
            this.btn_themKH.Text = "Thêm khách hàng";
            this.btn_themKH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_themKH.Click += new System.EventHandler(this.btn_themKH_Click);
            // 
            // btn_xoaKH
            // 
            this.btn_xoaKH.AnimationHoverSpeed = 0.07F;
            this.btn_xoaKH.AnimationSpeed = 0.03F;
            this.btn_xoaKH.BackColor = System.Drawing.Color.Transparent;
            this.btn_xoaKH.BaseColor = System.Drawing.Color.Transparent;
            this.btn_xoaKH.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_xoaKH.BorderSize = 2;
            this.btn_xoaKH.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_xoaKH.FocusedColor = System.Drawing.Color.Empty;
            this.btn_xoaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoaKH.ForeColor = System.Drawing.Color.LightGray;
            this.btn_xoaKH.Image = null;
            this.btn_xoaKH.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_xoaKH.Location = new System.Drawing.Point(643, 158);
            this.btn_xoaKH.Name = "btn_xoaKH";
            this.btn_xoaKH.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_xoaKH.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_xoaKH.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_xoaKH.OnHoverImage = null;
            this.btn_xoaKH.OnPressedColor = System.Drawing.Color.Black;
            this.btn_xoaKH.Radius = 20;
            this.btn_xoaKH.Size = new System.Drawing.Size(138, 51);
            this.btn_xoaKH.TabIndex = 12;
            this.btn_xoaKH.Text = "Xoá khách hàng";
            this.btn_xoaKH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_xoaKH.Click += new System.EventHandler(this.btn_xoaKH_Click);
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.BorderSize = 1;
            this.gunaGroupBox1.Controls.Add(this.txt_sdt);
            this.gunaGroupBox1.Controls.Add(this.txt_diachi);
            this.gunaGroupBox1.Controls.Add(this.txt_makh);
            this.gunaGroupBox1.Controls.Add(this.txt_tenkh);
            this.gunaGroupBox1.Controls.Add(this.label1);
            this.gunaGroupBox1.Controls.Add(this.label2);
            this.gunaGroupBox1.Controls.Add(this.label3);
            this.gunaGroupBox1.Controls.Add(this.label4);
            this.gunaGroupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Location = new System.Drawing.Point(12, 12);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(622, 211);
            this.gunaGroupBox1.TabIndex = 15;
            this.gunaGroupBox1.Text = "Thông tin khách hàng";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(230, 4);
            // 
            // txt_sdt
            // 
            this.txt_sdt.BaseColor = System.Drawing.Color.White;
            this.txt_sdt.BorderColor = System.Drawing.Color.Silver;
            this.txt_sdt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_sdt.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_sdt.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_sdt.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_sdt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_sdt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_sdt.Location = new System.Drawing.Point(345, 156);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.PasswordChar = '\0';
            this.txt_sdt.SelectedText = "";
            this.txt_sdt.Size = new System.Drawing.Size(267, 30);
            this.txt_sdt.TabIndex = 18;
            this.txt_sdt.Leave += new System.EventHandler(this.txt_sdt_Leave);
            // 
            // txt_diachi
            // 
            this.txt_diachi.BaseColor = System.Drawing.Color.White;
            this.txt_diachi.BorderColor = System.Drawing.Color.Silver;
            this.txt_diachi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_diachi.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_diachi.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_diachi.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_diachi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_diachi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_diachi.Location = new System.Drawing.Point(10, 156);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.PasswordChar = '\0';
            this.txt_diachi.SelectedText = "";
            this.txt_diachi.Size = new System.Drawing.Size(267, 30);
            this.txt_diachi.TabIndex = 17;
            // 
            // txt_makh
            // 
            this.txt_makh.BaseColor = System.Drawing.Color.White;
            this.txt_makh.BorderColor = System.Drawing.Color.Silver;
            this.txt_makh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_makh.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_makh.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_makh.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_makh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_makh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_makh.Location = new System.Drawing.Point(10, 74);
            this.txt_makh.Name = "txt_makh";
            this.txt_makh.PasswordChar = '\0';
            this.txt_makh.SelectedText = "";
            this.txt_makh.Size = new System.Drawing.Size(267, 30);
            this.txt_makh.TabIndex = 16;
            // 
            // txt_tenkh
            // 
            this.txt_tenkh.BaseColor = System.Drawing.Color.White;
            this.txt_tenkh.BorderColor = System.Drawing.Color.Silver;
            this.txt_tenkh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tenkh.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_tenkh.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_tenkh.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_tenkh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_tenkh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_tenkh.Location = new System.Drawing.Point(345, 74);
            this.txt_tenkh.Name = "txt_tenkh";
            this.txt_tenkh.PasswordChar = '\0';
            this.txt_tenkh.SelectedText = "";
            this.txt_tenkh.Size = new System.Drawing.Size(267, 30);
            this.txt_tenkh.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(12, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(9, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(342, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tên khách hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(344, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Số điện thoại";
            // 
            // btn_suaKH
            // 
            this.btn_suaKH.AnimationHoverSpeed = 0.07F;
            this.btn_suaKH.AnimationSpeed = 0.03F;
            this.btn_suaKH.BackColor = System.Drawing.Color.Transparent;
            this.btn_suaKH.BaseColor = System.Drawing.Color.Transparent;
            this.btn_suaKH.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_suaKH.BorderSize = 2;
            this.btn_suaKH.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_suaKH.FocusedColor = System.Drawing.Color.Empty;
            this.btn_suaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_suaKH.ForeColor = System.Drawing.Color.LightGray;
            this.btn_suaKH.Image = null;
            this.btn_suaKH.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_suaKH.Location = new System.Drawing.Point(643, 92);
            this.btn_suaKH.Name = "btn_suaKH";
            this.btn_suaKH.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_suaKH.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_suaKH.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_suaKH.OnHoverImage = null;
            this.btn_suaKH.OnPressedColor = System.Drawing.Color.Black;
            this.btn_suaKH.Radius = 20;
            this.btn_suaKH.Size = new System.Drawing.Size(138, 51);
            this.btn_suaKH.TabIndex = 16;
            this.btn_suaKH.Text = "Sửa Thông tin";
            this.btn_suaKH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_suaKH.Click += new System.EventHandler(this.btn_suaKH_Click);
            // 
            // Form_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(792, 485);
            this.Controls.Add(this.btn_suaKH);
            this.Controls.Add(this.gunaGroupBox1);
            this.Controls.Add(this.btn_xoaKH);
            this.Controls.Add(this.data_KHang);
            this.Controls.Add(this.btn_themKH);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_KhachHang";
            this.Text = "Form_KhachHang";
            this.Load += new System.EventHandler(this.Form_KhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_KHang)).EndInit();
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView data_KHang;
        private Guna.UI.WinForms.GunaButton btn_themKH;
        private Guna.UI.WinForms.GunaButton btn_xoaKH;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaTextBox txt_tenkh;
        private Guna.UI.WinForms.GunaButton btn_suaKH;
        private Guna.UI.WinForms.GunaTextBox txt_sdt;
        private Guna.UI.WinForms.GunaTextBox txt_diachi;
        private Guna.UI.WinForms.GunaTextBox txt_makh;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn Column3;
        private System.Windows.Forms.DataGridViewButtonColumn Column4;
    }
}