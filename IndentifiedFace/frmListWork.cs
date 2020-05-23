using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using IndentifiedFace.Configurations;

namespace IndentifiedFace
{
    public partial class frmListWork : Form
    {
        private SqlConnection con;
        private SqlDataAdapter da = new SqlDataAdapter();
        private AppConfig applicationConfiguration;
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dt3 = new DataTable();
        private void connect()
        {
            //String cn = applicationConfiguration.getDatabaseConnectionString();
            String cn = applicationConfiguration.getDatabaseConnectionString();
            try
            {
                con = new SqlConnection(cn);
                con.Open();
            }
            catch
            {
                MessageBox.Show(applicationConfiguration.getLanguagePackage().getErrorConnectToDatabaseMessage(),
                    applicationConfiguration.getLanguagePackage().getErrorConnectToDatabaseTitle(),
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void disconnect()
        {
            try
            {
                con.Close();
                con.Dispose();
                con = null;
            }
            catch (Exception e) { }

        }
        //=======================
        // Lay list theo manv
        private void GetListOne(string valueToSearch)
        {
            ClearDataGridView();
            dt = new DataTable();
            connect();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"SELECT tblEmployee.fldEmployeeID as 'EmployeeID',tblEmployee.fldFirstName as 'FirstName',
                                tblEmployee.fldLastName as 'LastName',tblEmployee.fldGroupID as 'Department',tblEmployeeWork.fldWorkName as 'WorkName',
                                tblEmployeeWork.fldEmployeeWorkDate as 'Work Day'
                                FROM tblEmployee
                                INNER JOIN (
                                SELECT tblWork.fldWorkID,tblWork.fldWorkName,tblEmployeeWork.fldEmployeeID,tblEmployeeWork.fldEmployeeWorkDate 
                                FROM tblWork INNER JOIN tblEmployeeWork
                                ON tblWork.fldWorkID = tblEmployeeWork.fldWorkID) tblEmployeeWork
                                ON tblEmployee.fldEmployeeID = tblEmployeeWork.fldEmployeeID 
                                Where tblEmployeeWork.fldEmployeeWorkDate=CONVERT(varchar, getdate(), 23)
                                and CONCAT(tblEmployee.fldEmployeeID,tblEmployee.fldFirstName,tblEmployee.fldLastName) LIKE '%" + valueToSearch + "%'";
            da.SelectCommand = cmd;
            da.Fill(dt);
            dgvDS.DataSource = dt;
            //dgvDS.Columns[0].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";


        }

        //===================================
        //Lay list tat ca nv tu ngay ... den ngay ....
        /*private void GetListToDay()
        {
            ClearDataGridView();
            dt1 = new DataTable();
            connect();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"SELECT DISTINCT b.fldEmployeeID as N'Mã nhân viên',
                                        b.fldFirstName as N'Họ
                                     ',b.fldLastName as N'Tên
                                    ', (Case b.fldSex when 'True' then N'Nam
                                    ' else N'Nữ
                                    ' end) as N'Giới tính
                                    ',b.fldBirth as N'Ngày sinh
                                    ', a.fldGroupName as N'Phòng ban
                                    ' FROM   tblGroup a INNER JOIN tblEmployee b
                                            ON a.fldGroupID = b.fldGroupID INNER JOIN tblTimekeeping c
                                            ON b.fldEmployeeID = c.fldEmployeeID  WHERE c.tDatetime between ('" + Convert.ToDateTime(dtpFrom.Value) + "') and ('" + Convert.ToDateTime(dtpTo.Value) + "') ";

            da.SelectCommand = cmd;
            da.Fill(dt1);
            dgvDS.DataSource = dt1;
            //dgvDS.Columns[0].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";


        }*/
        //========================================
        //===================================
        //Lấy tất cả list việc làm
        private void GetWorkList()
        {
            ClearDataGridView();

            dt1 = new DataTable();
            connect();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            //cmd.CommandText = @"SELECT fldWorkName as N'Công Việc',(Case fldWorkStatus when 'True' then N'Đã có người làm' else N'Chưa có người làm' end) as N'Trạng Thái' FROM Employee.dbo.tblWork";
            cmd.CommandText = @"SELECT w.fldWorkName as N'Work Name',w.fldWorkStatus as 'Status'  
                                FROM tblWork w ";

            da.SelectCommand = cmd;
            da.Fill(dt1);
            dgvDS.DataSource = dt1;
        }
        //========================================
        //Lấy list việc làm trong ngày
        private void GetWorkListDay()
        {
            ClearDataGridView();

            dt2 = new DataTable();
            connect();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"SELECT tblEmployee.fldEmployeeID as 'EmployeeID',tblEmployee.fldFirstName as 'FirstName',
                                tblEmployee.fldLastName as 'FirstName',tblEmployee.fldGroupID as 'Department',tblEmployeeWork.fldWorkName as 'WorkName',
                                tblEmployeeWork.fldEmployeeWorkDate as 'Work Day'
                                FROM tblEmployee
                                INNER JOIN (
                                SELECT tblWork.fldWorkID,tblWork.fldWorkName,tblEmployeeWork.fldEmployeeID,tblEmployeeWork.fldEmployeeWorkDate 
                                FROM tblWork INNER JOIN tblEmployeeWork
                                ON tblWork.fldWorkID = tblEmployeeWork.fldWorkID) tblEmployeeWork
                                ON tblEmployee.fldEmployeeID = tblEmployeeWork.fldEmployeeID 
                                Where tblEmployeeWork.fldEmployeeWorkDate=CONVERT(varchar, getdate(), 23)";

            da.SelectCommand = cmd;
            da.Fill(dt2);
            dgvDS.DataSource = dt2;


        }
        //========================================
        //dem ngay cong
        private void demngaycong(string valueToSearch)
        {
            ClearDataGridView();
            dt3 = new DataTable();
            connect();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;//,,
            cmd.CommandText = @"SELECT fldWorkID,fldWorkName,fldWorkStatus  FROM Employee.dbo.tblWork";

            da.SelectCommand = cmd;
            da.Fill(dt3);
            dgvDS.DataSource = dt3;

        }
        //========================================
        //Làm trắng DataGridView
        private void ClearDataGridView()
        {
            dgvDS.DataSource = null;
            dgvDS.Rows.Clear();
            dgvDS.Refresh();
        }

        public frmListWork(Configuration appConfig)
        {
            applicationConfiguration = (AppConfig)appConfig;
            InitializeComponent();
            //dtpFrom.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            //dtpTo.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day + 1);
        }
        private void frmListWork_Load(object sender, EventArgs e)
        {
            //GetList();
            label2.Enabled = true;
            //GetListOne("");
            GetWorkList();

        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            GetWorkList();
        }

        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {
            GetWorkList();
            //dtpTo.Value = DateTime.Now;
        }

        private void dgvDS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //GetList();
            //GetListOne();
            GetWorkList();
        }

        private void bt_checkall_Click(object sender, EventArgs e)
        {
            txt_search.Enabled = false;
            label2.Enabled = false;
            GetWorkList();
        }

        private void bt_getonebyone_Click(object sender, EventArgs e)
        {
            txt_search.Enabled = true;
            label2.Enabled = true;
            string valueToSearch = txt_search.Text.ToString();
            if (valueToSearch.Trim().Length > 0)
            {
                GetListOne(valueToSearch);
            }
        }

        private void bt_available_Click(object sender, EventArgs e)
        {
            txt_search.Enabled = false;
            label2.Enabled = false;
            //string valueToSearch = txt_search.Text.ToString();
            // demngaycong(valueToSearch);
            GetWorkListDay();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
