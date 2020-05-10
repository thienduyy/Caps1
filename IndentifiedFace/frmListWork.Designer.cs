
namespace IndentifiedFace
{
    partial class frmListWork
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.bt_available = new System.Windows.Forms.Button();
            this.btnGetEmployeeWork = new System.Windows.Forms.Button();
            this.bt_checkall = new System.Windows.Forms.Button();
            this.dgvDS = new Guna.UI.WinForms.GunaDataGridView();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDS)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(26, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(115, 1);
            this.panel3.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 22);
            this.label3.TabIndex = 15;
            this.label3.Text = "List Work";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(286, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 350);
            this.panel1.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(313, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "List :";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(3, 418);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(896, 1);
            this.panel4.TabIndex = 16;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // btn_exit
            // 
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Image = global::IndentifiedFace.Properties.Resources.x_30px1;
            this.btn_exit.Location = new System.Drawing.Point(804, 360);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(68, 36);
            this.btn_exit.TabIndex = 14;
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // bt_available
            // 
            this.bt_available.FlatAppearance.BorderSize = 0;
            this.bt_available.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_available.Image = global::IndentifiedFace.Properties.Resources.day_off_25px;
            this.bt_available.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_available.Location = new System.Drawing.Point(53, 197);
            this.bt_available.Name = "bt_available";
            this.bt_available.Size = new System.Drawing.Size(204, 36);
            this.bt_available.TabIndex = 13;
            this.bt_available.Text = "Schedule";
            this.bt_available.UseVisualStyleBackColor = true;
            this.bt_available.Click += new System.EventHandler(this.bt_available_Click);
            // 
            // btnGetEmployeeWork
            // 
            this.btnGetEmployeeWork.FlatAppearance.BorderSize = 0;
            this.btnGetEmployeeWork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetEmployeeWork.Image = global::IndentifiedFace.Properties.Resources.find_user_male_25px;
            this.btnGetEmployeeWork.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGetEmployeeWork.Location = new System.Drawing.Point(53, 249);
            this.btnGetEmployeeWork.Name = "btnGetEmployeeWork";
            this.btnGetEmployeeWork.Size = new System.Drawing.Size(204, 36);
            this.btnGetEmployeeWork.TabIndex = 11;
            this.btnGetEmployeeWork.Text = "Search";
            this.btnGetEmployeeWork.UseVisualStyleBackColor = true;
            this.btnGetEmployeeWork.Click += new System.EventHandler(this.bt_getonebyone_Click);
            // 
            // bt_checkall
            // 
            this.bt_checkall.FlatAppearance.BorderSize = 0;
            this.bt_checkall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_checkall.Image = global::IndentifiedFace.Properties.Resources.search_property_25px;
            this.bt_checkall.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_checkall.Location = new System.Drawing.Point(53, 146);
            this.bt_checkall.Name = "bt_checkall";
            this.bt_checkall.Size = new System.Drawing.Size(204, 36);
            this.bt_checkall.TabIndex = 10;
            this.bt_checkall.Text = "Work Status";
            this.bt_checkall.UseVisualStyleBackColor = true;
            this.bt_checkall.Click += new System.EventHandler(this.bt_checkall_Click);
            // 
            // dgvDS
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.dgvDS.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDS.BackgroundColor = System.Drawing.Color.White;
            this.dgvDS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDS.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDS.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDS.ColumnHeadersHeight = 40;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDS.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDS.EnableHeadersVisualStyles = false;
            this.dgvDS.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.dgvDS.Location = new System.Drawing.Point(324, 118);
            this.dgvDS.Name = "dgvDS";
            this.dgvDS.RowHeadersVisible = false;
            this.dgvDS.RowTemplate.Height = 30;
            this.dgvDS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDS.Size = new System.Drawing.Size(548, 224);
            this.dgvDS.TabIndex = 18;
            this.dgvDS.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.WetAsphalt;
            this.dgvDS.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.dgvDS.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDS.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDS.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDS.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDS.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvDS.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.dgvDS.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.dgvDS.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDS.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Times New Roman", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDS.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDS.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDS.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvDS.ThemeStyle.ReadOnly = false;
            this.dgvDS.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dgvDS.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDS.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Times New Roman", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDS.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvDS.ThemeStyle.RowsStyle.Height = 30;
            this.dgvDS.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.dgvDS.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // txt_search
            // 
            this.txt_search.Enabled = false;
            this.txt_search.Location = new System.Drawing.Point(456, 22);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(327, 25);
            this.txt_search.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(355, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Search Code: ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(366, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 1);
            this.panel2.TabIndex = 16;
            // 
            // frmListWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 428);
            this.Controls.Add(this.dgvDS);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.bt_available);
            this.Controls.Add(this.btnGetEmployeeWork);
            this.Controls.Add(this.bt_checkall);
            this.Font = new System.Drawing.Font("Times New Roman", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmListWork";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê";
            this.Load += new System.EventHandler(this.frmListWork_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bt_checkall;
        private System.Windows.Forms.Button btnGetEmployeeWork;
        private System.Windows.Forms.Button bt_available;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI.WinForms.GunaDataGridView dgvDS;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
    }
}