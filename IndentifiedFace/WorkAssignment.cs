using IndentifiedFace.Configurations;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IndentifiedFace
{
    public class WorkAssignment
    {
        private SqlConnection con;
        private SqlDataAdapter da = new SqlDataAdapter();
        private AppConfig applicationConfiguration;
        private DataTable dt;
        private List<Works> listWorks;
        //Số công việc nhận ngẫu nhiên
        int numberRandom = 2;

        public WorkAssignment(Configuration appConfig)
        {
            applicationConfiguration = (AppConfig)appConfig;
        }
        /// <summary>
        /// hàm kết nối dữ liệu
        /// </summary>
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
        /// <summary>
        /// hàm đóng kết nối
        /// </summary>
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

        public List<Works> GetListWorks()
        {
            listWorks = new List<Works>();
            string query = "SELECT fldWorkID, fldWorkName,fldWorkStatus FROM Employee.dbo.tblWork WHERE fldWorkStatus=@fldWorkStatus";
            connect();
            using (SqlCommand command = new SqlCommand(query, con))
            {
                //@fldWorkStatus=0 lấy ra các công việc chưa có ai làm.
                command.Parameters.AddWithValue("@fldWorkStatus", 0);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Works work = new Works();
                        work.WorkID = reader.GetInt32(0);
                        work.WorkName = reader.GetString(1);
                        work.WorkStatus = reader.GetBoolean(2);
                        listWorks.Add(work);
                    }
                }
            }
            return listWorks;
        }
        /// <summary>
        /// hàm phân công công việc ngẫu nhiên
        /// </summary>
        /// <param name="EmployeeID"></param>
        public void RandomWork(int EmployeeID)
        {
            listWorks = GetListWorks();
            numberRandom = GetNumberRandom();
            List<int> listRandomListWork = ListRandomListWork(listWorks.Count, numberRandom);
            foreach (int number in listRandomListWork)
            {
                Works works = listWorks[number];
                InsertWorkEmployee(works.WorkID, EmployeeID);
                UpdateWork(works.WorkID, true);
            }
        }
        /// <summary>
        /// thêm công việc ngày mới cho nhân viên
        /// </summary>
        /// <param name="workID"></param>
        /// <param name="employeeID"></param>
        public int InsertWorkEmployee(int workID, int employeeID)
        {
            int result = 0;
            try
            {
                connect();
                SqlCommand commandInsert = new SqlCommand();
                commandInsert.Connection = con;
                commandInsert.CommandType = CommandType.Text;
                commandInsert.CommandText = @" Insert tblEmployeeWork (fldWorkID,fldEmployeeID) Values (@fldWorkID,@fldEmployeeID)";
                commandInsert.Parameters.Add("@fldWorkID", SqlDbType.Int);
                commandInsert.Parameters["@fldWorkID"].Value = workID;
                commandInsert.Parameters.Add("@fldEmployeeID", SqlDbType.Int);
                commandInsert.Parameters["@fldEmployeeID"].Value = employeeID;
                result = commandInsert.ExecuteNonQuery();
            }
            catch
            {

            }
            return result;
        }
        /// <summary>
        /// Cập nhập lại trạng thái công việc
        /// </summary>
        /// <param name="workID"></param>
        /// <param name="employeeID"></param>
        public int UpdateWork(int workID, Boolean workStatus)
        {
            int result = 0;
            try
            {
                connect();
                SqlCommand commandInsert = new SqlCommand();
                commandInsert.Connection = con;
                commandInsert.CommandType = CommandType.Text;
                commandInsert.CommandText = @"UPDATE tblWork SET fldWorkStatus = @fldWorkStatus Where fldWorkID = @fldWorkID";
                commandInsert.Parameters.AddWithValue("@fldWorkStatus", workStatus);
                commandInsert.Parameters.AddWithValue("@fldWorkID", workID);
                result = commandInsert.ExecuteNonQuery();
            }
            catch
            {

            }
            return result;
        }
        /// <summary>
        /// Kiểm tra xem nhân viên này đã được phân công công việc hôm nay chưa
        /// </summary>
        /// <param name="employeeID">Mã nhân viên</param>
        /// <returns></returns>
        public int CheckEmployeeWorkDay(int employeeID)
        {
            int result = 0;
            try
            {
                connect();
                string query = @"SELECT * FROM tblEmployeeWork WHERE fldEmployeeID=@fldEmployeeID AND fldEmployeeWorkDate=CONVERT(varchar, getdate(), 23)";
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@fldEmployeeID", employeeID);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result++;
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return result;
        }
        /// <summary>
        /// Lấy thông tin số công việc
        /// </summary>
        /// <param name="employeeID"></param>
        public int GetNumberRandom()
        {
            connect();
            string query = @"SELECT fldConfigNumberWork FROM tblConfig";
            using (SqlCommand command = new SqlCommand(query, con))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return reader.GetInt32(0);
                    }
                }
            }
            return 0;
        }
        /// <summary>
        /// Lấy danh sách công việc ngẫu nhiên
        /// </summary>
        /// <param name="countListWork">Số tổng công việc khả dụng</param>
        /// <param name="numberRandom">Số công việc cần làm</param>
        /// <returns></returns>
        private List<int> ListRandomListWork(int countListWork, int numberRandom)
        {
            Random ranNumber = new Random();
            List<int> listResult = new List<int>();
            int temp = 0;
            int countR = 0;
            while (true)
            {
                temp = ranNumber.Next(countListWork);
                if (!listResult.Exists(x => x == temp))
                {
                    listResult.Add(temp);
                    countR++;
                }
                //nếu
                if (countR == numberRandom) break;
                if (countListWork == countR) break;
            }
            return listResult;
        }

    }
    public class Works
    {
        public int WorkID { get; set; }
        public String WorkName { get; set; }
        public Boolean WorkStatus { get; set; }
    }
}
