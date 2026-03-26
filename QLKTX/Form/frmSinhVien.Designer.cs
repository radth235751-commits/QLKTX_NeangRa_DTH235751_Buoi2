using QLKTX.Data;
using System;
using System.Windows.Forms;

namespace QLKTX.Forms
{
    public partial class frmSinhVien : System.Windows.Forms.Form
    {
        private System.ComponentModel.IContainer components = null;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            label1 = new Label();
            groupBox1 = new GroupBox();
            label7 = new Label();
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            picHinhAnh = new PictureBox();
            groupBox3 = new GroupBox();
            radNu = new RadioButton();
            radNam = new RadioButton();
            txtDienThoai = new TextBox();
            txtEmail = new TextBox();
            txtHoTen = new TextBox();
            txtKhoa = new TextBox();
            txtDiaChi = new TextBox();
            txtTiemKiem = new TextBox();
            txtMASV = new TextBox();
            btnTimKiem = new Button();
            btnDoiAnh = new Button();
            btnSua = new Button();
            btnThoat = new Button();
            btnXuat = new Button();
            btnNhap = new Button();
            btnLuu = new Button();
            btnThem = new Button();
            btnHuyBo = new Button();
            btnXoa = new Button();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            MaSV = new DataGridViewTextBoxColumn();
            HoVaTen = new DataGridViewTextBoxColumn();
            DienThoai = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            GioiTinh = new DataGridViewTextBoxColumn();
            Anh = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).BeginInit();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(489, 21);
            label1.Name = "label1";
            label1.Size = new Size(0, 21);
            label1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(picHinhAnh);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(txtDienThoai);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtHoTen);
            groupBox1.Controls.Add(txtKhoa);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(txtTiemKiem);
            groupBox1.Controls.Add(txtMASV);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(btnDoiAnh);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnXuat);
            groupBox1.Controls.Add(btnNhap);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Location = new Point(24, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1264, 307);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sinh viên";
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
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 276);
            label8.Name = "label8";
            label8.Size = new Size(48, 21);
            label8.TabIndex = 4;
            label8.Text = "Khoa:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 241);
            label6.Name = "label6";
            label6.Size = new Size(60, 21);
            label6.TabIndex = 4;
            label6.Text = "Địa chỉ:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 194);
            label5.Name = "label5";
            label5.Size = new Size(51, 21);
            label5.TabIndex = 4;
            label5.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 143);
            label4.Name = "label4";
            label4.Size = new Size(84, 21);
            label4.TabIndex = 4;
            label4.Text = "Điện thoại:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 94);
            label3.Name = "label3";
            label3.Size = new Size(100, 21);
            label3.TabIndex = 4;
            label3.Text = "Họ và tên (*):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 43);
            label2.Name = "label2";
            label2.Size = new Size(101, 21);
            label2.TabIndex = 4;
            label2.Text = "Mã sinh viên:";
            // 
            // picHinhAnh
            // 
            picHinhAnh.Location = new Point(476, 113);
            picHinhAnh.Name = "picHinhAnh";
            picHinhAnh.Size = new Size(162, 171);
            picHinhAnh.TabIndex = 3;
            picHinhAnh.TabStop = false;
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
            txtDienThoai.Location = new Point(143, 135);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(262, 29);
            txtDienThoai.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(143, 186);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(262, 29);
            txtEmail.TabIndex = 1;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(143, 86);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(262, 29);
            txtHoTen.TabIndex = 1;
            // 
            // txtKhoa
            // 
            txtKhoa.Location = new Point(143, 268);
            txtKhoa.Name = "txtKhoa";
            txtKhoa.Size = new Size(262, 29);
            txtKhoa.TabIndex = 1;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(143, 233);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(262, 29);
            txtDiaChi.TabIndex = 1;
            // 
            // txtTiemKiem
            // 
            txtTiemKiem.Location = new Point(876, 51);
            txtTiemKiem.Name = "txtTiemKiem";
            txtTiemKiem.Size = new Size(262, 29);
            txtTiemKiem.TabIndex = 1;
            // 
            // txtMASV
            // 
            txtMASV.Location = new Point(143, 37);
            txtMASV.Name = "txtMASV";
            txtMASV.Size = new Size(262, 29);
            txtMASV.TabIndex = 1;
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
            // btnDoiAnh
            // 
            btnDoiAnh.Location = new Point(664, 120);
            btnDoiAnh.Name = "btnDoiAnh";
            btnDoiAnh.Size = new Size(98, 31);
            btnDoiAnh.TabIndex = 0;
            btnDoiAnh.Text = "Đổi ảnh";
            btnDoiAnh.UseVisualStyleBackColor = true;
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
     //       btnThoat.Click += btnThoat_Click;
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(1134, 194);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(98, 31);
            btnXuat.TabIndex = 0;
            btnXuat.Text = "Xuất...";
            btnXuat.UseVisualStyleBackColor = true;
        //    btnXuat.Click += btnXuat_Click;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(1134, 147);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(98, 31);
            btnNhap.TabIndex = 0;
            btnNhap.Text = "Nhập...";
            btnNhap.UseVisualStyleBackColor = true;
         //   btnNhap.Click += btnNhap_Click;
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
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(24, 336);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1264, 313);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách sinh viên";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, MaSV, HoVaTen, DienThoai, Email, DiaChi, GioiTinh, Anh });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 25);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 53;
            dataGridView1.Size = new Size(1258, 285);
            dataGridView1.TabIndex = 0;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 7;
            ID.Name = "ID";
            // 
            // MaSV
            // 
            MaSV.DataPropertyName = "MaSV";
            MaSV.HeaderText = "Mã SV";
            MaSV.MinimumWidth = 7;
            MaSV.Name = "MaSV";
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
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.MinimumWidth = 7;
            Email.Name = "Email";
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
            // Anh
            // 
            Anh.DataPropertyName = "Anh";
            Anh.HeaderText = "Ảnh";
            Anh.MinimumWidth = 7;
            Anh.Name = "Anh";
            // 
            // frmSinhVien
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 671);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "frmSinhVien";
            Text = "Sinh Viên";
            Load += frmSinhVien_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private TextBox txtDienThoai;
        private TextBox txtEmail;
        private TextBox txtHoTen;
        private TextBox txtDiaChi;
        private TextBox txtMASV;
        private Button btnHuyBo;
        private Button btnXoa;
        private GroupBox groupBox2;
        private PictureBox picHinhAnh;
        private Button btnDoiAnh;
        private Button btnSua;
        private Button btnThoat;
        private Button btnXuat;
        private Button btnNhap;
        private Button btnLuu;
        private Button btnThem;
        private DataGridView dataGridView1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtTiemKiem;
        private Label label7;
        private Button btnTimKiem;
        private RadioButton radNu;
        private RadioButton radNam;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn MaSV;
        private DataGridViewTextBoxColumn HoVaTen;
        private DataGridViewTextBoxColumn DienThoai;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn GioiTinh;
        private DataGridViewTextBoxColumn Anh;
        private Label label8;
        private TextBox txtKhoa;
    }
}