using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thucHanh
{
    public partial class FormGV : Form
    {
        public FormGV()
        {
            InitializeComponent();
        }
        private void FormGV_Load(object sender, EventArgs e)
        {
            string sqlStr = "SELECT * FROM GiangVien";

            dbConnection connect = new dbConnection();
            connect.DataConnect(sqlStr, uc1.gvThongTin);

            uc1.btnThem.Click += btnThem_Click;
            uc1.btnXoa.Click += btnXoa_Click;
            uc1.btnSua.Click += btnSua_Click;      

        }

        private void RefreshData()
        {
            string sqlStr = "SELECT * FROM GiangVien";
            dbConnection connect = new dbConnection();
            connect.DataConnect(sqlStr, uc1.gvThongTin);
        }

        public string radGioiTinh()
        {
            if (uc1.radNam.Checked)
            {
                return "nam";
            }
            else if (uc1.radNu.Checked)
            {
                return "nu";
            }
            else
            {
                return ""; // Neither "nam" nor "nu" selected
            }
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            int id = int.Parse(uc1.txtId.Text);
            string gioiTinh = radGioiTinh();
            if (string.IsNullOrEmpty(gioiTinh))
            {
                MessageBox.Show("Please select gender.");
                return;
            }


            GiangVien giangVien = new GiangVien(id, uc1.txtHoTen.Text, gioiTinh, uc1.txtDiaChi.Text, uc1.txtCMND.Text, uc1.dtpNgaySinh.Value, uc1.txtPhone.Text, uc1.txtEmail.Text);
            GiangVienDAO dao = new GiangVienDAO();
            dao.Add(giangVien);

            RefreshData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int id = int.Parse(uc1.txtId.Text);
            string gioiTinh = radGioiTinh();


            GiangVien giangVien = new GiangVien(id, uc1.txtHoTen.Text, gioiTinh, uc1.txtDiaChi.Text, uc1.txtCMND.Text, uc1.dtpNgaySinh.Value, uc1.txtPhone.Text, uc1.txtEmail.Text);
            GiangVienDAO dao = new GiangVienDAO();
            dao.Delete(giangVien);

            RefreshData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int id = int.Parse(uc1.txtId.Text);
            string gioiTinh = radGioiTinh();
            if (string.IsNullOrEmpty(gioiTinh))
            {
                MessageBox.Show("Please select gender.");
                return;
            }


            GiangVien giangVien = new GiangVien(id, uc1.txtHoTen.Text, gioiTinh, uc1.txtDiaChi.Text, uc1.txtCMND.Text, uc1.dtpNgaySinh.Value, uc1.txtPhone.Text, uc1.txtEmail.Text);
            GiangVienDAO dao = new GiangVienDAO();
            dao.Modify(giangVien);

            RefreshData();
        }

        private void userControl11_Load_1(object sender, EventArgs e)
        {

        }
    }
}

