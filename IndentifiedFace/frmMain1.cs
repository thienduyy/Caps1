using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IndentifiedFace.Configurations;
using System.Data.SqlClient;
using System.Configuration;

namespace IndentifiedFace
{
    public partial class frmMain1 : Form
    {
        //private AppConfig applicationConfiguration;
        private SqlConnection con;
        private DataTable dt = new DataTable("show");
        private DataTable dtGroup = new DataTable("tblGroup");
        private SqlDataAdapter da = new SqlDataAdapter();
        private AppConfig applicationConfiguration;
        
        private frmAddNewEmployee _frmAddNewEmployee;
        public frmMain1()
        {
            InitializeComponent();
            

        }
        public frmMain1(IndentifiedFace.Configurations.Configuration appConfig)
        {
            applicationConfiguration = (AppConfig)appConfig;
            InitializeComponent();
            forceCustomReInitialize();


        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Do You Want Exit Program ?", "Yes", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                frmLogin lg = new frmLogin(applicationConfiguration);
                lg.Show();
                lg.FormClosed += new FormClosedEventHandler(lg_FormClosed);
                this.Hide();
            }
            else
            {

            }
            
        }

        private void lg_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _frmAddNewEmployee = new frmAddNewEmployee(applicationConfiguration);
            _frmAddNewEmployee.Show();
            _frmAddNewEmployee.FormClosed += new FormClosedEventHandler(_frmAddNewEmployee_FormClosed);
            this.Hide();
        }

        private void _frmAddNewEmployee_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            frmTimekeeping diemdanh = new frmTimekeeping(applicationConfiguration);
            diemdanh.Show();
            
        }
        private void diemdanh_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        private void connect()
        {
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
            con.Close();
            con.Dispose();
            con = null;
        }

        private void btnListOfEmp_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1(applicationConfiguration);
            frm.Show();
            frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
            this.Hide();
            
        }
        private void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmLogin lg = new frmLogin();
            lg.Show();
            lg.FormClosed += new FormClosedEventHandler(Lg_FormClosed);
            this.Hide();
        }

        private void Lg_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void BtnListWork_Click(object sender, EventArgs e)
        {
            frmListWork frm = new frmListWork(applicationConfiguration);
            frm.Show();
            frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            frmTimekeeping diemdanh = new frmTimekeeping(applicationConfiguration);
            diemdanh.Show();
        }

        private void frmMain1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lbTime.Text = DateTime.Now.ToLongTimeString();
            lbDate.Text = DateTime.Now.ToLongDateString();
            count_EmplPresent();
            count_EmplAbsent();
            count_Work();
            count_WorkCompl();
        }

        Int32 countEmplPresent;
        Int32 countEmplAbsent;
        Int32 countEmpl;
        Int32 countWork;
        Int32 countWorkCompl;
        private void count_EmplPresent()
        {
            connect();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;//,,
            cmd.CommandText = @"SELECT COUNT(DISTINCT fldEmployeeID) 
                                FROM tblTimekeeping
                                WHERE (CONCAT(DAY(tDatetime),MONTH(tDatetime),YEAR(tDatetime)) = CONCAT(DAY(GETDATE()),MONTH(GETDATE()),YEAR(GETDATE())));";
            countEmplPresent = Convert.ToInt32(cmd.ExecuteScalar());
            lb_EmplPresent.Text = countEmplPresent.ToString();
            cmd.Dispose();
            disconnect();
        }

        private void count_EmplAbsent()
        {
            connect();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;//,,
            cmd.CommandText = @"SELECT COUNT(fldEmployeeID) 
                                FROM tblEmployee";
            countEmpl = Convert.ToInt32(cmd.ExecuteScalar());
            countEmplAbsent = countEmpl - countEmplPresent;
            lb_EmplAbsent.Text = countEmplAbsent.ToString();
            cmd.Dispose();
            disconnect();
        }
        private void count_Work()
        {
            connect();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;//,,
            cmd.CommandText = @"SELECT COUNT(fldWorkID) 
                                FROM tblWork";
            countWork = Convert.ToInt32(cmd.ExecuteScalar());
            lb_TotalWork.Text = countWork.ToString();
            cmd.Dispose();
            disconnect();
        }
        private void count_WorkCompl()
        {
            connect();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;//,,
            cmd.CommandText = @"SELECT COUNT(fldWorkID) 
                                FROM tblWork
                                WHERE (fldWorkStatus = 'True')";
            countWorkCompl = Convert.ToInt32(cmd.ExecuteScalar());
            lb_WorkCompleted.Text = countWorkCompl.ToString();
            cmd.Dispose();
            disconnect();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void lbTime_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
