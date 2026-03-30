using ClosedXML.Excel;
using QLKTX.Data;
using System;
using System.Linq;
using System.Windows.Forms;

namespace QLKTX.Forms
{
    public partial class frmNhanVien : Form
    {
        QLKTXDbContext db = new QLKTXDbContext();
        bool xuLyThem = false;
        int id = 0;

        public frmNhanVien()
        {
            InitializeComponent();
        }

        // ================= LOAD =================
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            cboQuyenHan.Items.Clear();
            cboQuyenHan.Items.Add("Admin");
            cboQuyenHan.Items.Add("User");
            cboQuyenHan.Text = "Admin";

            LoadNhanVien();
            BatTatChucNang(false);
        }

        void LoadNhanVien()
        {
            var list = db.NhanVien
                .Select(nv => new
                {
                    nv.ID,
                    MaNV = nv.MaNV ?? "",
                    HoVaTen = nv.HoVaTen ?? "",
                    TenDangNhap = nv.TenDangNhap ?? "",
                    DienThoai = nv.DienThoai ?? "",
                    DiaChi = nv.DiaChi ?? "",
                    GioiTinh = nv.GioiTinh ?? "",
                    // Kiểm tra null cho kiểu bool? (nullable boolean)
                    QuyenHan = (nv.QuyenHan == true) ? "Admin" : "User"
                })
                .ToList();

            dataGridView1.DataSource = list;

            dataGridView1.Columns["ID"].DisplayIndex = 0;

        }

        // ================= ENABLE =================
        void BatTatChucNang(bool val)
        {
            txtMaNV.Enabled = val;
            txtHoTen.Enabled = val;
            txtTenDangNhap.Enabled = val;
            txtMatKhau.Enabled = val;
            txtDienThoai.Enabled = val;
            txtDiaChi.Enabled = val;

            radNam.Enabled = val;
            radNu.Enabled = val;
            cboQuyenHan.Enabled = val;

            btnLuu.Enabled = val;
            btnHuyBo.Enabled = val;

            btnThem.Enabled = !val;
            btnSua.Enabled = !val;
            btnXoa.Enabled = !val;
            btnNhap.Enabled = !val;
            btnXuat.Enabled = !val;

            dataGridView1.Enabled = !val;
        }

        // ================= GRID =================
        private void dataGridView1_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dataGridView1.Rows[e.RowIndex];

            id = Convert.ToInt32(row.Cells["ID"].Value);

            txtMaNV.Text = row.Cells["MaNV"].Value?.ToString() ?? "";
            txtHoTen.Text = row.Cells["HoVaTen"].Value?.ToString() ?? "";
            txtTenDangNhap.Text = row.Cells["TenDangNhap"].Value?.ToString() ?? "";
            txtDienThoai.Text = row.Cells["DienThoai"].Value?.ToString() ?? "";
            txtDiaChi.Text = row.Cells["DiaChi"].Value?.ToString() ?? "";

            string gt = row.Cells["GioiTinh"].Value?.ToString() ?? "";
            radNam.Checked = gt == "Nam";
            radNu.Checked = gt == "Nữ";

