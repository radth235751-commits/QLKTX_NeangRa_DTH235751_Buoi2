using Microsoft.EntityFrameworkCore;
using QLKTX.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKTX.Forms
{
    public partial class frmSinhVien : Form
    {
        QLKTXDbContext db = new QLKTXDbContext(); // Khởi tạo biến ngữ cảnh CSDL
        bool xuLyThem = false; // Kiểm tra có nhấn vào nút Thêm hay không?
        int id;
        public frmSinhVien()
        {
            InitializeComponent();
        }

        private void BatTatChucNang(bool giaTri)
        {
            // ===== Bật/Tắt input =====
            txtMASV.Enabled = giaTri;
            txtHoTen.Enabled = giaTri;
            txtDienThoai.Enabled = giaTri;
            txtEmail.Enabled = giaTri;
            txtDiaChi.Enabled = giaTri;
            txtKhoa.Enabled = giaTri;

            radNam.Enabled = giaTri;
            radNu.Enabled = giaTri;

            // ===== Nút =====
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }
        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            LoadSinhVien();
            BatTatChucNang(false);
        }
        void LoadSinhVien()
        {

            var list = db.SinhVien
                .Select(sv => new DanhSachSinhVien
                {
                    ID = sv.ID,
                    MaSV = sv.MaSV,
                    HoVaTen = sv.HoVaTen,
                    DienThoai = sv.DienThoai,
                    Khoa = sv.Khoa,
                    Email = sv.Email,
                    Phai = sv.Phai ? "Nam" : "Nữ"
                })
                .ToList();

            dataGridView1.DataSource = list;

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;

            BatTatChucNang(true);

            // Clear dữ liệu
            txtMASV.Clear();
            txtHoTen.Clear();
            txtDienThoai.Clear();
            txtEmail.Clear();
            txtDiaChi.Clear();
            txtKhoa.Clear();

            radNam.Checked = true;
        }

        // ================= XÓA =================
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            int id = (int)dataGridView1.CurrentRow.Cells["ID"].Value;


            var sv = db.SinhVien.Find(id);
            if (sv != null)
            {
                db.SinhVien.Remove(sv);
                db.SaveChanges();
            }


            LoadSinhVien();
        }

        // ================= SỬA =================
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            int id = (int)dataGridView1.CurrentRow.Cells["ID"].Value;


            var sv = db.SinhVien.Find(id);
            if (sv != null)
            {
                sv.MaSV = txtMASV.Text;
                sv.HoVaTen = txtHoTen.Text;
                sv.DienThoai = txtDienThoai.Text;
                sv.DiaChi = txtDiaChi.Text;
                sv.Khoa = txtKhoa.Text;
                sv.Email = txtEmail.Text;
                sv.Phai = radNam.Checked;

                db.SaveChanges();
            }


            LoadSinhVien();
        }

        // ================= CLICK GRID =================
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dataGridView1.Rows[e.RowIndex];

            txtMASV.Text = row.Cells["MaSV"].Value.ToString();
            txtHoTen.Text = row.Cells["HoVaTen"].Value.ToString();
            txtDienThoai.Text = row.Cells["DienThoai"].Value?.ToString();
            txtKhoa.Text = row.Cells["Khoa"].Value?.ToString();
            txtEmail.Text = row.Cells["Email"].Value?.ToString();

            string gt = row.Cells["Phai"].Value.ToString();
            radNam.Checked = gt == "Nam";
            radNu.Checked = gt == "Nữ";
        }

        // ================= TÌM KIẾM =================
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTiemKiem.Text.ToLower();


            var list = db.SinhVien
                .Where(sv => sv.MaSV.ToLower().Contains(keyword)
                          || sv.HoVaTen.ToLower().Contains(keyword))
                .Select(sv => new DanhSachSinhVien
                {
                    ID = sv.ID,
                    MaSV = sv.MaSV,
                    HoVaTen = sv.HoVaTen,
                    DienThoai = sv.DienThoai,
                    Khoa = sv.Khoa,
                    Email = sv.Email,
                    Phai = sv.Phai ? "Nam" : "Nữ"
                })
                .ToList();

            dataGridView1.DataSource = list;

        }

        // ================= CLEAR =================
        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            txtMASV.Clear();
            txtHoTen.Clear();
            txtDienThoai.Clear();
            txtDiaChi.Clear();
            txtKhoa.Clear();
            txtEmail.Clear();
            radNam.Checked = true;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {


            if (xuLyThem)
            {
                SinhVien sv = new SinhVien()
                {
                    MaSV = txtMASV.Text,
                    HoVaTen = txtHoTen.Text,
                    DienThoai = txtDienThoai.Text,
                    DiaChi = txtDiaChi.Text,
                    Khoa = txtKhoa.Text,
                    Email = txtEmail.Text,
                    Phai = radNam.Checked
                };

                db.SinhVien.Add(sv);
            }
            else
            {
                var sv = db.SinhVien.Find(id);
                if (sv != null)
                {
                    sv.MaSV = txtMASV.Text;
                    sv.HoVaTen = txtHoTen.Text;
                    sv.DienThoai = txtDienThoai.Text;
                    sv.DiaChi = txtDiaChi.Text;
                    sv.Khoa = txtKhoa.Text;
                    sv.Email = txtEmail.Text;
                    sv.Phai = radNam.Checked;
                }
            }

            db.SaveChanges();
            LoadSinhVien();
            BatTatChucNang(false);
        }

       

        
    }
}
