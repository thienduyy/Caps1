using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.IO;
using IndentifiedFace.Configurations;
using IndentifiedFace.IO;
using System.IO.Ports;

namespace IndentifiedFace
{
    public partial class frmTimekeeping : Form
    {
        // Khởi tạo các biến dt, dt0, dt1... là tên của các table tương ứng
        private SqlConnection con;
        private DataTable dt = new DataTable("Table0");
        private DataTable dt0 = new DataTable("Table1");
        private DataTable dt1 = new DataTable("Table2");
        private DataTable dt2 = new DataTable("Table3");
        private DataTable dt3 = new DataTable("Table4");
        private DataTable dtbl = new DataTable();
        private DataTable dtGroup = new DataTable("TableClass");
        private DateTime date;
        private SqlDataAdapter da = new SqlDataAdapter();

        // khai báo, khởi tạo các biến image về số byte, color...
        Capture grabber;
        Image<Bgr, Byte> currentFrame;
        Image<Gray, Byte> gray;
        HaarCascade haar;
        Image<Gray, Byte> result;
        List<Image<Gray, Byte>> trainingImages = new List<Image<Gray, byte>>();
        int ContTrain;
        List<String> EmployeeID = new List<string>();
        List<String> EmployeeGroupID = new List<string>();
        string countEmployee = "";
        string name = "", LoadFaces, str;
        MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_TRIPLEX, 0.5d, 0.5d); //Tạo phông chữ tỷ lệ ngang dọc
        // khai báo Presence là 1 mảng danh sách các employee hiện diện
        List<String> Presence = new List<string>();
        // khai báo Absence là 1 mảng danh sách các employee vắng mặt
        List<String> Absence = new List<string>();
        // khai báo Temporary là 1 mảng danh sách các employee tạm thời
        List<String> Temporary = new List<string>();

        Boolean test = false;
        private SerialPortConn serialPortManager;

        // hàm này thực hiện truy vấn để đưa ra danh sách employee theo từng group
        public frmTimekeeping(Configuration appConfig)
        {
            applicationConfiguration = (AppConfig)appConfig;
            InitializeComponent();
            // forceCustomReInitialize();

            /* Initial output device */
            foreach (string s in SerialPort.GetPortNames())
            {
                //comboBoxOutputDevice.Items.Add(s);
            }


            connect();
            haar = new HaarCascade("haarcascade_frontalface_default.xml");
            dt.Clear();
            dt0.Clear();
            // khởi tạo biến tham chiếu command để thao tác với csdl
            SqlCommand command = new SqlCommand();
            command.Connection = con;
            command.CommandType = CommandType.Text;                   
            // truy vấn lấy fldEmployeeID,fldFirstName,fldLastName ... từ bảng tblGroup kết hợp với tblEmployee điều kiện là fldGroupID của 2 bảng bằng nhau
            command.CommandText = @"SELECT  fldEmployeeID as 'EmployeeID',fldFirstName as 'FirstName',fldLastName as 'LastName',
                                            (Case fldSex when 'True' then 'Male' else 'Female' end) as N'Gender',
                                             fldBirth as 'Birthday', fldGroupName as 'Department',lastdate
                                             FROM   tblGroup INNER JOIN tblEmployee 
                                             ON tblGroup.fldGroupID = tblEmployee.fldGroupID";
            da.SelectCommand = command;
            // thực hiện xuất dữ liệu lấy được sau truy vấn vào table(dt)
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                /*grvdata.DataSource = dt;
                grvdata.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";*/
            }

