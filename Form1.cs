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
            connect.DataConnect(sqlStr, gvHocSinh);
        }

        private void RefreshData()
        {
            string sqlStr = "SELECT * FROM HocSinh";
            dbConnection connect = new dbConnection();
            connect.DataConnect(sqlStr, gvHocSinh);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
               HocSinh hocSinh = new HocSinh(txtHoTen.Text, txtDiaChi.Text, txtCMND.Text, dtpNgaySinh.Value);
               HocSinhDAO dao = new HocSinhDAO();
               dao.Add(hocSinh);

               RefreshData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            HocSinh hocSinh = new HocSinh(txtHoTen.Text, txtDiaChi.Text, txtCMND.Text, dtpNgaySinh.Value);
            HocSinhDAO dao = new HocSinhDAO();
            dao.Modify(hocSinh);

            RefreshData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            HocSinh hocSinh = new HocSinh(txtHoTen.Text, txtDiaChi.Text, txtCMND.Text, dtpNgaySinh.Value);
            HocSinhDAO dao = new HocSinhDAO();
            dao.Delete(hocSinh);

            RefreshData();
        }

        private void gv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnGiangVien_Click(object sender, EventArgs e)
        {
            FormGV formGV = new FormGV();
            formGV.ShowDialog();
        }
    }
}
