using IndentifiedFace.Configurations;
namespace IndentifiedFace
{
    partial class frmTimekeeping
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimekeeping));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label5 = new System.Windows.Forms.Label();
            this.imageBoxFrameGrabber = new Emgu.CV.UI.ImageBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCamera = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCallTheRoll = new System.Windows.Forms.Button();
            this.btn_excel2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_excel1 = new System.Windows.Forms.Button();
            this.btnAddNewEmployee = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.txtListDiemDanh = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtShow = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnListWork = new System.Windows.Forms.Button();
            this.btnListOfEmp = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grv_Data2 = new Guna.UI.WinForms.GunaDataGridView();
            this.grv_Data3 = new Guna.UI.WinForms.GunaDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxFrameGrabber)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_Data2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_Data3)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(287, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 30);
            this.label5.TabIndex = 5;
            this.label5.Text = "Face Employee:";
            // 
            // imageBoxFrameGrabber
            // 
            this.imageBoxFrameGrabber.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imageBoxFrameGrabber.BackgroundImage")));
            this.imageBoxFrameGrabber.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.imageBoxFrameGrabber.Location = new System.Drawing.Point(290, 117);
            this.imageBoxFrameGrabber.Name = "imageBoxFrameGrabber";
            this.imageBoxFrameGrabber.Size = new System.Drawing.Size(340, 263);
            this.imageBoxFrameGrabber.TabIndex = 2;
            this.imageBoxFrameGrabber.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(661, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 400);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(290, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(180, 1);
            this.panel3.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(297, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 36);
            this.label3.TabIndex = 3;
            this.label3.Text = "Face Recognition";
            // 
            // btnCamera
            // 
            this.btnCamera.FlatAppearance.BorderSize = 0;
            this.btnCamera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCamera.ForeColor = System.Drawing.Color.Blue;
            this.btnCamera.Image = global::IndentifiedFace.Properties.Resources.camera_30_1px;
            this.btnCamera.Location = new System.Drawing.Point(805, 360);
            this.btnCamera.Name = "btnCamera";
            this.btnCamera.Size = new System.Drawing.Size(84, 48);
            this.btnCamera.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnCamera, "Open Camera");
            this.btnCamera.UseVisualStyleBackColor = true;
            this.btnCamera.Click += new System.EventHandler(this.btnCamera_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(691, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(140, 1);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnCallTheRoll
            // 
            this.btnCallTheRoll.FlatAppearance.BorderSize = 0;
            this.btnCallTheRoll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCallTheRoll.ForeColor = System.Drawing.Color.Blue;
            this.btnCallTheRoll.Image = global::IndentifiedFace.Properties.Resources.attendance_30px;
            this.btnCallTheRoll.Location = new System.Drawing.Point(918, 360);
            this.btnCallTheRoll.Name = "btnCallTheRoll";
            this.btnCallTheRoll.Size = new System.Drawing.Size(84, 48);
            this.btnCallTheRoll.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnCallTheRoll, "Attendance");
            this.btnCallTheRoll.UseVisualStyleBackColor = true;
            this.btnCallTheRoll.Click += new System.EventHandler(this.btnCallTheRoll_Click);
            // 
            // btn_excel2
            // 
            this.btn_excel2.FlatAppearance.BorderSize = 0;
            this.btn_excel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_excel2.Image = global::IndentifiedFace.Properties.Resources.microsoft_excel_2019_25px1;
            this.btn_excel2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_excel2.Location = new System.Drawing.Point(1073, 281);
            this.btn_excel2.Name = "btn_excel2";
            this.btn_excel2.Size = new System.Drawing.Size(172, 29);
            this.btn_excel2.TabIndex = 6;
            this.btn_excel2.Text = "        Export File Excel";
            this.btn_excel2.UseVisualStyleBackColor = true;
            this.btn_excel2.Click += new System.EventHandler(this.btn_excel2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(688, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Employee Present:";
            // 
            // btn_excel1
            // 
            this.btn_excel1.FlatAppearance.BorderSize = 0;
            this.btn_excel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_excel1.Image = global::IndentifiedFace.Properties.Resources.microsoft_excel_2019_25px1;
            this.btn_excel1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_excel1.Location = new System.Drawing.Point(743, 281);
            this.btn_excel1.Name = "btn_excel1";
            this.btn_excel1.Size = new System.Drawing.Size(172, 29);
            this.btn_excel1.TabIndex = 6;
            this.btn_excel1.Text = "        Export File Excel";
            this.btn_excel1.UseVisualStyleBackColor = true;
            this.btn_excel1.Click += new System.EventHandler(this.btn_excel1_Click);
            // 
            // btnAddNewEmployee
            // 
            this.btnAddNewEmployee.FlatAppearance.BorderSize = 0;
            this.btnAddNewEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewEmployee.ForeColor = System.Drawing.Color.Blue;
            this.btnAddNewEmployee.Image = global::IndentifiedFace.Properties.Resources.add_user_group_woman_man_30px;
            this.btnAddNewEmployee.Location = new System.Drawing.Point(1027, 360);
            this.btnAddNewEmployee.Name = "btnAddNewEmployee";
            this.btnAddNewEmployee.Size = new System.Drawing.Size(84, 48);
            this.btnAddNewEmployee.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnAddNewEmployee, "Add Employee");
            this.btnAddNewEmployee.UseVisualStyleBackColor = true;
            this.btnAddNewEmployee.Click += new System.EventHandler(this.btnAddNewEmployee_Click);
            // 
            // btnexit
            // 
            this.btnexit.FlatAppearance.BorderSize = 0;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.ForeColor = System.Drawing.Color.Red;
            this.btnexit.Image = global::IndentifiedFace.Properties.Resources.x_30px;
            this.btnexit.Location = new System.Drawing.Point(1138, 360);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(84, 48);
            this.btnexit.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnexit, "Close");
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // txtListDiemDanh
            // 
            this.txtListDiemDanh.AutoSize = true;
            this.txtListDiemDanh.Location = new System.Drawing.Point(804, 256);
            this.txtListDiemDanh.Name = "txtListDiemDanh";
            this.txtListDiemDanh.Size = new System.Drawing.Size(20, 23);
            this.txtListDiemDanh.TabIndex = 9;
            this.txtListDiemDanh.Text = "0";
            this.txtListDiemDanh.Click += new System.EventHandler(this.txtListDiemDanh_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1017, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 23);
            this.label7.TabIndex = 11;
            this.label7.Text = "Employee Absent:";
            // 
            // txtShow
            // 
            this.txtShow.AutoSize = true;
            this.txtShow.Location = new System.Drawing.Point(1125, 256);
            this.txtShow.Name = "txtShow";
            this.txtShow.Size = new System.Drawing.Size(20, 23);
            this.txtShow.TabIndex = 9;
            this.txtShow.Text = "0";
            this.txtShow.Click += new System.EventHandler(this.txtShow_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(698, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 36);
            this.label4.TabIndex = 5;
            this.label4.Text = "Attendance";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.btnListWork);
            this.panel4.Controls.Add(this.btnListOfEmp);
            this.panel4.Controls.Add(this.btnHome);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(5, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(268, 444);
            this.panel4.TabIndex = 12;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // btnListWork
            // 
            this.btnListWork.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnListWork.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnListWork.FlatAppearance.BorderSize = 0;
            this.btnListWork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListWork.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListWork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnListWork.Image = ((System.Drawing.Image)(resources.GetObject("btnListWork.Image")));
            this.btnListWork.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListWork.Location = new System.Drawing.Point(0, 232);
            this.btnListWork.Name = "btnListWork";
            this.btnListWork.Size = new System.Drawing.Size(261, 47);
            this.btnListWork.TabIndex = 15;
            this.btnListWork.Text = "                       List Works";
            this.btnListWork.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListWork.UseVisualStyleBackColor = false;
            this.btnListWork.Click += new System.EventHandler(this.btnListWork_Click);
            // 
            // btnListOfEmp
            // 
            this.btnListOfEmp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnListOfEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnListOfEmp.FlatAppearance.BorderSize = 0;
            this.btnListOfEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListOfEmp.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListOfEmp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnListOfEmp.Image = ((System.Drawing.Image)(resources.GetObject("btnListOfEmp.Image")));
            this.btnListOfEmp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListOfEmp.Location = new System.Drawing.Point(0, 179);
            this.btnListOfEmp.Name = "btnListOfEmp";
            this.btnListOfEmp.Size = new System.Drawing.Size(261, 47);
            this.btnListOfEmp.TabIndex = 13;
            this.btnListOfEmp.Text = "                       List Of Employee";
            this.btnListOfEmp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListOfEmp.UseVisualStyleBackColor = false;
            this.btnListOfEmp.Click += new System.EventHandler(this.btnListOfEmp_Click);
            // 
            // btnHome
            // 
            this.btnHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(4, 122);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(261, 47);
            this.btnHome.TabIndex = 10;
            this.btnHome.Text = "                       Login";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(268, 116);
            this.panel5.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(63, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // grv_Data2
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.grv_Data2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.grv_Data2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grv_Data2.BackgroundColor = System.Drawing.Color.White;
            this.grv_Data2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grv_Data2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grv_Data2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grv_Data2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.grv_Data2.ColumnHeadersHeight = 40;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grv_Data2.DefaultCellStyle = dataGridViewCellStyle9;
            this.grv_Data2.EnableHeadersVisualStyles = false;
            this.grv_Data2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.grv_Data2.Location = new System.Drawing.Point(682, 86);
            this.grv_Data2.Name = "grv_Data2";
            this.grv_Data2.RowHeadersVisible = false;
            this.grv_Data2.RowHeadersWidth = 62;
            this.grv_Data2.RowTemplate.Height = 30;
            this.grv_Data2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grv_Data2.Size = new System.Drawing.Size(312, 163);
            this.grv_Data2.TabIndex = 19;
            this.grv_Data2.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.WetAsphalt;
            this.grv_Data2.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.grv_Data2.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grv_Data2.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grv_Data2.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.grv_Data2.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grv_Data2.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grv_Data2.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.grv_Data2.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.grv_Data2.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grv_Data2.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grv_Data2.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grv_Data2.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grv_Data2.ThemeStyle.HeaderStyle.Height = 40;
            this.grv_Data2.ThemeStyle.ReadOnly = false;
            this.grv_Data2.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.grv_Data2.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grv_Data2.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grv_Data2.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.grv_Data2.ThemeStyle.RowsStyle.Height = 30;
            this.grv_Data2.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.grv_Data2.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // grv_Data3
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.grv_Data3.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.grv_Data3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grv_Data3.BackgroundColor = System.Drawing.Color.White;
            this.grv_Data3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grv_Data3.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grv_Data3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grv_Data3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.grv_Data3.ColumnHeadersHeight = 40;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grv_Data3.DefaultCellStyle = dataGridViewCellStyle12;
            this.grv_Data3.EnableHeadersVisualStyles = false;
            this.grv_Data3.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.grv_Data3.Location = new System.Drawing.Point(1012, 86);
            this.grv_Data3.Name = "grv_Data3";
            this.grv_Data3.RowHeadersVisible = false;
            this.grv_Data3.RowHeadersWidth = 62;
            this.grv_Data3.RowTemplate.Height = 30;
            this.grv_Data3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grv_Data3.Size = new System.Drawing.Size(321, 163);
            this.grv_Data3.TabIndex = 19;
            this.grv_Data3.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.WetAsphalt;
            this.grv_Data3.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.grv_Data3.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grv_Data3.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grv_Data3.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.grv_Data3.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grv_Data3.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grv_Data3.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.grv_Data3.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.grv_Data3.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grv_Data3.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grv_Data3.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grv_Data3.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grv_Data3.ThemeStyle.HeaderStyle.Height = 40;
            this.grv_Data3.ThemeStyle.ReadOnly = false;
            this.grv_Data3.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.grv_Data3.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grv_Data3.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grv_Data3.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.grv_Data3.ThemeStyle.RowsStyle.Height = 30;
            this.grv_Data3.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.grv_Data3.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // frmTimekeeping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1348, 454);
            this.Controls.Add(this.grv_Data3);
            this.Controls.Add(this.grv_Data2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnCamera);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCallTheRoll);
            this.Controls.Add(this.imageBoxFrameGrabber);
            this.Controls.Add(this.btn_excel2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_excel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnAddNewEmployee);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.txtListDiemDanh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtShow);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTimekeeping";
            this.Opacity = 0.9D;
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Making Timekeeping";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmTimekeeping_FormClosed);
            this.Load += new System.EventHandler(this.frmTimekeeping_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxFrameGrabber)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_Data2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_Data3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void forceCustomReInitialize()
        {
            LanguagePackage langPack = applicationConfiguration.getLanguagePackage();

            //
            this.btnAddNewEmployee.Text = langPack.getAddMembersButtonLabel();
            this.btnexit.Text = langPack.getQuitButtonTitle();
            this.btnCallTheRoll.Text = langPack.getMakingRollCallButtonLabel();
            this.btnCamera.Text = langPack.getCameraActionButtonLabel();
           /* this.groupBox1.Text = langPack.getMemeberInfoBlockTitle();
            this.label6.Text = langPack.getBirthAlias();
            this.label5.Text = langPack.getSexAlias();
            this.label4.Text = langPack.getClassAlias();
            this.label3.Text = langPack.getFirstNameAlias();
            this.label8.Text = langPack.getMemberCodeAlias();
            this.label9.Text = langPack.getLastNameAlias();*/
            this.label2.Text = langPack.getMembersAlreadyMakingRollCallTitle();
            this.label7.Text = langPack.getMembersNotMakingRollCallYetTitle();
            
            /*this.label1.Text = langPack.getClassAlias();
            this.label10.Text = langPack.getOutputDeviceSelectionTitle();*/
            this.Text = langPack.getMakingRollCallFormTitle();
        }
        private System.Windows.Forms.Button btnCallTheRoll;
        private System.Windows.Forms.Button btnCamera;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnAddNewEmployee;
        private Emgu.CV.UI.ImageBox imageBoxFrameGrabber;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_excel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtListDiemDanh;
        private System.Windows.Forms.Button btn_excel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label txtShow;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.Button btnListWork;
        internal System.Windows.Forms.Button btnListOfEmp;
        internal System.Windows.Forms.Button btnHome;
        private Guna.UI.WinForms.GunaDataGridView grv_Data2;
        private Guna.UI.WinForms.GunaDataGridView grv_Data3;
    }
}