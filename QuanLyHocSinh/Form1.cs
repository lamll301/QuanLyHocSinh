using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinh
{
    public partial class formQllh : Form
    {
        private string maLop = "";
        private string tenLop = "";
        private void loadData()
        {
            dgvLopHoc.DataSource = Database.Query("select * from Lop");
            maLop = "";
        }
        private int isTenLopExist(string tenLop)
        {
            string query = "select count(*) from Lop where TenLop=@TenLop";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@TenLop", tenLop);
            DataTable rs = Database.Query(query, parameters);
            int count = Convert.ToInt32(rs.Rows[0][0]);
            return count;
        }
        public formQllh()
        {
            InitializeComponent();
            loadData();
            dgvLopHoc.ReadOnly = true;
            dgvLopHoc.Columns["MaLop"].Visible = false;
        }
        private void dgvLopHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                maLop = dgvLopHoc.Rows[e.RowIndex].Cells[0].Value.ToString();
                tenLop = dgvLopHoc.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtTenLop.Text = tenLop;
            }
        }
        private void btnHt_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenLop.Text.Length > 7)
                {
                    MessageBox.Show("Tên lớp chỉ có độ rộng là 7 kí tự.");
                    return;
                }
                else if (txtTenLop.Text == "")
                {
                    MessageBox.Show("Tên lớp không được để trống.");
                    return;
                }
                else if (isTenLopExist(txtTenLop.Text) != 0)
                {
                    MessageBox.Show("Tên lớp đã tồn tại.");
                    return;
                }

                string query = "insert into Lop (TenLop) values (@TenLop)";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@TenLop", txtTenLop.Text);
                Database.Execute(query, parameters);
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenLop.Text.Length > 7)
                {
                    MessageBox.Show("Tên lớp chỉ có độ rộng là 7 kí tự.");
                    return;
                }
                else if (maLop == "")
                {
                    MessageBox.Show("Phải chọn lớp trước khi sửa.");
                    return;
                }
                else if (txtTenLop.Text == "")
                {
                    MessageBox.Show("Tên lớp không được để trống.");
                    return;
                }
                else if (isTenLopExist(txtTenLop.Text) != 0)
                {
                    MessageBox.Show("Tên lớp đã tồn tại.");
                    return;
                }

                string query = "update Lop set TenLop=@TenLop where MaLop=@MaLop";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@MaLop", int.Parse(maLop));
                parameters.Add("@TenLop", txtTenLop.Text);
                Database.Execute(query, parameters);
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (maLop == "")
                {
                    MessageBox.Show("Phải chọn lớp trước khi xóa.");
                    return;
                }
                string query = "delete Lop where MaLop=@MaLop";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@MaLop", int.Parse(maLop));
                Database.Execute(query, parameters);
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnTk_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "select * from Lop where TenLop like @TenLop";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@TenLop", "%" + txtTenLop.Text + "%");
                dgvLopHoc.DataSource = Database.Query(query, parameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void quảnLýHọcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyHocSinh f = new QuanLyHocSinh();
            this.Hide();
            f.ShowDialog();
        }

        private void dgvLopHoc_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("ENTER");
        }
    }
}
