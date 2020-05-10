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
    public partial class frmConfig : Form
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
        
        private int UpdateConfig(string column, int value)
        {
            int result = 0;
            connect();
            string query = @"Update tblConfig set " + column + " = " + value;
            using (SqlCommand command = new SqlCommand(query, con))
            {
                result = command.ExecuteNonQuery();
            }
            return result;
        }
        private int ResetWork()
        {
            int result = 0;
            connect();
            string query = @"EXEC proc_Reset_Work";
            using (SqlCommand command = new SqlCommand(query, con))
            {
                result = command.ExecuteNonQuery();
            }
            return result;
        }
        public frmConfig(Configuration appConfig)
        {
            applicationConfiguration = (AppConfig)appConfig;
            InitializeComponent();

        }
        private void frmConfig_Load(object sender, EventArgs e)
        {
            txtNumberWork.Text = new WorkAssignment(applicationConfiguration).GetNumberRandom().ToString();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int numberWork = Int32.Parse(txtNumberWork.Text);
            if (UpdateConfig("fldConfigNumberWork", numberWork) > 0)
            {
                MessageBox.Show("Update Success !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnResetWork_Click(object sender, EventArgs e)
        {
            if (ResetWork() > 0)
            {
                MessageBox.Show("Đã Reset lại công việc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
 
       
    }
}
