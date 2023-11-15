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
            dgvHocSinh.DataSource = Database.Query("select * from HocSinh");
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
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtHoTen.Text == "" || txtDiaChi.Text == "" || txtEmail.Text == "" || txtSdt.Text == "")
                {
                    MessageBox.Show("Các ô không được để trống.");
                    return;
                }
                else if (txtHoTen.Text.Length > 35 || txtDiaChi.Text.Length > 100 || txtEmail.Text.Length > 50 || txtSdt.Text.Length > 10)
                {
                    MessageBox.Show("Quá độ dài dữ liệu.");
                    return;
                }
                string query = "insert into HocSinh(HoTen, NgaySinh, DiaChi, Email, DienThoai) values (@HoTen, @NgaySinh, @DiaChi, @Email, @DienThoai)";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@HoTen", txtHoTen.Text);
                parameters.Add("@NgaySinh", dtpNgaySinh.Value);
                parameters.Add("@DiaChi", txtDiaChi.Text);
                parameters.Add("@Email", txtEmail.Text);
                parameters.Add("@DienThoai", txtSdt.Text);
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
                if (txtHoTen.Text == "" || txtDiaChi.Text == "" || txtEmail.Text == "" || txtSdt.Text == "")
                {
                    MessageBox.Show("Các ô không được để trống.");
                    return;
                }
                else if (txtHoTen.Text.Length > 35 || txtDiaChi.Text.Length > 100 || txtEmail.Text.Length > 50 || txtSdt.Text.Length > 10)
                {
                    MessageBox.Show("Quá độ dài dữ liệu.");
                    return;
                }
                string query = "update HocSinh set HoTen=@HoTen, NgaySinh=@NgaySinh, DiaChi=@DiaChi, Email=@Email, DienThoai=@DienThoai where MaHocSinh=@MaHocSinh";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@MaHocSinh", maHs);
                parameters.Add("@HoTen", txtHoTen.Text);
                parameters.Add("@NgaySinh", dtpNgaySinh.Value);
                parameters.Add("@DiaChi", txtDiaChi.Text);
                parameters.Add("@Email", txtEmail.Text);
                parameters.Add("@DienThoai", txtSdt.Text);
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
                string query = "select * from HocSinh where 1=1";
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
