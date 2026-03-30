namespace QLKTX.Forms
{
    partial class frmNhanVien
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
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            MaNV = new DataGridViewTextBoxColumn();
            HoVaTen = new DataGridViewTextBoxColumn();
            DienThoai = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            GioiTinh = new DataGridViewTextBoxColumn();
            TenDangNhap = new DataGridViewTextBoxColumn();
            QuyenHan = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            cboQuyenHan = new ComboBox();
            txtMatKhau = new TextBox();
            label10 = new Label();
            label9 = new Label();
            txtTenDangNhap = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox3 = new GroupBox();
            radNu = new RadioButton();
            radNam = new RadioButton();
            txtDienThoai = new TextBox();
            txtHoTen = new TextBox();
            txtDiaChi = new TextBox();
            txtTimKiem = new TextBox();
            txtMaNV = new TextBox();
            btnTimKiem = new Button();
            btnSua = new Button();
            btnThoat = new Button();
            btnXuat = new Button();
            btnNhap = new Button();
            btnLuu = new Button();
            btnThem = new Button();
            btnHuyBo = new Button();
            btnXoa = new Button();
            label1 = new Label();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(18, 365);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1264, 313);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách sinh viên";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { MaNV, HoVaTen, DienThoai, DiaChi, GioiTinh, TenDangNhap, QuyenHan });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 25);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 53;
            dataGridView1.Size = new Size(1258, 285);
            dataGridView1.TabIndex = 0;
            // 
            // MaNV
            // 
            MaNV.DataPropertyName = "MaNV";
            MaNV.HeaderText = "Mã NV";
            MaNV.MinimumWidth = 7;
            MaNV.Name = "MaNV";
            // 
            // HoVaTen
            // 
            HoVaTen.DataPropertyName = "HoVaTen";
            HoVaTen.HeaderText = "Họ và tên";
            HoVaTen.MinimumWidth = 7;
            HoVaTen.Name = "HoVaTen";
            // 
            // DienThoai
            // 
            DienThoai.DataPropertyName = "DienThoai";
            DienThoai.HeaderText = "Điện thoại";
            DienThoai.MinimumWidth = 7;
            DienThoai.Name = "DienThoai";
            // 
            // DiaChi
            // 
            DiaChi.DataPropertyName = "DiaChi";
            DiaChi.HeaderText = "Địa chỉ";
            DiaChi.MinimumWidth = 7;
            DiaChi.Name = "DiaChi";
            // 
            // GioiTinh
            // 
            GioiTinh.DataPropertyName = "GioiTinh";
            GioiTinh.HeaderText = "Giới tính";
            GioiTinh.MinimumWidth = 7;
            GioiTinh.Name = "GioiTinh";
            // 
            // TenDangNhap
            // 
            TenDangNhap.DataPropertyName = "TenDangNhap";
            TenDangNhap.HeaderText = "Tên đăng nhập";
            TenDangNhap.MinimumWidth = 7;
            TenDangNhap.Name = "TenDangNhap";
            // 
            // QuyenHan
            // 
            QuyenHan.DataPropertyName = "QuyenHan";
            QuyenHan.HeaderText = "Quyền hạn";
            QuyenHan.MinimumWidth = 7;
            QuyenHan.Name = "QuyenHan";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboQuyenHan);
            groupBox1.Controls.Add(txtMatKhau);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtTenDangNhap);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(txtDienThoai);
            groupBox1.Controls.Add(txtHoTen);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(txtTimKiem);
            groupBox1.Controls.Add(txtMaNV);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnXuat);
            groupBox1.Controls.Add(btnNhap);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Location = new Point(18, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1264, 318);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhân viên";
            // 
            // cboQuyenHan
            // 
            cboQuyenHan.FormattingEnabled = true;
            cboQuyenHan.Location = new Point(585, 237);
            cboQuyenHan.Name = "cboQuyenHan";
            cboQuyenHan.Size = new Size(239, 29);
            cboQuyenHan.TabIndex = 8;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(582, 182);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(242, 29);
            txtMatKhau.TabIndex = 7;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(447, 182);
            label10.Name = "label10";
            label10.Size = new Size(99, 21);
            label10.TabIndex = 6;
            label10.Text = "Mật khẩu (*):";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(447, 237);
            label9.Name = "label9";
            label9.Size = new Size(110, 21);
            label9.TabIndex = 6;
            label9.Text = "Quyền hạn (*):";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(582, 128);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(242, 29);
            txtTenDangNhap.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(435, 131);
            label8.Name = "label8";
            label8.Size = new Size(135, 21);
            label8.TabIndex = 6;
            label8.Text = "Tên đăng nhập (*):";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(876, 25);
            label7.Name = "label7";
            label7.Size = new Size(77, 21);
            label7.TabIndex = 5;
            label7.Text = "Tìm kiếm:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 249);
            label6.Name = "label6";
            label6.Size = new Size(60, 21);
            label6.TabIndex = 4;
            label6.Text = "Địa chỉ:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 186);
            label4.Name = "label4";
            label4.Size = new Size(84, 21);
            label4.TabIndex = 4;
            label4.Text = "Điện thoại:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 128);
            label3.Name = "label3";
            label3.Size = new Size(100, 21);
            label3.TabIndex = 4;
            label3.Text = "Họ và tên (*):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 65);
            label2.Name = "label2";
            label2.Size = new Size(128, 21);
            label2.TabIndex = 4;
            label2.Text = "Mã nhân viên (*):";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(radNu);
            groupBox3.Controls.Add(radNam);
            groupBox3.Location = new Point(465, 37);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(326, 57);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Giới tính";
            // 
            // radNu
            // 
            radNu.AutoSize = true;
            radNu.Location = new Point(168, 26);
            radNu.Name = "radNu";
            radNu.Size = new Size(52, 25);
            radNu.TabIndex = 0;
            radNu.TabStop = true;
            radNu.Text = "Nữ";
            radNu.UseVisualStyleBackColor = true;
            // 
            // radNam
            // 
            radNam.AutoSize = true;
            radNam.Location = new Point(40, 26);
            radNam.Name = "radNam";
            radNam.Size = new Size(65, 25);
            radNam.TabIndex = 0;
            radNam.TabStop = true;
            radNam.Text = "Nam";
            radNam.UseVisualStyleBackColor = true;
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(143, 178);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(262, 29);
            txtDienThoai.TabIndex = 1;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(143, 120);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(262, 29);
            txtHoTen.TabIndex = 1;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(143, 246);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(262, 29);
            txtDiaChi.TabIndex = 1;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(876, 51);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(262, 29);
            txtTimKiem.TabIndex = 1;
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(143, 59);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(262, 29);
            txtMaNV.TabIndex = 1;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(1146, 49);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(98, 31);
            btnTimKiem.TabIndex = 0;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(876, 244);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(98, 31);
            btnSua.TabIndex = 0;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(1008, 244);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(98, 31);
            btnThoat.TabIndex = 0;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(1134, 194);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(98, 31);
            btnXuat.TabIndex = 0;
            btnXuat.Text = "Xuất...";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(1134, 147);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(98, 31);
            btnNhap.TabIndex = 0;
            btnNhap.Text = "Nhập...";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(876, 194);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(98, 31);
            btnLuu.TabIndex = 0;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(876, 147);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(98, 31);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(1008, 194);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(98, 31);
            btnHuyBo.TabIndex = 0;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(1008, 147);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(98, 31);
            btnXoa.TabIndex = 0;
            btnXoa.Text = "Xóa ";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(483, 50);
            label1.Name = "label1";
            label1.Size = new Size(0, 21);
            label1.TabIndex = 2;
            // 
            // frmNhanVien
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 719);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "frmNhanVien";
            Text = "frmNhanVien";
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox groupBox3;
        private RadioButton radNu;
        private RadioButton radNam;
        private TextBox txtDienThoai;
        private TextBox txtHoTen;
        private TextBox txtDiaChi;
        private TextBox txtTimKiem;
        private TextBox txtMaNV;
        private Button btnTimKiem;
        private Button btnSua;
        private Button btnThoat;
        private Button btnXuat;
        private Button btnNhap;
        private Button btnLuu;
        private Button btnThem;
        private Button btnHuyBo;
        private Button btnXoa;
        private Label label1;
        private TextBox txtMatKhau;
        private Label label10;
        private Label label9;
        private TextBox txtTenDangNhap;
        private Label label8;
        private DataGridViewTextBoxColumn MaNV;
        private DataGridViewTextBoxColumn HoVaTen;
        private DataGridViewTextBoxColumn DienThoai;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn GioiTinh;
        private DataGridViewTextBoxColumn TenDangNhap;
        private DataGridViewTextBoxColumn QuyenHan;
        private ComboBox cboQuyenHan;
    }
}