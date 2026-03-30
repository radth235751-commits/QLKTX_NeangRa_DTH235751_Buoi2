using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using QLKTX.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;


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
            btnDoiAnh.Enabled = giaTri;
            btnNhap.Enabled = !giaTri;
            btnXuat.Enabled = !giaTri;
        }
        private void frmSinhVien_Load(object? sender, EventArgs e)
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
                    DiaChi = sv.DiaChi,
                    HinhAnh = sv.HinhAnh,
                    Email = sv.Email,
                    Phai = sv.Phai == true ? "Nam" : "Nữ"

                })
                .ToList();
            //ảnh
            dataGridView1.DataSource = list;
            dataGridView1.Columns["HinhAnh"].Visible = false;
            dataGridView1.RowTemplate.Height = 80;
            ((DataGridViewImageColumn)dataGridView1.Columns["Anh"]).ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridView1.Columns["Anh"].Width = 100;


            dataGridView1.Columns["ID"].DisplayIndex = 0;
            dataGridView1.Columns["MaSV"].DisplayIndex = 1;
            dataGridView1.Columns["Anh"].DisplayIndex = dataGridView1.Columns.Count - 1;

            dataGridView1.CellClick += dataGridView1_CellClick;
        }


        private void btnThem_Click(object? sender, EventArgs e)
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
        private void btnXoa_Click(object? sender, EventArgs e)
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
        private void btnSua_Click(object? sender, EventArgs e)
        {


            xuLyThem = false;
            BatTatChucNang(true);

            id = (int)dataGridView1.CurrentRow.Cells["ID"].Value;
        }

        // ================= CLICK GRID =================
        private void dataGridView1_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dataGridView1.Rows[e.RowIndex];
            int id = (int)dataGridView1.CurrentRow.Cells["ID"].Value;

            txtMASV.Text = row.Cells["MaSV"].Value?.ToString() ?? "";
            txtHoTen.Text = row.Cells["HoVaTen"].Value?.ToString() ?? "";
            txtDienThoai.Text = row.Cells["DienThoai"].Value?.ToString() ?? "";
            txtKhoa.Text = row.Cells["Khoa"].Value?.ToString() ?? "";
            txtEmail.Text = row.Cells["Email"].Value?.ToString() ?? "";
            txtDiaChi.Text = row.Cells["DiaChi"].Value?.ToString() ?? "";
            picHinhAnh.ImageLocation = row.Cells["HinhAnh"].Value?.ToString() ?? "";

            string gt = row.Cells[8].Value?.ToString() ?? "";
            radNam.Checked = gt == "Nam";
            radNu.Checked = gt == "Nữ";
        }




        // ================= TÌM KIẾM =================
        private void btnTimKiem_Click(object? sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.ToLower();


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
                    DiaChi = sv.DiaChi,
                    HinhAnh = sv.HinhAnh,
                    Email = sv.Email,
                    Phai = sv.Phai == true ? "Nam" : "Nữ"
                })
                .ToList();

            dataGridView1.DataSource = list;

        }

        // ================= CLEAR =================
        private void btnHuyBo_Click(object? sender, EventArgs e)
        {
            txtMASV.Clear();
            txtHoTen.Clear();
            txtDienThoai.Clear();
            txtDiaChi.Clear();
            txtKhoa.Clear();
            txtEmail.Clear();
            radNam.Checked = true;

            BatTatChucNang(false);
        }
        private void btnLuu_Click(object? sender, EventArgs e)
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
                    Phai = radNam.Checked,
                    HinhAnh = picHinhAnh.ImageLocation

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
                    sv.HinhAnh = picHinhAnh.ImageLocation;

                }
            }

            db.SaveChanges();
            LoadSinhVien();
            BatTatChucNang(false);
        }
        private void btnDoiAnh_Click(object? sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image Files|*.jpg;*.png;*.jpeg";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                picHinhAnh.ImageLocation = dlg.FileName;
            }
        }

        private void btnThoat_Click(object? sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNhap_Click(object? sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Nhập dữ liệu Sinh viên từ tập tin Excel";
            openFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    using (XLWorkbook workbook = new XLWorkbook(openFileDialog.FileName))
                    {
                        IXLWorksheet worksheet = workbook.Worksheet(1);
                        bool firstRow = true;
                        string readRange = "1:1";

                        foreach (IXLRow row in worksheet.RowsUsed())
                        {
                            // 1. Đọc dòng tiêu đề để tạo cột cho DataTable
                            if (firstRow)
                            {
                                readRange = string.Format("{0}:{1}", 1, row.LastCellUsed().Address.ColumnNumber);
                                foreach (IXLCell cell in row.Cells(readRange))
                                {
                                    table.Columns.Add(cell.Value.ToString().Trim());
                                }
                                firstRow = false;
                            }
                            else // 2. Đọc nội dung các dòng tiếp theo
                            {
                                table.Rows.Add();
                                int cellIndex = 0;
                                foreach (IXLCell cell in row.Cells(readRange))
                                {
                                    table.Rows[table.Rows.Count - 1][cellIndex] = cell.Value.ToString();
                                    cellIndex++;
                                }
                            }
                        }

                        // 3. Đưa dữ liệu từ DataTable vào Database thông qua Entity Framework
                        if (table.Rows.Count > 0)
                        {
                            int soLuongThem = 0;
                            foreach (DataRow r in table.Rows)
                            {
                                string maSV = r["MaSV"].ToString().Trim();

                                // Kiểm tra nếu mã sinh viên đã tồn tại thì bỏ qua để tránh lỗi Primary Key
                                if (db.SinhVien.Any(s => s.MaSV == maSV)) continue;

                                SinhVien sv = new SinhVien();
                                sv.MaSV = maSV;
                                sv.HoVaTen = r["HoVaTen"].ToString();
                                sv.DienThoai = r["DienThoai"].ToString();
                                sv.Email = r["Email"].ToString();
                                sv.DiaChi = r["DiaChi"].ToString();
                                sv.Khoa = r["Khoa"].ToString();

                                // Xử lý giới tính từ chữ (Nam/Nữ) sang bool
                                string gioiTinh = r["Phai"].ToString();
                                sv.Phai = gioiTinh.Equals("Nam", StringComparison.OrdinalIgnoreCase);

                                db.SinhVien.Add(sv);
                                soLuongThem++;
                            }

                            db.SaveChanges(); // Lưu vào SQL Server
                            MessageBox.Show("Đã nhập thành công " + soLuongThem + " sinh viên mới.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Gọi hàm Load để cập nhật lại Grid
                            LoadSinhVien();
                        }

                        if (firstRow)
                            MessageBox.Show("Tập tin Excel rỗng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi định dạng tệp: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnXuat_Click(object? sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Title = "Xuất danh sách sinh viên ra Excel";
                sfd.Filter = "Excel Files|*.xlsx";
                sfd.FileName = "DanhSachSinhVien_" + DateTime.Now.ToString("yyyyMMdd_HHmm") + ".xlsx";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (var workbook = new XLWorkbook())
                        {
                            var worksheet = workbook.Worksheets.Add("SinhVien");

                            // HEADER
                            string[] headers = { "ID", "MaSV", "HoVaTen", "DienThoai", "Email", "Khoa", "DiaChi", "Phai", "HinhAnh" };

                            for (int i = 0; i < headers.Length; i++)
                            {
                                var cell = worksheet.Cell(1, i + 1);
                                cell.Value = headers[i];
                                cell.Style.Font.Bold = true;
                                cell.Style.Fill.BackgroundColor = XLColor.LightGray;
                                cell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                            }

                            // DATA
                            var listSinhVien = db.SinhVien.ToList();
                            int currentRow = 2;

                            foreach (var sv in listSinhVien)
                            {
                                worksheet.Cell(currentRow, 1).Value = sv.ID;
                                worksheet.Cell(currentRow, 2).Value = sv.MaSV;
                                worksheet.Cell(currentRow, 3).Value = sv.HoVaTen;
                                worksheet.Cell(currentRow, 4).Value = sv.DienThoai;
                                worksheet.Cell(currentRow, 5).Value = sv.Email;
                                worksheet.Cell(currentRow, 6).Value = sv.Khoa;
                                worksheet.Cell(currentRow, 7).Value = sv.DiaChi;
                                worksheet.Cell(currentRow, 7).Value = (sv.Phai == true ? "Nam" : "Nữ");
                                worksheet.Cell(currentRow, 9).Value = sv.HinhAnh; // lưu path

                                currentRow++;
                                // 👉 THÊM ẢNH (nếu có)
                                if (!string.IsNullOrEmpty(sv.HinhAnh) && File.Exists(sv.HinhAnh))
                                {
                                    worksheet.AddPicture(sv.HinhAnh)
                                        .MoveTo(worksheet.Cell(currentRow, 10))
                                        .Scale(0.5);
                                }

                                currentRow++;
                            }

                            // FORMAT
                            worksheet.Columns().AdjustToContents();
                            var range = worksheet.Range(1, 1, currentRow - 1, headers.Length);
                            range.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                            range.Style.Border.InsideBorder = XLBorderStyleValues.Thin;

                            // SAVE
                            workbook.SaveAs(sfd.FileName);

                            MessageBox.Show("Xuất thành công!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }

        }

        
    }

}
