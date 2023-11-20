using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinh
{
    public partial class QuanLyHocSinh : Form
    {
        string maHs = "";
        private void loadData()
        {
            dgvHocSinh.DataSource = Database.Query("select MaHocSinh,HoTen,NgaySinh,DiaChi,Email,DienThoai,TenLop from HocSinh inner join Lop on HocSinh.MaLop = Lop.MaLop");
            maHs = "";
            txtHoTen.Text = "";
            txtDiaChi.Text = "";
            txtEmail.Text = "";
            txtSdt.Text = "";
            txtMahs.Text = "";
        }
        public QuanLyHocSinh()
        {
            InitializeComponent();
            loadData();
            loadCbbLop();
        }
        private void loadCbbLop()
        {
            cbbLop.ValueMember = "MaLop";
            cbbLop.DisplayMember = "TenLop";
            cbbLop.DataSource = Database.Query("select * from Lop");
        }
        private bool checkForm()
        {
            bool ketQua = true;
            erpBaoLoi.Clear();
            if (txtHoTen.Text == "")
            {
                erpBaoLoi.SetError(txtHoTen, "Chưa điền họ tên.");
                ketQua = false;
            }
            if (txtHoTen.Text.Length > 35)
            {
                erpBaoLoi.SetError(txtHoTen, "Họ tên vượt quá 35 ký tự.");
                ketQua = false;
            }
            if (txtDiaChi.Text == "")
            {
                erpBaoLoi.SetError(txtDiaChi, "Chưa điền địa chỉ.");
                ketQua = false;
            }
            if (txtDiaChi.Text.Length > 100)
            {
                erpBaoLoi.SetError(txtDiaChi, "Địa chỉ vượt quá 100 ký tự.");
                ketQua = false;
            }
            if (txtEmail.Text == "")
            {
                erpBaoLoi.SetError(txtEmail, "Chưa điền email.");
                ketQua = false;
            }
            if (txtEmail.Text.Length > 50)
            {
                erpBaoLoi.SetError(txtEmail, "Email vượt quá 50 ký tự.");
                ketQua = false;
            }
            if (txtSdt.Text == "")
            {
                erpBaoLoi.SetError(txtSdt, "Chưa điền số điện thoại.");
                ketQua = false;
            }
            if (txtSdt.Text.Length > 10)
            {
                erpBaoLoi.SetError(txtSdt, "Số điện thoại vượt quá 10 ký tự.");
                ketQua = false;
            }
            return ketQua;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkForm() == false)
                {
                    return;
                }
                //if (txtHoTen.Text == "" || txtDiaChi.Text == "" || txtEmail.Text == "" || txtSdt.Text == "")
                //{
                //    MessageBox.Show("Các ô không được để trống.");
                //    return;
                //}
                //else if (txtHoTen.Text.Length > 35 || txtDiaChi.Text.Length > 100 || txtEmail.Text.Length > 50 || txtSdt.Text.Length > 10)
                //{
                //    MessageBox.Show("Quá độ dài dữ liệu.");
                //    return;
                //}
                string query = "insert into HocSinh(HoTen, NgaySinh, DiaChi, Email, DienThoai, MaLop) values (@HoTen, @NgaySinh, @DiaChi, @Email, @DienThoai, @MaLop)";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@HoTen", txtHoTen.Text);
                parameters.Add("@NgaySinh", dtpNgaySinh.Value);
                parameters.Add("@DiaChi", txtDiaChi.Text);
                parameters.Add("@Email", txtEmail.Text);
                parameters.Add("@DienThoai", txtSdt.Text);
                parameters.Add("@MaLop", cbbLop.SelectedValue.ToString());
                Database.Execute(query, parameters);
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkForm() == false)
                {
                    return;
                }
                string query = "update HocSinh set HoTen=@HoTen, NgaySinh=@NgaySinh, DiaChi=@DiaChi, Email=@Email, DienThoai=@DienThoai, MaLop=@MaLop where MaHocSinh=@MaHocSinh";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@MaHocSinh", maHs);
                parameters.Add("@HoTen", txtHoTen.Text);
                parameters.Add("@NgaySinh", dtpNgaySinh.Value);
                parameters.Add("@DiaChi", txtDiaChi.Text);
                parameters.Add("@Email", txtEmail.Text);
                parameters.Add("@DienThoai", txtSdt.Text);
                parameters.Add("@MaLop", cbbLop.SelectedValue.ToString());
                Database.Execute(query, parameters);
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "delete HocSinh where MaHocSinh=@MaHocSinh";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@MaHocSinh", int.Parse(maHs));
                Database.Execute(query, parameters);
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void btnTk_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "select MaHocSinh,HoTen,NgaySinh,DiaChi,Email,DienThoai,TenLop from HocSinh inner join Lop on HocSinh.MaLop = Lop.MaLop where 1=1";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                if (chbMa.Checked)
                {
                    query += " AND MaHocSinh=@MaHocSinh";
                    parameters.Add("@MaHocSinh", txtMahs.Text);
                }
                if (chbHoTen.Checked)
                {
                    query = query + " AND HoTen LIKE '%' + @HoTen + '%'";
                    parameters.Add("@HoTen", txtHoTen.Text);
                }
                if (chbNgaySinh.Checked)
                {
                    query = query + " AND NgaySinh=@NgaySinh";
                    parameters.Add("@NgaySinh", dtpNgaySinh.Value);
                }
                if (chbDiaChi.Checked)
                {
                    query = query + " AND DiaChi LIKE '%' + @DiaChi + '%'";
                    parameters.Add("@DiaChi", txtDiaChi.Text);
                }
                if (chbEmail.Checked)
                {
                    query = query + " AND Email LIKE '%' + @Email + '%'";
                    parameters.Add("@Email", txtEmail.Text);
                }
                if (chbSdt.Checked)
                {
                    query = query + " AND DienThoai LIKE '%' + @DienThoai + '%'";
                    parameters.Add("@DienThoai", txtSdt.Text);
                }
                if (chbLop.Checked)
                {
                    query = query + " AND Lop.MaLop LIKE '%' + @MaLop + '%'";
                    parameters.Add("@MaLop", cbbLop.SelectedValue.ToString());
                }
                dgvHocSinh.DataSource = Database.Query(query, parameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void quảnLýLớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formQllh f = new formQllh();
            this.Hide();
            f.ShowDialog();
        }
        private void dgvHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                maHs = dgvHocSinh.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtMahs.Text = maHs;
                txtHoTen.Text = dgvHocSinh.Rows[e.RowIndex].Cells[1].Value.ToString();
                dtpNgaySinh.Text = dgvHocSinh.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtDiaChi.Text = dgvHocSinh.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtEmail.Text = dgvHocSinh.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtSdt.Text = dgvHocSinh.Rows[e.RowIndex].Cells[5].Value.ToString();
                cbbLop.Text = dgvHocSinh.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
        }
        private void chbMa_CheckedChanged(object sender, EventArgs e)
        {
            if(chbMa.Checked) txtMahs.Enabled = true;
            else txtMahs.Enabled = false;
        }
        private void btnHt_Click(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
