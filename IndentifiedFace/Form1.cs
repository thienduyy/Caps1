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
    public partial class Form1 : Form
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
        private void GetListOne( string valueToSearch)
        {
            
            dt.Clear();
            connect();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"SELECT DISTINCT b.fldEmployeeID as 'EmployeeID', b.fldFirstName as 'FirstName', b.fldLastName as 'LastName'
                                    , (Case b.fldSex when 'True' then N'Male' else N'Female' end)
                                    ,b.fldBirth as 'Birthday', a.fldGroupName as 'Department'
                                     FROM tblGroup a INNER JOIN tblEmployee b
                                            ON a.fldGroupID = b.fldGroupID INNER JOIN tblTimekeeping c
                                            ON b.fldEmployeeID = c.fldEmployeeID  WHERE c.tDatetime >= '" + Convert.ToDateTime(dtpFrom.Value) + "' and c.tDatetime <= '" + Convert.ToDateTime(dtpTo.Value) + "' and CONCAT(b.fldEmployeeID,b.fldFirstName,b.fldLastName,b.fldBirth,a.fldGroupName) LIKE '%" + valueToSearch + "%'";

            da.SelectCommand = cmd;
            da.Fill(dt);
            dgvDS.DataSource = dt;
      
            //dgvDS.Columns[0].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";


        }


        //===================================
        //Lay list tat ca nv tu ngay ... den ngay ....
        private void GetList()
        {
            dt1.Clear();
            connect();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"SELECT DISTINCT b.fldEmployeeID as 'EmployeeID',
                                        b.fldFirstName as 'FirstName',b.fldLastName as 'LastName',
                                    (Case b.fldSex when 'True' then N'Male' else N'Female' end)
                                    ,b.fldBirth as 'Birthday', a.fldGroupName as 'Department'
                                     FROM   tblGroup a INNER JOIN tblEmployee b
                                            ON a.fldGroupID = b.fldGroupID INNER JOIN tblTimekeeping c
                                            ON b.fldEmployeeID = c.fldEmployeeID  WHERE c.tDatetime between ('" + Convert.ToDateTime(dtpFrom.Value) + "') and ('" + Convert.ToDateTime(dtpTo.Value) + "') ";

            da.SelectCommand = cmd;
            da.Fill(dt1);
            dgvDS.DataSource = dt1;
            //dgvDS.Columns[0].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";


        }
        //========================================

        //===================================
        //Lay list việc làm
        private void GetWorkList()
        {
            dt1.Clear();
            connect();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"SELECT fldWorkName as N'Work Name',fldWorkStatus as 'Status' FROM Employee.dbo.tblWork";

            da.SelectCommand = cmd;
            da.Fill(dt1);
            dgvDS.DataSource = dt1;
            //dgvDS.Columns[0].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";


        }
        //========================================

        //============
        //do du lieu len combo
        private void fillcombo()
        {
            dt2.Clear();
            connect();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"SELECT fldEmployeeID, fldFirstName +' '+ fldLastName as fldName from tblEmployee";

            da.SelectCommand = cmd;
            da.Fill(dt2);
        }
        
        //====================
        //dem ngay cong
        private void demngaycong(string valueToSearch)
        {
            dt3.Clear();
            connect();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;//,,
            cmd.CommandText = @"SELECT tk.fldEmployeeID as 'EmployeeID', e.fldFirstName as 'FirstName', e.fldLastName as 'LastName',g.fldGroupName as 'Department', COUNT(DISTINCT tk.fldEmployeeID) as 'Working Days'
                                        From tblTimekeeping tk , tblEmployee e,tblGroup g
                                         WHERE tk.fldEmployeeID = e.fldEmployeeID and e.fldGroupID = g.fldGroupID and tk.tDatetime >= '" + Convert.ToDateTime(dtpFrom.Value) + "' and tk.tDatetime <= '" + Convert.ToDateTime(dtpTo.Value) + "' and e.fldLastName LIKE '%" + valueToSearch + "%' Group by tk.fldEmployeeID, e.fldFirstName, e.fldLastName,g.fldGroupName Order By tk.fldEmployeeID";


            da.SelectCommand = cmd;
            da.Fill(dt3);
            dgvDS.DataSource = dt3;
            
        }

        public Form1(Configuration appConfig)
        {
            applicationConfiguration = (AppConfig)appConfig;
            InitializeComponent();
            //dtpFrom.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            //dtpTo.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day + 1);
            
            
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            //GetList();
            fillcombo();
            dtpTo.Value = DateTime.Now;
            label2.Enabled = false;
            GetListOne("");

        }

        public static bool IsValidDate(DateTime startDate, DateTime endDate)
        {
            return startDate < endDate && endDate > startDate;
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            GetList();

        }

        //private void GetList()
        //{
        //    throw new NotImplementedException();
        //}
        //private void GetListOne()
        //{
        //    throw new NotImplementedException();
        //}
        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {
            GetList();
            //dtpTo.Value = DateTime.Now;
            
        }

        private void dgvDS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            GetList();
            //GetListOne();
        }

        private void bt_checkall_Click(object sender, EventArgs e)
        {            
            txt_search.Enabled = false;
            label2.Enabled = false;
            GetList();
        }

        private void bt_getonebyone_Click(object sender, EventArgs e)
        {            
            txt_search.Enabled = true;
            label2.Enabled = true;
            string valueToSearch = txt_search.Text.ToString();
            GetListOne(valueToSearch);

        }

        private void bt_available_Click(object sender, EventArgs e)
        {
            txt_search.Enabled = true;
            label2.Enabled = true;
            string valueToSearch = txt_search.Text.ToString();
            demngaycong(valueToSearch);
            /*txt_search.Enabled = false;
            label2.Enabled = false;*/
            //GetWorkList();
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

        private void cmbgetEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtpTo_CloseUp(object sender, EventArgs e)
        {
            DateTime fromDate = Convert.ToDateTime(dtpFrom.Value);
            DateTime toDate = Convert.ToDateTime(dtpTo.Value);
            DateTime toDay = DateTime.Now;
            if( fromDate > toDate)
            {               
                MessageBox.Show("From Date Must Be Lesser Than To Date!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }else if(toDate > toDay)
            {
                MessageBox.Show("To Date Must Be Transgress Than To Day!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
