using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        // UserControl1 uc = new UserControl1();
        private void FormGV_Load(object sender, EventArgs e)
        {
            string sqlStr = "SELECT * FROM HocSinh";

            dbConnection connect = new dbConnection();
            connect.DataConnect(sqlStr, uc1.gvThongTin);

            uc1.btnThem.Click += btnThem_Click;
            uc1.btnXoa.Click += btnXoa_Click;
            uc1.btnSua.Click += btnSua_Click;      

        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            GiangVien gv = new GiangVien(uc1.txtHoTen.Text, uc1.txtDiaChi.Text, uc1.txtCMND.Text, uc1.dtpNgaySinh.Value);
            GiangVienDAO dao = new GiangVienDAO();
            dao.Add(gv);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            GiangVien gv = new GiangVien(uc1.txtHoTen.Text, uc1.txtDiaChi.Text, uc1.txtCMND.Text, uc1.dtpNgaySinh.Value);
            GiangVienDAO dao = new GiangVienDAO();
            dao.Delete(gv);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            GiangVien gv = new GiangVien(uc1.txtHoTen.Text, uc1.txtDiaChi.Text, uc1.txtCMND.Text, uc1.dtpNgaySinh.Value);
            GiangVienDAO dao = new GiangVienDAO();
            dao.Modify(gv);
        }

        private void userControl11_Load_1(object sender, EventArgs e)
        {

        }
    }
}