            cboQuyenHan.Text = row.Cells["QuyenHan"].Value?.ToString() ?? "User";
        }

        // ================= THÊM =================
        private void btnThem_Click(object? sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);

            txtMaNV.Clear();
            txtHoTen.Clear();
            txtTenDangNhap.Clear();
            txtMatKhau.Clear();
            txtDienThoai.Clear();
            txtDiaChi.Clear();

            radNam.Checked = true;
            cboQuyenHan.Text = "Admin";
        }

        // ================= SỬA =================
        private void btnSua_Click(object? sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);

            id = (int)dataGridView1.CurrentRow.Cells["ID"].Value;
        }

        // ================= XÓA =================
        private void btnXoa_Click(object? sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            int id = (int)dataGridView1.CurrentRow.Cells["ID"].Value;


            var nv = db.SinhVien.Find(id);
            if (nv != null)
            {
                db.SinhVien.Remove(nv);
                db.SaveChanges();
            }


            LoadNhanVien();
        }

        // ================= LƯU =================
        private void btnLuu_Click(object? sender, EventArgs e)
        {
            string gioiTinh = radNam.Checked ? "Nam" : "Nữ";
            bool quyenHan = cboQuyenHan.Text == "Admin";

            if (string.IsNullOrWhiteSpace(txtMaNV.Text))
            {
                MessageBox.Show("Thiếu mã NV");
                return;
            }

            if (xuLyThem)
            {
                if (db.NhanVien.Any(x => x.MaNV == txtMaNV.Text))
                {
                    MessageBox.Show("Mã NV đã tồn tại");
                    return;
                }

                var nv = new NhanVien()
                {
                    MaNV = txtMaNV.Text,
                    HoVaTen = txtHoTen.Text,
                    TenDangNhap = txtTenDangNhap.Text,
                    MatKhau = txtMatKhau.Text,
                    DienThoai = txtDienThoai.Text,
                    DiaChi = txtDiaChi.Text,
                    GioiTinh = gioiTinh,
                    QuyenHan = quyenHan
                };

                db.NhanVien.Add(nv);
            }
            else
            {
                var nv = db.NhanVien.Find(id);
                if (nv != null)
                {
                    nv.MaNV = txtMaNV.Text;
                    nv.HoVaTen = txtHoTen.Text;
                    nv.TenDangNhap = txtTenDangNhap.Text;
                    nv.MatKhau = txtMatKhau.Text;
                    nv.DienThoai = txtDienThoai.Text;
                    nv.DiaChi = txtDiaChi.Text;
                    nv.GioiTinh = gioiTinh;
                    nv.QuyenHan = quyenHan;
                }
            }

            db.SaveChanges();
            LoadNhanVien();
            BatTatChucNang(false);
        }

        // ================= HỦY =================
        private void btnHuyBo_Click(object? sender, EventArgs e)
        {

            txtMaNV.Clear();
            txtHoTen.Clear();
            txtDienThoai.Clear();
            txtDiaChi.Clear();
            txtTenDangNhap.Clear();
            txtMatKhau.Clear();
            radNam.Checked = true;

            BatTatChucNang(false);
        }

        // ================= TÌM =================
        private void btnTimKiem_Click(object? sender, EventArgs e)
        {
            string keyword = (txtTimKiem.Text ?? "").ToLower();

            var list = db.NhanVien
                .Where(nv =>
                    (nv.MaNV ?? "").ToLower().Contains(keyword) ||
                    (nv.HoVaTen ?? "").ToLower().Contains(keyword)
                )
                .Select(nv => new
                {
                    nv.ID,
                    nv.MaNV,
                    nv.HoVaTen,
                    nv.TenDangNhap,
                    nv.DienThoai,
                    nv.DiaChi,
                    nv.GioiTinh,
                    QuyenHan = (nv.QuyenHan ?? true) ? "Admin" : "User"
                })
                .ToList();

            dataGridView1.DataSource = list;
        }

        // ================= NHẬP EXCEL =================
        private void btnNhap_Click(object? sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Excel Files|*.xlsx";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (var wb = new XLWorkbook(ofd.FileName))
                    {
                        var ws = wb.Worksheet(1);
                        int rowCount = ws.LastRowUsed().RowNumber();

                        int them = 0;

                        for (int i = 2; i <= rowCount; i++)
                        {
                            string maNV = ws.Cell(i, 1).GetString().Trim();
                            if (string.IsNullOrEmpty(maNV)) continue;

                            if (db.NhanVien.Any(x => x.MaNV == maNV)) continue;
                            string gt = ws.Cell(i, 7).GetValue<string>()?.Trim() ?? "";

                            if (gt != "Nam" && gt != "Nữ")
                                gt = "Nam"; // default

                            var nv = new NhanVien()
                            {
                                MaNV = maNV,
                                HoVaTen = ws.Cell(i, 2).GetValue<string>(),
                                TenDangNhap = ws.Cell(i, 3).GetValue<string>(),
                                MatKhau = ws.Cell(i, 4).GetValue<string>(),
                                DienThoai = ws.Cell(i, 5).GetValue<string>(),
                                DiaChi = ws.Cell(i, 6).GetValue<string>(),
                                GioiTinh = gt,
                                QuyenHan = ws.Cell(i, 8).GetValue<string>() == "Admin"
                            };

                            db.NhanVien.Add(nv);
                            them++;
                        }

                        db.SaveChanges();
                        LoadNhanVien();

                        MessageBox.Show($"Đã nhập {them} nhân viên!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // ================= XUẤT EXCEL =================
        private void btnXuat_Click(object? sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Title = "Xuất danh sách nhân viên ra Excel";
                sfd.Filter = "Excel Files|*.xlsx";
                // Đặt tên file mặc định có kèm ngày giờ để tránh trùng lặp
                sfd.FileName = "DanhSachNhanVien_" + DateTime.Now.ToString("yyyyMMdd_HHmm") + ".xlsx";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (var wb = new XLWorkbook())
                        {
                            var ws = wb.Worksheets.Add("NhanVien");

                            // 1. THIẾT LẬP TIÊU ĐỀ (HEADER)
                            string[] header = {
                        "MaNV", "HoVaTen", "TenDangNhap", "MatKhau",
                        "DienThoai", "DiaChi", "GioiTinh", "QuyenHan"
                    };

                            for (int i = 0; i < header.Length; i++)
                            {
                                var cell = ws.Cell(1, i + 1);
                                cell.Value = header[i];
                                cell.Style.Font.Bold = true; // In đậm
                                cell.Style.Fill.BackgroundColor = XLColor.LightGray; // Đổ nền xám
                                cell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center; // Căn giữa
                            }

                            // 2. ĐỔ DỮ LIỆU (DATA)
                            var listNhanVien = db.NhanVien.ToList();
                            int row = 2;

                            foreach (var nv in listNhanVien)
                            {
                                ws.Cell(row, 1).Value = nv.MaNV;
                                ws.Cell(row, 2).Value = nv.HoVaTen;
                                ws.Cell(row, 3).Value = nv.TenDangNhap;
                                ws.Cell(row, 4).Value = nv.MatKhau;
                                ws.Cell(row, 5).Value = nv.DienThoai;
                                ws.Cell(row, 6).Value = nv.DiaChi;
                                ws.Cell(row, 7).Value = nv.GioiTinh;

                                // Xử lý Quyền hạn (An toàn với NULL)
                                ws.Cell(row, 8).Value = (nv.QuyenHan == true) ? "Admin" : "User";

                                row++;
                            }

                            // 3. ĐỊNH DẠNG (FORMAT)
                            // Tự động căn chỉnh độ rộng cột theo nội dung
                            ws.Columns().AdjustToContents();

                            // Kẻ khung (Border) cho toàn bộ vùng dữ liệu
                            var range = ws.Range(1, 1, row - 1, header.Length);
                            range.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                            range.Style.Border.InsideBorder = XLBorderStyleValues.Thin;

                            // 4. LƯU FILE
                            wb.SaveAs(sfd.FileName);
                            MessageBox.Show("Xuất danh sách nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xuất Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}