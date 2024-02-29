using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace thucHanh
{
    public partial class Form1 : Form
    {
        //SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public Form1()
        {
            InitializeComponent();
 
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            string sqlStr = "SELECT * FROM HocSinh";

            dbConnection connect = new dbConnection();
            connect.DataConnect(sqlStr, uc2.gvThongTin);

            uc2.btnThem.Click += btnThem_Click;
            uc2.btnXoa.Click += btnXoa_Click;
            uc2.btnSua.Click += btnSua_Click;
            uc2.gvThongTin.CellClick += gvThongTin_CellClick;
        }

        private void gvThongTin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Make sure the click is on a valid row
            {
                DataGridViewRow row = uc2.gvThongTin.Rows[e.RowIndex];

                // Populate text boxes with data from the selected row
                uc2.txtId.Text = row.Cells["id"].Value.ToString();
                uc2.txtHoTen.Text = row.Cells["ten"].Value.ToString();          
                uc2.txtDiaChi.Text = row.Cells["dia_chi"].Value.ToString();
                uc2.txtCMND.Text = row.Cells["cmnd"].Value.ToString();
                uc2.dtpNgaySinh.Value = Convert.ToDateTime(row.Cells["ngay_thang_nam"].Value);
                uc2.txtPhone.Text = row.Cells["phone"].Value.ToString();
                uc2.txtEmail.Text = row.Cells["email"].Value.ToString();


                string gioiTinh = row.Cells["gioi_tinh"].Value.ToString();
                if (gioiTinh == "nam")
                {
                    uc2.radNam.Checked = true;
                    uc2.radNu.Checked = false;
                }
                else if (gioiTinh == "nu")
                {
                    uc2.radNam.Checked = false;
                    uc2.radNu.Checked = true;
                }

            }
        }
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool IsValidPhone(string phone)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(phone, @"^\d{3} \d{4} \d{3}$");
        }


        private bool ValidateFields()
        {
            if (string.IsNullOrEmpty(uc2.txtHoTen.Text))
            {
                MessageBox.Show("Please enter a name.");
                return false;
            }

            if (string.IsNullOrEmpty(radGioiTinh() ))
            {
                MessageBox.Show("Please select gender.");
                return false;
            }

            if (string.IsNullOrEmpty(uc2.txtDiaChi.Text))
            {
                MessageBox.Show("Please enter an address.");
                return false;
            }


            if (string.IsNullOrEmpty(uc2.txtCMND.Text))
            {
                MessageBox.Show("Please enter an ID number.");
                return false;
            }

            if (uc2.dtpNgaySinh.Value == DateTime.MinValue)
            {
                MessageBox.Show("Please select a birth date.");
                return false;
            }

            if (string.IsNullOrEmpty(uc2.txtPhone.Text))
            {
                MessageBox.Show("Please enter a phone number.");
                return false;
            }
            else if (!IsValidPhone(uc2.txtPhone.Text))
            {
                MessageBox.Show("Please enter an valid phone number format.");
                return false;
            }


            if (string.IsNullOrEmpty(uc2.txtEmail.Text))
            {
                MessageBox.Show("Please enter an email address.");
                return false;
            }
            else if (!IsValidEmail(uc2.txtEmail.Text))
            {
                MessageBox.Show("Please enter an valid email.");
                return false;

            }

            return true;
        }

        private void RefreshData()
        {
            string sqlStr = "SELECT * FROM HocSinh";
            dbConnection connect = new dbConnection();
            connect.DataConnect(sqlStr, uc2.gvThongTin);
        }

        public string radGioiTinh()
        {
            if (uc2.radNam.Checked)
            {
                return "nam";
            }
            else if (uc2.radNu.Checked)
            {
                return "nu";
            }
            else
            {
                return ""; // Neither "nam" nor "nu" selected
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
            {
                return;
            }

            int id = int.Parse(uc2.txtId.Text);
            string gioiTinh = radGioiTinh();

            HocSinh hocSinh = new HocSinh( id ,uc2.txtHoTen.Text, gioiTinh, uc2.txtDiaChi.Text, uc2.txtCMND.Text, uc2.dtpNgaySinh.Value, uc2.txtPhone.Text, uc2.txtEmail.Text);
            HocSinhDAO dao = new HocSinhDAO();
            dao.Add(hocSinh);

            RefreshData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            int id = int.Parse(uc2.txtId.Text);
            string gioiTinh = radGioiTinh();

            if (string.IsNullOrEmpty(gioiTinh))
            {
                MessageBox.Show("Please select gender.");
                return;
            }

            HocSinh hocSinh = new HocSinh(id, uc2.txtHoTen.Text, gioiTinh, uc2.txtDiaChi.Text, uc2.txtCMND.Text, uc2.dtpNgaySinh.Value, uc2.txtPhone.Text, uc2.txtEmail.Text);
            HocSinhDAO dao = new HocSinhDAO();
            dao.Modify(hocSinh);

            RefreshData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int id = int.Parse(uc2.txtId.Text);
            string gioiTinh = radGioiTinh();

            HocSinh hocSinh = new HocSinh(id, uc2.txtHoTen.Text, gioiTinh, uc2.txtDiaChi.Text, uc2.txtCMND.Text, uc2.dtpNgaySinh.Value, uc2.txtPhone.Text, uc2.txtEmail.Text);
            HocSinhDAO dao = new HocSinhDAO();
            dao.Delete(hocSinh);

            RefreshData();
        }

        private void gv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }



        private void lblNgayThangNam_Click(object sender, EventArgs e)
        {

        }

        private void btnGiangVien_Click_1(object sender, EventArgs e)
        {
            FormGV formGV = new FormGV();
            formGV.ShowDialog();
        }
    }
}
