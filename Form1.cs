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
               HocSinh hocSinh = new HocSinh(txtHoTen.Text, txtDiaChi.Text, txtCMND.Text, dtpNgaySinh.Text );
               HocSinhDAO dao = new HocSinhDAO();
               dao.Add(hocSinh);

               RefreshData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Parse the date string to DateTime
            if (DateTime.TryParse(dtpNgaySinh.Text, out DateTime ngaySinh))
            {
                // Convert DateTime to string with a specific format
                string ngaySinhString = ngaySinh.ToString("yyyy-MM-dd"); // Adjust the format as needed

                // Create HocSinh object with the formatted date string
                HocSinh hocSinh = new HocSinh(txtHoTen.Text, txtDiaChi.Text, txtCMND.Text, ngaySinhString);

                // Assuming HocSinhDAO.Modify method accepts a HocSinh object
                HocSinhDAO dao = new HocSinhDAO();
                dao.Modify(hocSinh);
            }
            else
            {
                MessageBox.Show("Invalid date format for NgaySinh");
            }

            RefreshData();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            HocSinh hocSinh = new HocSinh(txtHoTen.Text, txtDiaChi.Text, txtCMND.Text, dtpNgaySinh.Text);
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