            try
            {
                foreach (DataRow dr in dt.Rows)
                {
                    EmployeeID.Add(dr.ItemArray[0].ToString());
                }

                ContTrain = EmployeeID.Count();
                for (int i = 1; i <= EmployeeID.Count(); i++)
                {
                    LoadFaces = String.Format("face" + i + ".bmp");
                    trainingImages.Add(new Image<Gray, byte>(Application.StartupPath + "/TrainedFaces/" + LoadFaces));//load ảnh
                }

            }
            catch (Exception)
            {
                /*MessageBox.Show(applicationConfiguration.getLanguagePackage().getMemberNotFoundMessage(),
                    "Cảnh Báo 1", MessageBoxButtons.OK, MessageBoxIcon.Error);*/
            }
            // truy vấn lấy fldEmployeeID,fldFirstName,fldLastName ... từ bảng tblGroup kết hợp với tblEmployee trên cơ sở là fldGroupID của 2 bảng bằng nhau với điều kiện là fldGroupName giống(like) biến group bắt được
            command.CommandText = @"SELECT  fldEmployeeID as 'EmployeeID',fldFirstName as 'FirstName',fldLastName as 'LastName',
                                            (Case fldSex when 'True' then 'Male' else 'Female' end) as N'Gender',
                                             fldBirth as 'Birthday', fldGroupName as 'Department',fldImage as 'Image'
                                             FROM   tblGroup INNER JOIN tblEmployee 
                                             ON tblGroup.fldGroupID = tblEmployee.fldGroupID";
            //command.Parameters.Add("@Group", SqlDbType.NVarChar, 50).Value = str;
            da.SelectCommand = command;
            // thực hiện xuất dữ liệu lấy được sau truy vấn vào table(dt0)
            da.Fill(dt0);
            if (dt0.Rows.Count > 0)
            {
                /*grvdata.DataSource = dt0;
                grvdata.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";*/
            }
            try
            {
                foreach (DataRow dr in dt0.Rows)
                {
                    EmployeeGroupID.Add(dr.ItemArray[0].ToString());
                }
            }
            catch (Exception)
            {
                /*MessageBox.Show(applicationConfiguration.getLanguagePackage().getMemberNotFoundMessage(),
                    "Cảnh Báo 1", MessageBoxButtons.OK, MessageBoxIcon.Error);*/
            }
            btnCallTheRoll.Enabled = false;
        }
        private AppConfig applicationConfiguration;

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
            try
            {
                con.Close();
                con.Dispose();
                con = null;
            }
            catch (Exception e) { }

        }
        private void frmTimekeeping_Load(object sender, EventArgs e)
        {
            date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);

        }
        // Hàm này thực hiện đếm số người đã điểm danh
        private void cbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {

            //==========================
            test = false;
            
            //==========================
            //str = cbGroup.Text;
            dt0.Clear();
            EmployeeGroupID.Clear();
            dt2.Clear();
            dt3.Clear();
            Temporary.Clear();
            Absence.Clear();
            Presence.Clear();
            txtListDiemDanh.Text = "0 Employee";
            txtShow.Text = "0 Employee";
            haar = new HaarCascade("haarcascade_frontalface_default.xml");
            SqlCommand command = new SqlCommand();
            command.Connection = con;
            command.CommandType = CommandType.Text;
            command.CommandText = @"SELECT  fldEmployeeID as 'EmployeeID',fldFirstName as 'FirstName',fldLastName as 'LastName',
                                            (Case fldSex when 'True' then 'Male' else 'Female' end) as N'Gender',
                                             fldBirth as 'Birthday', fldGroupName as 'Department'
                                                     FROM   tblGroup INNER JOIN tblEmployee
                                                     ON tblGroup.fldGroupID = tblEmployee.fldGroupID";
            //command.Parameters.Add("@Group", SqlDbType.NVarChar, 50).Value = cbGroup.Text;

            da.SelectCommand = command;
            da.Fill(dt0);

            if (dt0.Rows.Count > 0)
            {
                /*grvdata.DataSource = dt0;
                grvdata.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";*/
            }
            try
            {

                foreach (DataRow dr in dt0.Rows)
                {
                    EmployeeGroupID.Add(dr.ItemArray[0].ToString());
                }
            }
            catch (Exception)
            {
                MessageBox.Show(applicationConfiguration.getLanguagePackage().getMemberNotFoundMessage(),
                     "Cảnh Báo 2", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // Khi bật chương trình điểm danh, ấn vào button Camera thì nó chạy vào hàm này	
        private void btnCamera_Click(object sender, EventArgs e)
        {

            grabber = new Capture();
            grabber.QueryFrame();
            // đoạn này nó sẽ chạy vào hàm FrameGrabber để thực hiện việc nhận dạng xem ai đang ở trước camera
            Application.Idle += new EventHandler(FrameGrabber);
            btnCallTheRoll.Enabled = true;
            btnCamera.Enabled = false;

        }
        // Hàm này thực hiện kiểm tra xem cái chuỗi st đưa vào có trả về dữ liệu là đúng hay sai, hay nói cách khác hàm này thực hiện kiểm tra việc đúng sai của dữ liệu
        private Boolean Check(string st)
        {
            for (int i = 0; i < EmployeeID.Count; i++)
            {

                if (st == EmployeeID[i])
                {
                    test = true;
                    break;
                }
            }
            return test;
        }

        // Hàm này thực hiện nhận dạng
        void FrameGrabber(object sender, EventArgs e)
        {
            try
            {
                // khởi tạo 1 đối tượng là currentFrame có dạng là hình ảnh
                imageBoxFrameGrabber.Image = currentFrame;
                // khởi tạo currentFrame sẽ có khung hình rộng 350, cao 335
                currentFrame = grabber.QueryFrame().Resize(350, 335, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                // khai báo đối tượng gray này để quy định cái ảnh mà mình nhận được nằm trong khung
                gray = currentFrame.Convert<Gray, Byte>();
                // Face Detector sau khi thực hiện dòng lệnh này trả về 1 ảnh
                MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(haar, 1.1, 10, Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(20, 20));

                //Action for each elements detected
                foreach (MCvAvgComp f in facesDetected[0])
                {
                    // copy kết quả đã nhận diện vào result
                    result = currentFrame.Copy(f.rect).Convert<Gray, byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                    //draw the detector in the 0th (gray) channel with blue color
                    currentFrame.Draw(f.rect, new Bgr(Color.Red), 2);
                    if (trainingImages.ToArray().Length != 0)
                    {
                        //Để nhận dạng khuôn mặt với số lượng hình ảnh trained
                        MCvTermCriteria termCrit = new MCvTermCriteria(ContTrain, 0.001);
                        //Nhận dạng khuôn mặt
                        EigenObjectRecognizer recognizer = new EigenObjectRecognizer(trainingImages.ToArray(), EmployeeID.ToArray(), 3000, ref termCrit);
                        name = recognizer.Recognize(result);
                        Check(name);
                        if (test == true) 
                        {
                            //double StopValue = Convert.ToDouble(System.Configuration.ConfigurationSettings.AppSettings["StopValue"]);
                            // cái này là hiển thị ở trên khung hình màu đỏ gồm có số ID, cái thứ 2 là font chữ, cái thứ 3 là vị trí hiển thị, cái cuối là màu sắc
                            currentFrame.Draw("Employee ID:" + name, ref font, new Point(f.rect.X - 2, f.rect.Y - 2), new Bgr(Color.White));

                            dt1.Clear();
                            SqlCommand cmd = new SqlCommand();
                            cmd.Connection = con;
                            cmd.CommandType = CommandType.Text;
                            // truy vấn lấy thông tin của Employee trong csdl
                            cmd.CommandText = @"SELECT  fldEmployeeID as 'EmployeeID',fldFirstName as 'FirstName',fldLastName as 'LastName',
                                            (Case fldSex when 'True' then 'Male' else 'Female' end) as N'Gender',
                                             fldBirth as 'Birthday', fldGroupName as 'Department'
                                                                     FROM   tblGroup INNER JOIN tblEmployee 
                                                                     ON tblGroup.fldGroupID = tblEmployee.fldGroupID
                                                                      where fldEmployeeID= @EmployeeID";
                            cmd.Parameters.Add("@EmployeeID", SqlDbType.Int, 16).Value = Convert.ToInt16(name);
                            da.SelectCommand = cmd;

                            // Hiển thị thông tin của Employee vừa lấy được ở trên ra bảng
                            da.Fill(dt1);                         
                            DateTime date = Convert.ToDateTime(dt1.Rows[0]["lastdate"]);
                            TimeSpan diff = DateTime.Now - date;
                            double seconds = diff.TotalSeconds;                           
                        }
                        else
                        {
                            name = ""; 
                        }

                    }

                }
            }
            catch (Exception)
            {

            }

        }

        private void btnexit_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("Total Employee: " + dt0.Rows.Count + "\n Employee Present: " + Presence.Count + "\n Employee Absent: " + Absence.Count, "Information !", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
           if (dr == DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {

            }
            
        }

        private void Timekeeping()
        {
            Boolean Test = false;
            if (name != "")
            {
                if (Presence.Count == 0)
                {
                    Presence.Add(name.ToString());
                    for (int i = 0; i < EmployeeID.Count; i++)
                    {
                        if (EmployeeID[i].ToString() != name)
                        {
                            Absence.Add(EmployeeID[i].ToString());
                            Temporary.Add(EmployeeID[i].ToString());
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < Presence.Count; i++)
                    {
                        if (name.ToString() == Presence[i].ToString())
                            Test = true;

                    }
                    if (Test == false)
                    {
                        Presence.Add(name.ToString());
                        Absence.Clear();
                        for (int j = 0; j < Temporary.Count; j++)
                        {
                            if (name.ToString() != Temporary[j].ToString())
                            {
                                Absence.Add(Temporary[j].ToString());
                            }

                        }
                        Temporary.Clear();
                        for (int k = 0; k < Absence.Count; k++)
                        {
                            Temporary.Add(Absence[k].ToString());
                        }

                    }
                    //else if (Test == true)
                    //MessageBox.Show("Nhân viên:  " + txtHo.Text + " " + txtTen.Text + " đã được tạo!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                ShowInformation();
                /*if (comboBoxOutputDevice.Text.Equals("") || comboBoxOutputDevice.Text == null)
                {
                    //MessageBox.Show("Computer no device to record out Com port!");
                    return;
                }*/
                // đoạn này đưa dữ liệu ra cổng COM sẽ là A
                //serialPortManager.WriteConnection(applicationConfiguration.getLanguagePackage().getMakingRollCallSuccessSerialMessage());
            }
            else
            {
                MessageBox.Show("Nhân viên không được tìm thấy!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // đoạn này đưa dữ liệu ra cổng COM sẽ là B
                //serialPortManager.WriteConnection(applicationConfiguration.getLanguagePackage().getMakingRollCallFailSerialMessage());
            }

        }
        // Hàm này chỉ là hiển thị thông tin Employees
        public void ShowInformation()
        {
            txtListDiemDanh.Text = Presence.Count.ToString() + " Employee";
            txtShow.Text = Absence.Count.ToString() + " Employee";
            dt2.Clear();
            dtbl.Clear();
            foreach (var item in Presence)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"SELECT  fldEmployeeID as 'EmployeeID',fldFirstName as 'FirstName',fldLastName as 'LastName', fldGroupName as 'Department'
                                            FROM   tblGroup INNER JOIN tblEmployee 
                                            ON tblGroup.fldGroupID = tblEmployee.fldGroupID
                                            where fldEmployeeID= @EmployeeID";
                cmd.Parameters.Add("@EmployeeID", SqlDbType.Int, 16).Value = Convert.ToInt16(item.ToString());
                da.SelectCommand = cmd;
                da.Fill(dt2);

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = con;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = @"SELECT  fldEmployeeID FROM tblGroup INNER JOIN tblEmployee 
                                            ON tblGroup.fldGroupID = tblEmployee.fldGroupID
                                            where fldEmployeeID= @EmployeeID";
                sqlCmd.Parameters.Add("@EmployeeID", SqlDbType.Int, 16).Value = Convert.ToInt16(item.ToString());
                da.SelectCommand = sqlCmd;
                da.Fill(dtbl);

                if (dt1.Rows.Count > 0)
                {
                    SqlCommand cmd2 = new SqlCommand();
                    cmd2.Connection = con;
                    cmd2.CommandType = CommandType.Text;
                    //cmd2.CommandText = @"INSERT INTO tblTimekeeping(tDatetime,fldEmployeeID) VALUES('" + date + "','" + dtbl.Rows[0]["fldEmployeeID"] + "')";
                    cmd2.CommandText = @"INSERT INTO tblTimekeeping(tDatetime,fldEmployeeID) VALUES(getdate(),'" + dtbl.Rows[0]["fldEmployeeID"] + "')";
                    cmd2.ExecuteNonQuery();
                    grv_Data2.DataSource = dt2;
                    ///
                    // Phân công công việc
                    ///
                    int employeeId = Int32.Parse(dtbl.Rows[0]["fldEmployeeID"].ToString());
                    //nếu == 0 thì nhân viên này chưa được phân công việc
                    if (new WorkAssignment(applicationConfiguration).CheckEmployeeWorkDay(employeeId)==0)
                    {
                        new WorkAssignment(applicationConfiguration).RandomWork(employeeId);                        
                    }
                    ShowWorkEmployee(employeeId);
                }
            }
            dt3.Clear();
            foreach (var item in Absence)
            {
                SqlCommand command = new SqlCommand();
                command.Connection = con;
                command.CommandType = CommandType.Text;
                command.CommandText = @"SELECT  fldEmployeeID as 'EmployeeID',fldFirstName as 'FirstName',fldLastName as 'LastName', fldGroupName as 'Department'
                                    FROM   tblGroup INNER JOIN tblEmployee 
                                    ON tblGroup.fldGroupID = tblEmployee.fldGroupID
                                    where fldEmployeeID= @EmployeeID";
                command.Parameters.Add("@EmployeeID", SqlDbType.Int, 16).Value = Convert.ToInt16(item.ToString());
                da.SelectCommand = command;
                da.Fill(dt3);
                if (dt3.Rows.Count > 0)
                {
                    grv_Data3.DataSource = dt3;
                }
            }
            
        }
        /// <summary>
        /// Hiển thị công việc của nhân viên
        /// </summary>
        /// <param name="employeeID"></param>
        public void ShowWorkEmployee(int employeeID)
        {
            frmShowWorkDay frm = new frmShowWorkDay(applicationConfiguration,employeeID);
            frm.ShowDialog();
        }
        private void btnCallTheRoll_Click(object sender, EventArgs e)
        {
            Timekeeping();
        }


        private void frmTimekeeping_FormClosed(object sender, FormClosedEventArgs e)
        {
            /*try { serialPortManager.CloseConnection(); }
            catch
            {
                //No problem 
            }*/
        }

        private void comboBoxOutputDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // try to close if it has opened a connection before
                serialPortManager.CloseConnection();
            }
            catch (Exception ex)
            {
                //Noproblem ^^
            }
            //serialPortManager = new SerialPortConn(comboBoxOutputDevice.Text);
            serialPortManager.OpenConnection();
        }

        private void btnAddNewEmployee_Click(object sender, EventArgs e)
        {

            if (grabber != null)
            {
                grabber.Dispose();
            }
            Close();
            Dispose();
            disconnect();
            frmAddNewEmployee _themMoi = new frmAddNewEmployee(applicationConfiguration);
            _themMoi.Show();
            /*_themMoi.FormClosed += new FormClosingEventHandler(_themMoi_FormClose);
            this.Hide();*/
        }

        private void _themMoi_FormClose(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }



        private void cbGroup_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void grvData2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void btn_excel1_Click(object sender, EventArgs e)
        {
            try
            {
                //creating Excel Application
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                // creating new WorkBook within Excel application
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                // creating new Excelsheet in workbook
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                // see the excel sheet behind the program
                app.Visible = true;
                // get the reference of first sheet. By default its name is Sheet1.
                // store its reference to worksheet
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                // changing the name of active sheet
                worksheet.Name = "Exported from gridview";
                // storing header part in Excel
                for (int i = 1; i < grv_Data2.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = grv_Data2.Columns[i - 1].HeaderText;
                }
                // storing Each row and column value to excel sheet

                for (int i = 0; i < grv_Data2.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < grv_Data2.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = grv_Data2.Rows[i].Cells[j].Value.ToString();
                    }
                }
                // save the application

                workbook.SaveAs("c:\\grv_Data2.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                // Exit from the application
                app.Quit();
            }
            catch (Exception)
            {

            }
            finally
            {

            }
        }

        private void btn_excel2_Click(object sender, EventArgs e)
        {
            try
            {
                // creating Excel Application
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                // creating new WorkBook within Excel application
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                // creating new Excelsheet in workbook
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                // see the excel sheet behind the program
                app.Visible = true;
                // get the reference of first sheet. By default its name is Sheet1.
                // store its reference to worksheet
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                // changing the name of active sheet
                worksheet.Name = "Exported from gridview";
                // storing header part in Excel
                for (int i = 1; i < grv_Data3.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = grv_Data3.Columns[i - 1].HeaderText;
                }
                // storing Each row and column value to excel sheet
                for (int i = 0; i < grv_Data3.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < grv_Data3.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = grv_Data3.Rows[i].Cells[j].Value.ToString();
                    }
                }
                // save the application
                workbook.SaveAs("c:\\grv_Data3.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                // Exit from the application
                app.Quit();
            }
            catch (Exception)
            {
            }
            finally
            {
            }
        }

        private void grvdata3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtListDiemDanh_Click(object sender, EventArgs e)
        {
            
        }

        private void txtShow_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnListWork_Click(object sender, EventArgs e)
        {
            frmListWork frm = new frmListWork(applicationConfiguration);
            frm.Show();
        }

        private void btnListOfEmp_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1(applicationConfiguration);
            frm.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin(applicationConfiguration);            
            frm.Show();
            this.Hide();
        }

        private void dgvDS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grvData2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnList_Click(object sender, EventArgs e)
        {

        }



    }
}

