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
    public partial class frmShowWorkDay : Form
    {
        private SqlConnection con;
        private SqlDataAdapter da = new SqlDataAdapter();
        private AppConfig applicationConfiguration;
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dt3 = new DataTable();
        int employeeID = 0;
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
        private void GetListWorkToEmployeeID(int employeeID)
        {
            ClearDataGridView();
            dt = new DataTable();
            connect();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"SELECT tblEmployee.fldEmployeeID as 'Mã Nhân Viên',tblEmployee.fldFirstName as 'Họ',
                                tblEmployee.fldLastName as 'Tên',tblEmployee.fldGroupID as 'Nhóm',tblEmployeeWorkTmp.fldWorkName as 'Công Việc',
                                tblEmployeeWorkTmp.fldEmployeeWorkDate as 'Ngày Làm Việc'
                                FROM tblEmployee
                                INNER JOIN (
                                SELECT tblWork.fldWorkID,tblWork.fldWorkName,tblEmployeeWork.fldEmployeeID,tblEmployeeWork.fldEmployeeWorkDate 
                                FROM tblWork INNER JOIN tblEmployeeWork
                                ON tblWork.fldWorkID = tblEmployeeWork.fldWorkID) tblEmployeeWorkTmp
                                ON tblEmployee.fldEmployeeID = tblEmployeeWorkTmp.fldEmployeeID 
                                Where tblEmployeeWorkTmp.fldEmployeeWorkDate=CONVERT(varchar, getdate(), 23)
                                and tblEmployee.fldEmployeeID=@fldEmployeeID";
            cmd.Parameters.AddWithValue("@fldEmployeeID", employeeID);
            da.SelectCommand = cmd;
            da.Fill(dt);
            dgvDS.DataSource = dt;
        }
        /// <summary>
        /// Lấy thông tin của nhân viên
        /// </summary>
        /// <param name="employeeID"></param>
        private void GetEmployeeInfo(int employeeID)
        {
            connect();
            string query = @"SELECT fldEmployeeID ,fldFirstName,fldLastName FROM tblEmployee Where  fldEmployeeID=@fldEmployeeID";
            using (SqlCommand command = new SqlCommand(query, con))
            {
                command.Parameters.AddWithValue("@fldEmployeeID", employeeID);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string employeeName = reader.GetString(1) + " " + reader.GetString(2);
                        lbName.Text = "Employee Name : " + employeeName;
                        lbID.Text = "Employee ID : " + employeeID;
                        break;
                    }
                }
            }

        }
        //========================================
        //Làm trắng DataGridView
        private void ClearDataGridView()
        {
            dgvDS.DataSource = null;
            dgvDS.Rows.Clear();
            dgvDS.Refresh();
        }

        public frmShowWorkDay(Configuration appConfig)
        {
            applicationConfiguration = (AppConfig)appConfig;
            InitializeComponent();

        }
        public frmShowWorkDay()
        {

        }
        public frmShowWorkDay(Configuration appConfig, int employeeID)
        {
            applicationConfiguration = (AppConfig)appConfig;
            this.employeeID = employeeID;
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            GetListWorkToEmployeeID(employeeID);
            GetEmployeeInfo(employeeID);
        }
        private void dgvDS_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
