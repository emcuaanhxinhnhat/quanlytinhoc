﻿
using quanlytinhoc;
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


namespace quanlytinhoc
{
    public partial class frmCoquan : Form
    {
        public frmCoquan()
        {
            InitializeComponent();
        }

        private void frmCoquan_Load(object sender, EventArgs e)
        {
            LoaddatatoGridview();
        }
        private void LoaddatatoGridview()
        {
            try
            {
                DAO.OpenConnection();
                string sql = "select * from tblCoquan ";
                SqlDataAdapter myAdapter = new SqlDataAdapter(sql, DAO.conn);
                DataTable tblCoquan = new DataTable();
                myAdapter.Fill(tblCoquan);
                dataGridViewCoQuan.DataSource = tblCoquan;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                DAO.CloseConnection();
            }

        }

        private void dataGridViewCoQuan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaCQ.Text = dataGridViewCoQuan.CurrentRow.Cells["MaCQ"].Value.ToString();
            txtTenCQ.Text = dataGridViewCoQuan.CurrentRow.Cells["TenCQ"].Value.ToString();
            txtDiaChi.Text = dataGridViewCoQuan.CurrentRow.Cells["DiaChi"].Value.ToString();
            txtDienThoai.Text = dataGridViewCoQuan.CurrentRow.Cells["DienThoai"].Value.ToString();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            txtMaCQ.Enabled = true;
            txtTenCQ.Enabled = true;
            txtDiaChi.Enabled = true;
            txtDienThoai.Enabled = true;

            txtMaCQ.Text = "";
            txtTenCQ.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string sql = "update tblCoquan set TenCQ = N'" + txtTenCQ.Text.Trim() + "' where MaCQ = '" + txtMaCQ.Text + "' ";
            DAO.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = DAO.conn;
            cmd.ExecuteNonQuery();
            DAO.CloseConnection();
            LoaddatatoGridview();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql = "delete from tblCoquan where MaCQ = '" + txtMaCQ.Text + "'";
            DAO.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = DAO.conn;
            cmd.ExecuteNonQuery();
            DAO.CloseConnection();
            LoaddatatoGridview();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (txtMaCQ.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã cơ quan ");
                txtMaCQ.Focus();
                return;

            }
            if (txtTenCQ.Text == "")
            {
                MessageBox.Show("bạn chưa nhập tên cơ quan");
                txtTenCQ.Focus();

                return;
            }
            if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ ");
                txtDiaChi.Focus();
                return;

            }
            if (txtDienThoai.Text == "")
            {
                MessageBox.Show("bạn chưa nhập số điện thoại ");
                txtDienThoai.Focus();

                return;
            }

            string sqlCheckKey = "Select * from tblCoquan where MaCQ ='" + txtMaCQ.Text.Trim() + "'";
            DAO.OpenConnection();

            if (DAO.checkKeyExit(sqlCheckKey))
            {
                MessageBox.Show(" Mã cơ quan đã tồn tại");
                DAO.CloseConnection();
                txtMaCQ.Focus();
                return;
            }
            else
            {
                string sql = " insert into tblCoquan values('" + txtMaCQ.Text.Trim() + "', N'" + txtTenCQ.Text.Trim() + "', N'" + txtDiaChi.Text.Trim() + "', N'" + txtDienThoai.Text.Trim() + "')";


                SqlCommand cmd = new SqlCommand(sql, DAO.conn);
                cmd.ExecuteNonQuery();
                DAO.CloseConnection();
                LoaddatatoGridview();

            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
